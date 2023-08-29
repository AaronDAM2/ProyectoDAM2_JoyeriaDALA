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
    public partial class NotificacionFrm : Form
    {
        private Notificacion notif;
        private Grabado grabado;
        private Encargo encargo;
        private bool nuevo = false;
        
        public NotificacionFrm(Notificacion notif)
        {
            InitializeComponent();
            this.notif = notif;
            if(notif != null&&notif.NotifId!=0)
            {
                nuevo = false;
                txtTitulo.Text = notif.titulo;
                txtTitulo.Enabled = false;
                txtDescripcion.Text = notif.descripción;
                dtpInicio.Value = notif.fechaInicio;
                dtpInicio.Enabled = false;
                dtpFin.Value = notif.fechaFin;
                switch (notif.tipo)
                {
                    case "Grabado":
                        grabado = Herramientas.GetGrabadoAsync(notif.IdAsociado).Result;
                        cmbTipo.Text=notif.tipo;
                        btnIr.Enabled = true;
                        btnIr.Visible = true;
                        break;
                    case "Encargo":
                        encargo= Herramientas.GetEncargoAsync(notif.IdAsociado).Result;
                       
                        btnIr.Enabled = true;
                        btnIr.Visible = true;
                        break;
                    default:
                        cmbTipo.Text = notif.tipo;
                        btnIr.Enabled = false;
                        btnIr.Visible= false;
                        
                        break;

                }

            }
            else
            {
                nuevo = true;
                notif.tipo = "Notificacion";
                cmbTipo .Text = notif.tipo;
                dtpInicio.Enabled = true;
                dtpFin.Enabled = true;
                txtTitulo.Enabled = true;

            }
        }

        private async void btnIr_Click(object sender, EventArgs e)
        {
            if (grabado != null)
            {
                DetallesGrabadoFrm formGrabado=new DetallesGrabadoFrm(grabado);
                if (formGrabado.ShowDialog()==DialogResult.OK)
                {
                    grabado=formGrabado.DevolverGrabado();
                    formGrabado.Close();
                    notif.fechaFin = grabado.FechaFin.Value;
                    notif.descripción = grabado.contenido;
                    await Herramientas.UpdateNotificacionAsync(notif.NotifId, notif);
                    this.DialogResult= DialogResult.OK;
                    this.Close();
                }
            }else if (encargo != null)
            {
                DetallesEncargoFrm formEnc=new DetallesEncargoFrm(encargo);
                if (formEnc.ShowDialog() == DialogResult.OK)
                {
                    encargo=formEnc.DevolverEncargo();
                    formEnc.Close();
                    notif.fechaFin = encargo.FechaFin.Value;
                    notif.descripción = encargo.descripcion;
                    await Herramientas.UpdateNotificacionAsync(notif.NotifId, notif);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No hay ningún encargo o grabado asignado a esta notificación");
            }
        }

        private bool ComprobarFormulario()
        {
            if(txtTitulo==null||txtTitulo.Text.Length==0) return false;
            if(txtDescripcion==null||txtDescripcion.Text.Length==0) return false;
            if(dtpInicio.Value==null||dtpInicio.Value>dtpFin.Value||dtpFin.Value<DateTime.Now) return false;
            return true;
        }
        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!ComprobarFormulario())
            {
                MessageBox.Show("Introduce todos los datos para continuar");
            }
           notif.titulo=txtTitulo.Text;
            notif.descripción = txtTitulo.Text;
            notif.fechaInicio = dtpInicio.Value;
            notif.fechaFin= dtpFin.Value;
            if (grabado != null)
            {
                notif.tipo = "Grabado";
                notif.IdAsociado = grabado.IdGrabado;
            }else if (encargo != null)
            {
                notif.tipo = "Encargo";
                notif.IdAsociado=encargo.IdEncargo;
            }
            else
            {
                notif.tipo = "Notificacion";
            }

            if (nuevo)
            {
                await Herramientas.CreateNotificacionAsync(notif);
            }
            else
            {
                await Herramientas.UpdateNotificacionAsync(notif.NotifId, notif);
            }
            this.DialogResult= DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
