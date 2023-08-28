
using System.ComponentModel.DataAnnotations;

namespace JoyeríaDALA.Models
{
    public class MarcasTipo
    {
        [Key]
        [Required]
        public int IdMarca { get; set; }
        [Required]
        public int IdTipo { get; set; }

        [Required]
        public string NombreMarca { get; set; }
        
     //   public List<TipoProducto> TiposProducto { get; set; }

    }
}
