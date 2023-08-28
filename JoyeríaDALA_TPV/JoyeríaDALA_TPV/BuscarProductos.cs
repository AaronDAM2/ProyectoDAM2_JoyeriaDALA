using JoyeríaDALA_TPV.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoyeríaDALA_TPV
{
    public partial class BuscarProductos : Form
    {
        private List<Producto> productos;
        private List<Producto> productosFiltrados;
        private Producto productoBuscar;
        private string filtro = null;
        public BuscarProductos()
        {
            InitializeComponent();
            productos = new List<Producto>();
            productosFiltrados = new List<Producto>();
            
            
        }

        private async Task<List<Producto>> ObtenerProductos()
        {
            try
            {

                productos = await Herramientas.GetProductosAsync();

            }
            catch (Exception ex)
            {

            }
            return productos;
        }
        private async Task ActualizarListaAsync()
        {
            if (lvwProductos.Items.Count > 0)

                lvwProductos.Items.Clear();

            List<Producto> lista = new List<Producto>();
             lista = await Herramientas.GetProductosAsync();

            if (lista != null && lista.Count != 0)
            {
                foreach (Producto p in lista)
                {
                    if (p != null)
                    {
                        string nombre = Herramientas.NombreProducto(p);
                        if (p.nombre != null)
                        {
                            nombre = p.nombre;
                        }
                        string tipo = p.tipoProducto;
                        if (p.subtipo != null)
                        {
                            tipo += " " + p.subtipo;
                        }

                        string[] datos = new string[] { nombre, p.precio.ToString() };

                        ListViewItem item = new ListViewItem(datos);
                        if (p.stock < 1)
                            item.BackColor = Color.Yellow;
                        item.Tag = p.idProducto;
                        if (filtro == null)
                        {
                            lvwProductos.Items.Add(item);
                        }
                        else
                        if (datos.Contains<String>(filtro))
                            lvwProductos.Items.Add(item);

                    }

                }
            }

        }

        public void ActualizarFiltros()
        {
            List<string> tipos = new List<string>(); //Llamada a la API
            List<string> materiales = new List<string> { "Oro", "Plata", "Acero", "Cristal" };

            foreach (string tipo in materiales)
            {
                cmbMateriales.Items.Add(tipo);
            }

            
        }

        private void AplicarFiltros()
        {
            productos=Herramientas.GetProductosAsync().Result;
            // Limpiar la lista de productos filtrados
            productosFiltrados.Clear();

            // Obtener los valores de los filtros
            string filtroTexto = txtFiltro.Text;
            string filtroMaterial = cmbMateriales.SelectedItem?.ToString();
            string filtroTipo = cmbTipo.SelectedItem?.ToString();
            string filtroTamaño = null;
            string filtroSubtipo = null;
            string filtroMarcas = null;
            if (filtroTipo == "Anillo" || filtroTipo == "Collar" || filtroTipo == "Pulsera")
            {
                filtroTamaño = cmbTamaños.SelectedItem?.ToString();
            }
            if (filtroTipo != null)
            {//Llamada correspondiente
                filtroSubtipo = cmbSubTipos.SelectedItem?.ToString();
            }
            if (filtroTipo != null)
            {
                filtroMarcas=cmbMarca.SelectedItem?.ToString();
            }

            // Filtrar los productos según los filtros seleccionados
            productosFiltrados = productos.Where(p =>
                (string.IsNullOrEmpty(filtroTexto) || p.nombre.Contains(filtroTexto)) &&
                (string.IsNullOrEmpty(filtroMaterial) || p.material == filtroMaterial) &&
                (string.IsNullOrEmpty(filtroTipo) || p.tipoProducto == filtroTipo) &&
                (string.IsNullOrEmpty(filtroTamaño) || p.tamano.ToString() == filtroTamaño) &&
                (string.IsNullOrEmpty(filtroSubtipo) || p.subtipo == filtroSubtipo) &&
                (string.IsNullOrEmpty(filtroMarcas) || p.marca == filtroMarcas)
            ).ToList();

            // Si no se ha seleccionado ningún filtro, mostrar todos los productos
            if (string.IsNullOrEmpty(filtroTexto) && string.IsNullOrEmpty(filtroMaterial) &&
                string.IsNullOrEmpty(filtroTipo) && string.IsNullOrEmpty(filtroTamaño) && string.IsNullOrEmpty(filtroSubtipo)&&string.IsNullOrEmpty(filtroMarcas)) 
            {
                productosFiltrados = productos.ToList();
            }

            // Mostrar los productos filtrados en el ListView
            MostrarProductosFiltrados();
        }

        private void MostrarProductosFiltrados()
        {
            // Limpiar el ListView
            lvwProductos.Items.Clear();

            // Mostrar todos los productos si no hay productos filtrados
            if (productosFiltrados.Count == 0)
            {
                productosFiltrados = productos;
            }
            else
            {

                // Agregar los productos filtrados al ListView
                foreach (var p in productosFiltrados)
                {
                    if (p.activo)
                    {
                        string nombre = Herramientas.NombreProducto(p);
                        if (p.nombre != null)
                        {
                            nombre = p.nombre;
                        }
                        

                        string[] datos = new string[] { nombre, p.precio.ToString() };

                        ListViewItem item = new ListViewItem(datos);
                        if (p.stock < 1)
                            item.BackColor = Color.Yellow;
                        item.Tag = p.idProducto;
                        if (filtro == null)
                        {
                            lvwProductos.Items.Add(item);
                        }
                        else
                        if (datos.Contains<String>(filtro))
                            lvwProductos.Items.Add(item);

                    }
                }
            }
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            Producto nuevo=new Producto();
            ProductoFrm prodForm = new ProductoFrm(nuevo);
            if(prodForm.ShowDialog() == DialogResult.OK)
            {
                //Herramientas
                productos.Add(nuevo);
                this.productoBuscar = prodForm.DevolverProducto();
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }

        public async Task CargarTipos()
        {
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add(" ");
            List<TipoProducto> tiposProd = await Herramientas.GetTiposProductoAsync();
            foreach (TipoProducto t in tiposProd)
            {
                cmbTipo.Items.Add(t.Tipo);
            }
        }
        public async Task CargarMateriales()
        {
            cmbMateriales.Items.Clear();
            List<string> materiales = new List<string>();
            materiales = await Herramientas.getMateriales();
            foreach (string s in materiales)
                cmbMateriales.Items.Add(s);
        }

        public async Task CargarTamanos()
        {
            cmbTamaños.Items.Clear();
            List<string> tamanos = new List<string>();
            tamanos = await Herramientas.getTamanos();
            foreach (string s in tamanos)
                cmbTamaños.Items.Add(s);
        }


        public async void CargarSubtipos()
        {
            if (cmbTipo.SelectedItem == null || cmbTipo.SelectedItem == " ")
            {
                return;
            }
            cmbSubTipos.Enabled = true;
            string tipo = cmbTipo.SelectedItem.ToString();
           
            List<string> subtipos = await Herramientas.GetSubtiposProductoAsync(tipo);
            foreach (string subtipo in subtipos)
            {
                cmbSubTipos.Items.Add(subtipo);
            }
        }

        public async void CargarMarcas()
        {
            if (cmbTipo.SelectedItem == null || cmbTipo.SelectedItem == " ")
            {
                return;
            }
            cmbMarca.Enabled = true;
            string tipo = cmbTipo.SelectedItem.ToString();
          
            List<string> marcas = await Herramientas.GetMarcasProductoAsync(tipo);
            foreach (string marca in marcas)
            {
                cmbMarca.Items.Add(marca);
            }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(lvwProductos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona un producto para confirmar");
            }
            int ProductoId = 0;
            Int32.TryParse(lvwProductos.SelectedItems[0].Tag.ToString(), out ProductoId);
            productoBuscar = productos.FirstOrDefault(x => x.idProducto == ProductoId);
            this.DialogResult= DialogResult.OK;
                    
        }

        public Producto DevolverProducto() { return productoBuscar; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private async void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwProductos.SelectedItems.Count == 1)
            {
                string tipo = cmbTipo.SelectedItem.ToString();
                if (tipo != null)
                {
                    List<string> subtipos = await Herramientas.GetSubtiposProductoAsync(tipo);
                    if (subtipos.Count != 0)
                    {
                        foreach (string s in subtipos)
                            cmbSubTipos.Items.Add(s);
                    }
                    List<string> marcas = await Herramientas.GetMarcasProductoAsync(tipo);
                    if (marcas.Count != 0)
                    {
                        foreach (string s in marcas)
                            cmbMarca.Items.Add(s);
                    }
                }
            }
            else
            {
                cmbSubTipos.Items.Clear();
                cmbMarca.Items.Clear();
            }
        }

        private async void BuscarProductos_Load(object sender, EventArgs e)
        {
           await ObtenerProductos();
            
            await CargarTipos();
            await CargarMateriales();
            await CargarTamanos();

            await ActualizarListaAsync();
        }
    }
}
