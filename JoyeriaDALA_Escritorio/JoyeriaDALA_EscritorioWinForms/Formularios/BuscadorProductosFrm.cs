using JoyeriaDALA_EscritorioWinForms.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoyeriaDALA_EscritorioWinForms.Formularios
{
    public partial class BuscadorProductosFrm : Form
    {
       private Producto productoBuscar;
        private List<Producto> productos;
         private List<Producto> productosFiltrados;
        private string filtro = null;
        public BuscadorProductosFrm()
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

            List<Producto> lista = await Herramientas.GetProductosAsync();

            if (lista.Count > 0)
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

                        string[] datos = new string[] { nombre, p.precio.ToString(), p.stock.ToString() };

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
                cmbMaterial.Items.Add(tipo);
            }


        }

        private async void AplicarFiltros()
        {
            productos = await Herramientas.GetProductosAsync();
            // Limpiar la lista de productos filtrados
            productosFiltrados.Clear();

            // Obtener los valores de los filtros
            string filtroTexto = txtFiltro.Text;
            string filtroMaterial = cmbMaterial.SelectedItem?.ToString();
            string filtroTipo = cmbTipo.SelectedItem?.ToString();
            string filtroTamaño = null;
            string filtroSubtipo = null;
            string filtroMarcas = null;
            if (filtroTipo == "Anillo" || filtroTipo == "Collar" || filtroTipo == "Pulsera")
            {
                filtroTamaño = cmbTamano.SelectedItem?.ToString();
            }
            if (filtroTipo != null)
            {//Llamada correspondiente
                filtroSubtipo = cmbSubtipo.SelectedItem?.ToString();
            }
            if (filtroTipo != null)
            {
                filtroMarcas = cmbMarca.SelectedItem?.ToString();
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
                string.IsNullOrEmpty(filtroTipo) && string.IsNullOrEmpty(filtroTamaño) && string.IsNullOrEmpty(filtroSubtipo) && string.IsNullOrEmpty(filtroMarcas))
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
                        string tipo = p.tipoProducto;
                        if (p.subtipo != null)
                        {
                            tipo += " " + p.subtipo;
                        }

                        string[] datos = new string[] { nombre, p.precio.ToString(), p.stock.ToString() };

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

        public async Task CargarTipos()
        {
            cmbTipo.Items.Clear();
            
            List<TipoProducto> tiposProd = await Herramientas.GetTiposProductoAsync();
            foreach (TipoProducto t in tiposProd)
            {
                cmbTipo.Items.Add(t.Tipo);
            }
        }

        public async Task CargarMateriales()
        {
            cmbMaterial.Items.Clear();
            List<string> materiales=new List<string>();
            materiales = await Herramientas.getMateriales();
            foreach(string s in materiales)
                cmbMaterial.Items.Add(s);
        }

        public async Task CargarTamanos()
        {
            cmbTamano.Items.Clear();
            List<string> tamanos = new List<string>();
            tamanos = await Herramientas.getTamanos();
            foreach (string s in tamanos)
                cmbTamano.Items.Add(s);
        }

        public async Task CargarSubtipos()
        {

            if (cmbSubtipo.Items.Count != 0)
                cmbSubtipo.Items.Clear();
            if (cmbTipo.SelectedItem == null || cmbTipo.SelectedItem == " ")
            {
                return;
            }
            cmbSubtipo.Enabled = true;
            string tipo = cmbTipo.SelectedItem.ToString();
          
            List<string> subtipos = await Herramientas.GetSubtiposProductoAsync(tipo);
            foreach (string subtipo in subtipos)
            {
                cmbSubtipo.Items.Add(subtipo);
            }
        }

        public async Task CargarMarcas()
        {
            if (cmbMarca.Items.Count != 0)
                cmbMarca.Items.Clear(); 
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
        public Producto DevolverProducto() { return productoBuscar; }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            Producto nuevo = new Producto();
            DetallesProductoFrm prodForm = new DetallesProductoFrm(nuevo);
            if (prodForm.ShowDialog() == DialogResult.OK)
            {
                //Herramientas
                productos.Add(nuevo);
                this.productoBuscar = prodForm.DevolverProducto();
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (lvwProductos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona un producto para confirmar");
            }
            int ProductoId = 0;
            Int32.TryParse(lvwProductos.SelectedItems[0].Tag.ToString(), out ProductoId);
            productoBuscar = productos.FirstOrDefault(x => x.idProducto == ProductoId);
            this.DialogResult = DialogResult.OK;
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
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
                            cmbSubtipo.Items.Add(s);
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
                cmbSubtipo.Items.Clear();
                cmbMarca.Items.Clear();
            }
           await CargarSubtipos();
            await CargarMarcas();
        }

        private async void BuscadorProductosFrm_Load(object sender, EventArgs e)
        {
           await ObtenerProductos();
            await ActualizarListaAsync();
            await CargarTipos();
            await CargarMateriales();
            await CargarTamanos();
        }
    }
}
