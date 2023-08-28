using JoyeríaDALA_TPV.Modelo;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Anchor= AnchorStyles.Top;
            this.Dock= DockStyle.Fill;
            InicializarApp();  
        }

        private void InicializarApp()
        {
            VentasFrm ventas = new VentasFrm(new Venta());
            ventas.MdiParent = this;
            ventas.Dock = DockStyle.Fill;
            ventas.Anchor = AnchorStyles.Top;
            ventas.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {

            if (this.LimpiarFormularios())
            {
                VentasFrm ventas = new VentasFrm(new Venta());
                ventas.MdiParent = this;
                ventas.Dock = DockStyle.Fill;
                ventas.Anchor = AnchorStyles.Top;
                ventas.Show();
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
                    if (frm.GetType() == typeof(VentasFrm))
                    {
                        cerrar=MessageBox.Show("¿Seguro que quieres cerrar la pestaña de venta? Se perderán los datos no guardados", "Borrar Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void btnInventario_Click(object sender, EventArgs e)
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

        private void btnNuevoEncargo_Click(object sender, EventArgs e)
        {
            if (this.LimpiarFormularios())
            {

                DetallesEncargoFrm form = new DetallesEncargoFrm(new Encargo());
                form.MdiParent = this;
                form.Dock = DockStyle.Fill;
                form.Anchor = AnchorStyles.Top;
                form.Show();
            }
        }

        private void btnNuevoGrabado_Click(object sender, EventArgs e)
        {
            if (this.LimpiarFormularios())
            {

                DetallesGrabado form = new DetallesGrabado(new Grabado());
                form.MdiParent = this;
                form.Dock = DockStyle.Fill;
                form.Anchor = AnchorStyles.Top;
                form.Show();
            }
        }

        private void btnEncargos_Click(object sender, EventArgs e)
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

        private void btnGrabados_Click(object sender, EventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                InicializarApp();
            }
        }
    }
}
