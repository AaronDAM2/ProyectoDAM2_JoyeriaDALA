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
    public partial class ContadorFrm : Form
    {
        private int contador;
        public ContadorFrm()
        {
            InitializeComponent();
        }
        public ContadorFrm(int contador)
        {
            InitializeComponent();
            this.contador = contador;
            numContador.Value = contador; 
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            contador = (int)numContador.Value;
            this.DialogResult = DialogResult.OK;
        }

        public int DevolverContador() { return  contador; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.Cancel;
        }
    }
}
