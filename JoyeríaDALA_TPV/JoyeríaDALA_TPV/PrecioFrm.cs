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
    public partial class PrecioFrm : Form
    {
        private Producto producto;
        private double precio;
        private double precioOriginal;
        public PrecioFrm(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
            precio = producto.precio;
            txtPrecioOriginal.Text = precio.ToString();
            precioOriginal = precio;
        }

        public double DevolverPrecio()
        {
            return precio;
        }

        private async void ActualizarProducto()
        {

            double.TryParse(txtCalcular.Text, out precio);
            if (precio != precioOriginal)
            {
                try
                {
                    producto.precio = precio;

                    await Herramientas.UpdateProductoAsync(producto.idProducto, producto);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

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

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (producto == null)
            {
                MessageBox.Show("Error de producto");
                return;

            }

            ActualizarProducto();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.Cancel;
            this.Close();
        }
    }
}
