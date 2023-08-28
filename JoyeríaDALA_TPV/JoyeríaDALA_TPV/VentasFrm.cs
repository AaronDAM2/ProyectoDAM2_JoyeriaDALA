using JoyeríaDALA_TPV.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoyeríaDALA_TPV
{
    public partial class VentasFrm : Form
    {
        private Venta _venta;
        private double precio;
        private List<Producto> productos;
        public VentasFrm(Venta venta)
        {
            InitializeComponent();
            precio = 0;
            _venta = venta;
        }

        private void ResetearFormulario()
        {
            txtCalcular.Text="0";
            _venta=new Venta();
            lvwProductos.Items.Clear();

        }

        private void ActualizarListaProductos()
        {
            lvwProductos.Items.Clear();
            if(productos!=null)
            {
                foreach(Producto p in productos) { 
                ListViewItem item = new ListViewItem(new string[] { p.nombre, p.precio.ToString()});
                    item.Tag = p.idProducto;
                    lvwProductos.Items.Add(item);
                }

            }
        }

     
        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string filtro=b.Text;
            BuscarProductos buscador=new BuscarProductos();
            switch (filtro)
            {
                case "Oro":
                    buscador.cmbMateriales.SelectedItem = "Oro";
                    break;
                case "Plata":
                    buscador.cmbMateriales.SelectedItem = "Plata";
                    break;
                case "Relojes":
                    buscador.cmbTipo.SelectedItem = "Relojes";
                    break;
                case "Acero":
                    buscador.cmbMateriales.SelectedItem = "Acero";
                    break;
                case "Accesorios":
                    buscador.cmbTipo.SelectedItem = "Accesorios";
                    break;
                case "Trofeos":
                    buscador.cmbTipo.SelectedItem = "Trofeos";
                    break;

                case "Cuero":
                    buscador.cmbMateriales.SelectedItem = "Cuero";
                    break;

                case "Regalos":
                    buscador.cmbTipo.SelectedItem = "Regalos";
                    break;

            }
            if (buscador.ShowDialog() == DialogResult.OK)
            {
                Producto p = buscador.DevolverProducto();
                productos.Add(p);
                ActualizarListaProductos();
                precio += p.precio;
            }
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            
            Button b=(Button)sender;
            txtCalcular.Text += b.Tag;
        }

        private double CalcularOperacion()
        {
            
            try
            {
                string expresion = txtCalcular.Text.Replace(",", ".");

                DataTable table = new DataTable();
                DataColumn column = new DataColumn("expression", typeof(double), expresion);
                table.Columns.Add(column);

                DataRow row = table.NewRow();
                table.Rows.Add(row);

                double resultado = (double)row["expression"];
                return Math.Round(resultado, 2); // Redondeamos el resultado a 2 decimales
            }
            catch (Exception)
            {
                txtCalcular.Text = "0";
                return 0;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtCalcular.Text != "")
            {
              
                
            }
            else {
                txtCalcular.Text = "0";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCalcular.Text = "0";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (txtCalcular.Text != "" && txtCalcular.Text.Length > 0)
            {
                double precioNuevo = CalcularOperacion();
                this.precio = precioNuevo;
               txtCalcular.Text= precioNuevo.ToString();
            }
            else
            {
                txtCalcular.Text = "0";
            }
            
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            DetallesVentaFrm detalles=new DetallesVentaFrm(_venta.observaciones);
            if (detalles.ShowDialog() == DialogResult.OK)
                _venta.observaciones = detalles.DevolverDetalles();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            _venta.precio = precio;
        }

        private void descuentosbtn_Click(object sender, EventArgs e)
        {

        }

        private void VentasFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (lvwProductos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debes seleccionar un producto para poder eliminarlo");
                return;
            }
            if (lvwProductos.SelectedItems.Count == 1)
            {
                Producto p = productos.FirstOrDefault(x => x.nombre == lvwProductos.SelectedItems[0].Name);
                productos.Remove(p);
                lvwProductos.Items.Remove(lvwProductos.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Error de seleccion");
            }
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            Producto nuevo=new Producto();
            ProductoFrm formProducto=new ProductoFrm(nuevo);
            if (formProducto.ShowDialog() == DialogResult.OK)
            {
                nuevo=formProducto.GetProducto();
                if (nuevo != null)
                {
                    ListViewItem item = new ListViewItem(new string[] { nuevo.nombre, nuevo.precio.ToString() });
                    item.Tag = nuevo.nombre;
                    lvwProductos.Items.Add(item);
                    productos.Add(nuevo);
                 
                    
                }
            }
        }

      
        private void ImprimirRecibo(Venta venta)
        {

        }

        private void txtCalcular_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(productos.Count == 0 ||productos==null)
            {
                MessageBox.Show("No hay productos seleccionados");
                return;
            }
            foreach(Producto p  in productos)
            {
                if (p != null)
                {
                    precio += p.precio;
                }
                

            }
            txtCalcular.Text = precio.ToString();

        }

        

        private async void button1_Click(object sender, EventArgs e)
        {
            if(txtCalcular.Text.Length ==0 || txtCalcular.Text=="") {
                MessageBox.Show("Tienes que definir un precio");
                return;

            }
            if (_venta == null)
            {
                MessageBox.Show("Error al crear la venta");
                return;
            }
            
            if(precio==0)
            {
                if(MessageBox.Show("¿Deseas registrar esta venta sin un precio?","Registrar Venta",MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            if(productos.Count==0 || productos == null)
            {
                if (MessageBox.Show("Esta venta no tiene productos. ¿Quieres continuar igualmente?", "Registrar Venta", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            _venta.codVenta = await Herramientas.CrearCodVenta(_venta);
            await Herramientas.NuevaVentaAsync(_venta, productos);
            MessageBox.Show("Venta registrada con exito");

            if(MessageBox.Show("¿Quieres imprimir el recibo?","Imprimir recibo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FinalizarVenta();

            }

        }

        private void btnAddProducto_Click(object sender, EventArgs e)
        {
            Producto buscar = new Producto();
            BuscarProductos buscador = new BuscarProductos();
            if (buscador.ShowDialog()==DialogResult.OK)
            {
                buscar=buscador.DevolverProducto();
                buscador.Close();

                productos.Add(buscar);
                ListViewItem item= new ListViewItem(new string[] {buscar.nombre, buscar.precio.ToString()});
                lvwProductos.Items.Add(item);
            }
          
            
        }

        private async Task FinalizarVenta()
        {
            ConsultaReciboFrm reciboFrm = new ConsultaReciboFrm();
          if(reciboFrm.DialogResult==DialogResult.OK)
            {
                string accion = reciboFrm.DevolverAccion();
                switch (accion)
                {
                    case "Recibo":
                        await Herramientas.CrearRecibo(this._venta);
                        break;
                    case "Factura":
                        Factura factura=new Factura();
                        List<ItemFactura> items = new List<ItemFactura>();
                        FacturasManager manager=new FacturasManager();
                        
                       
                            foreach (Producto p in productos)
                            {
                                int cuenta = 1;
                                int aux = productos.Count(x => x.idProducto == p.idProducto);
                                if (aux > 0)
                                    cuenta = aux;
                                ItemFactura item = manager.CrearItemFactura(p, cuenta);
                            }
                        factura.Items = items;
                            break;
                    case "Ambos":
                        await Herramientas.CrearRecibo(this._venta);

                        break;
                }
            }
        }

        

    }
}
