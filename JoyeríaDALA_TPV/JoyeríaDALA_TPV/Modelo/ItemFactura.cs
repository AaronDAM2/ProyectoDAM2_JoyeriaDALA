using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoyeríaDALA_TPV.Modelo
{
    public class ItemFactura
    {

        public int IdItem { get; set; }

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
