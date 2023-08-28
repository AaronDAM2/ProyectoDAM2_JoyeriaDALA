using JoyeriaDALA_EscritorioWinForms.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace JoyeriaDALA_EscritorioWinForms
{
    public class FacturasManager
    {
        private List<Venta> ventas;
        private List<Encargo> encargos;
        private List<Grabado> grabados;
        private List<Producto> productos;

        private List<ItemFactura> items;

        public FacturasManager()
        {
            // Inicializar las listas de ventas, encargos, grabados y productos
            ventas = new List<Venta>();
            encargos = new List<Encargo>();
            grabados = new List<Grabado>();
            productos = new List<Producto>();

            items = new List<ItemFactura>();
        }

        // Método para agregar ventas a la lista
        public void AgregarVenta(Venta venta)
        {
            ventas.Add(venta);
        }

        // Método para agregar encargos a la lista
        public void AgregarEncargo(Encargo encargo)
        {
            encargos.Add(encargo);
        }

        // Método para agregar grabados a la lista
        public void AgregarGrabado(Grabado grabado)
        {
            grabados.Add(grabado);
        }

        // Método para agregar productos a la lista
        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }

        // Método para generar una factura
        public Factura GenerarFactura(string cliente, DateTime fechaFactura, DateTime fechaVencimiento,string formaPago, string FacturaNIF,string dirFactura, string domicilioPago, List<ItemFactura> items, int descuento)
        {
            
            Factura factura = new Factura
            {
                cliente = cliente,
                fechaFactura = fechaFactura,
                fechaVencimiento = fechaVencimiento,
                formaPago=formaPago,
                FacturaNIF=FacturaNIF,
                dirFactura=dirFactura,
                domicilioPago=domicilioPago,
                Items = items
            };

            // Calcular el subtotal y total de la factura
            double subtotal = items.Sum(item => item.Importe);
            factura.Subtotal = subtotal;
            if (descuento != 0)
               factura= AplicarDescuento(factura, descuento);
            factura.Total = subtotal;
            factura=AplicarIVA(factura);
            return factura;

        }

        public Factura AplicarDescuento(Factura factura, int descuento)
        {
            descuento = descuento / 100;
            factura.Subtotal = factura.Subtotal * descuento;
            return factura;
        }

        public Factura AplicarIVA(Factura factura)
        {
            factura.Total=factura.Subtotal*(0.21);
            return factura;
        }

        public ItemFactura CrearItemFactura(Producto producto, int cantidad)
        {
            double importe = producto.precio * cantidad;

            return new ItemFactura
            {
                IdObjeto = producto.idProducto,
                Descripcion = $"{producto.nombre} - {producto.descripcion}",
                PrecioUnitario = producto.precio,
                Cantidad = cantidad,
                Importe = importe
            };
        }

        public ItemFactura CrearItemFactura(Producto producto)
        {
            ;

            Producto p = productos.FirstOrDefault(x => x == producto);
            if (p == null)
            {

                return new ItemFactura
                {
                    IdObjeto = producto.idProducto,
                    Descripcion = $"{producto.nombre} - {producto.descripcion}",
                    PrecioUnitario = producto.precio,
                    tipo = "Producto",
                    Cantidad = 1,
                    Importe = producto.precio
                };
            }
            else
            {
                ItemFactura item = items.FirstOrDefault(x => x.IdObjeto == p.idProducto && x.tipo == "Producto");
                if (item != null)
                {
                    item.Cantidad++;
                    item.PrecioUnitario = item.PrecioUnitario * item.Cantidad;
                }
                return item;
            }
        }

        // Método para crear el ItemFactura a partir de un Encargo
        public ItemFactura CrearItemFactura(Encargo encargo)
        {
            double importe = encargo.precio;

            return new ItemFactura
            {
                IdObjeto = encargo.IdEncargo,
                Descripcion = $"Encargo - {encargo.descripcion}",
                tipo="Encargo",
                PrecioUnitario = encargo.precio,
                Cantidad = 1,
                Importe = importe
            };
        }

        // Método para crear el ItemFactura a partir de un Grabado
        public ItemFactura CrearItemFactura(Grabado grabado)
        {
            double importe = grabado.precio;

            return new ItemFactura
            {
                IdObjeto = grabado.IdGrabado,
                Descripcion = $"Grabado - {grabado.contenido}",
                tipo="Grabado",
                PrecioUnitario = grabado.precio,
                Cantidad = 1,
                Importe = importe
            };
        }

        public List<ItemFactura> CargarItems()
        {
            List<ItemFactura> itemsFactura=new List<ItemFactura>();
            if (productos != null&&productos.Count>0)
            {
                foreach (Producto p in productos)
                {
                    ItemFactura i = CrearItemFactura(p);      
                    itemsFactura.Add(i);
                }

            }

            if(grabados != null&&grabados.Count>0)
            {
                foreach(Grabado g in grabados)
                {
                    ItemFactura i= CrearItemFactura(g);
                    itemsFactura.Add(i);
                }
            }

            if (encargos != null && encargos.Count > 0)
            {
                foreach(Encargo e in encargos)
                {
                    ItemFactura i = CrearItemFactura(e);
                    itemsFactura.Add(i);
                }

            }

            items = itemsFactura;
            return itemsFactura;
        }

        
    }

}
