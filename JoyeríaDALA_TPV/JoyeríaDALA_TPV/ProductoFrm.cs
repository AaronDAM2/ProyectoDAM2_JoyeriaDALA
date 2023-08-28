using JoyeríaDALA_TPV.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoyeríaDALA_TPV
{
    public partial class ProductoFrm : Form
    {
        private Producto producto;
        private double precio;
        public ProductoFrm(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
            this.precio = producto.precio;
            CargarTipos();
            

        }
        private void btnNumero_Click(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            txtCalcular.Text += b.Tag;
        }

        private double CalcularOperacion()
        {
            if (txtCalcular.Text != "" && txtCalcular.Text.Contains("+") || txtCalcular.Text.Contains("-") || txtCalcular.Text.Contains("/") || txtCalcular.Text.Contains("*"))
            {



                // Obtenemos el contenido del TextBox y lo separamos en un array de cadenas
                string[] elementos = txtCalcular.Text.Split(new[] { "+", "-", "*", "/" }, StringSplitOptions.RemoveEmptyEntries);

                // Creamos una lista para almacenar los valores numéricos
                List<double> numeros = new List<double>();

                // Recorremos el array de elementos y convertimos los valores numéricos en doubles
                foreach (string elemento in elementos)
                {
                    if (double.TryParse(elemento.Replace(",", "."), NumberStyles.Number, CultureInfo.InvariantCulture, out double numero))
                    {
                        numeros.Add(numero);
                    }
                }

                // Creamos una variable para almacenar el resultado
                double resultado = numeros[0];

                // Recorremos el TextBox y realizamos las operaciones matemáticas
                for (int i = 0; i < txtCalcular.Text.Length; i++)
                {
                    char caracter = txtCalcular.Text[i];

                    switch (caracter)
                    {
                        case '+':
                            resultado += numeros[i];
                            break;
                        case '-':
                            resultado -= numeros[i];
                            break;
                        case '*':
                            resultado *= numeros[i];
                            break;
                        case '/':
                            resultado /= numeros[i];
                            break;
                    }
                }

                // Devolvemos el resultado
                return resultado;
            }
            return 0;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtCalcular.Text != "")
            {


            }
            else
            {
                txtCalcular.Text = "0";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCalcular.Text = "0";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (txtCalcular.Text != "" && txtCalcular.Text.Length > 0)
            {
                double precioNuevo = CalcularOperacion();
                this.precio = precioNuevo;
                txtCalcular.Text = precioNuevo.ToString();
            }
            else
            {
                txtCalcular.Text = "0";
            }

        }
        public Producto GetProducto() { return producto; }

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
            cmbMarcas.Enabled = true;
            string tipo = cmbTipo.SelectedItem.ToString();
            
            List<string> marcas = await Herramientas.GetMarcasProductoAsync(tipo);
            foreach (string marca in marcas)
            {
                cmbMarcas.Items.Add(marca);
            }
        }


        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    CargarSubtipos();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActivo.Checked)
            {
                producto.activo = true;
            }
            else
            {
                producto.activo = false;
            }
        }

        private void chkNombre_CheckedChanged(object sender, EventArgs e)
        {
            if(chkNombre.Checked)
            {
                string nombre= Herramientas.NombreProducto(producto);
                txtNombre.Text = nombre;
                producto.nombre = nombre;
            }
            else
            {
                txtNombre.Text = "";
            }
        }

        private async void btnNuevoEncargo_Click(object sender, EventArgs e)
        {
            precio = CalcularOperacion();
          //  double.TryParse(txtCalcular.Text, out precio);
            producto.nombre=txtNombre.Text;
            producto.stock = (int)numStock.Value;
            producto.precio=precio;
            producto.tipoProducto = cmbTipo.Text;
            if (cmbMateriales.Text != null && cmbMateriales.Text != "Material")
                producto.material = cmbMateriales.Text;
            if (cmbTamaños.Text != null && cmbTamaños.Text != "Tamaño")
                producto.tamano = cmbTamaños.Text;
            if (cmbSubTipos.Text!=null&&cmbSubTipos.Text!="Subtipos")
                producto.subtipo=cmbSubTipos.Text;
            if (cmbMarcas.Text!=null&&cmbMarcas.Text!="Marca")
                producto.marca=cmbMarcas.Text;

            await Herramientas.CreateProductoAsync(producto);
            MessageBox.Show("Producto creado con exito");
            this.DialogResult = DialogResult.OK;
            
        }

        public Producto DevolverProducto()
        {
            return producto;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; this.Close();
        }
    }
}
