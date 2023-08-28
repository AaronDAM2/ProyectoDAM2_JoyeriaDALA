

using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Drawing.Text;

namespace JoyeríaDALA.Models
{
    public class Grabado
    {
        [Key]
        [Required]
        public int IdGrabado { get; set; }
        [Required]
        public string nombreCliente { get; set; }
        [Required]
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public double? precio { get; set; }
        [Required]
        public string contenido { get; set; }

        //  public int idVenta { get; set; }
       
      public Venta venta { get; set; }

        public bool terminado { get; set; }

        public int idProducto { get; set; }
    }
}
