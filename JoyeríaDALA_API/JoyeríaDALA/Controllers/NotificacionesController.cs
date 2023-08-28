using JoyeríaDALA.Data;
using JoyeríaDALA.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JoyeríaDALA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificacionesController : ControllerBase
    {
        private readonly JoyeriaContext _context;

        public NotificacionesController(JoyeriaContext context)
        {
            _context = context;
        }

        // GET: api/Notificaciones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Notificacion>>> GetNotificacion()
        {
            var notificaciones = await _context.Notificacion.ToListAsync();
            if (notificaciones == null || notificaciones.Count == 0)
            {
                return NotFound();
            }
            return notificaciones;
        }

        // GET: api/Notificaciones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Notificacion>> GetNotificacion(int id)
        {
            var notificacion = await _context.Notificacion.FindAsync(id);
            if (notificacion == null)
            {
                return NotFound();
            }
            return notificacion;
        }

        // PUT: api/Notificaciones/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNotificacion(int id, Notificacion notificacion)
        {
            if (id != notificacion.NotifId)
            {
                return BadRequest();
            }
            _context.Entry(notificacion).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NotificacionExists(id))
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

        // POST: api/Notificaciones
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Notificacion>> PostNotificacion([FromBody] Notificacion notificacion)
        {
            _context.Notificacion.Add(notificacion);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetNotificacion", new { id = notificacion.NotifId }, notificacion);
        }

        // DELETE: api/Notificaciones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNotificacion(int id)
        {
            var notificacion = await _context.Notificacion.FindAsync(id);
            if (notificacion == null)
            {
                return NotFound();
            }
            _context.Notificacion.Remove(notificacion);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        private bool NotificacionExists(int id)
        {
            return _context.Notificacion.Any(e => e.NotifId == id);
        }
    }
}
