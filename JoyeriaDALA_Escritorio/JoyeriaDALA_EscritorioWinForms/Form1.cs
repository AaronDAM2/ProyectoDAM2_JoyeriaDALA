using DocumentFormat.OpenXml.Vml.Spreadsheet;
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
    public partial class Form1 : Form
    {
        private List<Notificacion> notificaciones;
        public Form1()
        {
            InitializeComponent();
            notificaciones = new List<Notificacion>();
           ;
        }

        private async Task<List<Notificacion>> ObtenerNotificaciones()
        {
            try
            {

                notificaciones = await Herramientas.GetNotificacionesAsync();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return notificaciones;
        }

        public async Task ActualizarLista()
        {
            if (lvwNotificacion.Items.Count > 0)
                lvwNotificacion.Items.Clear();
            List<Notificacion> lista=await ObtenerNotificaciones();
            if (lista == null || lista.Count == 0)
                return;
            lista=lista.OrderBy(o=>o.fechaFin).ToList();

            if (lista.Count > 0)
            {
                foreach (Notificacion g in lista)
                {
                    if (g != null)
                    {


                        string[] datos = new string[] { g.titulo, g.fechaInicio.ToShortDateString(), g.fechaFin.ToShortDateString(), g.tipo, g.descripción };

                        ListViewItem item = new ListViewItem(datos);
                       if(g.fechaFin<DateTime.Now.AddDays(15))
                            item.BackColor = Color.Green;
                       if(g.fechaFin < DateTime.Now.AddDays(7))
                            item.BackColor = Color.Yellow;
                       if(g.fechaFin < DateTime.Now.AddDays(4))
                            item.BackColor = Color.Red;

                        item.Tag = g.NotifId;
                       lvwNotificacion.Items.Add(item);

                    }


                }

            }
        }


        private async void Form1_Load(object sender, EventArgs e)
        {
           await Herramientas.ActualizarNotificaciones();
            await ActualizarLista();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            if (LimpiarFormularios())
            {
                MdiParentFrm frm = new MdiParentFrm();
                frm.ShowDialog();
                InventarioFrm form = new InventarioFrm();
                form.MdiParent = frm;
                form.Dock = DockStyle.Fill;
                form.Anchor = AnchorStyles.Top;
                frm.Show();
                this.Close();
                form.Show();
                
            }

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            if (LimpiarFormularios())
            {
                MdiParentFrm frm = new MdiParentFrm();
                frm.ShowDialog();
                VentasFrm form = new VentasFrm();
                form.MdiParent = frm;
                form.Dock = DockStyle.Fill;
                form.Anchor = AnchorStyles.Top;
                frm.Show();
                form.Show();
                this.Close();
            }
        }

        private void btnEncargo_Click(object sender, EventArgs e)
        {
            if (this.LimpiarFormularios())
            {
                MdiParentFrm frm = new MdiParentFrm();
                frm.ShowDialog();
                EncargosFrm form = new EncargosFrm();
                form.MdiParent = frm;
                form.Dock = DockStyle.Fill;
                form.Anchor = AnchorStyles.Top;
                frm.Show();
                form.Show();
                this.Close();
            }
        }

        private void btnGrabados_Click(object sender, EventArgs e)
        {
            if (this.LimpiarFormularios())
            {
                MdiParentFrm frm = new MdiParentFrm();
                frm.ShowDialog();
                GrabadosFrm form = new GrabadosFrm();
                form.MdiParent = frm;
                form.Dock = DockStyle.Fill;
                form.Anchor = AnchorStyles.Top;
                frm.Show();
                form.Show();
                this.Close();
            }
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            if (LimpiarFormularios())
            {
                MdiParentFrm frm = new MdiParentFrm();
                frm.ShowDialog();
                FacturasFrm form = new FacturasFrm();
                form.MdiParent = frm;
                form.Dock = DockStyle.Fill;
                form.Anchor = AnchorStyles.Top;
                frm.Show();
                form.Show();
                this.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (this.LimpiarFormularios())
            {
                this.Close();
                

            }
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            AjustesAppFrm frm = new AjustesAppFrm();
            frm.ShowDialog();
        }

        private async void irANotificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvwNotificacion.SelectedItems.Count == 1)
            {
                Notificacion n = new Notificacion();
                n = await Herramientas.GetNotificacionAsync((int)lvwNotificacion.SelectedItems[0].Tag);
                if (n != null)
                {
                    NotificacionFrm notif = new NotificacionFrm(n);
                    notif.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Selecciona una notificación");
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
                    if (frm.GetType() == typeof(DetallesEncargoFrm) || frm.GetType() == typeof(DetallesGrabadoFrm) || frm.GetType() == typeof(DetallesVentaFrm) || frm.GetType() == typeof(DetallesProductoFrm) || frm.GetType() == typeof(DetallesFacturaFrm))
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

        private async void actualizarNotificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await Herramientas.ActualizarNotificaciones();
            await ActualizarLista();
        }

        private void crearNotificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notificacion n=new Notificacion();
            NotificacionFrm notif = new NotificacionFrm(n);
            notif.ShowDialog();
        }

        private async void verNotificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvwNotificacion.SelectedItems.Count == 1)
            {
                Notificacion n=new Notificacion();
                n = await Herramientas.GetNotificacionAsync((int)lvwNotificacion.SelectedItems[0].Tag);
                if (n != null)
                {
                    NotificacionFrm notif = new NotificacionFrm(n);
                    notif.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Selecciona una notificación");
            }
        }

        private async void borrarNotificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvwNotificacion.SelectedItems.Count == 1)
            {
                bool res = false;
                 res= await Herramientas.DeleteNotificacionAsync((int)lvwNotificacion.SelectedItems[0].Tag);
               if(res)
                {
                    MessageBox.Show("Notificación borrada");
                }
                else
                {
                    MessageBox.Show("Error al borrar notificación");
                }
            }
            else
            {
                MessageBox.Show("Selecciona una notificación");
            }
        }
    }
}
