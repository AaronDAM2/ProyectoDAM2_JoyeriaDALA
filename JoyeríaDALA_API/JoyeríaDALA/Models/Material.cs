using System.ComponentModel.DataAnnotations;

namespace JoyeríaDALA.Models
{
    public class Material
    {
        [Key]
        [Required]
        public int MaterialId { get; set; }
        [Required]
        public string material { get; set; }
    }
}
