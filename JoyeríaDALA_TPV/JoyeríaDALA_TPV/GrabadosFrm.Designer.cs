namespace JoyeríaDALA_TPV
{
    partial class GrabadosFrm
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
            this.btnTerminarGrabado = new System.Windows.Forms.Button();
            this.lvwGrabados = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCalcular = new System.Windows.Forms.TextBox();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.btnEditarContenido = new System.Windows.Forms.Button();
            this.btnFacturas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTerminarGrabado
            // 
            this.btnTerminarGrabado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminarGrabado.Location = new System.Drawing.Point(798, 620);
            this.btnTerminarGrabado.Name = "btnTerminarGrabado";
            this.btnTerminarGrabado.Size = new System.Drawing.Size(188, 79);
            this.btnTerminarGrabado.TabIndex = 105;
            this.btnTerminarGrabado.Text = "Terminar Grabado";
            this.btnTerminarGrabado.UseVisualStyleBackColor = true;
            this.btnTerminarGrabado.Click += new System.EventHandler(this.btnTerminarGrabado_Click);
            // 
            // lvwGrabados
            // 
            this.lvwGrabados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvwGrabados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwGrabados.FullRowSelect = true;
            this.lvwGrabados.GridLines = true;
            this.lvwGrabados.HideSelection = false;
            this.lvwGrabados.Location = new System.Drawing.Point(21, 253);
            this.lvwGrabados.MultiSelect = false;
            this.lvwGrabados.Name = "lvwGrabados";
            this.lvwGrabados.Size = new System.Drawing.Size(771, 446);
            this.lvwGrabados.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwGrabados.TabIndex = 103;
            this.lvwGrabados.UseCompatibleStateImageBehavior = false;
            this.lvwGrabados.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cliente";
            this.columnHeader1.Width = 159;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "FechaInicio";
            this.columnHeader2.Width = 122;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "FechaFin";
            this.columnHeader3.Width = 105;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Precio";
            this.columnHeader4.Width = 115;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Terminado";
            this.columnHeader5.Width = 115;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Producto";
            this.columnHeader6.Width = 103;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(808, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(178, 92);
            this.btnBuscar.TabIndex = 99;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCalcular
            // 
            this.txtCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalcular.Location = new System.Drawing.Point(12, 12);
            this.txtCalcular.Name = "txtCalcular";
            this.txtCalcular.Size = new System.Drawing.Size(780, 90);
            this.txtCalcular.TabIndex = 98;
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProducto.Location = new System.Drawing.Point(798, 253);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(188, 79);
            this.btnNuevoProducto.TabIndex = 96;
            this.btnNuevoProducto.Text = "Nuevo Grabado";
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 107;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 108;
            this.label2.Text = "hasta: ";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(104, 122);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(175, 38);
            this.dtpInicio.TabIndex = 109;
            // 
            // dtpFin
            // 
            this.dtpFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(386, 122);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(175, 38);
            this.dtpFin.TabIndex = 110;
            // 
            // btnEditarContenido
            // 
            this.btnEditarContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarContenido.Location = new System.Drawing.Point(798, 366);
            this.btnEditarContenido.Name = "btnEditarContenido";
            this.btnEditarContenido.Size = new System.Drawing.Size(188, 79);
            this.btnEditarContenido.TabIndex = 111;
            this.btnEditarContenido.Text = "Editar Contenido";
            this.btnEditarContenido.UseVisualStyleBackColor = true;
            this.btnEditarContenido.Click += new System.EventHandler(this.btnEditarContenido_Click);
            // 
            // btnFacturas
            // 
            this.btnFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturas.Location = new System.Drawing.Point(798, 487);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Size = new System.Drawing.Size(188, 79);
            this.btnFacturas.TabIndex = 116;
            this.btnFacturas.Text = "Generar Factura";
            this.btnFacturas.UseVisualStyleBackColor = true;
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            // 
            // GrabadosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 711);
            this.Controls.Add(this.btnFacturas);
            this.Controls.Add(this.btnEditarContenido);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTerminarGrabado);
            this.Controls.Add(this.lvwGrabados);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCalcular);
            this.Controls.Add(this.btnNuevoProducto);
            this.Name = "GrabadosFrm";
            this.Text = "Grabados";
            this.Load += new System.EventHandler(this.GrabadosFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTerminarGrabado;
        public System.Windows.Forms.ListView lvwGrabados;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCalcular;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Button btnEditarContenido;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnFacturas;
    }
}