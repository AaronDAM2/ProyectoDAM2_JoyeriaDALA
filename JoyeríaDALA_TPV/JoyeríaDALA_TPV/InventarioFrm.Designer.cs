namespace JoyeríaDALA_TPV
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
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbMateriales = new System.Windows.Forms.ComboBox();
            this.cmbSubTipos = new System.Windows.Forms.ComboBox();
            this.lvwProductos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbTamaños = new System.Windows.Forms.ComboBox();
            this.btnPrecio = new System.Windows.Forms.Button();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProducto.Location = new System.Drawing.Point(798, 203);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(188, 79);
            this.btnNuevoProducto.TabIndex = 67;
            this.btnNuevoProducto.Text = "Nuevo Producto";
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // btnStock
            // 
            this.btnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.Location = new System.Drawing.Point(798, 370);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(188, 79);
            this.btnStock.TabIndex = 68;
            this.btnStock.Text = "Revisar Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnRetirar
            // 
            this.btnRetirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirar.Location = new System.Drawing.Point(798, 570);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(188, 79);
            this.btnRetirar.TabIndex = 69;
            this.btnRetirar.Text = "Retirar/Activar Producto";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(12, 12);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(780, 90);
            this.txtFiltro.TabIndex = 70;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(808, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(178, 92);
            this.btnBuscar.TabIndex = 78;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Accesorios",
            "Anillos",
            "Collares",
            "Relojes",
            "Pendientes",
            "Pulseras",
            "Trofeos",
            "Otros",
            ""});
            this.cmbTipo.Location = new System.Drawing.Point(12, 124);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(189, 50);
            this.cmbTipo.TabIndex = 79;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged_1);
            // 
            // cmbMateriales
            // 
            this.cmbMateriales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateriales.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMateriales.FormattingEnabled = true;
            this.cmbMateriales.Items.AddRange(new object[] {
            "Oro",
            "Plata",
            "Acero",
            "Cuero",
            "Cristal",
            "Otros"});
            this.cmbMateriales.Location = new System.Drawing.Point(213, 124);
            this.cmbMateriales.Name = "cmbMateriales";
            this.cmbMateriales.Size = new System.Drawing.Size(189, 50);
            this.cmbMateriales.TabIndex = 80;
            // 
            // cmbSubTipos
            // 
            this.cmbSubTipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubTipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubTipos.FormattingEnabled = true;
            this.cmbSubTipos.Location = new System.Drawing.Point(408, 124);
            this.cmbSubTipos.Name = "cmbSubTipos";
            this.cmbSubTipos.Size = new System.Drawing.Size(189, 50);
            this.cmbSubTipos.TabIndex = 81;
            // 
            // lvwProductos
            // 
            this.lvwProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7});
            this.lvwProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwProductos.FullRowSelect = true;
            this.lvwProductos.GridLines = true;
            this.lvwProductos.HideSelection = false;
            this.lvwProductos.Location = new System.Drawing.Point(21, 203);
            this.lvwProductos.MultiSelect = false;
            this.lvwProductos.Name = "lvwProductos";
            this.lvwProductos.Size = new System.Drawing.Size(771, 446);
            this.lvwProductos.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwProductos.TabIndex = 82;
            this.lvwProductos.UseCompatibleStateImageBehavior = false;
            this.lvwProductos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Producto";
            this.columnHeader1.Width = 194;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Stock";
            this.columnHeader2.Width = 95;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Precio";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tipo";
            this.columnHeader4.Width = 149;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Marca";
            this.columnHeader6.Width = 132;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Activo";
            this.columnHeader7.Width = 149;
            // 
            // cmbTamaños
            // 
            this.cmbTamaños.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTamaños.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTamaños.FormattingEnabled = true;
            this.cmbTamaños.Items.AddRange(new object[] {
            "Pequeño",
            "Mediano",
            "Grande"});
            this.cmbTamaños.Location = new System.Drawing.Point(603, 124);
            this.cmbTamaños.Name = "cmbTamaños";
            this.cmbTamaños.Size = new System.Drawing.Size(189, 50);
            this.cmbTamaños.TabIndex = 83;
            // 
            // btnPrecio
            // 
            this.btnPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrecio.Location = new System.Drawing.Point(798, 474);
            this.btnPrecio.Name = "btnPrecio";
            this.btnPrecio.Size = new System.Drawing.Size(188, 79);
            this.btnPrecio.TabIndex = 84;
            this.btnPrecio.Text = "Revisar Precio";
            this.btnPrecio.UseVisualStyleBackColor = true;
            this.btnPrecio.Click += new System.EventHandler(this.btnPrecio_Click);
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "Accesorios",
            "Anillos",
            "Collares",
            "Relojes",
            "Pendientes",
            "Pulseras",
            "Trofeos",
            "Otros",
            ""});
            this.cmbMarca.Location = new System.Drawing.Point(797, 124);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(189, 50);
            this.cmbMarca.TabIndex = 85;
            // 
            // InventarioFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 711);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.btnPrecio);
            this.Controls.Add(this.cmbTamaños);
            this.Controls.Add(this.lvwProductos);
            this.Controls.Add(this.cmbSubTipos);
            this.Controls.Add(this.cmbMateriales);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnNuevoProducto);
            this.Name = "InventarioFrm";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.InventarioFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbMateriales;
        private System.Windows.Forms.ComboBox cmbSubTipos;
        private System.Windows.Forms.ComboBox cmbTamaños;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnPrecio;
        public System.Windows.Forms.ListView lvwProductos;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ComboBox cmbMarca;
    }
}