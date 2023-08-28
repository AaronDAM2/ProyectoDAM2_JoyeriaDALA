using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JoyeríaDALA.Models
{
    public class Producto
    {
        [Key]
        [Required]
        public int idProducto { get; set; }

        [Required]
        public string tipoProducto { get; set; }
        [Required]
        public string nombre { get; set; }

        public int stock { get; set; }

        public double? precio { get; set; }

        public string? descripcion { get; set;}

        public string? material { get; set; }

        public string? tamano { get; set; }

        [DefaultValue(true)]
        public bool? activo { get; set; }

        public string? subtipo { get; set; }

        public string? marca { get; set; }

    }
}
