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
    public class EncargosController : ControllerBase
    {
        private readonly JoyeriaContext _context;

        public EncargosController(JoyeriaContext context)
        {
            _context = context;
        }

        // GET: api/Encargos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Encargo>>> GetEncargo()
        {
          if (_context.Encargo == null)
          {
              return NotFound();
          }
            return await _context.Encargo.ToListAsync();
        }

        // GET: api/Encargos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Encargo>> GetEncargo(int id)
        {
          if (_context.Encargo == null)
          {
              return NotFound();
          }
            var encargo = await _context.Encargo.FindAsync(id);

            if (encargo == null)
            {
                return NotFound();
            }

            return encargo;
        }

        // PUT: api/Encargos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEncargo(int id, [FromBody] string jsonEncargo)
        {
            if (jsonEncargo == null)
                return BadRequest(string.Empty);

            Encargo encargo = JsonConvert.DeserializeObject<Encargo>(jsonEncargo);

            if (id != encargo.IdEncargo)
            {
                return BadRequest();
            }

            _context.Entry(encargo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EncargoExists(id))
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


        // POST: api/Encargos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Encargo>> PostEncargo([FromBody] string jsonEncargo)
        {
            if (jsonEncargo == null)
                return null;
            Encargo encargo = JsonConvert.DeserializeObject<Encargo>(jsonEncargo);

            if (_context.Encargo == null)
            {
                return Problem("Entity set 'JoyeriaContext.Encargo' is null.");
            }
            _context.Encargo.Add(encargo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEncargo", new { id = encargo.IdEncargo }, encargo);
        }

        // DELETE: api/Encargos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEncargo(int id)
        {
            if (_context.Encargo == null)
            {
                return NotFound();
            }
            var encargo = await _context.Encargo.FindAsync(id);
            if (encargo == null)
            {
                return NotFound();
            }

            _context.Encargo.Remove(encargo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EncargoExists(int id)
        {
            return (_context.Encargo?.Any(e => e.IdEncargo == id)).GetValueOrDefault();
        }
    }
}
