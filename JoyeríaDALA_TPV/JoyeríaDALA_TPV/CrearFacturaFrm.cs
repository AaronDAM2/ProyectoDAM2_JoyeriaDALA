﻿using JoyeríaDALA_TPV.Modelo;
using JoyeríaDALA_TPV.Reports;
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
    public partial class CrearFacturaFrm : Form
    {

        private Factura factura;
        private List<ItemFactura> itemsFactura;
        private bool nuevo;
        FacturasManager facturasManager;
        public CrearFacturaFrm(Factura factura)
        {
            InitializeComponent();
            facturasManager = new FacturasManager();
            this.factura = factura;
            if (factura.idFactura != 0)
            {

                nuevo = false;
                txtCliente.Text = factura.cliente;
                txtDireccion.Text = factura.dirFactura;
                txtDomicilio.Text = factura.domicilioPago;
                txtNIF.Text = factura.FacturaNIF;
                txtSubtotal.Text = factura.Subtotal.ToString();
                txtTotal.Text = factura.Total.ToString();
                itemsFactura = factura.Items;

                ActualizarLista();
            }
            else
            {
                nuevo = true;
                itemsFactura = new List<ItemFactura>();
            }
        }

        private void CrearFacturaFrm_Load(object sender, EventArgs e)
        {
        }

        private void ActualizarLista()
        {
            if (itemsFactura != null && itemsFactura.Count > 0)
            {
                lvwItems.Items.Clear();
                foreach (ItemFactura itemF in itemsFactura)
                {
                    string[] datos = new string[] { itemF.Descripcion, itemF.tipo, itemF.Cantidad.ToString(), itemF.Importe.ToString(), itemF.Descuento.ToString() };
                    System.Windows.Forms.ListViewItem item = new System.Windows.Forms.ListViewItem(datos);
                    item.Tag = itemF.IdItem;
                    lvwItems.Items.Add(item);
                }
                ActualizarPrecio();
            }
        }

        private void btnCargarProducto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            BuscarProductos buscador = new BuscarProductos();
            if (buscador.ShowDialog() == DialogResult.OK)
            {
                producto = buscador.DevolverProducto();
                buscador.Close();
                if (producto != null)
                {
                    CargarProducto(producto);
                }
            }
        }

        public void CargarProducto(Producto producto)
        {
            if (producto != null)
            {
                int cantidad = 1;
                ContadorFrm cont = new ContadorFrm();
                if (cont.ShowDialog() == DialogResult.OK)
                {
                    cantidad = cont.DevolverContador();
                    cont.Close();
                }
                facturasManager.AgregarProducto(producto);
                ItemFactura f = facturasManager.CrearItemFactura(producto, cantidad);
                itemsFactura.Add(f);
                ActualizarLista();
            }
        }


        public void CargarEncargo(Encargo e)
        {
            if (e != null)
            {
                facturasManager.AgregarEncargo(e);
                ItemFactura f = facturasManager.CrearItemFactura(e);
                itemsFactura.Add(f);
                ActualizarLista();
            }
        }

        public void CargarGrabado(Grabado g)
        {
            if (g != null)
            {
                facturasManager.AgregarGrabado(g);
                ItemFactura f = facturasManager.CrearItemFactura(g);
                itemsFactura.Add(f);
                ActualizarLista();
            }
        }





        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            ProductoFrm crear = new ProductoFrm(producto);
            if (crear.ShowDialog() == DialogResult.OK)
            {

                CargarProducto(producto);
            }

        }

        private void nuevoEncargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Encargo encargo = new Encargo();
            DetallesEncargoFrm crear = new DetallesEncargoFrm(encargo);
            if (crear.ShowDialog() == DialogResult.OK)
            {
                encargo = crear.devolverEncargo();
                crear.Close();
                if (encargo != null)
                {
                    CargarEncargo(encargo);
                }
            }
        }

        private void nuevoGrabadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grabado grabado = new Grabado();
            DetallesGrabado crear = new DetallesGrabado(grabado);
            if (crear.ShowDialog() == DialogResult.OK)
            {
                grabado = crear.devolverGrabado();
                crear.Close();
                if (grabado != null)
                {
                    CargarGrabado(grabado);
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (lvwItems.SelectedItems.Count == 1)
            {
                int descuento = 0;
                ContadorFrm contador = new ContadorFrm();
                if (contador.ShowDialog() == DialogResult.OK)
                {
                    descuento = contador.DevolverContador();
                    contador.Close();
                    ItemFactura item = itemsFactura.FirstOrDefault(x => x.IdItem == (int)lvwItems.SelectedItems[0].Tag);
                    if (item != null)
                    {
                        item.Descuento = descuento;

                        item.Importe = (item.PrecioUnitario * item.Cantidad) * (descuento / 100);
                        itemsFactura.Remove(item);
                        itemsFactura.Add(item);
                        ActualizarLista();
                    }
                }
            }
            else
                MessageBox.Show("Selecciona una linea de factura");
        }

        private void btnQuitarItem_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarPrecio()
        {
            double subtotal = 0, total = 0;
            if (itemsFactura != null && itemsFactura.Count > 0)
            {
                foreach (ItemFactura item in itemsFactura)
                {
                    double precioLinea = item.PrecioUnitario * item.Cantidad;
                    if (item.Descuento > 0)
                        precioLinea = precioLinea * (item.Descuento / 100);
                    subtotal += precioLinea;
                }

                txtSubtotal.Text = subtotal.ToString();
                double IVA = (subtotal * 21) / 100;
                total = subtotal + IVA;
                txtTotal.Text = total.ToString();
                factura.Subtotal = subtotal;
                factura.Total = total;
            }
        }

        private void btnCargarPrecios_Click(object sender, EventArgs e)
        {
            ActualizarPrecio();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text.Length > 0 && txtDireccion.Text.Length > 0 && txtNIF.Text.Length > 0 && dtpFactura.Value != null && dtpVencimiento.Value != null && cmbPago.Text.Length > 0)
            {
                if (dtpVencimiento.Value < DateTime.Now || dtpVencimiento.Value < dtpFactura.Value)
                {
                    factura.cliente = txtCliente.Text;
                    factura.dirFactura = txtDireccion.Text;
                    factura.fechaFactura = dtpFactura.Value;
                    factura.domicilioPago = txtDomicilio.Text;
                    factura.FacturaNIF = txtNIF.Text;
                    factura.formaPago = cmbPago.Text;
                    factura.fechaVencimiento = dtpVencimiento.Value;

                    factura.Items = itemsFactura;
                    ActualizarPrecio();

                    this.DialogResult = DialogResult.OK;

                    if (nuevo)
                    {
                        await Herramientas.NuevaFacturaAsync(factura, itemsFactura);
                    }
                    else
                    {
                        await Herramientas.ActualizarFacturaAsync(factura, itemsFactura);
                    }
                    MessageBox.Show("Factura registrada");

                    ClienteWr cliente = new ClienteWr();
                    cliente.nombre = txtCliente.Text;
                    cliente.NIF = txtNIF.Text;
                    cliente.dirección = txtDireccion.Text;

                   /* VisorFacturas visor = new VisorFacturas(factura, itemsFactura, cliente);
                    visor.ShowDialog();
                    this.Close();*/

                }
                else
                    MessageBox.Show("La fecha de vencimiento no es valida. Debe ser mayor que la fecha actual y que la fecha de facturación");
            }
            else
                MessageBox.Show("Introduce todos los datos para guardar la factura");

        }
        public Factura DevolverFactura() { return factura; }

        public List<ItemFactura> DevolverItems() { return itemsFactura; }

        private void cambiarCantidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvwItems.SelectedItems.Count == 1)
            {
                ItemFactura item = null;
                item = itemsFactura.FirstOrDefault(x => x.IdItem == (int)lvwItems.SelectedItems[0].Tag);
                if (item != null)
                {
                    int cantidad = item.Cantidad;
                    ContadorFrm contador = new ContadorFrm(cantidad);
                    if (contador.ShowDialog() == DialogResult.OK)
                    {
                        cantidad = contador.DevolverContador();
                        contador.Close();
                        item.Cantidad = cantidad;
                        itemsFactura.Remove(item);
                        itemsFactura.Add(item);
                        ActualizarLista();
                    }
                }

            }
            else
                MessageBox.Show("Selecciona una lista de factura");
        }

        private void btnQuitarItem_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCargarPrecios_Click_1(object sender, EventArgs e)
        {
            ActualizarPrecio();
        }

        private void btnDescuento_Click(object sender, EventArgs e)
        {
            if (lvwItems.SelectedItems.Count == 1)
            {
                int descuento = 0;
                ContadorFrm contador = new ContadorFrm();
                if (contador.ShowDialog() == DialogResult.OK)
                {
                    descuento = contador.DevolverContador();
                    contador.Close();
                    ItemFactura item = itemsFactura.FirstOrDefault(x => x.IdItem == (int)lvwItems.SelectedItems[0].Tag);
                    if (item != null)
                    {
                        item.Descuento = descuento;

                        item.Importe = (item.PrecioUnitario * item.Cantidad) * (descuento / 100);
                        itemsFactura.Remove(item);
                        itemsFactura.Add(item);
                        ActualizarLista();
                    }
                }
            }
            else
                MessageBox.Show("Selecciona una linea de factura");
        }
    }
}
