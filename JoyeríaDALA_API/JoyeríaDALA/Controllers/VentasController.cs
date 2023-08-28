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
using System.Text;
using Newtonsoft.Json.Linq;

namespace JoyeríaDALA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        private readonly JoyeriaContext _context;

        public VentasController(JoyeriaContext context)
        {
            _context = context;
        }

        // GET: api/Ventas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Venta>>> GetVenta()
        {
          if (_context.Venta == null)
          {
              return NotFound();
          }
            return await _context.Venta.ToListAsync();
        }

        // GET: api/Ventas/5
        [HttpGet("{id}")]
        //[Route("api/Venta/")]
        public async Task<ActionResult<Venta>> GetVenta(int id)
        {
          if (_context.Venta == null)
          {
              return NotFound();
          }
            var venta = await _context.Venta.FindAsync(id);

            if (venta == null)
            {
                return NotFound();
            }

       
        

            return venta;
        }

        [HttpGet("getProductosVenta/{id}")]
       
        public List<Producto> getProductosVenta(int id)
        {
            List<ProductosVenta> ProdVenta = _context.ProductosVenta.Where(x => x.IdVenta == id).ToList();
            List<Producto> productos = new List<Producto>();
            foreach (var pv in ProdVenta)
            {
                Producto p = _context.Producto.FirstOrDefault(x => x.idProducto == pv.IdProducto);
                if (p != null)
                    productos.Add(p);
            }
            if (productos == null || productos.Count == 0)
                return null;
            return productos;
        }

        // PUT: api/Ventas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]

        public async Task<IActionResult> PutVenta(int id, [FromBody]string jsonVenta)
        {
            if(jsonVenta== null)
                return BadRequest(string.Empty);

            Venta venta = JsonConvert.DeserializeObject<Venta>(jsonVenta);

            if (id != venta.IdVenta)
            {
                return BadRequest();
            }

            _context.Entry(venta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VentaExists(id))
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

        // POST: api/Ventas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Venta>> PostVenta([FromBody]string JsonVenta)
        {
            if (JsonVenta == null)
                return null;
            Venta venta = JsonConvert.DeserializeObject<Venta>(JsonVenta);

          if (_context.Venta == null)
          {
              return Problem("Entity set 'JoyeriaContext.Venta'  is null.");
          }
            _context.Venta.Add(venta);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVenta", new { id = venta.IdVenta }, venta);
        }

        
        // [Route("api/Venta/")]
        [HttpPost("NuevaVenta")]
        public async Task<ActionResult<Venta>> NuevaVenta([FromBody] JObject        jsonData)
        {
            if (jsonData == null)
            {
                return BadRequest("Datos de venta inválidos.");
            }

            Venta venta = jsonData["venta"].ToObject<Venta>();
            List<Producto> productos = jsonData["productos"].ToObject<List<Producto>>();

            if (venta == null)
            {
                return BadRequest("Datos de venta inválidos.");
            }

            _context.Venta.Add(venta);

            foreach (Producto producto in productos)
            {
                ProductosVenta productosVenta = new ProductosVenta
                {
                    IdVenta = venta.IdVenta,
                    IdProducto = producto.idProducto
                };

                _context.ProductosVenta.Add(productosVenta);
            }

            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVenta", new { id = venta.IdVenta }, venta);
        }

       

        // DELETE: api/Ventas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVenta(int id)
        {
            if (_context.Venta == null)
            {
                return NotFound();  
            }
            var venta = await _context.Venta.FindAsync(id);
            if (venta == null)
            {
                return NotFound();
            }

            var productosVenta = _context.ProductosVenta.Where(pv => pv.IdVenta == id);
            _context.ProductosVenta.RemoveRange(productosVenta);


            _context.Venta.Remove(venta);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VentaExists(int id)
        {
            return (_context.Venta?.Any(e => e.IdVenta == id)).GetValueOrDefault();
        }

        
    }
}
