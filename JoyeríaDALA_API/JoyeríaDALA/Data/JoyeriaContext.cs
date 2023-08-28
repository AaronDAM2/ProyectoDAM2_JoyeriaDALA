using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JoyeríaDALA.Models;

namespace JoyeríaDALA.Data
{
    public class JoyeriaContext : DbContext
    {
        public JoyeriaContext (DbContextOptions<JoyeriaContext> options)
            : base(options)
        {
        }

        public DbSet<JoyeríaDALA.Models.Encargo> Encargo { get; set; } = default!;

        public DbSet<JoyeríaDALA.Models.Grabado>? Grabado { get; set; }

        public DbSet<JoyeríaDALA.Models.Producto>? Producto { get; set; }

        public DbSet<JoyeríaDALA.Models.Venta>? Venta { get; set; }

        public DbSet<JoyeríaDALA.Models.Factura>? Factura { get; set;}

        public DbSet<JoyeríaDALA.Models.MarcasTipo>? MarcasTipo { get; set; }
        public DbSet<JoyeríaDALA.Models.SubtiposProducto>? SubtiposProducto { get; set; }
        public DbSet<JoyeríaDALA.Models.Usuario>? Usuario { get; set;}
        public DbSet<JoyeríaDALA.Models.ProductosVenta>? ProductosVenta { get; set; }
        public DbSet<JoyeríaDALA.Models.TipoProducto>? TipoProducto { get; set; }
        public DbSet<JoyeríaDALA.Models.Notificacion>? Notificacion { get; set; }

        public DbSet<JoyeríaDALA.Models.Preferencia>? Preferencia { get; set;}

       public DbSet<JoyeríaDALA.Models.ItemFactura>? ItemFactura { get; set;}


        public DbSet<JoyeríaDALA.Models.Material>? Material { get; set; }
        public DbSet<JoyeríaDALA.Models.Tamano>? tamanos { get; set; }

    }
}
