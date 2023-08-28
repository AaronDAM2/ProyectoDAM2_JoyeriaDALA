using JoyeriaDALA_EscritorioWinForms.Formularios;
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

namespace JoyeriaDALA_EscritorioWinForms
{
    public partial class MdiParentFrm : Form
    {
        public MdiParentFrm()
        {
            InitializeComponent();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.LimpiarFormularios())
            {

                Form1 inicio = new Form1();
                
                inicio.Show();
                this.Close();
            }
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.LimpiarFormularios())
            {

                InventarioFrm inventario = new InventarioFrm();
                inventario.MdiParent = this;
                inventario.Dock = DockStyle.Fill;
                inventario.Anchor = AnchorStyles.Top;
                inventario.Show();
            }
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.LimpiarFormularios())
            {

                VentasFrm form = new VentasFrm();
                form.MdiParent = this;
                form.Dock = DockStyle.Fill;
                form.Anchor = AnchorStyles.Top;
                form.Show();
            }
        }

        private void encargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.LimpiarFormularios())
            {

                EncargosFrm form = new EncargosFrm();
                form.MdiParent = this;
                form.Dock = DockStyle.Fill;
                form.Anchor = AnchorStyles.Top;
                form.Show();
            }
        }

        private void grabadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.LimpiarFormularios())
            {

                GrabadosFrm form = new GrabadosFrm();
                form.MdiParent = this;
                form.Dock = DockStyle.Fill;
                form.Anchor = AnchorStyles.Top;
                form.Show();
            }
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.LimpiarFormularios())
            {

                FacturasFrm form = new FacturasFrm();
                form.MdiParent = this;
                form.Dock = DockStyle.Fill;
                form.Anchor = AnchorStyles.Top;
                form.Show();
            }
        }

        private bool LimpiarFormularios()
        {
            bool abrir = true;
            foreach (Form frm in this.MdiChildren)
            {
                DialogResult cerrar = DialogResult.Yes;
                if (frm != this)
                {
                    if (frm.GetType() == typeof(DetallesEncargoFrm)|| frm.GetType() == typeof(DetallesGrabadoFrm)|| frm.GetType() == typeof(DetallesVentaFrm)|| frm.GetType() == typeof(DetallesProductoFrm)|| frm.GetType() == typeof(DetallesFacturaFrm))
                    {
                        cerrar = MessageBox.Show("¿Seguro que quieres cerrar la pestaña? Se perderán los cambios no guardados", "Cerrar Formulario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                    if (cerrar == DialogResult.Yes)
                    {
                        frm.Dispose();
                        frm.Close();
                    }
                    else
                    {
                        abrir = false;
                        return abrir;
                    }

                }
            }
            return abrir;
        }
    }
}
