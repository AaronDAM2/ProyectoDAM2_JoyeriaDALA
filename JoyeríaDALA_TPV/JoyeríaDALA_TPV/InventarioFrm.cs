using JoyeríaDALA_TPV.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoyeríaDALA_TPV
{
    public partial class InventarioFrm : Form
    {
        private string filtro=null;
        private List<Producto> productos;
        private List<Producto> productosFiltrados;
        public InventarioFrm()
        {
            InitializeComponent();
            productos = new List<Producto>();
            productosFiltrados = new List<Producto>();
            
            
        }

        private async Task<List<Producto>> ObtenerProductos()
        {
            try
            {
               
                productos= await Herramientas.GetProductosAsync();
               
            }catch (Exception ex)
            {

            }
            return productos;
        }
        private async Task ActualizarListaAsync()
        {
            if(lvwProductos.Items.Count > 0)
            
                lvwProductos.Items.Clear();

            List<Producto> lista = new List<Producto>();
            lista = await Herramientas.GetProductosAsync();

            if (lista!=null && lista.Count != 0)
            {
                foreach(Producto p in lista) {
                    if (p != null)
                    {
                        string nombre=Herramientas.NombreProducto(p);
                        if (p.nombre != null)
                        {
                            nombre = p.nombre;
                        }
                        string tipo = p.tipoProducto;
                        if (p.subtipo != null)
                        {
                            tipo += " " + p.subtipo;
                        }
                        
                        string[] datos = new string[] {nombre, p.stock.ToString(), p.precio.ToString(), tipo, p.marca, p.activo.ToString() };

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
            productos = Herramientas.GetProductosAsync().Result;
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
                    
                        ListViewItem item = new ListViewItem(new string[] { producto.nombre, producto.precio.ToString() });


                        lvwProductos.Items.Add(item);
                    
                }
            }
        }
       
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AplicarFiltros();
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

       /* private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //    CargarSubtipos();
        }*/

        private async void btnStock_Click(object sender, EventArgs e)
        {
            if (lvwProductos.SelectedItems.Count == 1)
            {
                Producto p = await Herramientas.GetProductoAsync((int)lvwProductos.SelectedItems[0].Tag);
                if (p != null)
                {
                    ContadorFrm contador=new ContadorFrm(p.precio);
                    if (contador.ShowDialog() == DialogResult.OK)
                        MessageBox.Show("Stock Actualizado");
                    
                }
                else
                    MessageBox.Show("Producto no encontrado");
            }
            else
            {
                MessageBox.Show("Elige un producto para editarlo");
            }
        }

        private async void btnPrecio_Click(object sender, EventArgs e)
        {
            if (lvwProductos.SelectedItems.Count == 1)
            {
                Producto p = await Herramientas.GetProductoAsync((int)lvwProductos.SelectedItems[0].Tag);
                if (p != null)
                {
                    ContadorFrm contador = new ContadorFrm(p.precio);
                    if (contador.ShowDialog() == DialogResult.OK)
                        MessageBox.Show("Precio Actualizado");

                }
                else
                    MessageBox.Show("Producto no encontrado");
            }
            else
            {
                MessageBox.Show("Elige un producto para editarlo");
            }
        }

        private async void btnRetirar_Click(object sender, EventArgs e)
        {
            if (lvwProductos.SelectedItems.Count == 1)
            {
                Producto p = await Herramientas.GetProductoAsync((int)lvwProductos.SelectedItems[0].Tag);
                if (p != null)
                {
                    if (p.activo)
                    {
                        p.activo = false;
                        MessageBox.Show("El producto ha sido retirado");
                    }
                    else
                    {
                        p.activo = true;
                        MessageBox.Show("El producto ha sido reactivado");
                    }

                    await Herramientas.UpdateProductoAsync(p.idProducto, p);
                }
                else
                    MessageBox.Show("Producto no encontrado");
            }
            else
            {
                MessageBox.Show("Elige un producto para editarlo");
            }

        }



    private async void ActualizarPrecio(int idProducto)
        {

        }
        private async void ActivarProducto(int idProducto)
        {

        }

        private async void cmbTipo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CargarSubtipos();
            CargarMarcas();
        }

        private async void InventarioFrm_Load(object sender, EventArgs e)
        {
            await ObtenerProductos();
            
            await CargarTipos();
            await CargarMateriales();
            await CargarTamanos();

            await ActualizarListaAsync();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
           Producto p=new Producto();
            ProductoFrm nuevo = new ProductoFrm(p);
            nuevo.ShowDialog();
        }
    }
}
