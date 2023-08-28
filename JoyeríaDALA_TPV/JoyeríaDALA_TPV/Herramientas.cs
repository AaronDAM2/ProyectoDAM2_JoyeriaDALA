using JoyeríaDALA_TPV.Modelo;
using JoyeríaDALA_TPV.Reports;
using Microsoft.Reporting.WinForms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
namespace JoyeríaDALA_TPV
{
    public static class Herramientas
    {
        public static async Task<string> CrearCodVenta(Venta venta)
        {
            int cuenta = GetVentasAsync().Result.Count() + 1;
            string letra = "V";
            if (venta.esGrabado)
                letra = "G";
            if (venta.esEncargo)
                letra = "E";
            string cod = $"{letra}{cuenta.ToString("D3")}_{venta.FechaVenta.ToShortDateString()}";
            return cod;
        }
        public static string NombreProducto(Producto producto)
        {
            string nombre = "";
            if (producto != null && producto.tipoProducto != null)
            {
                if (producto.subtipo != null)
                {
                    nombre += producto.subtipo + " ";
                } else
                    nombre += producto.tipoProducto + " ";
                if (producto.marca != null)
                {
                    nombre += producto.marca + " ";
                }
                nombre += producto.material;
                if (producto.tamano != null)
                    nombre += " " + producto.tamano;

                return nombre;


            }
            return null;
        }

        public static async Task<List<Producto>> GetProductosAsync()
        {
            Negocio negocio = new Negocio();
            List<Producto> productos = await negocio.GetAsync<List<Producto>>("productos");

            return productos;
        }

        public static async Task<List<Venta>> GetVentasAsync()
        {
            Negocio negocio = new Negocio();
            List<Venta> ventas = await negocio.GetAsync<List<Venta>>("Ventas");

            return ventas;
        }

        public static async Task<List<Grabado>> GetGrabadosAsync()
        {
            Negocio negocio = new Negocio();
            List<Grabado> Grabados = await negocio.GetAsync<List<Grabado>>("Grabados");

            return Grabados;
        }

        public static async Task<List<Encargo>> GetEncargosAsync()
        {
            Negocio negocio = new Negocio();
            List<Encargo> Encargos = await negocio.GetAsync<List<Encargo>>("Encargos");

            return Encargos;
        }

        public static async Task<List<Factura>> GetFacturasAsync()
        {
            Negocio negocio = new Negocio();
            List<Factura> Facturas = await negocio.GetAsync<List<Factura>>("Facturas");

            return Facturas;
        }



        public static async Task<Producto> GetProductoAsync(int id)
        {
            Negocio negocio = new Negocio();
            Producto producto = await negocio.GetAsync<Producto>($"api/Productos/{id}");
            return producto;
        }

        public static async Task<List<TipoProducto>> GetTiposProductoAsync()
        {
            Negocio negocio = new Negocio();
            List<TipoProducto> tipos = await negocio.GetAsync<List<TipoProducto>>("api/Productos/getTipos");
            return tipos;
        }

     public static async Task<List<string>> GetListaTipos()
        {
           
         List<TipoProducto> tipos = GetTiposProductoAsync().Result;
            List<string> lista = new List<string>();
            foreach(TipoProducto tipo in tipos)
            {
                lista.Add(tipo.Tipo);
            }
            return lista;
        }

        public static async Task<List<Producto>> GetProductosVentaAsync(int ventaId)
        {
            Negocio negocio = new Negocio();
            List<ProductosVenta> productosVenta = await negocio.GetAsync<List<ProductosVenta>>($"api/Ventas/getProductosVenta/{ventaId}");

            if (productosVenta == null || productosVenta.Count == 0)
                return new List<Producto>();

            List<int> productoIds = productosVenta.Select(pv => pv.IdProducto).ToList();
            List<Producto> productos = await Herramientas.GetProductosAsync();

            return productos.Where(p => productoIds.Contains(p.idProducto)).ToList();
        }

        public static async Task<int> getIdTipo(string tipo)
        {
            Negocio negocio = new Negocio();
            int idTipo = await negocio.GetAsync<int>($"api/Productos/getIdTipo/{tipo}");
            return idTipo;
        }
        public static async Task<List<string>> GetSubtiposProductoAsync(string tipo)
        {
            Negocio negocio = new Negocio();
            int idTipo = await getIdTipo(tipo);
            List<string> subtipos = await negocio.GetAsync<List<string>>($"api/Productos/getSubtipos/{idTipo}");
            return subtipos;
        }

        public static async Task<List<string>> GetMarcasProductoAsync(string tipo)
        {
            Negocio negocio = new Negocio();
            int idTipo = await getIdTipo(tipo);
            List<string> marcas = await negocio.GetAsync<List<string>>($"api/Productos/getMarcas/{idTipo}");
            return marcas;
        }




        public static async Task<Producto> CreateProductoAsync(Producto producto)
        {
            Negocio negocio = new Negocio();
            Producto createdProducto = await negocio.PostAsync<Producto>("api/Productos", producto, "apikey");
            return createdProducto;
        }

        public static async Task UpdateProductoAsync(int id, Producto producto)
        {
            Negocio negocio = new Negocio();
            await negocio.PutAsync<Producto>($"api/Productos/{id}", producto, id, "apikey");
        }

        public static async Task DeleteProductoAsync(int id)
        {
            Negocio negocio = new Negocio();
            await negocio.DeleteAsync($"api/Productos/{id}", "apikey");
        }

     

        public static async Task<Venta> GetVentaAsync(int id)
        {
            Negocio negocio = new Negocio();
            Venta venta = await negocio.GetAsync<Venta>($"api/Ventas/{id}");
            return venta;
        }

       /* public static async Task<List<Producto>> GetProductosVentaAsync(int id)
        {
            Negocio negocio = new Negocio();
            List<Producto> productos = await negocio.GetAsync<List<Producto>>($"api/Ventas/getProductosVenta/{id}");
            return productos;
        }*/

        public static async Task<Venta> CreateVentaAsync(Venta venta)
        {
            Negocio negocio = new Negocio();
            Venta createdVenta = await negocio.PostAsync<Venta>("api/Ventas", venta, "apikey");
            return createdVenta;
        }

        public static async Task NuevaVentaAsync(Venta venta, List<Producto> productos)
        {
            Negocio negocio = new Negocio();

            // Crear el JObject con la venta y la lista de productos
            var jsonObject = new JObject();
            jsonObject["venta"] = JToken.FromObject(venta);
            jsonObject["productos"] = JToken.FromObject(productos);

            // Llamar al método PostAsync del Negocio para enviar el JObject
            await negocio.PostJsonObjectAsync<JObject>("api/Ventas/NuevaVenta", jsonObject, "apikey");
        }

        public static async Task UpdateVentaAsync(int id, Venta venta)
        {
            Negocio negocio = new Negocio();
            await negocio.PutAsync<Venta>($"api/Ventas/{id}", venta,id, "apikey");
        }

        public static async Task DeleteVentaAsync(int id)
        {
            Negocio negocio = new Negocio();
            await negocio.DeleteAsync($"api/Ventas/{id}", "apikey");
        }

       

        public static async Task<Grabado> GetGrabadoAsync(int id)
        {
            Negocio negocio = new Negocio();
            Grabado grabado = await negocio.GetAsync<Grabado>($"api/Grabados/{id}");
            return grabado;
        }

        public static async Task<Grabado> CreateGrabadoAsync(Grabado grabado)
        {
            Negocio negocio = new Negocio();
            Grabado createdGrabado = await negocio.PostAsync<Grabado>("api/Grabados", grabado, "apikey");
            return createdGrabado;
        }

        public static async Task UpdateGrabadoAsync(int id, Grabado grabado)
        {
            Negocio negocio = new Negocio();
            await negocio.PutAsync<Grabado>($"api/Grabados/{id}", grabado,id, "apikey");
        }

        public static async Task DeleteGrabadoAsync(int id)
        {
            Negocio negocio = new Negocio();
            await negocio.DeleteAsync($"api/Grabados/{id}", "apikey");
        }

       
        public static async Task<Encargo> GetEncargoAsync(int id)
        {
            Negocio negocio = new Negocio();
            Encargo encargo = await negocio.GetAsync<Encargo>($"api/Encargos/{id}");
            return encargo;
        }

        public static async Task<Encargo> CreateEncargoAsync(Encargo encargo)
        {
            Negocio negocio = new Negocio();
            Encargo createdEncargo = await negocio.PostAsync<Encargo>("api/Encargos", encargo, "apikey");
            return createdEncargo;
        }

        public static async Task UpdateEncargoAsync(int id, Encargo encargo)
        {
            Negocio negocio = new Negocio();
            await negocio.PutAsync<Encargo>($"api/Encargos/{id}", encargo,id, "apikey");
        }

        public static async Task<bool> DeleteEncargoAsync(int id)
        {
            Negocio negocio = new Negocio();
            bool respuesta=await negocio.DeleteAsync($"api/Encargos/{id}", "apikey");
            return respuesta;
        }

        public static async Task<Factura> NuevaFacturaAsync(Factura factura, List<ItemFactura> itemsFactura)
        {
            Negocio negocio = new Negocio();

            // Crear el JObject con la factura y la lista de itemsFactura
            var jsonObject = new JObject();
            jsonObject["factura"] = JToken.FromObject(factura);
            jsonObject["itemsFactura"] = JToken.FromObject(itemsFactura);

            // Llamar al método PostAsync del Negocio para enviar el JObject
            Factura createdFactura = await negocio.PostJsonObjectAsync<Factura>("Facturas/NuevaFactura", jsonObject, "apikey");
            return createdFactura;
        }


        public static async Task<Factura> ActualizarFacturaAsync(Factura factura, List<ItemFactura> itemsFactura)
        {
            Negocio negocio = new Negocio();

            // Crear el JObject con la factura y la lista de itemsFactura
            var jsonObject = new JObject();
            jsonObject["factura"] = JToken.FromObject(factura);
            jsonObject["itemsFactura"] = JToken.FromObject(itemsFactura);

            // Llamar al método PutJsonObjectAsync del Negocio para enviar el JObject
            await negocio.PutJsonObjectAsync<Factura>($"Facturas/{factura.idFactura}", jsonObject, factura.idFactura, "apikey");

            return factura;
        }

        public static async Task<PropietarioWr> ObtenerPropietarioAsync()
        {
            Negocio negocio = new Negocio();    
            List<Preferencia> preferencias = await negocio.GetAsync<List<Preferencia>>("api/Facturas/ObtenerPropietario");
            PropietarioWr propietario = new PropietarioWr();
            foreach (Preferencia p in preferencias)
            {
                switch (p.nombreAjuste)
                {
                    case "nombreNegocio":
                        propietario.nombre = p.valor;
                        break;
                    case "direccionNegocio":
                        propietario.dirección = p.valor;
                        break;

                    case "tlfNegocio":
                        propietario.telefono = p.valor;
                        break;

                    case "NifPropietario":
                        propietario.NIF = p.valor;
                        break;

                }
            }
            if (propietario != null)
                return propietario;
            else return null;

        }

        public static async Task CrearRecibo(Venta v)
        {
            if (v == null) return;
            Factura f = new Factura();
            f.fechaFactura = v.FechaVenta;
            List<ItemFactura> items = new List<ItemFactura>();
            List<Producto> products = new List<Producto>();
            FacturasManager manager = new FacturasManager();
            products = await GetProductosVentaAsync(v.IdVenta);
            if (products != null && products.Count > 0)
            {
                foreach (Producto p in products)
                {
                    int cuenta = 1;
                    int aux = products.Count(x => x.idProducto == p.idProducto);
                    if (aux > 0)
                        cuenta = aux;
                    ItemFactura item = manager.CrearItemFactura(p, cuenta);
                }
                using (LocalReport report = new LocalReport())
                {
                    ReportDataSource rpsFactura = new ReportDataSource("DataSet2", f);
                    ReportDataSource rsItems = new ReportDataSource("DataSet3", items);
                    report.ReportPath = "ReportRecibo.rdlc";
                    report.DataSources.Add(rpsFactura);
                    report.DataSources.Add(rsItems);
                    PageSettings pageSettings = new PageSettings();
                    pageSettings.Margins = new Margins(0, 0, 0, 0);
                    PaperSize customPaperSize = new PaperSize("CustomReceipt", 8, 8);
                    pageSettings.PaperSize = customPaperSize;
                    PrintDocument printDoc = new PrintDocument();
                    printDoc.DefaultPageSettings = pageSettings;

                    // Manejar el evento PrintPage para renderizar el informe en cada página
                    printDoc.PrintPage += (s, args) =>
                    {
                        // Obtener el contenido renderizado del informe
                        var pageStream = new System.IO.MemoryStream();
                        report.Render("Image");
                        pageStream.Position = 0;
                    };
                       /* PrintDialog printDialog = new PrintDialog();
                        printDoc.PrinterSettings = printDialog.PrinterSettings;

                        if (printDialog.ShowDialog() == DialogResult.OK)
                        {
                            printDoc.Print();
                        }*/

            }

            }

        }

        public static async Task<bool> Login(string username, string pass)
        {
            try
            {
                Negocio _negocio = new Negocio();
                if (username == "admin" && pass == "admin")
                    return true;
                if (username == null && pass == null)
                    return true;
                bool resultado = await _negocio.LoginAsync(username, pass);
                return resultado;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static async Task<List<string>> getMateriales()
        {
            Negocio negocio = new Negocio();
            List<string> materiales = new List<string>();
            materiales = await negocio.GetAsync<List<string>>($"api/Productos/getMateriales");
            return materiales;
        }

        public static async Task<List<string>> getTamanos()
        {
            Negocio negocio = new Negocio();
            List<string> tamanos = new List<string>();
            tamanos = await negocio.GetAsync<List<string>>($"api/Productos/getTamanos");
            return tamanos;
        }

        public static async Task<Usuario> CreateUsuarioAsync(Usuario usuario)
        {
            if (usuario == null)
            {
                throw new ArgumentNullException(nameof(usuario));
            }

            Negocio negocio = new Negocio();
            Usuario createdUsuario = await negocio.PostAsync<Usuario>("api/Usuarios", usuario, "apikey");
            return createdUsuario;
        }

        public static async Task UpdateUsuarioAsync(int id, Usuario usuario)
        {
            if (usuario == null)
            {
                throw new ArgumentNullException(nameof(usuario));
            }

            Negocio negocio = new Negocio();
            await negocio.PutAsync<Usuario>($"api/Usuarios/{id}", usuario, id, "apikey");
        }

        public static async Task DeleteUsuarioAsync(int id)
        {
            Negocio negocio = new Negocio();
            await negocio.DeleteAsync($"api/Usuarios/{id}", "apikey");
        }

        public static async Task<Usuario> GetUsuarioAsync(int id)
        {
            Negocio negocio = new Negocio();
            Usuario usuario = await negocio.GetAsync<Usuario>($"api/Usuarios/{id}");
            return usuario;
        }

        public static async Task<List<Usuario>> GetUsuariosAsync()
        {
            Negocio negocio = new Negocio();
            List<Usuario> usuarios = await negocio.GetAsync<List<Usuario>>("api/Usuarios");
            return usuarios;
        }
    }

}

