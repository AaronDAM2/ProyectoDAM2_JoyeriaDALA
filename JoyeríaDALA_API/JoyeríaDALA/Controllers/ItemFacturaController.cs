using JoyeríaDALA.Data;
using JoyeríaDALA.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JoyeríaDALA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemFacturaController : ControllerBase
    {
        // GET: api/<ItemFacturaController>
        private readonly JoyeriaContext _context;

        public ItemFacturaController(JoyeriaContext context)
        {
            _context = context;
        }

        // GET: api/ItemFactura
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemFactura>>> GetItemFactura()
        {
            return await _context.ItemFactura.ToListAsync();
        }

        // GET: api/ItemFactura/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemFactura>> GetItemFactura(int id)
        {
            var itemFactura = await _context.ItemFactura.FindAsync(id);

            if (itemFactura == null)
            {
                return NotFound();
            }

            return itemFactura;
        }

        // PUT: api/ItemFactura/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItemFactura(int id, ItemFactura itemFactura)
        {
            if (id != itemFactura.IdItem)
            {
                return BadRequest();
            }

            _context.Entry(itemFactura).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemFacturaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ItemFactura
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ItemFactura>> PostItemFactura([FromBody] ItemFactura itemFactura)
        {
            _context.ItemFactura.Add(itemFactura);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetItemFactura", new { id = itemFactura.IdItem }, itemFactura);
        }

        // DELETE: api/ItemFactura/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItemFactura(int id)
        {
            var itemFactura = await _context.ItemFactura.FindAsync(id);
            if (itemFactura == null)
            {
                return NotFound();
            }

            _context.ItemFactura.Remove(itemFactura);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ItemFacturaExists(int id)
        {
            return _context.ItemFactura.Any(e => e.IdItem == id);
        }
    }
}

