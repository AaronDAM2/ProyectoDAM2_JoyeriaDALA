using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoyeriaDALA_EscritorioWinForms.Reports
{
    public class ClienteWr
    {
        public string nombre { get; set; }
        public string NIF { get; set; }
        public string telefono { get; set; }

        public string CC { get; set; }
        public string dirección { get; set; }

        public int importePagado { get; set; }
    }
}
