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
    public partial class EncargosFrm : Form
    {
        private string filtro = null;
        private List<Encargo> encargos;
        private List<Encargo> encargosFiltrados;
        public EncargosFrm()
        {
            InitializeComponent();
            encargos = new List<Encargo>();
            encargosFiltrados = new List<Encargo>();
           

        }

        private async Task<List<Encargo>> ObtenerEncargos()
        {
            try
            {

                encargos = await Herramientas.GetEncargosAsync();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return encargos;
        }

        private async Task ActualizarListaAsync()
        {
            if (lvwEncargos.Items.Count > 0)

                lvwEncargos.Items.Clear();

            List<Encargo> lista = await Herramientas.GetEncargosAsync();

            if (lista.Count > 0)
            {
                foreach (Encargo g in lista)
                {
                    if (g != null)
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
                            string[] datos = new string[] { g.cliente, g.FechaInicio.ToString(), g.FechaFin.ToString(), g.precio.ToString(), g.terminada.ToString(), prod };

                            ListViewItem item = new ListViewItem(datos);
                            if (!g.terminada)
                                item.BackColor = Color.Yellow;
                            if (!g.terminada && g.FechaFin.Value < DateTime.UtcNow)
                                item.BackColor = Color.Red;
                            item.Tag = g.IdEncargo;
                            if (filtro == null)
                            {
                                lvwEncargos.Items.Add(item);
                            }
                            else
                            if (datos.Contains<String>(filtro))
                                lvwEncargos.Items.Add(item);

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

            // Obtener los objetos Encargo que cumplen con el filtro
            List<Encargo> encargosFiltrados = ObtenerEncargosFiltrados(nombre, fechaInicio, fechaFin);

            // Limpiar la lista actual de ListViewItem
            lvwEncargos.Items.Clear();

            // Agregar los objetos Encargo filtrados a la ListView
            foreach (Encargo g in encargosFiltrados)
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
                    string[] datos = new string[] { g.cliente, g.FechaInicio.ToString(), g.FechaFin.ToString(), g.precio.ToString(), g.terminada.ToString(), prod };

                    ListViewItem item = new ListViewItem(datos);
                    if (!g.terminada)
                        item.BackColor = Color.Yellow;
                    if (!g.terminada && g.FechaFin.Value < DateTime.UtcNow)
                        item.BackColor = Color.Red;
                    item.Tag = g.IdEncargo;
                    if (filtro == null)
                    {
                        lvwEncargos.Items.Add(item);
                    }
                    else
                    if (datos.Contains<String>(filtro))
                        lvwEncargos.Items.Add(item);

                
            }
        }

        private List<Encargo> ObtenerEncargosFiltrados(string nombre, DateTime? fechaInicio, DateTime? fechaFin)
        {
            // Obtener todos los objetos Encargo (o desde tu origen de datos)
            List<Encargo> todosLosEncargos = ObtenerEncargos().Result;

            // Aplicar el filtro en base a los valores proporcionados
            List<Encargo> encargosFiltrados = todosLosEncargos;

            if (!string.IsNullOrWhiteSpace(nombre))
            {
                encargosFiltrados = encargosFiltrados.Where(g => g.cliente.Contains(nombre)).ToList();
            }

            if (fechaInicio.HasValue)
            {
                encargosFiltrados = encargosFiltrados.Where(g => g.FechaInicio >= fechaInicio).ToList();
            }

            if (fechaFin.HasValue)
            {
                encargosFiltrados = encargosFiltrados.Where(g => g.FechaFin <= fechaFin).ToList();
            }

            return encargosFiltrados;
        }

        private void nuevoEncargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Encargo nuevo=new Encargo();
            DetallesEncargoFrm crearEncargo = new DetallesEncargoFrm(nuevo);
            if(crearEncargo.ShowDialog() == DialogResult.OK)
            {
                nuevo=crearEncargo.DevolverEncargo();
               
               
                crearEncargo.Close();
                AplicarFiltro();

            }
        }

        private async void modificarEncargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lvwEncargos.SelectedItems.Count ==1)
            {
                Encargo encargo = await Herramientas.GetEncargoAsync((int)lvwEncargos.SelectedItems[0].Tag);
                if (encargo != null)
                {
                    DetallesEncargoFrm editar = new DetallesEncargoFrm(encargo);
                    if(editar.ShowDialog() == DialogResult.OK)
                    {
                        encargo=editar.DevolverEncargo();
                        editar.Close();
                        AplicarFiltro();
                    }
                }
            }
            else { MessageBox.Show("Selecciona un encargo"); }
        }

        private async void borrarEncargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvwEncargos.SelectedItems.Count == 1)
            {
                Encargo encargo = await Herramientas.GetEncargoAsync((int)lvwEncargos.SelectedItems[0].Tag);
                if (encargo != null)
                {

                    string mensaje = "¿Seguro que quieres borrar este encargo? ";
                    if(MessageBox.Show(mensaje,"Borrar Encargo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        await Herramientas.DeleteEncargoAsync(encargo.IdEncargo);
                        AplicarFiltro();
                        MessageBox.Show("Encargo borrado con exito");
                    }


                        }
            }
            else { MessageBox.Show("Selecciona un encargo"); }
        }

        private async void terminarEncargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvwEncargos.SelectedItems.Count == 1)
            {

                Encargo encargo = await Herramientas.GetEncargoAsync((int)lvwEncargos.SelectedItems[0].Tag);
                if (encargo != null)
                {

                    string mensaje = "¿Terminar/Abrir este encargo? ";
                    if (MessageBox.Show(mensaje, "Terminar/Reabrir Encargo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (encargo.terminada)
                        {
                            encargo.terminada = false;
                        }
                        else
                        {
                            encargo.terminada = true;
                        }
                        await Herramientas.UpdateEncargoAsync(encargo.IdEncargo, encargo);
                        AplicarFiltro();
                    }
                    
                    


                }
            }
            else { MessageBox.Show("Selecciona un encargo"); }
        }

        private async void duplicarEncargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
                if (lvwEncargos.SelectedItems.Count == 1)
                {
                    Encargo encargo = await Herramientas.GetEncargoAsync((int)lvwEncargos.SelectedItems[0].Tag);
                    if (encargo != null)
                    {

                        string mensaje = "¿Duplicar este encargo? ";
                        if (MessageBox.Show(mensaje, "Duplicar Encargo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                           Encargo encargo2=new Encargo();
                            Venta venta=new Venta();
                            encargo2=encargo;
                            encargo2.FechaInicio=DateTime.Now;
                            encargo2.IdEncargo = 0;
                            venta.precio = encargo2.precio;
                            venta.FechaVenta = encargo2.FechaInicio;
                            venta.esEncargo = true;
                            encargo2.venta = venta;
                            await Herramientas.CreateEncargoAsync(encargo2);
                            MessageBox.Show("Encargo duplicado");
                        }


                    }
                }
                else { MessageBox.Show("Selecciona un encargo"); }
        }

        private void generarVerFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private async void EncargosFrm_Load(object sender, EventArgs e)
        {
            await ObtenerEncargos();
            await ActualizarListaAsync();
        }
    }
}
