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
    public partial class DetallesProductoFrm : Form
    {
        private Producto producto;
        private bool nuevo=false;
        public DetallesProductoFrm(Producto producto)
        {

            InitializeComponent();
            this.producto = producto;
            if (producto.idProducto == 0)
            {
                nuevo = true;
            }
            CargarTipos();
            if (!nuevo)
            {
                CargarDatos();
            }
        }

        private void CargarDatos() {
            if (producto != null)
            {
                txtNombre.Text = producto.nombre;
                txtDescripcion.Text=producto.descripcion;
                txtPrecio.Text = producto.precio.ToString();
                cmbTipo.Text = producto.tipoProducto;
                cmbSubtipo.Text = producto.subtipo;
                cmbMarcas.Text = producto.marca;
                cmbTamaños.Text = producto.tamano;
                cmbMateriales.Text = producto.material;
                numStock.Value= producto.stock;
                if (producto.activo)
                {
                    chkEnVenta.Checked= true;
                }
                else
                {
                    chkEnVenta.Checked= false;
                }
            }

        }

        public async void CargarTipos()
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
            cmbSubtipo.Enabled = true;
            string tipo = cmbTipo.SelectedItem.ToString();
           
            List<string> subtipos = await Herramientas.GetSubtiposProductoAsync(tipo);
            foreach (string subtipo in subtipos)
            {
                cmbSubtipo.Items.Add(subtipo);
            }
        }

        public async void CargarMarcas()
        {

            if (cmbTipo.SelectedItem == null || cmbTipo.SelectedItem == " ")
            {
                return;
            }
            cmbMarcas.Enabled = true;
            string tipo = cmbTipo.SelectedItem.ToString();
           
            List<string> marcas = await Herramientas.GetMarcasProductoAsync(tipo);
            foreach (string marca in marcas)
            {
                cmbMarcas.Items.Add(marca);
            }
        }

        
      

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            double precio = 0;
            producto.nombre = txtNombre.Text;
            producto.stock = (int)numStock.Value;
            Double.TryParse(txtPrecio.Text, out precio);
            producto.precio = precio;
            producto.tipoProducto = cmbTipo.Text;
            if (cmbMateriales.Text != null && cmbMateriales.Text != "Material")
                producto.material = cmbMateriales.Text;
            if (cmbTamaños.Text != null && cmbTamaños.Text != "Tamaño")
            {
                

                producto.tamano =cmbTamaños.Text;
            }
            if (cmbSubtipo.Text != null && cmbSubtipo.Text != "Subtipos")
                producto.subtipo = cmbSubtipo.Text;
            if (cmbMarcas.Text != null && cmbMarcas.Text != "Marca")
                producto.marca = cmbMarcas.Text;
            if (nuevo)
            {
                await Herramientas.CreateProductoAsync(producto);
                MessageBox.Show("Producto creado con exito");
            }
            else
            {
                await Herramientas.UpdateProductoAsync(producto.idProducto,producto);
                MessageBox.Show("Producto modificado con exito");
            }
            
            this.DialogResult = DialogResult.OK;
        }

        private void numStock_ValueChanged(object sender, EventArgs e)
        {
            producto.stock = (int)numStock.Value;
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            double precio=producto.precio;
            Double.TryParse(txtPrecio.Text, out precio);
            producto.precio = precio;
        }

        private void chkEnVenta_CheckedChanged(object sender, EventArgs e)
        {
            if(chkEnVenta.Checked)
            {
                producto.activo = true;
            }
            else
            {
                producto.activo= false;
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            producto.descripcion = txtDescripcion.Text;
        }
        public Producto DevolverProducto() { return producto; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
