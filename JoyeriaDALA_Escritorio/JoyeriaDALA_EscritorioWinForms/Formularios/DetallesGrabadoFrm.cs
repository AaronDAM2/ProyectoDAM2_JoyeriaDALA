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
    public partial class DetallesGrabadoFrm : Form
    {
        private Grabado grabado = new Grabado();
        private Venta venta = new Venta();
        private Producto producto = new Producto();
        private bool nuevo = false;

        public DetallesGrabadoFrm(Grabado grabado)
        {
            InitializeComponent();
            this.grabado = grabado;
            venta = grabado.venta;
            if (grabado.IdGrabado == 0)
            {
                nuevo = true;
                venta = new Venta();
            }
                
        }

        private void DetallesGrabadoFrm_Load(object sender, EventArgs e)
        {

        }

      

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            BuscadorProductosFrm buscador = new BuscadorProductosFrm();
            if (buscador.ShowDialog() == DialogResult.OK)
            {
                producto = buscador.DevolverProducto();
              
                txtProducto.Text = producto.nombre;

            }
        }

        private bool ComprobarFormulario()
        {
            if(txtCliente.Text==null||txtCliente.Text.Length== 0) return false;
            if(txtDescripcion.Text==null||txtDescripcion.Text.Length== 0) return false; 
            if(dtpInicio.Value>dtpFin.Value) return false;
            if(dtpFin.Value<dtpFin.Value) return false;
            if(dtpFin.Value<DateTime.Now) return false;
            if(txtPrecio.Text==null||txtPrecio.Text.Length== 0)return false;

            return true;

        }
        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!ComprobarFormulario())
            {
                MessageBox.Show("El grabado debe tener cliente, contenido y precio. La fecha de inicio debe ser anterior a la de finalización si esta existe, y esta última debe ser posterior a la actual.");
                return;
            }

            if (nuevo)
            {
                venta = new Venta();
                Double.TryParse(txtPrecio.Text, out double precio);
                grabado.precio = precio;
                grabado.FechaInicio=dtpInicio.Value;
                grabado.FechaFin=dtpFin.Value;
                grabado.contenido=txtDescripcion.Text;
                grabado.nombreCliente=txtCliente.Text;
                venta.precio = precio;
                venta.FechaVenta = grabado.FechaInicio;
                venta.esGrabado = true;
                venta.codVenta = await Herramientas.CrearCodVenta(venta);
                grabado.venta= venta;

                await Herramientas.CreateGrabadoAsync(grabado);
                
            }
            else
            {
                Double.TryParse(txtPrecio.Text, out double precio);
                grabado.precio = precio;
                grabado.FechaFin = dtpFin.Value;
                grabado.contenido = txtDescripcion.Text;
                grabado.nombreCliente = txtCliente.Text;
                venta.precio = precio;
                venta.FechaVenta = grabado.FechaInicio;
                venta.esGrabado = true;
                venta.codVenta = await Herramientas.CrearCodVenta(venta);
                grabado.venta = venta;

                await Herramientas.UpdateGrabadoAsync(grabado.IdGrabado, grabado);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.Cancel;
        }

        public Grabado DevolverGrabado() { return grabado; }
    }
}
