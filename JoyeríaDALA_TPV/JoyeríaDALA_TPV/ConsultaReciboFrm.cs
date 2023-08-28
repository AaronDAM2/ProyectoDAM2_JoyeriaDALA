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
    public partial class ConsultaReciboFrm : Form
    {
        string accion = null;
        public ConsultaReciboFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            accion = "Factura";
            this.DialogResult = DialogResult.OK;
        }

        private void btnRecibo_Click(object sender, EventArgs e)
        {
            accion = "Recibo";
            this.DialogResult = DialogResult.OK;
        }

        private void btnAmbos_Click(object sender, EventArgs e)
        {
            accion = "Ambos";
            this.DialogResult = DialogResult.OK;
        }

        public string DevolverAccion() { return  accion; }
    }
}
