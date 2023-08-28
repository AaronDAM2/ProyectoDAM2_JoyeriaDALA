
    using JoyeríaDALA_TPV.Modelo;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
namespace JoyeríaDALA_TPV.Modelo
{

    public class Venta
    {
    
        public int IdVenta { get; set; }

        public string codVenta { get; set; }

        public double precio { get; set; }

        public string observaciones { get; set; }

      
        public DateTime FechaVenta { get; set; }

        
        public  List<ProductosVenta> Productos { get; set; }

        public bool esGrabado { get; set; }

        public bool esEncargo { get; set; }

    }
}
