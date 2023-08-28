
using System.ComponentModel.DataAnnotations;

namespace JoyeríaDALA.Models
{
    public class Usuario
    {
        [Key]
        [Required]
        public int IdUsuario { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string apikey{ get; set; }   

        public string tipoUsuario { get; set; }

    }
}
