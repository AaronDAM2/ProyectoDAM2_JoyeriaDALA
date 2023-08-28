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
    public partial class DetallesVentaFrm : Form
    {
        private double precio;
        private Venta venta;
        private List<Producto> productos;
        private bool nuevo=false;

        public DetallesVentaFrm(Venta venta)
        {
            InitializeComponent();
            this.venta = venta;
            if (venta.IdVenta == 0)
            {
                this.nuevo = true;
            }
            else
            {
                txtPrecio.Text=venta.precio.ToString();
                txtObservaciones.Text = venta.observaciones;
                dtpVenta.Value = venta.FechaVenta;
                productos = ObtenerProductosVenta().Result;
                foreach(Producto producto in productos)
                {
                    string[] datos = new string[] { producto.nombre, producto.precio.ToString() };
                }
            }
        }

        private async Task<List<Producto>> ObtenerProductosVenta()
        {
            productos = await Herramientas.GetProductosVentaAsync(venta.IdVenta);
            return productos;   
        }

        private void txtObservaciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCargarPrecios_Click(object sender, EventArgs e)
        {
            Double.TryParse(txtPrecio.Text, out precio);
            if (productos.Count == 0 || productos == null)
            {
                MessageBox.Show("No hay productos seleccionados");
                return;
            }
            foreach (Producto p in productos)
            {
                if (p != null)
                {
                    precio += p.precio;
                }
                

            }
            txtPrecio.Text = precio.ToString();
        }

        private void btnAddProducto_Click(object sender, EventArgs e)
        {
            Producto buscar = new Producto();
            BuscadorProductosFrm buscador = new BuscadorProductosFrm();
            if (buscador.ShowDialog() == DialogResult.OK)
            {
                buscar = buscador.DevolverProducto();
                buscador.Close();

                productos.Add(buscar);
                ListViewItem item = new ListViewItem(new string[] { buscar.nombre, buscar.precio.ToString() });
                lvwProductos.Items.Add(item);
            }
        }

        private void btnQuitarProducto_Click(object sender, EventArgs e)
        {
            if (lvwProductos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debes seleccionar un producto para poder eliminarlo");
                return;
            }
            if (lvwProductos.SelectedItems.Count == 1)
            {
                Producto p = productos.FirstOrDefault(x => x.nombre == lvwProductos.SelectedItems[0].Name);
                productos.Remove(p);
                lvwProductos.Items.Remove(lvwProductos.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Error de seleccion");
            }
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            Double.TryParse(txtPrecio.Text, out double precio);
            venta.FechaVenta=dtpVenta.Value;
            venta.observaciones=txtObservaciones.Text;
            venta.precio=precio;
            venta.codVenta = await Herramientas.CrearCodVenta(venta);
            await Herramientas.NuevaVentaAsync(venta, productos);
            this.DialogResult= DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void VaciarFormulario()
        {
            venta = new Venta();
            productos = new List<Producto>();
            txtObservaciones.Clear();
            txtPrecio.Clear();
            dtpVenta.Value = DateTime.Now;
        }
    }
}
