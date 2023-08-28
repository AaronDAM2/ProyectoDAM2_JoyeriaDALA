using System.ComponentModel.DataAnnotations;

namespace JoyeríaDALA.Models
{
    public class SubtiposProducto
    {
        [Key]
        [Required]
        public int idSubtipo { get; set; }
        [Required]
        public int idTipo { get; set; }
        [Required]
        public string subtipo { get; set; }

    }
}
