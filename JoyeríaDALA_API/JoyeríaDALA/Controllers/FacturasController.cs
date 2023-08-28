using JoyeríaDALA.Data;
using JoyeríaDALA.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JoyeríaDALA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturasController : ControllerBase
    {
        private readonly JoyeriaContext _context;

        public FacturasController(JoyeriaContext context)
        {
            _context = context;
        }

        // GET: api/Facturas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Factura>>> GetFactura()
        {
            var facturas = await _context.Factura.ToListAsync();
            if (facturas == null || facturas.Count == 0)
            {
                return NotFound();
            }
            return facturas;
        }

        // GET: api/Facturas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Factura>> GetFactura(int id)
        {
            var factura = await _context.Factura.FindAsync(id);
            if (factura == null)
            {
                return NotFound();
            }
            return factura;
        }

        // PUT: api/Facturas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFactura(int id, Factura factura)
        {
            if (id != factura.idFactura)
            {
                return BadRequest();
            }
            _context.Entry(factura).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FacturaExists(id))
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

        // POST: api/Facturas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Factura>> PostFactura(Factura factura)
        {
            _context.Factura.Add(factura);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetFactura", new { id = factura.idFactura }, factura);
        }

        // DELETE: api/Facturas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFactura(int id)
        {
            var factura = await _context.Factura.FindAsync(id);
            if (factura == null)
            {
                return NotFound();
            }
            _context.Factura.Remove(factura);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        private bool FacturaExists(int id)
        {
            return _context.Factura.Any(e => e.idFactura == id);
        }
        [HttpGet("getVentaFactura/{id}")]
        private Venta getVentaFactura(int idFactura) {
            var factura = _context.Factura.FirstOrDefault(x => x.idFactura == idFactura);
            if (factura != null && factura.TipoAsociado == "Venta")
            {
                Venta venta = _context.Venta.FirstOrDefault(x => x.IdVenta == factura.IdAsociado);
                if (venta != null)
                    return venta;
            }
            return null;
        }
        [HttpGet("getEncargoFactura/{id}")]
        private Encargo getEncargoFactura(int idFactura)
        {
            var factura = _context.Factura.FirstOrDefault(x => x.idFactura == idFactura);
            if (factura != null && factura.TipoAsociado == "Encargo")
            {
                Encargo encargo = _context.Encargo.FirstOrDefault(x => x.IdEncargo == factura.IdAsociado);
                if (encargo != null)
                    return encargo;
            }
            return null;
        }

        [HttpGet("getGrabadoFactura/{id}")]
        private Grabado getGrabadoFactura(int idFactura)
        {
            var factura = _context.Factura.FirstOrDefault(x => x.idFactura == idFactura);
            if (factura != null && factura.TipoAsociado == "Grabado")
            {
                Grabado grabado = _context.Grabado.FirstOrDefault(x => x.IdGrabado == factura.IdAsociado);
                if (grabado != null)
                    return grabado;
            }
            return null;
        }
        [HttpPost("NuevaFactura")]

        public async Task<ActionResult<Factura>> NuevaFactura([FromBody] JObject jsonData)
        {
            if (jsonData == null)
            {
                return BadRequest("Datos de factura inválidos.");
            }

            Factura factura = jsonData["factura"].ToObject<Factura>();
            List<ItemFactura> itemsFactura = jsonData["itemsFactura"].ToObject<List<ItemFactura>>();

            if (factura == null || itemsFactura == null)
            {
                return BadRequest("Datos de factura inválidos.");
            }

            _context.Factura.Add(factura);
            await _context.SaveChangesAsync();

            foreach (ItemFactura itemFactura in itemsFactura)
            {
                itemFactura.IdFactura = factura.idFactura;
                _context.ItemFactura.Add(itemFactura);
            }

            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFactura", new { id = factura.idFactura }, factura);
        }

        [HttpPut("EditarFactura{id}")]
        public async Task<IActionResult> EditarFactura(int id, [FromBody] JObject jsonData)
        {
            if (jsonData == null)
            {
                return BadRequest("Datos de factura inválidos.");
            }

            Factura facturaData = jsonData["factura"].ToObject<Factura>();
            List<ItemFactura> itemsFacturaData = jsonData["itemsFactura"].ToObject<List<ItemFactura>>();

            if (facturaData == null)
            {
                return BadRequest("Datos de factura inválidos.");
            }

            Factura factura = await _context.Factura
                .Include(f => f.Items)
                .FirstOrDefaultAsync(f => f.idFactura == id);

            if (factura == null)
            {
                return NotFound();
            }

            // Actualizar los campos de la factura
            factura.cliente = facturaData.cliente;
            factura.fechaFactura = facturaData.fechaFactura;
            factura.fechaVencimiento = facturaData.fechaVencimiento;
            factura.TipoAsociado = facturaData.TipoAsociado;
            factura.IdAsociado = facturaData.IdAsociado;
            factura.Subtotal = facturaData.Subtotal;
            factura.Total = facturaData.Total;
            factura.dirFactura = facturaData.dirFactura;
            factura.FacturaNIF = facturaData.FacturaNIF;
            factura.formaPago = facturaData.formaPago;
            factura.domicilioPago = facturaData.domicilioPago;

            // Actualizar o agregar elementos de ItemFactura
            foreach (var itemFacturaData in itemsFacturaData)
            {
                ItemFactura itemFactura = factura.Items.FirstOrDefault(i => i.IdItem == itemFacturaData.IdItem);

                if (itemFactura != null)
                {
                    // Si el ItemFactura existe, actualizar sus campos
                    itemFactura.Descripcion = itemFacturaData.Descripcion;
                    itemFactura.tipo = itemFacturaData.tipo;
                    itemFactura.PrecioUnitario = itemFacturaData.PrecioUnitario;
                    itemFactura.Cantidad = itemFacturaData.Cantidad;
                    itemFactura.Importe = itemFacturaData.Importe;
                    itemFactura.Descuento = itemFacturaData.Descuento;
                }
                else
                {
                    // Si el ItemFactura no existe, agregarlo a la lista
                    factura.Items.Add(itemFacturaData);
                }
            }

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FacturaExists(id))
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
    

      
}

} 