using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoyeriaDALA_EscritorioWinForms.Modelo
{
    public class Notificacion
    {
        public int NotifId { get; set; }

        public string titulo { get; set;}

        public string descripción { get; set; }

        public DateTime fechaInicio { get; set; }

        public DateTime fechaFin { get; set; }

        public string tipo { get; set; }

        public int IdAsociado { get; set;}
    }
}
