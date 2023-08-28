using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoyeriaDALA_EscritorioWinForms.Modelo
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
 
        public string nombre { get; set; }
 
        public string username { get; set; }
     
        public string password { get; set; }
      
        public string apikey { get; set; }

        public string tipoUsuario { get; set; }
    }
}
