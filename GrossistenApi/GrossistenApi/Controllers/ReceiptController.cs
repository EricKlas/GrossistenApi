using GrossistenApi.Models;
using GrossistenApi.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace GrossistenApi.Controller
{
    [ApiController]
    [Route("api/Reciept")]
    public class ReceiptController : ControllerBase
    {
        private readonly GrossistenApiDatabaseContext _context;
        public ReceiptController(GrossistenApiDatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Receipt>>> GetReceipts()
        {
            return await _context.ReceiptsTable.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Receipt>> GetReceipt(int id)
        {
            var receipt = await _context.ReceiptsTable.FindAsync(id);
            if (receipt == null)
            {
                return NotFound();
            }
            return receipt;
        }

        [HttpPost]
        public async Task<ActionResult<Receipt>> PostReceipt(Receipt receipt)
        {
            _context.ReceiptsTable.Add(receipt);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetReceipt), new { id = receipt.Id }, receipt);
        }
        //update item
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReceipt(int id, Receipt receipt)
        {
            if (id != receipt.Id)
            {
                return BadRequest();
            }
            _context.Entry(receipt).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReceipt(int id)
        {
            var receipt = await _context.ReceiptsTable.FindAsync(id);
            if (receipt == null)
            {
                return NotFound();
            }
            _context.ReceiptsTable.Remove(receipt);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
