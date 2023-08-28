using System.ComponentModel.DataAnnotations;

namespace JoyeríaDALA.Models
{
    public class Notificacion
    {
        [Key]
        [Required]
        public int NotifId { get; set; }
        [Required]
        public string titulo { get; set; }

        public string descripción { get; set; } 
        [Required]
        public DateTime fechaInicio { get; set; }
        [Required]
        public DateTime fechaFin { get; set; }

        public string tipo { get; set; }

        public int IdAsociado { get; set; }
    }
}
