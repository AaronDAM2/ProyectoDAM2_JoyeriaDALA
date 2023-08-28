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
    public partial class AjustesInventarioFrm : Form
    {
        public AjustesInventarioFrm()
        {
            InitializeComponent();
        }

        public async Task CargarListas()
        {
            List<TipoProducto> tipos= new List<TipoProducto>();
            tipos=await Herramientas.GetTiposProductoAsync();
            if (tipos.Count != 0)
            {
                foreach(TipoProducto tipo in tipos) { 
                lvwTipos.Items.Add(tipo.Tipo);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if(lvwTipos.SelectedItems.Count != 0) {
                string tipo = lvwTipos.SelectedItems[0].Text;
                if(tipo != null)
                {
                    List<string> subtipos=await Herramientas.GetSubtiposProductoAsync(tipo);
                    if (subtipos.Count != 0)
                    {
                        foreach(string s in subtipos)
                            lvwSubtipos.Items.Add(s);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un objeto");
            }
        }

        private async void button6_Click(object sender, EventArgs e)
        {

            if (lvwTipos.SelectedItems.Count != 0)
            {
                string tipo = lvwTipos.SelectedItems[0].Text;
                if (tipo != null)
                {
                    List<string> marcas=await Herramientas.GetMarcasProductoAsync(tipo);
                    if (marcas.Count != 0)
                    {
                        foreach (string s in marcas)
                            lvwMarcas.Items.Add(s);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un objeto");
            }
        }
    }
}
