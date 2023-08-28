using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoyeríaDALA_TPV.Reports
{
    public partial class VisorRecibo : Form
    {
        public VisorRecibo()
        {
            InitializeComponent();
        }

        private void VisorRecibo_Load(object sender, EventArgs e)
        {

            this.rpvRecibo.RefreshReport();
        }
    }
}
