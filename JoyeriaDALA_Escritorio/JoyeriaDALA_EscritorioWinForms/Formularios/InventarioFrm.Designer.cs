namespace JoyeriaDALA_EscritorioWinForms.Formularios
{
    partial class InventarioFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvwProductos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.retirarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.cmbSubtipo = new System.Windows.Forms.ComboBox();
            this.cmbTamano = new System.Windows.Forms.ComboBox();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvwProductos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 480);
            this.panel1.TabIndex = 0;
            // 
            // lvwProductos
            // 
            this.lvwProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvwProductos.ContextMenuStrip = this.contextMenuStrip1;
            this.lvwProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwProductos.FullRowSelect = true;
            this.lvwProductos.GridLines = true;
            this.lvwProductos.HideSelection = false;
            this.lvwProductos.Location = new System.Drawing.Point(0, 0);
            this.lvwProductos.MultiSelect = false;
            this.lvwProductos.Name = "lvwProductos";
            this.lvwProductos.Size = new System.Drawing.Size(945, 480);
            this.lvwProductos.TabIndex = 0;
            this.lvwProductos.UseCompatibleStateImageBehavior = false;
            this.lvwProductos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Producto";
            this.columnHeader1.Width = 155;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Stock";
            this.columnHeader2.Width = 69;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Precio";
            this.columnHeader3.Width = 72;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tipo";
            this.columnHeader4.Width = 109;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Marca";
            this.columnHeader5.Width = 112;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "En venta";
            this.columnHeader6.Width = 82;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Descripción";
            this.columnHeader7.Width = 306;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoProductoToolStripMenuItem,
            this.editarProductoToolStripMenuItem,
            this.borrarProductoToolStripMenuItem,
            this.toolStripSeparator1,
            this.retirarProductoToolStripMenuItem,
            this.cambiarStockToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(162, 120);
            // 
            // nuevoProductoToolStripMenuItem
            // 
            this.nuevoProductoToolStripMenuItem.Image = global::JoyeriaDALA_EscritorioWinForms.Properties.Resources.action_add_16xMD;
            this.nuevoProductoToolStripMenuItem.Name = "nuevoProductoToolStripMenuItem";
            this.nuevoProductoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.nuevoProductoToolStripMenuItem.Text = "Nuevo Producto";
            this.nuevoProductoToolStripMenuItem.Click += new System.EventHandler(this.nuevoProductoToolStripMenuItem_Click);
            // 
            // editarProductoToolStripMenuItem
            // 
            this.editarProductoToolStripMenuItem.Image = global::JoyeriaDALA_EscritorioWinForms.Properties.Resources.action_Edit_16xMD;
            this.editarProductoToolStripMenuItem.Name = "editarProductoToolStripMenuItem";
            this.editarProductoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.editarProductoToolStripMenuItem.Text = "Editar Producto";
            this.editarProductoToolStripMenuItem.Click += new System.EventHandler(this.editarProductoToolStripMenuItem_Click);
            // 
            // borrarProductoToolStripMenuItem
            // 
            this.borrarProductoToolStripMenuItem.Image = global::JoyeriaDALA_EscritorioWinForms.Properties.Resources.garbage_can_16xMD;
            this.borrarProductoToolStripMenuItem.Name = "borrarProductoToolStripMenuItem";
            this.borrarProductoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.borrarProductoToolStripMenuItem.Text = "Borrar Producto";
            this.borrarProductoToolStripMenuItem.Click += new System.EventHandler(this.borrarProductoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // retirarProductoToolStripMenuItem
            // 
            this.retirarProductoToolStripMenuItem.Image = global::JoyeriaDALA_EscritorioWinForms.Properties.Resources.folder_Closed_16xLG;
            this.retirarProductoToolStripMenuItem.Name = "retirarProductoToolStripMenuItem";
            this.retirarProductoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.retirarProductoToolStripMenuItem.Text = "Retirar Producto";
            this.retirarProductoToolStripMenuItem.Click += new System.EventHandler(this.retirarProductoToolStripMenuItem_Click);
            // 
            // cambiarStockToolStripMenuItem
            // 
            this.cambiarStockToolStripMenuItem.Image = global::JoyeriaDALA_EscritorioWinForms.Properties.Resources.Paste_6520;
            this.cambiarStockToolStripMenuItem.Name = "cambiarStockToolStripMenuItem";
            this.cambiarStockToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.cambiarStockToolStripMenuItem.Text = "Cambiar Stock";
            this.cambiarStockToolStripMenuItem.Click += new System.EventHandler(this.cambiarStockToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAjustes);
            this.panel2.Controls.Add(this.btnExportar);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.cmbMarca);
            this.panel2.Controls.Add(this.cmbSubtipo);
            this.panel2.Controls.Add(this.cmbTamano);
            this.panel2.Controls.Add(this.cmbMaterial);
            this.panel2.Controls.Add(this.cmbTipo);
            this.panel2.Controls.Add(this.txtFiltro);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 108);
            this.panel2.TabIndex = 1;
            // 
            // btnAjustes
            // 
            this.btnAjustes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjustes.Location = new System.Drawing.Point(812, 58);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(121, 29);
            this.btnAjustes.TabIndex = 18;
            this.btnAjustes.Text = "Ajustes";
            this.btnAjustes.UseVisualStyleBackColor = true;
            this.btnAjustes.Click += new System.EventHandler(this.btnAjustes_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(812, 14);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(121, 29);
            this.btnExportar.TabIndex = 17;
            this.btnExportar.Text = "Exportar datos";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(520, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(121, 29);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(520, 47);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(121, 28);
            this.cmbMarca.TabIndex = 15;
            // 
            // cmbSubtipo
            // 
            this.cmbSubtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubtipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubtipo.FormattingEnabled = true;
            this.cmbSubtipo.Location = new System.Drawing.Point(393, 47);
            this.cmbSubtipo.Name = "cmbSubtipo";
            this.cmbSubtipo.Size = new System.Drawing.Size(121, 28);
            this.cmbSubtipo.TabIndex = 14;
            // 
            // cmbTamano
            // 
            this.cmbTamano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTamano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTamano.FormattingEnabled = true;
            this.cmbTamano.Location = new System.Drawing.Point(266, 47);
            this.cmbTamano.Name = "cmbTamano";
            this.cmbTamano.Size = new System.Drawing.Size(121, 28);
            this.cmbTamano.TabIndex = 13;
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(139, 47);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(121, 28);
            this.cmbMaterial.TabIndex = 12;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(12, 47);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 28);
            this.cmbTipo.TabIndex = 11;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(12, 12);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(502, 29);
            this.txtFiltro.TabIndex = 10;
            // 
            // InventarioFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(945, 606);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "InventarioFrm";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.InventarioFrm_Load);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvwProductos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAjustes;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.ComboBox cmbSubtipo;
        private System.Windows.Forms.ComboBox cmbTamano;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem retirarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarStockToolStripMenuItem;
    }
}