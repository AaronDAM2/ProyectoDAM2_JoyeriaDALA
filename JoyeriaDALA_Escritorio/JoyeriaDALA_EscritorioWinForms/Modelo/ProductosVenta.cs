using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoyeriaDALA_EscritorioWinForms.Modelo
{
    public class ProductosVenta
    {

        public int IdProdVenta { get; set; }

        public int IdVenta { get; set; }

        public int IdProducto { get; set; }

        public int cantidad { get; set; }

        public string nombre { get; set; }

        public double precioUnidad { get; set; }
        public double precioTotal { get; set; }
        public int descuento { get; set; }
    }
}
