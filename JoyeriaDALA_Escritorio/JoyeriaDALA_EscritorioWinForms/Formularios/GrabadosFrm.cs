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
    public partial class GrabadosFrm : Form
    {
        private string filtro = null;
        private List<Grabado> grabados;
        private List<Grabado> grabadosFiltrados;
        public GrabadosFrm()
        {
            InitializeComponent();
            grabados = new List<Grabado>();
            grabadosFiltrados = new List<Grabado>();
           
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

            if (lista.Count > 0)
            {
                foreach (Grabado g in lista)
                {
                    if (g != null)
                    {
                        string prod = "Indefinido";
                        if (g.productoidProducto != 0 && g.productoidProducto != null)
                        {
                            
                                Producto p = await Herramientas.GetProductoAsync(g.productoidProducto.Value);
                                if (p != null)
                                {
                                    prod = p.nombre;
                                }
                            
                        }
                            string[] datos = new string[] { g.nombreCliente, g.FechaInicio.ToString(), g.FechaFin.ToString(), g.precio.ToString(), g.terminado.ToString(), prod, g.contenido };

                            ListViewItem item = new ListViewItem(datos);
                            if (!g.terminado)
                                item.BackColor = Color.Yellow;
                            if (!g.terminado && g.FechaFin.Value < DateTime.UtcNow)
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

        private async void AplicarFiltro()
        {
            string nombre = txtFiltro.Text;
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
                }
                    ListViewItem item = new ListViewItem(new string[] { g.nombreCliente, g.FechaInicio.ToString(), g.FechaFin.ToString(), g.precio.ToString(), g.terminado.ToString(), prod, g.contenido });
              
                lvwGrabados.Items.Add(item);
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
        private async void GrabadosFrm_Load(object sender, EventArgs e)
        {
            await ObtenerGrabados();
            await ActualizarListaAsync();
        }

        private void nuevoGrabadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grabado nuevo = new Grabado();
            DetallesGrabadoFrm crearGrabado = new DetallesGrabadoFrm(nuevo);
            if (crearGrabado.ShowDialog() == DialogResult.OK)
            {
                nuevo = crearGrabado.DevolverGrabado();


                crearGrabado.Close();
                AplicarFiltro();

            }
        }

        private async void editarGrabadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvwGrabados.SelectedItems.Count == 1)
            {
                Grabado grabado = await Herramientas.GetGrabadoAsync((int)lvwGrabados.SelectedItems[0].Tag);
                if (grabado != null)
                {
                    DetallesGrabadoFrm editar = new DetallesGrabadoFrm(grabado);
                    if (editar.ShowDialog() == DialogResult.OK)
                    {
                        grabado = editar.DevolverGrabado();
                        
                        AplicarFiltro();
                        editar.Close();
                    }
                }
            }
            else { MessageBox.Show("Selecciona un grabado"); }
        }

        private async void borrarGrabadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvwGrabados.SelectedItems.Count == 1)
            {

                Grabado grabado = await Herramientas.GetGrabadoAsync((int)lvwGrabados.SelectedItems[0].Tag);
                if (grabado != null)
                {

                    string mensaje = "¿Seguro que quieres borrar este grabado? ";
                    if (MessageBox.Show(mensaje, "Borrar Grabado", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        await Herramientas.DeleteGrabadoAsync(grabado.IdGrabado);
                        AplicarFiltro();
                        MessageBox.Show("Grabado borrado con exito");
                    }


                }
            }

            else { MessageBox.Show("Selecciona un grabado"); }
            
    }

        private async void terminarGRabadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvwGrabados.SelectedItems.Count == 1)
            {
                Grabado grabado = await Herramientas.GetGrabadoAsync((int)lvwGrabados.SelectedItems[0].Tag);
                if (grabado != null)
                {
                    string mensaje = "¿Terminar/Reabrir este grabado? ";

                    if (MessageBox.Show(mensaje, "Terminar/Reabrir Grabado", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (grabado.terminado)
                        {
                            grabado.terminado = false;
                        }
                        else
                        {
                            grabado.terminado = true;
                        }
                        await Herramientas.UpdateGrabadoAsync(grabado.IdGrabado, grabado);
                        AplicarFiltro();
                    }
                }
                }
            else { MessageBox.Show("Selecciona un grabado"); }
        }

        private async void verContenidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvwGrabados.SelectedItems.Count == 1)
            {
                Grabado grabado = await Herramientas.GetGrabadoAsync((int)lvwGrabados.SelectedItems[0].Tag);
                if (grabado != null)
                {
                    MessageBox.Show(grabado.contenido, "Contenido del grabado");

                }
                }
            else { MessageBox.Show("Selecciona un encargo"); }
        }

        private async void duplicarGrabadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvwGrabados.SelectedItems.Count == 1)
            {
                if (lvwGrabados.SelectedItems.Count == 1)
                {
                    Grabado grabado = await Herramientas.GetGrabadoAsync((int)lvwGrabados.SelectedItems[0].Tag);
                    if (grabado != null)
                    {

                        string mensaje = "¿Duplicar este encargo? ";
                        if (MessageBox.Show(mensaje, "Duplicar Encargo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Grabado grabado2 = new Grabado();
                            Venta venta = new Venta();
                            grabado2 = grabado;
                            grabado2.FechaInicio = DateTime.Now;
                            grabado2.IdGrabado = 0;
                            venta.precio = grabado2.precio;
                            venta.FechaVenta = grabado2.FechaInicio;
                            venta.esEncargo = true;
                            grabado2.venta = venta;
                            await Herramientas.CreateGrabadoAsync(grabado2);
                            MessageBox.Show("Encargo duplicado");
                        }


                    }
                }
                else { MessageBox.Show("Selecciona un encargo"); }
            }
            else { MessageBox.Show("Selecciona un encargo"); }
        }
    }
}
