using JoyeríaDALA.Data;
using JoyeríaDALA.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JoyeríaDALA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubtiposProductoController : ControllerBase
    {
        private readonly JoyeriaContext _context;

        public SubtiposProductoController(JoyeriaContext context)
        {
            _context = context;
        }

        // GET: api/SubtiposProducto
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubtiposProducto>>> GetSubtiposProducto()
        {
            return await _context.SubtiposProducto.ToListAsync();
        }

        // GET: api/SubtiposProducto/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SubtiposProducto>> GetSubtiposProducto(int id)
        {
            var subtiposProducto = await _context.SubtiposProducto.FindAsync(id);
            if (subtiposProducto == null)
            {
                return NotFound();
            }
            return subtiposProducto;
        }

        // POST: api/SubtiposProducto
        [HttpPost]
        public async Task<ActionResult<SubtiposProducto>> PostSubtiposProducto([FromBody] SubtiposProducto subtiposProducto)
        {
            if (subtiposProducto == null)
            {
                return BadRequest();
            }

            _context.SubtiposProducto.Add(subtiposProducto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSubtiposProducto", new { id = subtiposProducto.idSubtipo }, subtiposProducto);
        }

        // PUT: api/SubtiposProducto/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSubtiposProducto(int id, [FromBody] SubtiposProducto subtiposProducto)
        {
            if (id != subtiposProducto.idSubtipo)
            {
                return BadRequest();
            }

            _context.Entry(subtiposProducto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubtiposProductoExists(id))
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

        // DELETE: api/SubtiposProducto/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubtiposProducto(int id)
        {
            var subtiposProducto = await _context.SubtiposProducto.FindAsync(id);
            if (subtiposProducto == null)
            {
                return NotFound();
            }

            _context.SubtiposProducto.Remove(subtiposProducto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SubtiposProductoExists(int id)
        {
            return _context.SubtiposProducto.Any(e => e.idSubtipo == id);
        }
    }
}
