namespace JoyeriaDALA_EscritorioWinForms.Formularios
{
    partial class FacturasFrm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvwFacturas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.imprimirFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpFin);
            this.panel2.Controls.Add(this.dtpInicio);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnExportar);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.txtFiltro);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 128);
            this.panel2.TabIndex = 4;
            // 
            // dtpFin
            // 
            this.dtpFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(382, 62);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 29);
            this.dtpFin.TabIndex = 22;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(93, 62);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(200, 29);
            this.dtpInicio.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "hasta: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Desde: ";
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
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(12, 12);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(502, 29);
            this.txtFiltro.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvwFacturas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 460);
            this.panel1.TabIndex = 3;
            // 
            // lvwFacturas
            // 
            this.lvwFacturas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6});
            this.lvwFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwFacturas.FullRowSelect = true;
            this.lvwFacturas.GridLines = true;
            this.lvwFacturas.HideSelection = false;
            this.lvwFacturas.Location = new System.Drawing.Point(0, 0);
            this.lvwFacturas.Name = "lvwFacturas";
            this.lvwFacturas.Size = new System.Drawing.Size(945, 460);
            this.lvwFacturas.TabIndex = 0;
            this.lvwFacturas.UseCompatibleStateImageBehavior = false;
            this.lvwFacturas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cliente";
            this.columnHeader1.Width = 155;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Inicio";
            this.columnHeader2.Width = 86;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Vencimiento";
            this.columnHeader3.Width = 115;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Subtotal";
            this.columnHeader5.Width = 112;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Total";
            this.columnHeader6.Width = 88;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaFacturaToolStripMenuItem,
            this.verFacturaToolStripMenuItem,
            this.toolStripSeparator1,
            this.imprimirFacturaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 98);
            // 
            // verFacturaToolStripMenuItem
            // 
            this.verFacturaToolStripMenuItem.Image = global::JoyeriaDALA_EscritorioWinForms.Properties.Resources.action_Edit_16xMD;
            this.verFacturaToolStripMenuItem.Name = "verFacturaToolStripMenuItem";
            this.verFacturaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verFacturaToolStripMenuItem.Text = "Ver Factura";
            this.verFacturaToolStripMenuItem.Click += new System.EventHandler(this.verFacturaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // imprimirFacturaToolStripMenuItem
            // 
            this.imprimirFacturaToolStripMenuItem.Image = global::JoyeriaDALA_EscritorioWinForms.Properties.Resources.document_16xLG1;
            this.imprimirFacturaToolStripMenuItem.Name = "imprimirFacturaToolStripMenuItem";
            this.imprimirFacturaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imprimirFacturaToolStripMenuItem.Text = "Imprimir Factura";
            this.imprimirFacturaToolStripMenuItem.Click += new System.EventHandler(this.imprimirFacturaToolStripMenuItem_Click);
            // 
            // nuevaFacturaToolStripMenuItem
            // 
            this.nuevaFacturaToolStripMenuItem.Image = global::JoyeriaDALA_EscritorioWinForms.Properties.Resources.action_add_16xMD;
            this.nuevaFacturaToolStripMenuItem.Name = "nuevaFacturaToolStripMenuItem";
            this.nuevaFacturaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevaFacturaToolStripMenuItem.Text = "Nueva Factura";
            this.nuevaFacturaToolStripMenuItem.Click += new System.EventHandler(this.nuevaFacturaToolStripMenuItem_Click);
            // 
            // FacturasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(945, 606);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FacturasFrm";
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.FacturasFrm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvwFacturas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem imprimirFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaFacturaToolStripMenuItem;
    }
}