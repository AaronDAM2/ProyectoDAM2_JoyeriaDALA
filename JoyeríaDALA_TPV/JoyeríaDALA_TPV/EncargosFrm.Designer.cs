namespace JoyeríaDALA_TPV
{
    partial class EncargosFrm
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
            this.TerminarEncargo = new System.Windows.Forms.Button();
            this.lvwEncargos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCalcular = new System.Windows.Forms.TextBox();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFacturas = new System.Windows.Forms.Button();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDescripción = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TerminarEncargo
            // 
            this.TerminarEncargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TerminarEncargo.Location = new System.Drawing.Point(798, 620);
            this.TerminarEncargo.Name = "TerminarEncargo";
            this.TerminarEncargo.Size = new System.Drawing.Size(188, 79);
            this.TerminarEncargo.TabIndex = 95;
            this.TerminarEncargo.Text = "Terminar Encargo";
            this.TerminarEncargo.UseVisualStyleBackColor = true;
            this.TerminarEncargo.Click += new System.EventHandler(this.TerminarEncargo_Click);
            // 
            // lvwEncargos
            // 
            this.lvwEncargos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lvwEncargos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwEncargos.FullRowSelect = true;
            this.lvwEncargos.GridLines = true;
            this.lvwEncargos.HideSelection = false;
            this.lvwEncargos.Location = new System.Drawing.Point(12, 253);
            this.lvwEncargos.MultiSelect = false;
            this.lvwEncargos.Name = "lvwEncargos";
            this.lvwEncargos.Size = new System.Drawing.Size(771, 446);
            this.lvwEncargos.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwEncargos.TabIndex = 93;
            this.lvwEncargos.UseCompatibleStateImageBehavior = false;
            this.lvwEncargos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cliente";
            this.columnHeader1.Width = 162;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descripción";
            this.columnHeader2.Width = 242;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(808, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(178, 92);
            this.btnBuscar.TabIndex = 89;
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
            this.txtCalcular.TabIndex = 88;
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProducto.Location = new System.Drawing.Point(798, 253);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(188, 79);
            this.btnNuevoProducto.TabIndex = 85;
            this.btnNuevoProducto.Text = "Nuevo Encargo";
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // dtpFin
            // 
            this.dtpFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(385, 121);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(175, 38);
            this.dtpFin.TabIndex = 114;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(103, 121);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(175, 38);
            this.dtpInicio.TabIndex = 113;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 112;
            this.label2.Text = "hasta: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 111;
            this.label1.Text = "Desde:";
            // 
            // btnFacturas
            // 
            this.btnFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturas.Location = new System.Drawing.Point(798, 479);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Size = new System.Drawing.Size(188, 79);
            this.btnFacturas.TabIndex = 115;
            this.btnFacturas.Text = "Generar Factura";
            this.btnFacturas.UseVisualStyleBackColor = true;
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Inicio";
            this.columnHeader7.Width = 76;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Hasta";
            this.columnHeader8.Width = 82;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Precio";
            this.columnHeader9.Width = 86;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Terminado";
            this.columnHeader10.Width = 99;
            // 
            // btnDescripción
            // 
            this.btnDescripción.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescripción.Location = new System.Drawing.Point(798, 364);
            this.btnDescripción.Name = "btnDescripción";
            this.btnDescripción.Size = new System.Drawing.Size(188, 79);
            this.btnDescripción.TabIndex = 116;
            this.btnDescripción.Text = "Ver Descripción";
            this.btnDescripción.UseVisualStyleBackColor = true;
            this.btnDescripción.Click += new System.EventHandler(this.btnDescripción_Click);
            // 
            // EncargosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 711);
            this.Controls.Add(this.btnDescripción);
            this.Controls.Add(this.btnFacturas);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TerminarEncargo);
            this.Controls.Add(this.lvwEncargos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCalcular);
            this.Controls.Add(this.btnNuevoProducto);
            this.Name = "EncargosFrm";
            this.Text = "Encargos";
            this.Load += new System.EventHandler(this.EncargosFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TerminarEncargo;
        public System.Windows.Forms.ListView lvwEncargos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCalcular;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFacturas;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button btnDescripción;
    }
}