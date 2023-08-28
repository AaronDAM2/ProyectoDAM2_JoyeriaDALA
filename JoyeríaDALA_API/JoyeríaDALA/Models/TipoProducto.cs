using System.ComponentModel.DataAnnotations;

namespace JoyeríaDALA.Models
{
    public class TipoProducto
    {
        [Key]
        [Required]
        public int IdTipo { get; set; }
        [Required]
        public string Tipo { get; set; }
    }
}
