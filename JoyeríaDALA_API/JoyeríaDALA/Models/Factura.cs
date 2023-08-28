using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace JoyeríaDALA.Models
{
    public class Factura
    {
        [Key]
        [Required]
        public int idFactura { get; set; }
        public string cliente { get; set; }

        public DateTime fechaFactura { get; set; }

        public DateTime fechaVencimiento { get; set; }
        [Required]
        public string TipoAsociado { get; set; }
        [Required]
        public int IdAsociado { get; set; }
        public double Subtotal { get; set; }
        public double Total { get; set; }

        public string dirFactura { get; set; }
        public string FacturaNIF { get; set; }
        public string formaPago { get; set; }
        public string domicilioPago { get; set; }


        public List<ItemFactura> Items { get; set; }

    }
}
