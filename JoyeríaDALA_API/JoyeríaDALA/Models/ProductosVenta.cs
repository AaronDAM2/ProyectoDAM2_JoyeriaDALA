using System.ComponentModel.DataAnnotations;

namespace JoyeríaDALA.Models
{
    public class ProductosVenta
    {
        [Key]
        [Required]
        public int IdProdVenta { get; set; }
        [Required]
        public int IdVenta { get; set; }
        [Required]
        public int IdProducto { get; set; }
        
        public int cantidad { get; set; }

        public string nombre { get; set;}

        public double precioUnidad { get; set; }
        public double precioTotal { get; set; }
        public int descuento { get; set; }

       
    }
}
