using JoyeriaDALA_EscritorioWinForms.Modelo;
using OfficeOpenXml.ConditionalFormatting.Contracts;
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
    public partial class InventarioFrm : Form
    {
        private string filtro = null;
        private List<Producto> productos;
        private List<Producto> productosFiltrados;
        public InventarioFrm()
        {
            InitializeComponent();
            productos = new List<Producto>();
            productosFiltrados = new List<Producto>();
            
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
            cmbMaterial.Items.Clear();
            List<string> materiales = new List<string>();
            materiales = await Herramientas.getMateriales();
            foreach (string s in materiales)
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

                        string[] datos = new string[] { nombre, p.stock.ToString(), p.precio.ToString(), tipo, p.marca, p.activo.ToString(), p.descripcion };

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
            productos = await Herramientas.GetProductosAsync() ;
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
                foreach (var producto in productosFiltrados)
                {

                    ListViewItem item = new ListViewItem(new string[] { producto.nombre, producto.precio.ToString(), producto.descripcion });


                    lvwProductos.Items.Add(item);

                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto nuevo=new Producto();
            DetallesProductoFrm crear = new DetallesProductoFrm(nuevo);
            if(crear.ShowDialog() == DialogResult.OK)
            {
                nuevo=crear.DevolverProducto();
                AplicarFiltros();
                crear.Close();
            }

           

        }

        private async void editarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvwProductos.SelectedItems.Count == 1)
            {
                int id = (int)lvwProductos.SelectedItems[0].Tag;
                Producto p = await Herramientas.GetProductoAsync(id);
                if (p != null)
                {
                    DetallesProductoFrm editar = new DetallesProductoFrm(p);
                    if(editar.ShowDialog() == DialogResult.OK)
                    {
                        p=editar.DevolverProducto();
                        AplicarFiltros();
                        editar.Close();
                    }
                }
            }
            else
                MessageBox.Show("Selecciona un producto");

            AplicarFiltros();
        }

        private async void borrarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvwProductos.SelectedItems.Count == 1)
            {
                int id = (int)lvwProductos.SelectedItems[0].Tag;
                Producto p = await Herramientas.GetProductoAsync(id);
                if (p != null)
                {
                    string mensaje = "¿Seguro que quieres borrar este producto? Aparecerá en ventas y registros, pero dejará de estar disponible";
                    if(MessageBox.Show(mensaje,"Borrar Producto", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        await Herramientas.DeleteProductoAsync(p.idProducto);
                        MessageBox.Show("Producto borrado con exito");
                    }
                    }
            }
            else
                MessageBox.Show("Selecciona un producto");
        }

        private async void retirarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvwProductos.SelectedItems.Count == 1)
            {
                int id = (int)lvwProductos.SelectedItems[0].Tag;
                Producto p = await Herramientas.GetProductoAsync(id);
                if (p != null)
                {
                    if (p.activo)
                    {
                        string mensaje = "¿Seguro que quieres retirar este producto? No estará disponible para añadir a ventas y otros";
                        if (MessageBox.Show(mensaje, "Retirar Producto", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            p.activo = false;
                            await Herramientas.UpdateProductoAsync(p.idProducto,p);
                            MessageBox.Show("Producto retirado con exito");
                        }
                    }
                    else
                    {

                        string mensaje = "¿Reactivar este producto? Volverá a disponible para añadir a ventas y otros";
                        if (MessageBox.Show(mensaje, "Reactivar Producto", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            p.activo = true;
                            await Herramientas.UpdateProductoAsync(p.idProducto, p);
                            MessageBox.Show("Producto reactivado con exito");
                        }
                    }
                }
            }
            else
                MessageBox.Show("Selecciona un producto");

            AplicarFiltros();
        }

        private async void cambiarStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvwProductos.SelectedItems.Count == 1)
            {
                int id = (int)lvwProductos.SelectedItems[0].Tag;
                Producto p = await Herramientas.GetProductoAsync(id);
                if (p != null)
                {
                    CambiarStockFrm stock=new CambiarStockFrm(p);
                    if(stock.ShowDialog() == DialogResult.OK)
                    {
                        AplicarFiltros();
                        stock.Close();
                    }
                }
            }
            else
                MessageBox.Show("Selecciona un producto");
        }

        private async void InventarioFrm_Load(object sender, EventArgs e)
        {
            await ObtenerProductos();
            await ActualizarListaAsync();
            await CargarTipos();
            await CargarTamanos();
            await CargarMateriales();
        }

        private async void btnExportar_Click(object sender, EventArgs e)
        {
            string salida;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Seleccionar ruta de excel";
            ofd.Filter = "*Archivos de Excel|*.xlsx";
            if(ofd.ShowDialog() == DialogResult.OK) { 
                salida = ofd.FileName;
              await  Herramientas.ExportarProductos(salida);
            }
            
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            AjustesInventarioFrm ajustes=new AjustesInventarioFrm();
            ajustes.ShowDialog();
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
            if(cmbMarca.Items.Count != 0)
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
    }
}
