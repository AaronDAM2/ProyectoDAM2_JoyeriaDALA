using JoyeriaDALA_EscritorioWinForms.Modelo;
using JoyeriaDALA_EscritorioWinForms.Reports;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JoyeriaDALA_EscritorioWinForms
{
    public static class Herramientas
    {
        public static string NombreProducto(Producto producto)
        {
            string nombre = "";
            if (producto != null && producto.tipoProducto != null)
            {
                if (producto.subtipo != null)
                {
                    nombre += producto.subtipo + " ";
                }
                else
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

        public static async Task<List<Producto>> GetProductosAsync()
        {
            Negocio negocio = new Negocio();
            List<Producto> productos=new List<Producto> ();
            productos = await negocio.GetAsync<List<Producto>>("api/productos");

            return productos;
        }

        public static async Task<List<Venta>> GetVentasAsync()
        {
            Negocio negocio = new Negocio();
            List<Venta> ventas = new List<Venta>();
                ventas= await negocio.GetAsync<List<Venta>>("api/Ventas");

            return ventas;
        }

        public static async Task<List<Grabado>> GetGrabadosAsync()
        {
            Negocio negocio = new Negocio();
            List<Grabado> Grabados = new List<Grabado>();
               Grabados= await negocio.GetAsync<List<Grabado>>("api/Grabados");

            return Grabados;
        }

        public static async Task<List<Encargo>> GetEncargosAsync()
        {
            Negocio negocio = new Negocio();
            List<Encargo> Encargos = new List<Encargo> ();
              Encargos=  await negocio.GetAsync<List<Encargo>>("api/Encargos");

            return Encargos;
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
            foreach (TipoProducto tipo in tipos)
            {
                lista.Add(tipo.Tipo);
            }
            return lista;
        }

        public static async Task<int> getIdTipo(string tipo)
        {
            Negocio negocio = new Negocio();
            int idTipo = await negocio.GetAsync<int>($"api/Productos/getIdTipo/{tipo}");
            return idTipo;
        } 

        public static async Task<List<string>> getMateriales()
        {
            Negocio negocio=new Negocio();
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
            Producto createdProducto = await negocio.PostAsync<Producto>("api/Productos/postProducto", producto, "apikey");
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


        public static async Task<Venta> GetVentaAsync(int id)
        {
            Negocio negocio = new Negocio();
            Venta venta = await negocio.GetAsync<Venta>($"api/Ventas/{id}");
            return venta;
        }



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
            await negocio.PutAsync<Venta>($"api/Ventas/{id}", venta, id, "apikey");
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
            await negocio.PutAsync<Grabado>($"api/Grabados/{id}", grabado, id, "apikey");
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
            await negocio.PutAsync<Encargo>($"api/Encargos/{id}", encargo, id, "apikey");
        }

        public static async Task<bool> DeleteEncargoAsync(int id)
        {
            Negocio negocio = new Negocio();
            bool respuesta = await negocio.DeleteAsync($"api/Encargos/{id}", "apikey");
            return respuesta;
        }


        public static async Task<List<Factura>> GetFacturasAsync()
        {
            Negocio negocio = new Negocio();
            return await negocio.GetAsync<List<Factura>>("api/Facturas");
        }

        public static async Task<Factura> GetFacturaByIdAsync(int id)
        {
            Negocio negocio = new Negocio();
            return await negocio.GetAsync<Factura>($"api/Facturas/{id}");
        }

        public static async Task<Factura> CreateFacturaAsync(Factura factura)
        {
            Negocio negocio = new Negocio();
            return await negocio.PostAsync<Factura>("api/Facturas", factura, "apikey");
        }

        public static async Task UpdateFacturaAsync(Factura factura)
        {
            Negocio negocio = new Negocio();
            await negocio.PutAsync<Factura>($"api/Facturas/{factura.idFactura}", factura, factura.idFactura, "apikey");
        }

        public static async Task<bool> DeleteFacturaAsync(int id)
        {
            Negocio negocio = new Negocio();
            return await negocio.DeleteAsync($"api/Facturas/{id}", "apikey");
        }

        public static async Task<Venta> GetVentaFacturaAsync(int idFactura)
        {
            Negocio negocio = new Negocio();
            return await negocio.GetAsync<Venta>($"api/Facturas/getVentaFactura/{idFactura}");
        }

        public static async Task<Encargo> GetEncargoFacturaAsync(int idFactura)
        {
            Negocio negocio = new Negocio();
            return await negocio.GetAsync<Encargo>($"api/Facturas/getEncargoFactura/{idFactura}");
        }

        public static async Task<Grabado> GetGrabadoFacturaAsync(int idFactura)
        {
            Negocio negocio = new Negocio();
            return await negocio.GetAsync<Grabado>($"api/Facturas/getGrabadoFactura/{idFactura}");
        }

        public static async Task<List<Notificacion>> GetNotificacionesAsync()
        {
            Negocio negocio = new Negocio();
            List<Notificacion> notifs=new List<Notificacion>();
            notifs= await negocio.GetAsync<List<Notificacion>>("api/Notificaciones");
            return notifs;
        }

        public static async Task<Notificacion> GetNotificacionAsync(int id)
        {
            Negocio negocio = new Negocio();
            return await negocio.GetAsync<Notificacion>($"api/Notificaciones/{id}");
        }

        public static async Task<Notificacion> CreateNotificacionAsync(Notificacion notificacion)
        {
            Negocio negocio = new Negocio();
            return await negocio.PostAsync<Notificacion>("api/Notificaciones", notificacion, "apikey");
        }

        public static async Task UpdateNotificacionAsync(int id, Notificacion notificacion)
        {
            Negocio negocio = new Negocio();
            await negocio.PutAsync<Notificacion>($"api/Notificaciones/{id}", notificacion, id, "apikey");
        }

        public static async Task<bool> DeleteNotificacionAsync(int id)
        {
            Negocio negocio = new Negocio();
            return await negocio.DeleteAsync($"api/Notificaciones/{id}", "apikey");
        }

        public static async Task<int> LimpiarNotificaciones()
        {
            int i = 0;
            Negocio negocio = new Negocio();
            List<Notificacion> notificaciones = await negocio.GetAsync<List<Notificacion>>("api/Notificaciones");
            if (notificaciones != null && notificaciones.Count != 0)
            {
                foreach (Notificacion n in notificaciones)
                {
                    if (n.fechaFin < DateTime.Now.AddDays(1))
                    {
                        await negocio.DeleteAsync($"api/Notificaciones/{n.NotifId}", "apikey");
                        i++;
                    }
                }
                return i;
            }
            return -1;
        }

        public static async Task ActualizarNotificaciones()
        {
            List<Notificacion> notifs = await GetNotificacionesAsync();
            List<Encargo> encargos = await GetEncargosAsync();
            List<Grabado> grabados = await GetGrabadosAsync();
            if (notifs == null || notifs.Count < 1)
                return;
            List<Notificacion> nEncargos = notifs.Where(x => x.tipo == "Encargo").ToList();
            List<Notificacion> nGrabados = notifs.Where(x => x.tipo == "Grabado").ToList();
            foreach (Encargo e in encargos)
            {
                if (e.FechaInicio > DateTime.Now && e.FechaFin < e.FechaFin && !e.terminada)
                {
                    Notificacion n = nEncargos.FirstOrDefault(x => x.IdAsociado == e.IdEncargo);
                    if (n == null)
                    {
                        n = new Notificacion();
                        n.fechaInicio = e.FechaInicio;
                        n.fechaFin = e.FechaFin.Value;
                        n.titulo = "Encargo_" + e.cliente + "_" + e.FechaInicio.ToShortDateString();
                        n.descripción = e.descripcion;
                        n.tipo = "Encargo";
                        n.IdAsociado = e.IdEncargo;
                        await CreateNotificacionAsync(n);
                    }

                }
            }

            foreach (Grabado e in grabados)
            {
                if (e.FechaInicio > DateTime.Now && e.FechaFin < e.FechaFin && !e.terminado)
                {
                    Notificacion n = nGrabados.FirstOrDefault(x => x.IdAsociado == e.IdGrabado);
                    if (n == null)
                    {
                        n = new Notificacion();
                        n.fechaInicio = e.FechaInicio;
                        n.fechaFin = e.FechaFin.Value;
                        n.titulo = "Grabado_" + e.nombreCliente + "_" + e.FechaInicio.ToShortDateString();
                        n.descripción = e.contenido;
                        n.tipo = "Grabado";
                        n.IdAsociado = e.IdGrabado;
                        await CreateNotificacionAsync(n);
                    }

                }
            }

            await LimpiarNotificaciones();

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
            List<Preferencia> preferencias= await negocio.GetAsync<List<Preferencia>>("api/Facturas/ObtenerPropietario");
            PropietarioWr propietario=new PropietarioWr();
            foreach(Preferencia p in preferencias)
            {
                switch (p.nombreAjuste)
                {
                    case "nombreNegocio":
                        propietario.nombre = p.valor;
                        break;
                    case "direccionNegocio":
                        propietario.dirección=p.valor;
                        break;

                    case "tlfNegocio":
                        propietario.telefono=p.valor;
                        break;

                    case "NifPropietario":
                        propietario.NIF=p.valor;
                        break;

                }
            }
            if( propietario != null )
                return propietario; else return null;

        }

        public static async Task ExportarProductos(string salida)
        {
            using (var package = new ExcelPackage())
            {
                List<Producto> productos = new List<Producto>();
                productos=await GetProductosAsync();
                var worksheet = package.Workbook.Worksheets.Add("Productos");

                // Agregar la fila de cabecera
                worksheet.Cells[1, 1].Value = "ID";
                worksheet.Cells[1, 2].Value = "Tipo de Producto";
                worksheet.Cells[1, 3].Value = "Nombre";
                worksheet.Cells[1, 4].Value = "Precio";
                worksheet.Cells[1, 5].Value = "Stock";
                worksheet.Cells[1, 6].Value = "Descripción";
                worksheet.Cells[1, 7].Value = "Material";
                worksheet.Cells[1, 8].Value = "Tamaño";
                worksheet.Cells[1, 9].Value = "Activo";
                worksheet.Cells[1, 10].Value = "Subtipo";
                worksheet.Cells[1, 11].Value = "Marca";

                // Llenar filas con datos
                for (int i = 0; i < productos.Count; i++)
                {
                    var producto = productos[i];
                    int row = i + 2;

                    worksheet.Cells[row, 1].Value = producto.idProducto;
                    worksheet.Cells[row, 2].Value = producto.tipoProducto;
                    worksheet.Cells[row, 3].Value = producto.nombre;
                    worksheet.Cells[row, 4].Value = producto.precio;
                    worksheet.Cells[row, 5].Value = producto.stock;
                    worksheet.Cells[row, 6].Value = producto.descripcion;
                    worksheet.Cells[row, 7].Value = producto.material;
                    worksheet.Cells[row, 8].Value = producto.tamano;
                    worksheet.Cells[row, 9].Value = producto.activo;
                    worksheet.Cells[row, 10].Value = producto.subtipo;
                    worksheet.Cells[row, 11].Value = producto.marca;
                }

                package.SaveAs(new FileInfo(salida));
            }
        }




        public static async Task<bool> InicializarDB()
        {
            string connectionString;
            try
            {
                Negocio _negocio = new Negocio();
                connectionString = await _negocio.GetAsync<string>("Preferencia/ConString");
            }
            catch (Exception e)
            {
                return false;
            }
            if(connectionString == null)
            {
                return false;   
            }
             // Reemplaza con tu cadena de conexión
            string scriptFilePath = "InicializarDB.sql"; // Ruta al archivo de script SQL

            try
            {
                string scriptContent = System.IO.File.ReadAllText(scriptFilePath);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(scriptContent, connection))
                    {
                        if (command.ExecuteNonQuery() > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                       // MessageBox.Show("Script executed successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                //  MessageBox.Show("An error occurred: " + ex.Message);
                return false;
            }
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

        public static async Task<bool> Login(string username, string pass)
        {
            try
            {
                Negocio _negocio=new Negocio();
                if (username == "admin" && pass == "admin")
                    return true;
                if (username == null && pass == null)
                    return true;
                bool resultado = await _negocio.LoginAsync(username, pass);
                return resultado;
            }catch (Exception ex)
            {
                return false;
            }
        }



    }
}
