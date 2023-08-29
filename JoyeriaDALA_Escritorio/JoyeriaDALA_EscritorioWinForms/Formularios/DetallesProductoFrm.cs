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

        private bool ComprobarFormulario()
        {
            if(txtPrecio.Text==null||txtPrecio.Text.Length==0) return false;
            if(cmbTipo.Text==null||cmbTipo.Text.Length==0) return false;
            if(txtNombre.Text==null||txtNombre.Text.Length==0) return false;

            return true;
        }
      

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!ComprobarFormulario())
            {
                MessageBox.Show("Debes introducir al menos un nombre, un precio, un stock y un tipo para crear un producto");
                return;
            }
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

        private async void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarSubtipos();
            CargarMarcas();
        }

        private async void DetallesProductoFrm_Load(object sender, EventArgs e)
        {
             CargarTipos();
            await CargarMateriales();
            await CargarTamanos();
        }

        private void btnGenerarNombre_Click(object sender, EventArgs e)
        {
            string tipo=cmbTipo.Text;
            string subtipo=null, marca=null, material=null, tamano=null;
            if (cmbSubtipo.Text.Length != 0) {
                   subtipo=cmbSubtipo.Text;
                    }
            if(cmbMateriales.Text.Length != 0)
            {
                material=cmbMateriales.Text;
            }

            if(cmbMarcas.Text.Length != 0)
            {
                marca=cmbMarcas.Text;
            }
            if(cmbTamaños.Text.Length != 0){
                tamano = cmbTamaños.Text;
            }
            Producto p=new Producto(); p.tipoProducto = tipo; p.subtipo=subtipo; p.marca=marca; p.material=material; p.tamano=tamano;
            string nombre = Herramientas.NombreProducto(p);
            producto.nombre=nombre;
            txtNombre.Text=nombre;
        }
    }
}
