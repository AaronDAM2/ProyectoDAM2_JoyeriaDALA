using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace JoyeríaDALA.Models
{
    public class Venta
    {
        [Key]
        [Required]        
        public int IdVenta { get; set; }
        [AllowNull]
        public string codVenta { get; set; }
        [Required]
        public double precio { get; set; }
        public string? observaciones { get; set; }
        public DateTime FechaVenta { get; set; }
        //public List<Producto> productos { get; set; }
        public List<ProductosVenta> productos { get; set; }

    }
    
}
