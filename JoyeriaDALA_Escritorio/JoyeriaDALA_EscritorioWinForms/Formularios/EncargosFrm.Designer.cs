namespace JoyeriaDALA_EscritorioWinForms.Formularios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncargosFrm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvwEncargos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoEncargoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarEncargoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.terminarEncargoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicarEncargoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.generarVerFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.modificarEncargoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.panel2.TabIndex = 3;
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
            this.panel1.Controls.Add(this.lvwEncargos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 460);
            this.panel1.TabIndex = 4;
            // 
            // lvwEncargos
            // 
            this.lvwEncargos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvwEncargos.ContextMenuStrip = this.contextMenuStrip1;
            this.lvwEncargos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwEncargos.FullRowSelect = true;
            this.lvwEncargos.GridLines = true;
            this.lvwEncargos.HideSelection = false;
            this.lvwEncargos.Location = new System.Drawing.Point(0, 0);
            this.lvwEncargos.MultiSelect = false;
            this.lvwEncargos.Name = "lvwEncargos";
            this.lvwEncargos.Size = new System.Drawing.Size(945, 460);
            this.lvwEncargos.TabIndex = 0;
            this.lvwEncargos.UseCompatibleStateImageBehavior = false;
            this.lvwEncargos.View = System.Windows.Forms.View.Details;
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
            this.nuevoEncargoToolStripMenuItem,
            this.modificarEncargoToolStripMenuItem,
            this.borrarEncargoToolStripMenuItem,
            this.toolStripSeparator1,
            this.terminarEncargoToolStripMenuItem,
            this.duplicarEncargoToolStripMenuItem,
            this.toolStripSeparator2,
            this.generarVerFacturaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 170);
            // 
            // nuevoEncargoToolStripMenuItem
            // 
            this.nuevoEncargoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoEncargoToolStripMenuItem.Image")));
            this.nuevoEncargoToolStripMenuItem.Name = "nuevoEncargoToolStripMenuItem";
            this.nuevoEncargoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoEncargoToolStripMenuItem.Text = "Nuevo Encargo";
            this.nuevoEncargoToolStripMenuItem.Click += new System.EventHandler(this.nuevoEncargoToolStripMenuItem_Click);
            // 
            // borrarEncargoToolStripMenuItem
            // 
            this.borrarEncargoToolStripMenuItem.Image = global::JoyeriaDALA_EscritorioWinForms.Properties.Resources.garbage_can_16xMD;
            this.borrarEncargoToolStripMenuItem.Name = "borrarEncargoToolStripMenuItem";
            this.borrarEncargoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.borrarEncargoToolStripMenuItem.Text = "Borrar Encargo";
            this.borrarEncargoToolStripMenuItem.Click += new System.EventHandler(this.borrarEncargoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // terminarEncargoToolStripMenuItem
            // 
            this.terminarEncargoToolStripMenuItem.Image = global::JoyeriaDALA_EscritorioWinForms.Properties.Resources.CheckBox_669;
            this.terminarEncargoToolStripMenuItem.Name = "terminarEncargoToolStripMenuItem";
            this.terminarEncargoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.terminarEncargoToolStripMenuItem.Text = "Terminar Encargo";
            this.terminarEncargoToolStripMenuItem.Click += new System.EventHandler(this.terminarEncargoToolStripMenuItem_Click);
            // 
            // duplicarEncargoToolStripMenuItem
            // 
            this.duplicarEncargoToolStripMenuItem.Image = global::JoyeriaDALA_EscritorioWinForms.Properties.Resources.Copy_6524;
            this.duplicarEncargoToolStripMenuItem.Name = "duplicarEncargoToolStripMenuItem";
            this.duplicarEncargoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.duplicarEncargoToolStripMenuItem.Text = "Duplicar Encargo";
            this.duplicarEncargoToolStripMenuItem.Click += new System.EventHandler(this.duplicarEncargoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // generarVerFacturaToolStripMenuItem
            // 
            this.generarVerFacturaToolStripMenuItem.Image = global::JoyeriaDALA_EscritorioWinForms.Properties.Resources.document_16xLG;
            this.generarVerFacturaToolStripMenuItem.Name = "generarVerFacturaToolStripMenuItem";
            this.generarVerFacturaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generarVerFacturaToolStripMenuItem.Text = "Generar Factura";
            this.generarVerFacturaToolStripMenuItem.Click += new System.EventHandler(this.generarVerFacturaToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "action_add_16xMD.png");
            this.imageList1.Images.SetKeyName(1, "action_Cancel_16xMD.png");
            this.imageList1.Images.SetKeyName(2, "action_Edit_16xMD.png");
            this.imageList1.Images.SetKeyName(3, "action_Search_16xMD.png");
            this.imageList1.Images.SetKeyName(4, "blueinterrogation_16xLG.png");
            this.imageList1.Images.SetKeyName(5, "bluestar_16xMD.png");
            this.imageList1.Images.SetKeyName(6, "CheckBox_669.png");
            this.imageList1.Images.SetKeyName(7, "Copy_6524.png");
            this.imageList1.Images.SetKeyName(8, "Cut_6523.png");
            this.imageList1.Images.SetKeyName(9, "cyanuser_16xMD.png");
            this.imageList1.Images.SetKeyName(10, "document_16xLG.png");
            this.imageList1.Images.SetKeyName(11, "folder_Closed_16xLG.png");
            this.imageList1.Images.SetKeyName(12, "folder_Open_16xLG.png");
            this.imageList1.Images.SetKeyName(13, "garbage_can_16xMD.png");
            this.imageList1.Images.SetKeyName(14, "greenarrow_down_16xMD.png");
            this.imageList1.Images.SetKeyName(15, "greentick_16xLG.png");
            this.imageList1.Images.SetKeyName(16, "hard_Drive_16xLG.png");
            this.imageList1.Images.SetKeyName(17, "interrogation_16xLG.png");
            this.imageList1.Images.SetKeyName(18, "menu_16xMD.png");
            this.imageList1.Images.SetKeyName(19, "Paste_6520.png");
            this.imageList1.Images.SetKeyName(20, "patinete_16xLG.png");
            this.imageList1.Images.SetKeyName(21, "procedure_16xMD.png");
            this.imageList1.Images.SetKeyName(22, "redarrow_up_16xMD.png");
            this.imageList1.Images.SetKeyName(23, "Redo_16x.png");
            this.imageList1.Images.SetKeyName(24, "redUbicationPointer_16xMD.png");
            this.imageList1.Images.SetKeyName(25, "refresh_16xMD.png");
            this.imageList1.Images.SetKeyName(26, "Save_6530.png");
            this.imageList1.Images.SetKeyName(27, "Undo_16x.png");
            this.imageList1.Images.SetKeyName(28, "wrench_16xMD.png");
            // 
            // modificarEncargoToolStripMenuItem
            // 
            this.modificarEncargoToolStripMenuItem.Image = global::JoyeriaDALA_EscritorioWinForms.Properties.Resources.action_Edit_16xMD;
            this.modificarEncargoToolStripMenuItem.Name = "modificarEncargoToolStripMenuItem";
            this.modificarEncargoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarEncargoToolStripMenuItem.Text = "Modificar Encargo";
            this.modificarEncargoToolStripMenuItem.Click += new System.EventHandler(this.modificarEncargoToolStripMenuItem_Click);
            // 
            // EncargosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(945, 606);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "EncargosFrm";
            this.Text = "Encargos";
            this.Load += new System.EventHandler(this.EncargosFrm_Load);
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
        private System.Windows.Forms.ListView lvwEncargos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoEncargoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminarEncargoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarEncargoToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem duplicarEncargoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem generarVerFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarEncargoToolStripMenuItem;
    }
}