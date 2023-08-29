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
    public partial class DetallesGrabado : Form
    {
        private Grabado grabado=new Grabado();
        private Venta venta=new Venta();
        private Producto producto=new Producto();
        private double precio;
        public DetallesGrabado(Grabado grabado)
        {
            InitializeComponent();
            this.grabado=grabado;
            venta=grabado.venta;
            precio = venta.precio;

            
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

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            DetallesVentaFrm detalles = new DetallesVentaFrm(venta.observaciones);
            if (detalles.ShowDialog() == DialogResult.OK)
                venta.observaciones = detalles.DevolverDetalles();
        }

        private void btnAddProducto_Click(object sender, EventArgs e)
        {
            
            BuscarProductos buscador=new BuscarProductos();
            if(buscador.ShowDialog() == DialogResult.OK)
            {
                producto=buscador.DevolverProducto();
                precio += producto.precio;
                txtProducto.Text = producto.nombre;
                
            }
        }

        private void dtpFin_ValueChanged(object sender, EventArgs e)
        {
           /* DateTime fechaFin=dtpFin.Value;
            if(fechaFin < DateTime.UtcNow)
            {
                MessageBox.Show("La fecha de fin que estás estableciendo ya ha pasado");
            }*/

            grabado.FechaFin=dtpFin.Value;
        }

        private async void btnNuevoEncargo_Click(object sender, EventArgs e)
        {
            if (txtCalcular.Text != "" & txtCalcular.Text != "0" && txtProducto.Text != null)
            {
                if (double.TryParse(txtCalcular.Text, out double precioFinal))
                {
                    precio = precioFinal;
                    if (txtProducto.Text!=null&&txtProducto.Text.Length!=0&&producto != null)
                        grabado.productoidProducto = producto.idProducto;
                    venta.FechaVenta = dtpInicio.Value;
                    grabado.FechaInicio = dtpInicio.Value;
                    grabado.FechaFin = dtpFin.Value;
                    venta.precio = precio;
                    grabado.precio = precio;
                    grabado.venta = venta;

                    await Herramientas.CreateGrabadoAsync(grabado);
                    await Herramientas.CreateVentaAsync (venta);

                    this.DialogResult = DialogResult.OK;
                    


                }
            }
            else
            {
                MessageBox.Show("Selecciona todos los datos para guardar el encargo");
            }
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            grabado.FechaInicio = dtpInicio.Value;
        }

        public Grabado devolverGrabado() { return grabado; }
    }
}
