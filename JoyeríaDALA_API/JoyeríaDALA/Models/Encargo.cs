using MySql.Data.Types;
using System.ComponentModel.DataAnnotations;

namespace JoyeríaDALA.Models
{
    public class Encargo
    {
        [Key]
        [Required]
        public int IdEncargo { get; set; }
        [Required]
        public string cliente { get; set;}
        public string? descripcion { get; set; }
        [Required]
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public double? precio { get; set; }
        public bool terminada { get; set; }
      //  public int idVenta { get; set; }   
        public Venta venta { get; set; }

        public int idProducto { get; set; }


    }
}
