using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoyeriaDALA_EscritorioWinForms.Modelo
{
    public partial class Grabado
    {

        public int IdGrabado { get; set; }


        public string contenido { get; set; }

        public int? productoidProducto { get; set; }


        public DateTime? FechaFin { get; set; }


        public DateTime FechaInicio { get; set; }


        public string nombreCliente { get; set; }

        public double precio { get; set; }

        public bool terminado { get; set; }

        public Venta venta { get; set; }


    }
}
