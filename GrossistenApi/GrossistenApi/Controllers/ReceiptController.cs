using GrossistenApi.Models;
using GrossistenApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GrossistenApi.Controller
{
    [ApiController]
    [Route("api/Reciept")]
    public class ReceiptController : ControllerBase
    {
        private readonly GrossistenAppDatabaseContext _context;
        public ReceiptController(GrossistenAppDatabaseContext context)
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
    }
}
