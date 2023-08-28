using JoyeriaDALA_EscritorioWinForms.Formularios;
using JoyeriaDALA_EscritorioWinForms.Modelo;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoyeriaDALA_EscritorioWinForms.Reports
{
        public partial class VisorFacturas : Form
        {
            private Factura factura;
            private List<ItemFactura> items;
            private PropietarioWr propietario;
            private ClienteWr cliente;
            public VisorFacturas()
            {
                InitializeComponent();
            }

            public VisorFacturas(Factura factura, List<ItemFactura> items, ClienteWr cliente)
            {
                InitializeComponent();
                this.factura = factura;
                this.items = items;
                this.cliente = cliente;
            }

            private async Task<PropietarioWr> ObtenerPropietario()
            {
                propietario=await Herramientas.ObtenerPropietarioAsync();
                return propietario;
            }
            private void VisorFacturas_Load(object sender, EventArgs e)
            {
                propietario=ObtenerPropietario().Result;
                try
                {
                    MostrarReporte();
                    this.rpvFacturas.RefreshReport();
                }
               catch (Exception ex)
                {
                    MessageBox.Show("Error al mostrar la factura");
                    this.rpvFacturas.Clear();
                }
            }

            private void btnImprimir_Click(object sender, EventArgs e)
            {
                if (rpvFacturas.LocalReport != null&&rpvFacturas.LocalReport.DataSources.Count!=0)
                {

                    rpvFacturas.PrintDialog();
                }
            
            }

       

            private void button1_Click(object sender, EventArgs e)
            {
            
            }

            private void btnModificarFacturas_Click(object sender, EventArgs e)
            {
                this.factura.Items = this.items;
                DetallesFacturaFrm detallesFactura = new DetallesFacturaFrm(factura);
                detallesFactura.ShowDialog();
                rpvFacturas.Dispose();
                this.Close();
            }

            private void btnSalir_Click(object sender, EventArgs e)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

         


            private void MostrarReporte()
            {
                // Crear la lista de objetos PropietarioWr, Factura y ItemFactura
                List<ClienteWr> clientes = new List<ClienteWr> ();
                clientes.Add (this.cliente);
                List<Factura> facturas = new List<Factura>();
                facturas.Add (this.factura);
                List<ItemFactura> itemsFactura = this.items;
                List<PropietarioWr> propietarios = new List<PropietarioWr>();
                propietarios.Add (this.propietario);

                //     Crear un DataSet y agregar DataTables para cada clase


                ReportDataSource rdsClientes = new ReportDataSource("DataSetClientes", clientes);
                ReportDataSource rdsFacturas = new ReportDataSource("DataSet1", facturas);
                ReportDataSource rdsPropietarios = new ReportDataSource("DataSetPropietarios", propietarios);
                ReportDataSource rdsItemsFactura = new ReportDataSource("DataSet2", itemsFactura);

                // Configurar el control ReportViewer
                rpvFacturas.LocalReport.ReportPath = "ReportFactura.rdlc";
                rpvFacturas.LocalReport.DataSources.Clear();

                rpvFacturas.LocalReport.DataSources.Add(rdsClientes);
                rpvFacturas.LocalReport.DataSources.Add(rdsFacturas);
                rpvFacturas.LocalReport.DataSources.Add(rdsPropietarios);
                rpvFacturas.LocalReport.DataSources.Add(rdsItemsFactura);
            

                // Refrescar el control ReportViewer
                rpvFacturas.RefreshReport();
            }


        }
}
