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
    public partial class VentasFrm : Form
    {
        private string filtro = null;
        List<Venta> ventas;
        List<Venta> ventasFiltradas;
        public VentasFrm()
        {
            InitializeComponent();
            ventas = new List<Venta>();
            ventasFiltradas= new List<Venta>();
            
        }

        private async Task<List<Venta>> ObtenerVentas()
        {
            try
            {

                ventas = await Herramientas.GetVentasAsync();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ventas;
        }

        private async Task ActualizarListaAsync()
        {
            if (lvwVentas.Items.Count > 0)

                lvwVentas.Items.Clear();

            List<Venta> lista = await Herramientas.GetVentasAsync();

            if (lista.Count > 0)
            {
                foreach (Venta g in lista)
                {
                    if (g != null)
                    {
                        string tipo = "Venta";
                        if (g.esGrabado)
                            tipo = "Grabado";
                        if (g.esEncargo)
                            tipo = "Encargo";
                        string[] datos = new string[] { g.codVenta, tipo, g.precio.ToString(), g.FechaVenta.ToShortDateString(), g.observaciones  };

                            ListViewItem item = new ListViewItem(datos);
                          
                            item.Tag = g.IdVenta;
                            if (filtro == null)
                            {
                                lvwVentas.Items.Add(item);
                            }
                            else
                            if (datos.Contains<String>(filtro))
                                lvwVentas.Items.Add(item);

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



            // Obtener los objetos Venta que cumplen con el filtro
            List<Venta> ventasFiltrados = ObtenerVentasFiltrados(nombre, fechaInicio, fechaFin).OrderBy(o => o.FechaVenta).ToList();

            // Limpiar la lista actual de ListViewItem
            lvwVentas.Items.Clear();

            // Agregar los objetos Venta filtrados a la ListView
            foreach (Venta g in ventasFiltrados)
            {

                string tipo = "Venta";
                if (g.esGrabado)
                    tipo = "Grabado";
                if (g.esEncargo)
                    tipo = "Encargo";
                string[] datos = new string[] { g.codVenta, tipo, g.precio.ToString(), g.FechaVenta.ToShortDateString(), g.observaciones };

                ListViewItem item = new ListViewItem(datos);
                        
                    item.Tag = g.IdVenta;
                    if (filtro == null)
                    {
                        lvwVentas.Items.Add(item);
                    }
                    else
                    if (datos.Contains<String>(filtro))
                        lvwVentas.Items.Add(item);

                
            }
        }

        private List<Venta> ObtenerVentasFiltrados(string nombre, DateTime? fechaInicio, DateTime? fechaFin)
        {
            // Obtener todos los objetos Venta (o desde tu origen de datos)
            List<Venta> todosLosVentas = ObtenerVentas().Result;

            // Aplicar el filtro en base a los valores proporcionados
            List<Venta> ventasFiltrados = todosLosVentas;

            if (!string.IsNullOrWhiteSpace(nombre))
            {
                ventasFiltrados = ventasFiltrados.Where(g => g.codVenta.Contains(nombre)).ToList();
            }

            if (fechaInicio.HasValue)
            {
                ventasFiltrados = ventasFiltrados.Where(g => g.FechaVenta >= fechaInicio).ToList();
            }

          

            return ventasFiltrados;
        }

        private async void VentasFrm_Load(object sender, EventArgs e)
        {
            await ObtenerVentas();
            await ActualizarListaAsync();
        }

        private async void editarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvwVentas.SelectedItems.Count == 1)
            {
                int id = (int)lvwVentas.SelectedItems[0].Tag;    
                Venta venta=await Herramientas.GetVentaAsync(id);
                if (venta != null)
                {
                    DetallesVentaFrm v = new DetallesVentaFrm(venta);
                    v.ShowDialog(); 
                }
            }
            else
            {
                MessageBox.Show("Selecciona una venta");
            }
        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            DetallesVentaFrm nuevo = new DetallesVentaFrm(venta);
            nuevo.ShowDialog();
        }
    }
}
