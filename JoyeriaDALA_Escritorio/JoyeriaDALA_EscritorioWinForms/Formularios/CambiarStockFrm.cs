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
    public partial class CambiarStockFrm : Form
    {
        private Producto producto;
        public CambiarStockFrm(Producto p)
        {
            InitializeComponent();
            this.producto = p;
            numStock.Value = p.stock;
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (numStock.Value > 0)
            {
                producto.stock = (int)numStock.Value;
                await Herramientas.UpdateProductoAsync(producto.idProducto, producto);
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("El stock no puede ser negativo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
