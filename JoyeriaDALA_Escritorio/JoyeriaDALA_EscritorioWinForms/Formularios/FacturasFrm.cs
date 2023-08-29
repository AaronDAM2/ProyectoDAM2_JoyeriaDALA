using JoyeriaDALA_EscritorioWinForms.Modelo;
using JoyeriaDALA_EscritorioWinForms.Reports;
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
    public partial class FacturasFrm : Form
    {
        private string filtro = null;
        private List<Factura> facturas;
        private List<Factura> facturasFiltradas;
        public FacturasFrm()
        {
            InitializeComponent();
            facturas = new List<Factura>();
            facturasFiltradas=new List<Factura>();
        }

        private void FacturasFrm_Load(object sender, EventArgs e)
        {

        }

        private async Task<List<Factura>> ObtenerFacturas()
        {
            try
            {

                facturas = await Herramientas.GetFacturasAsync();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return facturas;
        }


        private async Task ActualizarListaAsync()
        {
            if (lvwFacturas.Items.Count > 0)

                lvwFacturas.Items.Clear();

            List<Factura> lista = await Herramientas.GetFacturasAsync();

            if (lista.Count > 0)
            {
                foreach (Factura g in lista)
                {
                    if (g != null)
                    {

                        string[] datos = new string[] { g.cliente, g.fechaFactura.ToString(), g.fechaVencimiento.ToString(), g.Subtotal.ToString(), g.Total.ToString() };

                        ListViewItem item = new ListViewItem(datos);
                       
                        if (g.fechaFactura< DateTime.UtcNow.AddDays(15))
                            item.BackColor = Color.Yellow;
                         if (g.fechaFactura < DateTime.UtcNow.AddDays(5))
                            item.BackColor = Color.Red;
                        item.Tag = g.idFactura;
                        if (filtro == null)
                        {
                            lvwFacturas.Items.Add(item);
                        }
                        else
                        if (datos.Contains<String>(filtro))
                            lvwFacturas.Items.Add(item);

                    }


                }

            }
        }

        private async Task AplicarFiltro()
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
            List<Factura> facturasFiltrados = await ObtenerFacturasFiltrados(nombre, fechaInicio, fechaFin);

            // Limpiar la lista actual de ListViewItem
            lvwFacturas.Items.Clear();

            // Agregar los objetos Encargo filtrados a la ListView
            foreach (Factura g in facturasFiltrados)
            {




                string[] datos = new string[] { g.cliente, g.fechaFactura.ToString(), g.fechaVencimiento.ToString(), g.Subtotal.ToString(), g.Total.ToString() };

                ListViewItem item = new ListViewItem(datos);

                if (g.fechaFactura < DateTime.UtcNow.AddDays(15))
                    item.BackColor = Color.Yellow;
                if (g.fechaFactura < DateTime.UtcNow.AddDays(5))
                    item.BackColor = Color.Red;
                item.Tag = g.idFactura;
                if (filtro == null)
                {
                    lvwFacturas.Items.Add(item);
                }
                else
                if (datos.Contains<String>(filtro))
                    lvwFacturas.Items.Add(item);

            
        }
        }

        private async Task<List<Factura>> ObtenerFacturasFiltrados(string nombre, DateTime? fechaInicio, DateTime? fechaFin)
        {
            // Obtener todos los objetos Encargo (o desde tu origen de datos)
            List<Factura> todosLosFacturas = await ObtenerFacturas();

            // Aplicar el filtro en base a los valores proporcionados
            List<Factura> facturasFiltrados = todosLosFacturas;

            if (!string.IsNullOrWhiteSpace(nombre))
            {
                facturasFiltrados = facturasFiltrados.Where(g => g.cliente.Contains(nombre)).ToList();
            }

            if (fechaInicio.HasValue)
            {
                facturasFiltrados = facturasFiltrados.Where(g => g.fechaFactura >= fechaInicio).ToList();
            }

            if (fechaFin.HasValue)
            {
                facturasFiltrados = facturasFiltrados.Where(g => g.fechaVencimiento <= fechaFin).ToList();
            }

            return facturasFiltrados;
        }

        private async Task nuevaFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factura f=new Factura();
            DetallesFacturaFrm nueva = new DetallesFacturaFrm(f);
            if (nueva.ShowDialog() == DialogResult.OK)
            {
                f = nueva.DevolverFactura();
                nueva.Close();
                await AplicarFiltro();
            }
        }

        private async void verFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvwFacturas.SelectedItems.Count == 1)
            {
                Factura f=new Factura();
                f = await Herramientas.GetFacturaByIdAsync((int)lvwFacturas.SelectedItems[0].Tag);
                DetallesFacturaFrm nueva = new DetallesFacturaFrm(f);
                if (nueva.ShowDialog() == DialogResult.OK)
                {
                    f = nueva.DevolverFactura();
                    nueva.Close();
                    await AplicarFiltro();
                }

            }
            else
            {
                MessageBox.Show("Selecciona una factura");
            }


        }

        private async void imprimirFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvwFacturas.SelectedItems.Count == 1)
            {
                Factura f = new Factura();
                f = await Herramientas.GetFacturaByIdAsync((int)lvwFacturas.SelectedItems[0].Tag);
                DetallesFacturaFrm nueva = new DetallesFacturaFrm(f);
                if (nueva.ShowDialog() == DialogResult.OK)
                {
                    f = nueva.DevolverFactura();
                    nueva.Close();
                    await AplicarFiltro();
                }

            }
            else
            {
                MessageBox.Show("Selecciona una factura");
            }
        }
    }
}
