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
                nuevo = true;
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

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (nuevo)
            {
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
