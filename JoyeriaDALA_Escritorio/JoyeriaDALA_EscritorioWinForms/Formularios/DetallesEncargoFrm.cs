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
    public partial class DetallesEncargoFrm : Form
    {
        private Encargo encargo = new Encargo();
        private Venta venta = new Venta();
        private Producto producto = new Producto();
        private bool nuevo = false;
        public DetallesEncargoFrm(Encargo encargo)
        {
            InitializeComponent();
            this.encargo = encargo;
            venta = encargo.venta;
            if (encargo.IdEncargo == 0)
                nuevo = true;
        }

        private void label1_Click(object sender, EventArgs e)
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
                encargo.precio = precio;
                encargo.FechaInicio = dtpInicio.Value;
                encargo.FechaFin = dtpFin.Value;
                encargo.descripcion = txtDescripcion.Text;
                encargo.cliente = txtCliente.Text;
                venta.FechaVenta = encargo.FechaInicio;
                venta.precio = encargo.precio;
                venta.esEncargo = true;
                venta.codVenta = await Herramientas.CrearCodVenta(venta);
                encargo.venta = venta;
                await Herramientas.CreateEncargoAsync(encargo);

            }
            else
            {
                Double.TryParse(txtPrecio.Text, out double precio);
                encargo.precio = precio;
                encargo.FechaFin = dtpFin.Value;
                encargo.descripcion = txtDescripcion.Text;
                encargo.cliente = txtCliente.Text;
                venta.FechaVenta = encargo.FechaInicio;
                venta.precio = encargo.precio;
                venta.esEncargo = true;
                venta.codVenta = await Herramientas.CrearCodVenta(venta);
                encargo.venta = venta;
                await Herramientas.UpdateEncargoAsync(encargo.IdEncargo, encargo);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public Encargo DevolverEncargo() { return encargo; }
    }
}
