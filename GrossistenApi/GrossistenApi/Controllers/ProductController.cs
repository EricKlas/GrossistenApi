using GrossistenApi.Models;
using GrossistenApi.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GrossistenApi.Controller
{
    [ApiController]
    [Route("api/Product")]
    public class ProductController : ControllerBase
    {
        private readonly GrossistenApiDatabaseContext _context;
        public ProductController(GrossistenApiDatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return await _context.ProductsTable.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _context.ProductsTable.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return product;
        }

        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            _context.ProductsTable.Add(product);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
        }
        //update item
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut("bulk")]
        public async Task<IActionResult> PutBulkProduct([FromBody] List<Product> products)
        {
            var existing = await _context.ProductsTable
                                         .Where(p => products.Select(x => x.Id).Contains(p.Id))
                                         .ToListAsync();
            if (existing.Count != products.Count) return NotFound();

            foreach (var e in existing)
            {
                e.Quantity = products.First(p => p.Id == e.Id).Quantity;
                e.Title = products.First(p => p.Id == e.Id).Title;
                e.Description = products.First(p => p.Id == e.Id).Description;
                e.Size = products.First(p => p.Id == e.Id).Size;
                e.Price = products.First(p => p.Id == e.Id).Price;
                e.Category = products.First(p => p.Id == e.Id).Category;
                e.ShowInAvailableToPurchase = products.First(p => p.Id == e.Id).ShowInAvailableToPurchase;
                e.ShowInStock = products.First(p => p.Id == e.Id).ShowInStock;
                e.ShowOnReceipt = products.First(p => p.Id == e.Id).ShowOnReceipt;
                e.ReceiptId = products.First(p => p.Id == e.Id).ReceiptId;
            }
                

            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.ProductsTable.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            _context.ProductsTable.Remove(product);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}