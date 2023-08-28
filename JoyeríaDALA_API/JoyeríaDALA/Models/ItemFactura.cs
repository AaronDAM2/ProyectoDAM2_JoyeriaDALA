using System.ComponentModel.DataAnnotations;

namespace JoyeríaDALA.Models
{
    public class ItemFactura
    {
        [Key]
        [Required]
        public int IdItem { get; set; }
        [Required]
        public int IdFactura { get; set; }
        public int IdObjeto { get; set; }
        public string Descripcion { get; set; }
        public string tipo { get; set; }

        public double PrecioUnitario { get; set; }
        
        public int Cantidad { get; set; }
        public double Importe { get; set; }

        public int Descuento { get; set; }  
    }
}
