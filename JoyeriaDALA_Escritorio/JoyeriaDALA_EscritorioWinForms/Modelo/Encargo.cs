using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoyeriaDALA_EscritorioWinForms.Modelo
{
    [Table("Encargo")]
    public partial class Encargo
    {
        public int IdEncargo { get; set; }


        public string cliente { get; set; }

        public string descripcion { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime FechaInicio { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? FechaFin { get; set; }

        public double precio { get; set; }

        public bool terminada { get; set; }


        public Venta venta { get; set; }

        public int? productoidProducto { get; set; }
    }
}
