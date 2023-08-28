namespace JoyeriaDALA_EscritorioWinForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnFacturas = new System.Windows.Forms.Button();
            this.btnEncargo = new System.Windows.Forms.Button();
            this.btnGrabados = new System.Windows.Forms.Button();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lvwNotificacion = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.irANotificaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verNotificaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.crearNotificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verNotificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarNotificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarNotificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInventario
            // 
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.Location = new System.Drawing.Point(12, 12);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(171, 40);
            this.btnInventario.TabIndex = 0;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Location = new System.Drawing.Point(12, 68);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(171, 40);
            this.btnVentas.TabIndex = 1;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnFacturas
            // 
            this.btnFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturas.Location = new System.Drawing.Point(12, 243);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Size = new System.Drawing.Size(171, 40);
            this.btnFacturas.TabIndex = 2;
            this.btnFacturas.Text = "Facturas";
            this.btnFacturas.UseVisualStyleBackColor = true;
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            // 
            // btnEncargo
            // 
            this.btnEncargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncargo.Location = new System.Drawing.Point(12, 126);
            this.btnEncargo.Name = "btnEncargo";
            this.btnEncargo.Size = new System.Drawing.Size(171, 40);
            this.btnEncargo.TabIndex = 3;
            this.btnEncargo.Text = "Encargos";
            this.btnEncargo.UseVisualStyleBackColor = true;
            this.btnEncargo.Click += new System.EventHandler(this.btnEncargo_Click);
            // 
            // btnGrabados
            // 
            this.btnGrabados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabados.Location = new System.Drawing.Point(12, 184);
            this.btnGrabados.Name = "btnGrabados";
            this.btnGrabados.Size = new System.Drawing.Size(171, 40);
            this.btnGrabados.TabIndex = 4;
            this.btnGrabados.Text = "Grabados";
            this.btnGrabados.UseVisualStyleBackColor = true;
            this.btnGrabados.Click += new System.EventHandler(this.btnGrabados_Click);
            // 
            // btnAjustes
            // 
            this.btnAjustes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjustes.Location = new System.Drawing.Point(10, 458);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(173, 40);
            this.btnAjustes.TabIndex = 8;
            this.btnAjustes.Text = "Ajustes";
            this.btnAjustes.UseVisualStyleBackColor = true;
            this.btnAjustes.Click += new System.EventHandler(this.btnAjustes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(10, 392);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(173, 40);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Cerrar Sesión";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(419, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Notificaciones de la semana";
            // 
            // lvwNotificacion
            // 
            this.lvwNotificacion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvwNotificacion.ContextMenuStrip = this.contextMenuStrip1;
            this.lvwNotificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwNotificacion.FullRowSelect = true;
            this.lvwNotificacion.GridLines = true;
            this.lvwNotificacion.HideSelection = false;
            this.lvwNotificacion.Location = new System.Drawing.Point(225, 51);
            this.lvwNotificacion.MultiSelect = false;
            this.lvwNotificacion.Name = "lvwNotificacion";
            this.lvwNotificacion.Size = new System.Drawing.Size(657, 447);
            this.lvwNotificacion.TabIndex = 11;
            this.lvwNotificacion.UseCompatibleStateImageBehavior = false;
            this.lvwNotificacion.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Titulo";
            this.columnHeader1.Width = 145;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Inicio";
            this.columnHeader2.Width = 101;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fin";
            this.columnHeader3.Width = 94;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tipo";
            this.columnHeader4.Width = 95;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Descripción";
            this.columnHeader5.Width = 206;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.irANotificaciónToolStripMenuItem,
            this.verNotificaciónToolStripMenuItem,
            this.toolStripSeparator1,
            this.crearNotificacionToolStripMenuItem,
            this.verNotificacionToolStripMenuItem,
            this.borrarNotificacionToolStripMenuItem,
            this.actualizarNotificacionesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(206, 164);
            // 
            // irANotificaciónToolStripMenuItem
            // 
            this.irANotificaciónToolStripMenuItem.Name = "irANotificaciónToolStripMenuItem";
            this.irANotificaciónToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.irANotificaciónToolStripMenuItem.Text = "Ir a Notificación";
            this.irANotificaciónToolStripMenuItem.Click += new System.EventHandler(this.irANotificaciónToolStripMenuItem_Click);
            // 
            // verNotificaciónToolStripMenuItem
            // 
            this.verNotificaciónToolStripMenuItem.Name = "verNotificaciónToolStripMenuItem";
            this.verNotificaciónToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.verNotificaciónToolStripMenuItem.Text = "Ver Notificación";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
            // 
            // crearNotificacionToolStripMenuItem
            // 
            this.crearNotificacionToolStripMenuItem.Name = "crearNotificacionToolStripMenuItem";
            this.crearNotificacionToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.crearNotificacionToolStripMenuItem.Text = "Crear Notificacion";
            this.crearNotificacionToolStripMenuItem.Click += new System.EventHandler(this.crearNotificacionToolStripMenuItem_Click);
            // 
            // verNotificacionToolStripMenuItem
            // 
            this.verNotificacionToolStripMenuItem.Name = "verNotificacionToolStripMenuItem";
            this.verNotificacionToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.verNotificacionToolStripMenuItem.Text = "Ver Notificacion";
            this.verNotificacionToolStripMenuItem.Click += new System.EventHandler(this.verNotificacionToolStripMenuItem_Click);
            // 
            // borrarNotificacionToolStripMenuItem
            // 
            this.borrarNotificacionToolStripMenuItem.Name = "borrarNotificacionToolStripMenuItem";
            this.borrarNotificacionToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.borrarNotificacionToolStripMenuItem.Text = "Borrar Notificacion";
            this.borrarNotificacionToolStripMenuItem.Click += new System.EventHandler(this.borrarNotificacionToolStripMenuItem_Click);
            // 
            // actualizarNotificacionesToolStripMenuItem
            // 
            this.actualizarNotificacionesToolStripMenuItem.Name = "actualizarNotificacionesToolStripMenuItem";
            this.actualizarNotificacionesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.actualizarNotificacionesToolStripMenuItem.Text = "Actualizar Notificaciones";
            this.actualizarNotificacionesToolStripMenuItem.Click += new System.EventHandler(this.actualizarNotificacionesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 514);
            this.Controls.Add(this.lvwNotificacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAjustes);
            this.Controls.Add(this.btnGrabados);
            this.Controls.Add(this.btnEncargo);
            this.Controls.Add(this.btnFacturas);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnInventario);
            this.Name = "Form1";
            this.Text = "Joyería DALA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnFacturas;
        private System.Windows.Forms.Button btnEncargo;
        private System.Windows.Forms.Button btnGrabados;
        private System.Windows.Forms.Button btnAjustes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvwNotificacion;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem irANotificaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verNotificaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem crearNotificacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verNotificacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarNotificacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarNotificacionesToolStripMenuItem;
    }
}

