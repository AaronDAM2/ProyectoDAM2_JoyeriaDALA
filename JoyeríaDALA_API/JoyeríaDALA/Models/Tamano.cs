using System.ComponentModel.DataAnnotations;

namespace JoyeríaDALA.Models
{
    public class Tamano
    {
        [Key]
        [Required]
        public int IdTamano { get; set; }
        [Required]
        public string tamano { get; set; }
    }
}
