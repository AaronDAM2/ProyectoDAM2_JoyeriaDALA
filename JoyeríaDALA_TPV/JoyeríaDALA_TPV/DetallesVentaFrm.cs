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
    public partial class DetallesVentaFrm : Form
    {
        string detalles;

        public DetallesVentaFrm(string detalles)
        {
            InitializeComponent();
            this.detalles = detalles;
            txtDetalles.Text = detalles;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
                    }

        private void button2_Click_1(object sender, EventArgs e)
        {
            detalles=txtDetalles.Text;
            this.DialogResult= DialogResult.OK;
            this.Close();
        }

        public string DevolverDetalles()
        {
            return detalles;
        }

      
    }
}
