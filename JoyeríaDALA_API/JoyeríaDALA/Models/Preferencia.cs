using System.ComponentModel.DataAnnotations;

namespace JoyeríaDALA.Models
{
    public class Preferencia
    {
        [Key]
        [Required]
        public int IdAjuste { get; set; }
        [Required]
        public string nombreAjuste { get; set; }

        [Required]
        public string valor { get; set; }

        public string otrosDatos { get; set; }

    }
}
