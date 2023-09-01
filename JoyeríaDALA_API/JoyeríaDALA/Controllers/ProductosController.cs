using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JoyeríaDALA.Data;
using JoyeríaDALA.Models;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Newtonsoft.Json;


namespace JoyeríaDALA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly JoyeriaContext _context;

        public ProductosController(JoyeriaContext context)
        {
            _context = context;
        }

        // GET: api/Productos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Producto>>> GetProducto()
        {
          if (_context.Producto == null)
          {
              return NotFound();
          }
            return await _context.Producto.ToListAsync();
        }

        // GET: api/Productos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Producto>> GetProducto(int id)
        {
          if (_context.Producto == null)
          { 
              return NotFound();
          }
            var producto =  _context.Producto.FirstOrDefault(x=>x.idProducto==id);

            if (producto == null)
            {
                return NotFound();
            }

            return producto;
        }

        [HttpGet("getTipos")]
     //   [Route("api/Producto/getTipos")]
        public List<TipoProducto> getTipos()
        {
            if (_context.TipoProducto == null)
                return null;
           return _context.TipoProducto.ToList();
        }

        [HttpGet("getSubtipos/{tipo}")]
     //   [Route("api/Producto/getSubtipos/{tipo}")]
        public List<string> getSubTipos(int tipo) 
        {
            if (_context.SubtiposProducto == null)
                return null;
            List<string> sub = new List<string>();
            foreach(SubtiposProducto s in _context.SubtiposProducto.Where(x => x.idTipo == tipo).ToList())
            {
                sub.Add(s.subtipo);

            }
            if (sub == null || sub.Count == 0)
                return null;
            return sub;
        }

        [HttpGet("getMarcas/{tipo}")]
    //    [Route("api/Producto/getMarcas/{tipo}")]
        public List<string> getMarcas(int tipo)
        {
            if (_context.MarcasTipo == null)
                return null;

            List<string> marcas = new List<string>();
            foreach(MarcasTipo m in _context.MarcasTipo.Where(x => x.IdTipo == tipo)){
                marcas.Add(m.NombreMarca);
            }
            if (marcas == null || marcas.Count == 0)
                return null;
            return marcas;
        }

        [HttpGet("getTamanos")]
        public List<string> getTamanos()
        {
            List<string> listaTamanos = new List<string>();
            if (_context.tamanos != null)
            {
                foreach (Tamano t in _context.tamanos)
                    listaTamanos.Add(t.tamano);

                
            }
            return listaTamanos;
        }
        [HttpGet("getMateriales")]
        public List<string> getMateriales()
        {
            List<string> listaMateriales = new List<string>();
            if (_context.Material != null)
            {
                foreach (Material m in _context.Material)
                    listaMateriales.Add(m.material);


            }
            return listaMateriales;
        }


        // PUT: api/Productos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProducto(int id, [FromBody] Producto producto)
        {
         

            if (id != producto.idProducto)
            {
                return BadRequest();
            }

            _context.Entry(producto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductoExists(id))
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


      

            // POST: api/Productos
            // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
            [HttpPost("postProducto")]
        public async Task<ActionResult<Producto>> PostProducto([FromBody] Producto producto)
        {
           /* if (jsonProducto == null)
                return null;*/
            //Producto producto = JsonConvert.DeserializeObject<Producto>(jsonProducto.ToString());

            if (_context.Producto == null)
            {
                return Problem("Entity set 'JoyeriaContext.Producto' is null.");
            }
            _context.Producto.Add(producto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProducto", new { id = producto.idProducto }, producto);
        }

        // DELETE: api/Productos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProducto(int id)
        {
            if (_context.Producto == null)
            {
                return NotFound();
            }
            var producto = await _context.Producto.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }

            List<ProductosVenta> pv=_context.ProductosVenta.Where(x=>x.IdProducto==id).ToList();
            _context.ProductosVenta.RemoveRange(pv);

            _context.Producto.Remove(producto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductoExists(int id)
        {
            return (_context.Producto?.Any(e => e.idProducto == id)).GetValueOrDefault();
        }

        [HttpPut("ActualizarStock/{id}")]
        //[Route("api/[controller]/ActualizarStock/{id}")]
        private int ActualizarStock(int id, int nuevoStock)
        {
            if (_context.Producto == null)
            {
                return -2;
            }
            var producto = _context.Producto.FirstOrDefault(x => x.idProducto == id);

            if (producto == null)
            {
                return -1;
            }
            producto.stock = nuevoStock;
            _context.SaveChanges();
            return producto.stock;      
        }

        [HttpGet("getIdTipo/{tipo}")]
        public async Task<int> getIdTipo(string tipo)
        {
            TipoProducto tipoProducto=_context.TipoProducto.FirstOrDefault(x=>x.Tipo==tipo);
            if(tipoProducto == null) {
                return -1;
            }
            return tipoProducto.IdTipo;
        }

    }
}
