using JoyeríaDALA.Data;
using JoyeríaDALA.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JoyeríaDALA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcasTipoController : ControllerBase
    {
        private readonly JoyeriaContext _context;

        public MarcasTipoController(JoyeriaContext context)
        {
            _context = context;
        }

        // GET: api/MarcasTipo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MarcasTipo>>> GetMarcasTipo()
        {
            return await _context.MarcasTipo.ToListAsync();
        }

        // GET: api/MarcasTipo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MarcasTipo>> GetMarcasTipo(int id)
        {
            var marcasTipo = await _context.MarcasTipo.FindAsync(id);
            if (marcasTipo == null)
            {
                return NotFound();
            }
            return marcasTipo;
        }

        // POST: api/MarcasTipo
        [HttpPost]
        public async Task<ActionResult<MarcasTipo>> PostMarcasTipo([FromBody] MarcasTipo marcasTipo)
        {
            if (marcasTipo == null)
            {
                return BadRequest();
            }

            _context.MarcasTipo.Add(marcasTipo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMarcasTipo", new { id = marcasTipo.IdMarca }, marcasTipo);
        }

        // PUT: api/MarcasTipo/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMarcasTipo(int id, [FromBody] MarcasTipo marcasTipo)
        {
            if (id != marcasTipo.IdMarca)
            {
                return BadRequest();
            }

            _context.Entry(marcasTipo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MarcasTipoExists(id))
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

        // DELETE: api/MarcasTipo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMarcasTipo(int id)
        {
            var marcasTipo = await _context.MarcasTipo.FindAsync(id);
            if (marcasTipo == null)
            {
                return NotFound();
            }

            _context.MarcasTipo.Remove(marcasTipo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MarcasTipoExists(int id)
        {
            return _context.MarcasTipo.Any(e => e.IdMarca == id);
        }
    }
}
