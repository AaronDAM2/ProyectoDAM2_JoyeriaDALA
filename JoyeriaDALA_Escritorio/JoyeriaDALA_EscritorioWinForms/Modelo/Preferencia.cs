using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoyeriaDALA_EscritorioWinForms.Modelo
{
        public class Preferencia
        {
        
            public int IdAjuste { get; set; }
       
            public string nombreAjuste { get; set; }

     
            public string valor { get; set; }

            public string otrosDatos { get; set; }

        }
}
