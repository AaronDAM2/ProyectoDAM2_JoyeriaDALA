using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JoyeríaDALA.Data;
using JoyeríaDALA.Models;
using Newtonsoft.Json;

namespace JoyeríaDALA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GrabadosController : ControllerBase
    {
        private readonly JoyeriaContext _context;

        public GrabadosController(JoyeriaContext context)
        {
            _context = context;
        }

        // GET: api/Grabados
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Grabado>>> GetGrabado()
        {
          if (_context.Grabado == null)
          {
              return NotFound();
          }
            return await _context.Grabado.ToListAsync();
        }

        // GET: api/Grabados/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Grabado>> GetGrabado(int id)
        {
          if (_context.Grabado == null)
          {
              return NotFound();
          }
            var grabado = await _context.Grabado.FindAsync(id);

            if (grabado == null)
            {
                return NotFound();
            }

            return grabado;
        }

        // PUT: api/Grabados/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGrabado(int id, [FromBody] string jsonGrabado)
        {
            if (jsonGrabado == null)
                return BadRequest(string.Empty);

            Grabado grabado = JsonConvert.DeserializeObject<Grabado>(jsonGrabado);

            if (id != grabado.IdGrabado)
            {
                return BadRequest();
            }

            _context.Entry(grabado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GrabadoExists(id))
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

        // POST: api/Grabados
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Grabado>> PostGrabado([FromBody] string jsonGrabado)
        {
            if (jsonGrabado == null)
                return null;
            Grabado grabado = JsonConvert.DeserializeObject<Grabado>(jsonGrabado);

            if (_context.Grabado == null)
            {
                return Problem("Entity set 'JoyeriaContext.Grabado' is null.");
            }
            _context.Grabado.Add(grabado);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGrabado", new { id = grabado.IdGrabado }, grabado);
        }

        // DELETE: api/Grabados/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGrabado(int id)
        {
            if (_context.Grabado == null)
            {
                return NotFound();
            }
            var grabado = await _context.Grabado.FindAsync(id);
            if (grabado == null)
            {
                return NotFound();
            }

            _context.Grabado.Remove(grabado);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GrabadoExists(int id)
        {
            return (_context.Grabado?.Any(e => e.IdGrabado == id)).GetValueOrDefault();
        }
    }
}
