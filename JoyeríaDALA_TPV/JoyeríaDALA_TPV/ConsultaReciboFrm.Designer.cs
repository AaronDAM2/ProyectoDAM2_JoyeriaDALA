namespace JoyeríaDALA_TPV
{
    partial class ConsultaReciboFrm
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
            this.btnRecibo = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.btnAmbos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRecibo
            // 
            this.btnRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecibo.Location = new System.Drawing.Point(167, 55);
            this.btnRecibo.Name = "btnRecibo";
            this.btnRecibo.Size = new System.Drawing.Size(117, 66);
            this.btnRecibo.TabIndex = 109;
            this.btnRecibo.Tag = "";
            this.btnRecibo.Text = "Recibo";
            this.btnRecibo.UseVisualStyleBackColor = true;
            this.btnRecibo.Click += new System.EventHandler(this.btnRecibo_Click);
            // 
            // btnFactura
            // 
            this.btnFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactura.Location = new System.Drawing.Point(12, 55);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(117, 66);
            this.btnFactura.TabIndex = 110;
            this.btnFactura.Tag = "";
            this.btnFactura.Text = "Factura";
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAmbos
            // 
            this.btnAmbos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmbos.Location = new System.Drawing.Point(319, 55);
            this.btnAmbos.Name = "btnAmbos";
            this.btnAmbos.Size = new System.Drawing.Size(117, 66);
            this.btnAmbos.TabIndex = 111;
            this.btnAmbos.Tag = "";
            this.btnAmbos.Text = "Ambos";
            this.btnAmbos.UseVisualStyleBackColor = true;
            this.btnAmbos.Click += new System.EventHandler(this.btnAmbos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 25);
            this.label1.TabIndex = 112;
            this.label1.Text = "¿Quieres imprimir factura, recibo, o ambos?";
            // 
            // ConsultaReciboFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 137);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAmbos);
            this.Controls.Add(this.btnFactura);
            this.Controls.Add(this.btnRecibo);
            this.Name = "ConsultaReciboFrm";
            this.Text = "Finalizar Venta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecibo;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Button btnAmbos;
        private System.Windows.Forms.Label label1;
    }
}