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
    public partial class GrabadosFrm : Form
    {
        private string filtro = null;
        private List<Grabado> grabados;
        private List<Grabado> grabadosFiltrados;
        public GrabadosFrm()
        {
            InitializeComponent();
            grabados=new List<Grabado>();
            grabadosFiltrados=new List<Grabado>();
          
        }

        private async Task<List<Grabado>> ObtenerGrabados()
        {
            try
            {

                grabados = await Herramientas.GetGrabadosAsync();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return grabados;
        }

        private async Task ActualizarListaAsync()
        {
            if (lvwGrabados.Items.Count > 0)

                lvwGrabados.Items.Clear();

            List<Grabado> lista = await Herramientas.GetGrabadosAsync();

            if (lista != null && lista.Count != 0)
            {
                foreach (Grabado g in lista)
                {
                    if (g != null)
                    {
                        string prod = "Indefinido";
                        if (g.productoidProducto != 0 && g.productoidProducto != null) {
                            {
                                Producto p = await Herramientas.GetProductoAsync(g.productoidProducto.Value);
                                if (p != null)
                                {
                                    prod = p.nombre;
                                }
                            }
                            string[] datos = new string[] { g.nombreCliente, g.FechaInicio.ToString(), g.FechaFin.ToString(), g.precio.ToString(), g.terminado.ToString(), prod };

                            ListViewItem item = new ListViewItem(datos);
                            if (!g.terminado)
                                item.BackColor = Color.Yellow;
                            if(!g.terminado && g.FechaFin.Value<DateTime.UtcNow)
                                item.BackColor = Color.Red;
                            item.Tag = g.IdGrabado;
                            if (filtro == null)
                            {
                                lvwGrabados.Items.Add(item);
                            }
                            else
                            if (datos.Contains<String>(filtro))
                                lvwGrabados.Items.Add(item);

                        }

                    }
                }

            }
        }

        private async void AplicarFiltro()
        {
            string nombre = txtCalcular.Text;
            DateTime? fechaInicio = null;
            DateTime? fechaFin = null;

            if (dtpInicio.Checked)
            {
                fechaInicio = dtpInicio.Value;
            }

            if (dtpFin.Checked)
            {
                fechaFin = dtpFin.Value;
            }

            // Obtener los objetos Grabado que cumplen con el filtro
            List<Grabado> grabadosFiltrados = ObtenerGrabadosFiltrados(nombre, fechaInicio, fechaFin);

            // Limpiar la lista actual de ListViewItem
            lvwGrabados.Items.Clear();

            // Agregar los objetos Grabado filtrados a la ListView
            foreach (Grabado g in grabadosFiltrados)
            {
                string prod = "Indefinido";
                if (g.productoidProducto != 0 && g.productoidProducto != null)
                {
                    {
                        Producto p = await Herramientas.GetProductoAsync(g.productoidProducto.Value);
                        if (p != null)
                        {
                            prod = p.nombre;
                        }
                    }
                    string[] datos = new string[] { g.nombreCliente, g.FechaInicio.ToString(), g.FechaFin.ToString(), g.precio.ToString(), g.terminado.ToString(), prod };

                    ListViewItem item = new ListViewItem(datos);
                    lvwGrabados.Items.Add(item);
                }
            }
        }

        private List<Grabado> ObtenerGrabadosFiltrados(string nombre, DateTime? fechaInicio, DateTime? fechaFin)
        {
            // Obtener todos los objetos Grabado (o desde tu origen de datos)
            List<Grabado> todosLosGrabados = ObtenerGrabados().Result;

            // Aplicar el filtro en base a los valores proporcionados
            List<Grabado> grabadosFiltrados = todosLosGrabados;

            if (!string.IsNullOrWhiteSpace(nombre))
            {
                grabadosFiltrados = grabadosFiltrados.Where(g => g.nombreCliente.Contains(nombre)).ToList();
            }

            if (fechaInicio.HasValue)
            {
                grabadosFiltrados = grabadosFiltrados.Where(g => g.FechaInicio >= fechaInicio).ToList();
            }

            if (fechaFin.HasValue)
            {
                grabadosFiltrados = grabadosFiltrados.Where(g => g.FechaFin <= fechaFin).ToList();
            }

            return grabadosFiltrados;
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            DetallesGrabado form=new DetallesGrabado(new Grabado());
            if(form.ShowDialog() == DialogResult.OK)
            {
                Grabado g = form.devolverGrabado();
                grabados.Add(g);
                form.Close();
                ActualizarListaAsync();
            }
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private async void btnEditarContenido_Click(object sender, EventArgs e)
        {
            if(lvwGrabados.SelectedItems.Count > 0) {

                Grabado grabado = await Herramientas.GetGrabadoAsync((int)lvwGrabados.SelectedItems[0].Tag);
                if(grabado != null)
                {
                    DetallesVentaFrm form = new DetallesVentaFrm(grabado.contenido);
                    if(form.ShowDialog() == DialogResult.OK)
                    {
                        grabado.contenido = form.DevolverDetalles();
                        await Herramientas.UpdateGrabadoAsync(grabado.IdGrabado, grabado);
                        form.Close();
                    }

                }
            }
        }

        private async void btnTerminarGrabado_Click(object sender, EventArgs e)
        {
            if (lvwGrabados.SelectedItems.Count > 0)
            {

                Grabado grabado = await Herramientas.GetGrabadoAsync((int)lvwGrabados.SelectedItems[0].Tag);
                if (grabado != null)
                {
                    if (!grabado.terminado)
                    {
                        grabado.terminado = true;
                        await Herramientas.UpdateGrabadoAsync(grabado.IdGrabado, grabado);
                        MessageBox.Show("Grabado actualizado");
                    }
                    else
                    {
                        if(MessageBox.Show("Este grabado ya está terminado. ¿Deseas reanudarlo?","Grabado Terminado", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            grabado.terminado = false;
                            await Herramientas.UpdateGrabadoAsync(grabado.IdGrabado, grabado);
                            MessageBox.Show("Grabado actualizado");
                        }
                    }
                }
            }

                }

        private async void btnFacturas_Click(object sender, EventArgs e)
        {
            if (lvwGrabados.SelectedItems.Count == 1)
            {
                Grabado g = await Herramientas.GetGrabadoAsync((int)lvwGrabados.SelectedItems[0].Tag);
                if (g != null)
                {
                    Factura f = new Factura();
                    FacturasManager manager = new FacturasManager();
                    ItemFactura item = manager.CrearItemFactura(g);
                    f.Items.Add(item);
                    CrearFacturaFrm crear = new CrearFacturaFrm(f);
                    crear.ShowDialog();
                }
            }
        }

        private async void GrabadosFrm_Load(object sender, EventArgs e)
        {
            await ObtenerGrabados();
            await ActualizarListaAsync();
        }
    }
}
