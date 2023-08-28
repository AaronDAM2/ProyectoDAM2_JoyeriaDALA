namespace JoyeriaDALA_EscritorioWinForms.Formularios
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvwGrabados = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoGrabadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarGrabadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarGrabadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.terminarGRabadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verContenidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicarGrabadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.generarVerFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvwGrabados);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 460);
            this.panel1.TabIndex = 1;
            // 
            // lvwGrabados
            // 
            this.lvwGrabados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvwGrabados.ContextMenuStrip = this.contextMenuStrip1;
            this.lvwGrabados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwGrabados.FullRowSelect = true;
            this.lvwGrabados.GridLines = true;
            this.lvwGrabados.HideSelection = false;
            this.lvwGrabados.Location = new System.Drawing.Point(0, 0);
            this.lvwGrabados.MultiSelect = false;
            this.lvwGrabados.Name = "lvwGrabados";
            this.lvwGrabados.Size = new System.Drawing.Size(945, 460);
            this.lvwGrabados.TabIndex = 0;
            this.lvwGrabados.UseCompatibleStateImageBehavior = false;
            this.lvwGrabados.View = System.Windows.Forms.View.Details;
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
            this.columnHeader3.Text = "Fin";
            this.columnHeader3.Width = 115;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Precio";
            this.columnHeader4.Width = 69;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Producto";
            this.columnHeader5.Width = 112;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Terminado";
            this.columnHeader6.Width = 88;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Contenido";
            this.columnHeader7.Width = 266;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoGrabadoToolStripMenuItem,
            this.editarGrabadoToolStripMenuItem,
            this.borrarGrabadoToolStripMenuItem,
            this.toolStripSeparator1,
            this.terminarGRabadoToolStripMenuItem,
            this.verContenidoToolStripMenuItem,
            this.duplicarGrabadoToolStripMenuItem,
            this.toolStripSeparator2,
            this.generarVerFacturaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 170);
            // 
            // nuevoGrabadoToolStripMenuItem
            // 
            this.nuevoGrabadoToolStripMenuItem.Image = global::JoyeriaDALA_EscritorioWinForms.Properties.Resources.action_add_16xMD;
            this.nuevoGrabadoToolStripMenuItem.Name = "nuevoGrabadoToolStripMenuItem";
            this.nuevoGrabadoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.nuevoGrabadoToolStripMenuItem.Text = "Nuevo Grabado";
            this.nuevoGrabadoToolStripMenuItem.Click += new System.EventHandler(this.nuevoGrabadoToolStripMenuItem_Click);
            // 
            // editarGrabadoToolStripMenuItem
            // 
            this.editarGrabadoToolStripMenuItem.Image = global::JoyeriaDALA_EscritorioWinForms.Properties.Resources.action_Edit_16xMD;
            this.editarGrabadoToolStripMenuItem.Name = "editarGrabadoToolStripMenuItem";
            this.editarGrabadoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.editarGrabadoToolStripMenuItem.Text = "Editar Grabado";
            this.editarGrabadoToolStripMenuItem.Click += new System.EventHandler(this.editarGrabadoToolStripMenuItem_Click);
            // 
            // borrarGrabadoToolStripMenuItem
            // 
            this.borrarGrabadoToolStripMenuItem.Image = global::JoyeriaDALA_EscritorioWinForms.Properties.Resources.garbage_can_16xMD;
            this.borrarGrabadoToolStripMenuItem.Name = "borrarGrabadoToolStripMenuItem";
            this.borrarGrabadoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.borrarGrabadoToolStripMenuItem.Text = "Borrar Grabado";
            this.borrarGrabadoToolStripMenuItem.Click += new System.EventHandler(this.borrarGrabadoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // terminarGRabadoToolStripMenuItem
            // 
            this.terminarGRabadoToolStripMenuItem.Image = global::JoyeriaDALA_EscritorioWinForms.Properties.Resources.CheckBox_669;
            this.terminarGRabadoToolStripMenuItem.Name = "terminarGRabadoToolStripMenuItem";
            this.terminarGRabadoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.terminarGRabadoToolStripMenuItem.Text = "Terminar Grabado";
            this.terminarGRabadoToolStripMenuItem.Click += new System.EventHandler(this.terminarGRabadoToolStripMenuItem_Click);
            // 
            // verContenidoToolStripMenuItem
            // 
            this.verContenidoToolStripMenuItem.Image = global::JoyeriaDALA_EscritorioWinForms.Properties.Resources.procedure_16xMD;
            this.verContenidoToolStripMenuItem.Name = "verContenidoToolStripMenuItem";
            this.verContenidoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.verContenidoToolStripMenuItem.Text = "Ver Contenido";
            this.verContenidoToolStripMenuItem.Click += new System.EventHandler(this.verContenidoToolStripMenuItem_Click);
            // 
            // duplicarGrabadoToolStripMenuItem
            // 
            this.duplicarGrabadoToolStripMenuItem.Image = global::JoyeriaDALA_EscritorioWinForms.Properties.Resources.Copy_6524;
            this.duplicarGrabadoToolStripMenuItem.Name = "duplicarGrabadoToolStripMenuItem";
            this.duplicarGrabadoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.duplicarGrabadoToolStripMenuItem.Text = "Duplicar Grabado";
            this.duplicarGrabadoToolStripMenuItem.Click += new System.EventHandler(this.duplicarGrabadoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(165, 6);
            // 
            // generarVerFacturaToolStripMenuItem
            // 
            this.generarVerFacturaToolStripMenuItem.Name = "generarVerFacturaToolStripMenuItem";
            this.generarVerFacturaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.generarVerFacturaToolStripMenuItem.Text = "Generar Factura";
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
            this.panel2.TabIndex = 2;
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
            // GrabadosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(945, 606);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GrabadosFrm";
            this.Text = "Grabados";
            this.Load += new System.EventHandler(this.GrabadosFrm_Load);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvwGrabados;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoGrabadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarGrabadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarGrabadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem terminarGRabadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verContenidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicarGrabadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem generarVerFacturaToolStripMenuItem;
    }
}