namespace JoyeriaDALA_EscritorioWinForms.Formularios
{
    partial class AjustesInventarioFrm
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
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("Pequeño");
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("Mediano");
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem("Grande");
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem("Oro");
            System.Windows.Forms.ListViewItem listViewItem21 = new System.Windows.Forms.ListViewItem("Plata");
            System.Windows.Forms.ListViewItem listViewItem22 = new System.Windows.Forms.ListViewItem("Acero");
            System.Windows.Forms.ListViewItem listViewItem23 = new System.Windows.Forms.ListViewItem("Cuero");
            System.Windows.Forms.ListViewItem listViewItem24 = new System.Windows.Forms.ListViewItem("Cristal");
            this.label1 = new System.Windows.Forms.Label();
            this.lvwTipos = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.lvwSubtipos = new System.Windows.Forms.ListView();
            this.lvwMarcas = new System.Windows.Forms.ListView();
            this.lvwTamanos = new System.Windows.Forms.ListView();
            this.lvwMateriales = new System.Windows.Forms.ListView();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipos";
            // 
            // lvwTipos
            // 
            this.lvwTipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwTipos.FullRowSelect = true;
            this.lvwTipos.GridLines = true;
            this.lvwTipos.HideSelection = false;
            this.lvwTipos.Location = new System.Drawing.Point(16, 48);
            this.lvwTipos.MultiSelect = false;
            this.lvwTipos.Name = "lvwTipos";
            this.lvwTipos.Size = new System.Drawing.Size(161, 243);
            this.lvwTipos.TabIndex = 1;
            this.lvwTipos.UseCompatibleStateImageBehavior = false;
            this.lvwTipos.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Añadir Tipo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(16, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Quitar Tipo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(16, 369);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "Cargar Subtipos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Subtipos";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(197, 297);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 30);
            this.button4.TabIndex = 7;
            this.button4.Text = "Añadir Subtipo";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(197, 333);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(161, 30);
            this.button5.TabIndex = 8;
            this.button5.Text = "Quitar Subtipo";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(423, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Marcas";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(16, 405);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(161, 30);
            this.button6.TabIndex = 11;
            this.button6.Text = "Cargar Marcas";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(379, 297);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(161, 30);
            this.button7.TabIndex = 12;
            this.button7.Text = "Añadir Marca";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(379, 333);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(161, 30);
            this.button8.TabIndex = 13;
            this.button8.Text = "Quitar Marca";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(599, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tamaños";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(774, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Materiales";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(563, 297);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(161, 30);
            this.button9.TabIndex = 18;
            this.button9.Text = "Añadir Tamaño";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(742, 297);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(161, 30);
            this.button10.TabIndex = 19;
            this.button10.Text = "Añadir Material";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(563, 333);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(161, 30);
            this.button11.TabIndex = 20;
            this.button11.Text = "Quitar Tamaño";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(742, 333);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(161, 30);
            this.button12.TabIndex = 21;
            this.button12.Text = "Quitar Material";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // lvwSubtipos
            // 
            this.lvwSubtipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwSubtipos.FullRowSelect = true;
            this.lvwSubtipos.GridLines = true;
            this.lvwSubtipos.HideSelection = false;
            this.lvwSubtipos.Location = new System.Drawing.Point(197, 48);
            this.lvwSubtipos.MultiSelect = false;
            this.lvwSubtipos.Name = "lvwSubtipos";
            this.lvwSubtipos.Size = new System.Drawing.Size(161, 243);
            this.lvwSubtipos.TabIndex = 22;
            this.lvwSubtipos.UseCompatibleStateImageBehavior = false;
            this.lvwSubtipos.View = System.Windows.Forms.View.Details;
            // 
            // lvwMarcas
            // 
            this.lvwMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwMarcas.FullRowSelect = true;
            this.lvwMarcas.GridLines = true;
            this.lvwMarcas.HideSelection = false;
            this.lvwMarcas.Location = new System.Drawing.Point(379, 48);
            this.lvwMarcas.MultiSelect = false;
            this.lvwMarcas.Name = "lvwMarcas";
            this.lvwMarcas.Size = new System.Drawing.Size(161, 243);
            this.lvwMarcas.TabIndex = 23;
            this.lvwMarcas.UseCompatibleStateImageBehavior = false;
            this.lvwMarcas.View = System.Windows.Forms.View.Details;
            // 
            // lvwTamanos
            // 
            this.lvwTamanos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwTamanos.FullRowSelect = true;
            this.lvwTamanos.GridLines = true;
            this.lvwTamanos.HideSelection = false;
            this.lvwTamanos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem17,
            listViewItem18,
            listViewItem19});
            this.lvwTamanos.Location = new System.Drawing.Point(563, 48);
            this.lvwTamanos.MultiSelect = false;
            this.lvwTamanos.Name = "lvwTamanos";
            this.lvwTamanos.Size = new System.Drawing.Size(161, 243);
            this.lvwTamanos.TabIndex = 24;
            this.lvwTamanos.UseCompatibleStateImageBehavior = false;
            this.lvwTamanos.View = System.Windows.Forms.View.Details;
            // 
            // lvwMateriales
            // 
            this.lvwMateriales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwMateriales.FullRowSelect = true;
            this.lvwMateriales.GridLines = true;
            this.lvwMateriales.HideSelection = false;
            this.lvwMateriales.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem20,
            listViewItem21,
            listViewItem22,
            listViewItem23,
            listViewItem24});
            this.lvwMateriales.Location = new System.Drawing.Point(742, 48);
            this.lvwMateriales.MultiSelect = false;
            this.lvwMateriales.Name = "lvwMateriales";
            this.lvwMateriales.Size = new System.Drawing.Size(161, 243);
            this.lvwMateriales.TabIndex = 25;
            this.lvwMateriales.UseCompatibleStateImageBehavior = false;
            this.lvwMateriales.View = System.Windows.Forms.View.Details;
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(814, 429);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(123, 30);
            this.button13.TabIndex = 26;
            this.button13.Text = "Aceptar";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(685, 429);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(123, 30);
            this.button14.TabIndex = 27;
            this.button14.Text = "Cancelar";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // AjustesInventarioFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 471);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.lvwMateriales);
            this.Controls.Add(this.lvwTamanos);
            this.Controls.Add(this.lvwMarcas);
            this.Controls.Add(this.lvwSubtipos);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvwTipos);
            this.Controls.Add(this.label1);
            this.Name = "AjustesInventarioFrm";
            this.Text = "Ajustes de Inventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvwTipos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.ListView lvwSubtipos;
        private System.Windows.Forms.ListView lvwMarcas;
        private System.Windows.Forms.ListView lvwTamanos;
        private System.Windows.Forms.ListView lvwMateriales;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
    }
}