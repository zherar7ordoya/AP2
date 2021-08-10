
namespace Integrador
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEmprenderViaje = new System.Windows.Forms.Button();
            this.btnSubir = new System.Windows.Forms.Button();
            this.lblEnEspera = new System.Windows.Forms.Label();
            this.lstPasajeros = new System.Windows.Forms.ListBox();
            this.btnAnotar = new System.Windows.Forms.Button();
            this.lblPasajero = new System.Windows.Forms.Label();
            this.txtPasajero = new System.Windows.Forms.TextBox();
            this.imgBondi = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBondi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEmprenderViaje);
            this.groupBox1.Controls.Add(this.btnSubir);
            this.groupBox1.Controls.Add(this.lblEnEspera);
            this.groupBox1.Controls.Add(this.lstPasajeros);
            this.groupBox1.Controls.Add(this.btnAnotar);
            this.groupBox1.Controls.Add(this.lblPasajero);
            this.groupBox1.Controls.Add(this.txtPasajero);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(632, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(548, 368);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Terminal Obelisco";
            // 
            // btnEmprenderViaje
            // 
            this.btnEmprenderViaje.Location = new System.Drawing.Point(31, 320);
            this.btnEmprenderViaje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEmprenderViaje.Name = "btnEmprenderViaje";
            this.btnEmprenderViaje.Size = new System.Drawing.Size(196, 28);
            this.btnEmprenderViaje.TabIndex = 6;
            this.btnEmprenderViaje.Text = "Emprender viaje";
            this.btnEmprenderViaje.UseVisualStyleBackColor = true;
            this.btnEmprenderViaje.Click += new System.EventHandler(this.btnEmprenderViaje_Click);
            // 
            // btnSubir
            // 
            this.btnSubir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSubir.Location = new System.Drawing.Point(319, 320);
            this.btnSubir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(187, 28);
            this.btnSubir.TabIndex = 5;
            this.btnSubir.Text = "Subir a la combi!";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // lblEnEspera
            // 
            this.lblEnEspera.AutoSize = true;
            this.lblEnEspera.Location = new System.Drawing.Point(27, 105);
            this.lblEnEspera.Name = "lblEnEspera";
            this.lblEnEspera.Size = new System.Drawing.Size(74, 17);
            this.lblEnEspera.TabIndex = 4;
            this.lblEnEspera.Text = "En Espera";
            // 
            // lstPasajeros
            // 
            this.lstPasajeros.FormattingEnabled = true;
            this.lstPasajeros.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstPasajeros.ItemHeight = 16;
            this.lstPasajeros.Location = new System.Drawing.Point(31, 123);
            this.lstPasajeros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstPasajeros.Name = "lstPasajeros";
            this.lstPasajeros.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstPasajeros.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstPasajeros.Size = new System.Drawing.Size(473, 180);
            this.lstPasajeros.TabIndex = 3;
            // 
            // btnAnotar
            // 
            this.btnAnotar.Location = new System.Drawing.Point(392, 78);
            this.btnAnotar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnotar.Name = "btnAnotar";
            this.btnAnotar.Size = new System.Drawing.Size(113, 28);
            this.btnAnotar.TabIndex = 2;
            this.btnAnotar.Text = "Anotar";
            this.btnAnotar.UseVisualStyleBackColor = true;
            this.btnAnotar.Click += new System.EventHandler(this.btnAnotar_Click);
            // 
            // lblPasajero
            // 
            this.lblPasajero.AutoSize = true;
            this.lblPasajero.Location = new System.Drawing.Point(27, 41);
            this.lblPasajero.Name = "lblPasajero";
            this.lblPasajero.Size = new System.Drawing.Size(64, 17);
            this.lblPasajero.TabIndex = 1;
            this.lblPasajero.Text = "Pasajero";
            // 
            // txtPasajero
            // 
            this.txtPasajero.Location = new System.Drawing.Point(96, 37);
            this.txtPasajero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPasajero.Name = "txtPasajero";
            this.txtPasajero.Size = new System.Drawing.Size(407, 22);
            this.txtPasajero.TabIndex = 0;
            this.txtPasajero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPasajero_KeyDown);
            // 
            // imgBondi
            // 
            this.imgBondi.BackColor = System.Drawing.Color.White;
            this.imgBondi.BackgroundImage = global::Integrador.Properties.Resources.Combi0;
            this.imgBondi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgBondi.Location = new System.Drawing.Point(22, 38);
            this.imgBondi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgBondi.Name = "imgBondi";
            this.imgBondi.Size = new System.Drawing.Size(604, 313);
            this.imgBondi.TabIndex = 1;
            this.imgBondi.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 398);
            this.Controls.Add(this.imgBondi);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicio de Combis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBondi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.Label lblEnEspera;
        private System.Windows.Forms.ListBox lstPasajeros;
        private System.Windows.Forms.Label lblPasajero;
        private System.Windows.Forms.TextBox txtPasajero;
        private System.Windows.Forms.PictureBox imgBondi;
        private System.Windows.Forms.Button btnAnotar;
        private System.Windows.Forms.Button btnEmprenderViaje;
    }
}

