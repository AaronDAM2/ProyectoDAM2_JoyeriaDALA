using JoyeríaDALA.Data;
using JoyeríaDALA.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Web;
using System.IO;
using System.Data.SqlClient;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JoyeríaDALA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PreferenciaController : ControllerBase
    {
        private readonly JoyeriaContext _context;
        
        public PreferenciaController(JoyeriaContext context)
        {
            _context = context;
        }

        // GET: api/Preferencia
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Preferencia>>> GetPreferencia()
        {
            return await _context.Preferencia.ToListAsync();
        }

        // GET: api/Preferencia/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Preferencia>> GetPreferencia(int id)
        {
            var preferencia = await _context.Preferencia.FindAsync(id);
            if (preferencia == null)
            {
                return NotFound();
            }
            return preferencia;
        }

        // POST: api/Preferencia
        [HttpPost]
        public async Task<ActionResult<Preferencia>> PostPreferencia([FromBody] Preferencia preferencia)
        {
            if (preferencia == null)
            {
                return BadRequest();
            }

            _context.Preferencia.Add(preferencia);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPreferencia", new { id = preferencia.IdAjuste }, preferencia);
        }

        // PUT: api/Preferencia/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPreferencia(int id, [FromBody] Preferencia preferencia)
        {
            if (id != preferencia.IdAjuste)
            {
                return BadRequest();
            }

            _context.Entry(preferencia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PreferenciaExists(id))
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

        // DELETE: api/Preferencia/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePreferencia(int id)
        {
            var preferencia = await _context.Preferencia.FindAsync(id);
            if (preferencia == null)
            {
                return NotFound();
            }

            _context.Preferencia.Remove(preferencia);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PreferenciaExists(int id)
        {
            return _context.Preferencia.Any(e => e.IdAjuste == id);
        }


        [HttpGet("ObtenerPropietario")]
        public async Task<ActionResult<List<Preferencia>>> ObtenerPropietario()
        {
            List<string> nombresAjuste = new List<string> { "nombreNegocio", "direccionNegocio", "tlfNegocio", "NifPropietario" };

            List<Preferencia> preferencias = await _context.Preferencia
                .Where(p => nombresAjuste.Contains(p.nombreAjuste))
                .ToListAsync();

            return preferencias;
        }

        [HttpGet("getConnString")]
        public async Task<string> ObtenerConnectionString()
        {
            return new string("DESKTOP-61JCH03;Database=JoyeríaDALA.Data;Trusted_Connection=True;PersistSecurityInfo=True; Encrypt=True; TrustServerCertificate=True;MultipleActiveResultSets=true");
        }
    }
}
