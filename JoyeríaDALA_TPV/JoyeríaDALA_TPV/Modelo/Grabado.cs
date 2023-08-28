
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;


namespace JoyeríaDALA_TPV.Modelo
{



    public class Grabado
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
