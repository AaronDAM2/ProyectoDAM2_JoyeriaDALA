using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoyeríaDALA_TPV
{
    public partial class ContadorFrm : Form
    {
        private int contador;
        private double precio;
        public ContadorFrm()
        {
            InitializeComponent();
        }
        public ContadorFrm(int contador)
        {
            InitializeComponent();
            numContador.DecimalPlaces = 0;
            this.contador = contador;
            numContador.Value = contador;
            
        }

        public ContadorFrm(double precio) {
            InitializeComponent();
            numContador.DecimalPlaces = 2;
            this.precio = precio;
            numContador.Value = (decimal)precio;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            contador = (int)numContador.Value;
            this.DialogResult = DialogResult.OK;
        }

        public int DevolverContador() { return contador; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
