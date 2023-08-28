using JoyeríaDALA.Data;
using JoyeríaDALA.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JoyeríaDALA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoProductoController : ControllerBase
    {
        private readonly JoyeriaContext _context;

        public TipoProductoController(JoyeriaContext context)
        {
            _context = context;
        }

        // GET: api/TipoProducto
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoProducto>>> GetTipoProductos()
        {
            return await _context.TipoProducto.ToListAsync();
        }

        // GET: api/TipoProducto/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TipoProducto>> GetTipoProducto(int id)
        {
            var tipoProducto = await _context.TipoProducto.FindAsync(id);
            if (tipoProducto == null)
            {
                return NotFound();
            }
            return tipoProducto;
        }

        // POST: api/TipoProducto
        [HttpPost]
        public async Task<ActionResult<TipoProducto>> PostTipoProducto([FromBody] TipoProducto tipoProducto)
        {
            if (tipoProducto == null)
            {
                return BadRequest();
            }

            _context.TipoProducto.Add(tipoProducto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoProducto", new { id = tipoProducto.IdTipo }, tipoProducto);
        }

        // PUT: api/TipoProducto/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoProducto(int id, [FromBody] TipoProducto tipoProducto)
        {
            if (id != tipoProducto.IdTipo)
            {
                return BadRequest();
            }

            _context.Entry(tipoProducto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoProductoExists(id))
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

        // DELETE: api/TipoProducto/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipoProducto(int id)
        {
            var tipoProducto = await _context.TipoProducto.FindAsync(id);
            if (tipoProducto == null)
            {
                return NotFound();
            }

            _context.TipoProducto.Remove(tipoProducto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TipoProductoExists(int id)
        {
            return _context.TipoProducto.Any(e => e.IdTipo == id);
        }
    }
}

