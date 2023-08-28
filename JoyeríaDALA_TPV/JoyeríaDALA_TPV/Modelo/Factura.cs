
    using JoyeríaDALA_TPV.Modelo;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
namespace JoyeríaDALA_TPV.Modelo
{

    public class Factura
    {

        public int idFactura { get; set; }
        public string cliente { get; set; }

        public DateTime fechaFactura { get; set; }

        public DateTime fechaVencimiento { get; set; }

        public string TipoAsociado { get; set; }

        public int IdAsociado { get; set; }
        public double Subtotal { get; set; }
        public double Total { get; set; }

        public string dirFactura { get; set; }
        public string FacturaNIF { get; set; }
        public string formaPago { get; set; }
        public string domicilioPago { get; set; }


        public List<ItemFactura> Items { get; set; }

    }
}
