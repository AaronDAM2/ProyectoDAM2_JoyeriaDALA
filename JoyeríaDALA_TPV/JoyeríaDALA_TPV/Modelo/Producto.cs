        namespace JoyeríaDALA_TPV.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    
    public class Producto
    {


        public int idProducto { get; set; }

        
        public string tipoProducto { get; set; }

        public string nombre { get; set; }

        public double precio { get; set; }

        public int stock { get; set; }
        public string descripcion { get; set; }

        public string material { get; set; }

        public string tamano { get; set; }

        [DefaultValue(true)]
        public bool activo { get; set; }

        public string subtipo { get; set; }

        public string marca { get; set; }






    }
}
