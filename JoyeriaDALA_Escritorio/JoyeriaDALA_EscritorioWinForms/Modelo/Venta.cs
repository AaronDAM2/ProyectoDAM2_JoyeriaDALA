using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoyeriaDALA_EscritorioWinForms.Modelo
{
    public partial class Venta
    {

        public int IdVenta { get; set; }
        
        public string codVenta { get; set; }

        public double precio { get; set; }

        public string observaciones { get; set; }


        public DateTime FechaVenta { get; set; }


        public List<ProductosVenta> Productos { get; set; }
        [DefaultValue(false)]
        public bool esGrabado { get; set; }

        [DefaultValue(false)]
        public bool esEncargo { get; set; }
    }
}
