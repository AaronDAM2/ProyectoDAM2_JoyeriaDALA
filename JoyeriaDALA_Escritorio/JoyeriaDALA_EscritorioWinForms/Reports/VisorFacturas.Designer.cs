namespace JoyeriaDALA_EscritorioWinForms.Reports
{
    partial class VisorFacturas
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
            this.rpvFacturas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnModificarFacturas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rpvFacturas
            // 
            this.rpvFacturas.LocalReport.ReportEmbeddedResource = "JoyeriaDALA_EscritorioWinForms.Reports.ReportFactura.rdlc";
            this.rpvFacturas.Location = new System.Drawing.Point(145, 12);
            this.rpvFacturas.Name = "rpvFacturas";
            this.rpvFacturas.ServerReport.BearerToken = null;
            this.rpvFacturas.Size = new System.Drawing.Size(728, 455);
            this.rpvFacturas.TabIndex = 0;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(12, 12);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(109, 62);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Imprimir Factura";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnModificarFacturas
            // 
            this.btnModificarFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarFacturas.Location = new System.Drawing.Point(12, 224);
            this.btnModificarFacturas.Name = "btnModificarFacturas";
            this.btnModificarFacturas.Size = new System.Drawing.Size(109, 62);
            this.btnModificarFacturas.TabIndex = 2;
            this.btnModificarFacturas.Text = "Modificar Factura";
            this.btnModificarFacturas.UseVisualStyleBackColor = true;
            this.btnModificarFacturas.Click += new System.EventHandler(this.btnModificarFacturas_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(12, 433);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 34);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // VisorFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 479);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificarFacturas);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.rpvFacturas);
            this.Name = "VisorFacturas";
            this.Text = "Visor de Facturas";
            this.Load += new System.EventHandler(this.VisorFacturas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvFacturas;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnModificarFacturas;
        private System.Windows.Forms.Button btnSalir;
    }
}