using GrossistenApi.Controller;
using GrossistenApi.Data;
using GrossistenApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrossitenApiTest
{
    public class ReceiptControllerTests : IDisposable
    {
        private readonly GrossistenApiDatabaseContext _context;
        private readonly ReceiptController _controller;

        public ReceiptControllerTests()
        {
            // Create in-memory database for testing
            var options = new DbContextOptionsBuilder<GrossistenApiDatabaseContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _context = new GrossistenApiDatabaseContext(options);
            _controller = new ReceiptController(_context);
        }

        // to ensure a clean database for each test
        public void Dispose()
        {
            _context.Dispose();
        }

        [Fact]
        public async Task GetReceiptsReturnsEmptyListWhenNoReceiptsExist()
        {
            var result = await _controller.GetReceipts();

            // Assert that the result is an empty list
            var actionResult = Assert.IsType<ActionResult<IEnumerable<Receipt>>>(result);
            var receipts = Assert.IsType<List<Receipt>>(actionResult.Value);
            Assert.Empty(receipts);
        }

        [Fact]
        public async Task GetReceiptsReturnsAllReceiptsWhenReceiptsExist()
        {
            var receipts = new List<Receipt>
            {
                new Receipt { Id = 1,},
                new Receipt { Id = 2,},
                new Receipt { Id = 3,}
            };

            _context.ReceiptsTable.AddRange(receipts);
            await _context.SaveChangesAsync();

            var result = await _controller.GetReceipts();

            // Assert that the result contains all receipts
            var actionResult = Assert.IsType<ActionResult<IEnumerable<Receipt>>>(result);
            var returnedReceipts = Assert.IsType<List<Receipt>>(actionResult.Value);
            Assert.Equal(3, returnedReceipts.Count);
        }

        [Fact]
        public async Task GetReceiptReturnsReceiptWhenReceiptExists()
        {
            var receipt = new Receipt { Id = 1 };
            _context.ReceiptsTable.Add(receipt);
            await _context.SaveChangesAsync();

            var result = await _controller.GetReceipt(1);

            // Assert that the result is the expected receipt
            var actionResult = Assert.IsType<ActionResult<Receipt>>(result);
            var returnedReceipt = Assert.IsType<Receipt>(actionResult.Value);
            Assert.Equal(1, returnedReceipt.Id);
        }

        [Fact]
        public async Task GetReceiptReturnsNotFoundWhenReceiptDoesNotExist()
        {
            var result = await _controller.GetReceipt(999);

            // Assert that the result is NotFound
            var actionResult = Assert.IsType<ActionResult<Receipt>>(result);
            Assert.IsType<NotFoundResult>(actionResult.Result);
        }

        [Fact]
        public async Task PostReceiptCreatesNewReceiptWhenValidReceiptIsProvided()
        {
            // Arrange
            var newReceipt = new Receipt { Id = 1};

            // Act
            var result = await _controller.PostReceipt(newReceipt);

            // Assert
            var actionResult = Assert.IsType<ActionResult<Receipt>>(result);
            var createdAtActionResult = Assert.IsType<CreatedAtActionResult>(actionResult.Result);
            var createdReceipt = Assert.IsType<Receipt>(createdAtActionResult.Value);

            Assert.Equal(1, createdReceipt.Id);
            Assert.Equal("GetReceipt", createdAtActionResult.ActionName);

            // Verify receipt was saved to database
            var savedReceipt = await _context.ReceiptsTable.FindAsync(1);
            Assert.NotNull(savedReceipt);
            Assert.Equal(1, savedReceipt.Id);
        }

        [Fact]
        public async Task PostReceiptIncreasesReceiptCountWhenValidReceiptIsProvided()
        {
            var initialCount = await _context.ReceiptsTable.CountAsync();
            var newReceipt = new Receipt { Id = 1};

            await _controller.PostReceipt(newReceipt);

            // Assert that the count has increased by 1
            var finalCount = await _context.ReceiptsTable.CountAsync();
            Assert.Equal(initialCount + 1, finalCount);
        }

        [Fact]
        public async Task PutReceiptUpdatesReceiptWhenValidReceiptIsProvided()
        {
            var existingReceipt = new Receipt { Id = 1 };
            _context.ReceiptsTable.Add(existingReceipt);
            await _context.SaveChangesAsync();

            // Clear the change tracker to stop tracking the existing entity
            _context.ChangeTracker.Clear();

            // Create an updated receipt
            var updatedReceipt = new Receipt { Id = 1 };
            var result = await _controller.PutReceipt(1, updatedReceipt);
            Assert.IsType<NoContentResult>(result);

            // Verify receipt was updated in database
            var savedReceipt = await _context.ReceiptsTable.FindAsync(1);
            Assert.NotNull(savedReceipt);
            Assert.Equal(1, savedReceipt.Id);
        }

        [Fact]
        public async Task PutReceiptReturnsBadRequestWhenIdIsWrong()
        {
            var receipt = new Receipt { Id = 2};

            var result = await _controller.PutReceipt(1, receipt);

            // Assert that the result is BadRequest
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task PutReceiptThrowsDbUpdateErrorWhenReceiptDoesNotExist()
        {
            var nonExistentReceipt = new Receipt { Id = 999};

            // Assert that it throws a DbUpdateConcurrencyException
            await Assert.ThrowsAsync<DbUpdateConcurrencyException>(
                () => _controller.PutReceipt(999, nonExistentReceipt));
        }

        [Fact]
        public async Task DeleteReceiptRemovesReceiptWhenReceiptExists()
        {
            var receipt = new Receipt { Id = 1};
            _context.ReceiptsTable.Add(receipt);
            await _context.SaveChangesAsync();

            var result = await _controller.DeleteReceipt(1);

            // Assert that the result is NoContent
            Assert.IsType<NoContentResult>(result);

            // Verify receipt was deleted from database
            var deletedReceipt = await _context.ReceiptsTable.FindAsync(1);
            Assert.Null(deletedReceipt);
        }

        [Fact]
        public async Task DeleteReceiptReturnsNotFoundWhenReceiptDoesNotExist()
        {
            var result = await _controller.DeleteReceipt(999);

            // Assert that the result is NotFound
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async Task DeleteReceiptDecreasesReceiptCountWhenReceiptExists()
        {
            var receipt = new Receipt { Id = 1};
            _context.ReceiptsTable.Add(receipt);
            await _context.SaveChangesAsync();

            var initialCount = await _context.ReceiptsTable.CountAsync();

            await _controller.DeleteReceipt(1);

            // Assert that the count has decreased by 1
            var finalCount = await _context.ReceiptsTable.CountAsync();
            Assert.Equal(initialCount - 1, finalCount);
        }
    }
}
