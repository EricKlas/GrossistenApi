using GrossistenApi.Controller;
using GrossistenApi.Data;
using GrossistenApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace GrossitenApiTest
{
    public class ProductControllerTests : IDisposable
    {
        private readonly GrossistenApiDatabaseContext _context;
        private readonly ProductController _controller;

        public ProductControllerTests()
        {
            // Setup in-memory database for testing
            var options = new DbContextOptionsBuilder<GrossistenApiDatabaseContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _context = new GrossistenApiDatabaseContext(options);
            _controller = new ProductController(_context);
        }
        //to start with a clean database for each test
        public void Dispose()
        {
            _context.Dispose();
        }

        private async Task TestData()
        {
            // test data so we have products in the database for testing
            var products = new List<Product>
            {
                new Product { Id = 1, Title = "Test Product 1", Quantity = 10 },
                new Product { Id = 2, Title = "Test Product 2", Quantity = 20 },
                new Product { Id = 3, Title = "Test Product 3", Quantity = 30 }
            };

            _context.ProductsTable.AddRange(products);
            await _context.SaveChangesAsync();
        }

        [Fact]
        public async Task GetProductsReturnsAllProducts()
        {
            // Calls on test data
            await TestData();

            // runs the controller function
            var result = await _controller.GetProducts();

            // Looks for that it is the correct answer and correct amount of products
            var actionResult = Assert.IsType<ActionResult<IEnumerable<Product>>>(result);
            var products = Assert.IsAssignableFrom<IEnumerable<Product>>(actionResult.Value);
            Assert.Equal(3, products.Count());
        }

        [Fact]
        public async Task GetProductsReturnsEmptyListWhenNoProducts()
        {
            
            var result = await _controller.GetProducts();

            // Looks at the result and checks that it is an empty list
            var actionResult = Assert.IsType<ActionResult<IEnumerable<Product>>>(result);
            var products = Assert.IsAssignableFrom<IEnumerable<Product>>(actionResult.Value);
            Assert.Empty(products);
        }

        [Fact]
        public async Task GetProductReturnsProductWhenProductExists()
        {
            await TestData();

            var result = await _controller.GetProduct(1);

            // checks the answer is the correct product
            var actionResult = Assert.IsType<ActionResult<Product>>(result);
            var product = Assert.IsType<Product>(actionResult.Value);
            Assert.Equal(1, product.Id);
            Assert.Equal("Test Product 1", product.Title);
        }

        [Fact]
        public async Task GetProductReturnsNotFoundWhenProductDoesNotExist()
        {
            var result = await _controller.GetProduct(999);

            // checks that the product does not exist
            Assert.IsType<NotFoundResult>(result.Result);
        }

        [Fact]
        public async Task PostProductCreatesNewProduct()
        {
            // set up test data to add to the test database
            var newProduct = new Product { Id = 4, Title = "New Product", Quantity = 5 };

            var result = await _controller.PostProduct(newProduct);

            // first checks it is the correct type 
            var actionResult = Assert.IsType<ActionResult<Product>>(result);
            var createdAtActionResult = Assert.IsType<CreatedAtActionResult>(actionResult.Result);
            var product = Assert.IsType<Product>(createdAtActionResult.Value);

            // checks the product has the correct values
            Assert.Equal(4, product.Id);
            Assert.Equal("New Product", product.Title);
            Assert.Equal(5, product.Quantity);

            // Verify product was added to database
            var dbProduct = await _context.ProductsTable.FindAsync(4);
            Assert.NotNull(dbProduct);
            Assert.Equal("New Product", dbProduct.Title);
        }

        [Fact]
        public async Task PutProductUpdatesProductWhenIdIsCorrect()
        {
            await TestData();

            // Clear change tracker to avoid tracking conflicts
            _context.ChangeTracker.Clear();

            var updatedProduct = new Product { Id = 1, Title = "Updated Product", Quantity = 100 };
            var result = await _controller.PutProduct(1, updatedProduct);

            Assert.IsType<NoContentResult>(result);

            // Verify product was updated in database
            var dbProduct = await _context.ProductsTable.FindAsync(1);
            Assert.Equal("Updated Product", dbProduct?.Title);
            Assert.Equal(100, dbProduct?.Quantity);
        }

        [Fact]
        public async Task PutProductReturnsBadRequestWhenIdDoesNotMatch()
        {
            var product = new Product { Id = 2, Title = "Test Product", Quantity = 10 };

            var result = await _controller.PutProduct(1, product);

            // The type should be BadRequestResult
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task PutBulkProductUpdatesMultipleProductsWhenAllExist()
        {
            await TestData();
            var productsToUpdate = new List<Product>
            {
                new Product { Id = 1, Quantity = 100 },
                new Product { Id = 2, Quantity = 200 }
            };

            var result = await _controller.PutBulkProduct(productsToUpdate);

            Assert.IsType<NoContentResult>(result);

            // Verify products were updated
            var product1 = await _context.ProductsTable.FindAsync(1);
            var product2 = await _context.ProductsTable.FindAsync(2);

            Assert.Equal(100, product1?.Quantity);
            Assert.Equal(200, product2?.Quantity);
        }

        [Fact]
        public async Task PutBulkProductReturnsNotFoundWhenSomeProductsDoNotExist()
        {
            await TestData();
            var productsToUpdate = new List<Product>
            {
                new Product { Id = 1, Quantity = 100 },
                new Product { Id = 999, Quantity = 200 }
            };

            var result = await _controller.PutBulkProduct(productsToUpdate);

            Assert.IsType<NotFoundResult>(result);

            // Verify no products were updated
            var product1 = await _context.ProductsTable.FindAsync(1);
            Assert.Equal(10, product1.Quantity);
        }

        [Fact]
        public async Task DeleteProductRemovesProductWhenProductExists()
        {
            await TestData();

            var result = await _controller.DeleteProduct(1);

            // Assert that the result is NoContentResult
            Assert.IsType<NoContentResult>(result);

            // Verify product was removed from database
            var dbProduct = await _context.ProductsTable.FindAsync(1);
            Assert.Null(dbProduct);
        }

        [Fact]
        public async Task DeleteProduct_ReturnsNotFound_WhenProductDoesNotExist()
        {
            var result = await _controller.DeleteProduct(999);

            // type should be NotFoundResult
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async Task PutBulkProduct_ReturnsNotFound_WhenEmptyList()
        {
            await TestData();
            var emptyList = new List<Product>();

            var result = await _controller.PutBulkProduct(emptyList);

            // type should be NoContentResult
            Assert.IsType<NoContentResult>(result);
        }

        [Fact]
        public async Task PostProduct_HandlesProductWithoutExplicitId()
        {
            var newProduct = new Product { Title = "Test Product", Quantity = 15 };

            var result = await _controller.PostProduct(newProduct);

            // checks that the product was created correctly
            var actionResult = Assert.IsType<ActionResult<Product>>(result);
            var createdAtActionResult = Assert.IsType<CreatedAtActionResult>(actionResult.Result);
            var product = Assert.IsType<Product>(createdAtActionResult.Value);

            Assert.Equal("Test Product", product.Title);
            Assert.Equal(15, product.Quantity);
        }
    }
}
