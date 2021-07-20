
namespace Integrador
{
    partial class frmCombis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCombis));
            this.picCombi = new System.Windows.Forms.PictureBox();
            this.lblTerminal = new System.Windows.Forms.Label();
            this.lblPasajero = new System.Windows.Forms.Label();
            this.txtPasajero = new System.Windows.Forms.TextBox();
            this.btnAnotar = new System.Windows.Forms.Button();
            this.lstPasajeros = new System.Windows.Forms.ListView();
            this.btnSubir = new System.Windows.Forms.Button();
            this.btnViajar = new System.Windows.Forms.Button();
            this.lblEspera = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCombi)).BeginInit();
            this.SuspendLayout();
            // 
            // picCombi
            // 
            this.picCombi.Image = ((System.Drawing.Image)(resources.GetObject("picCombi.Image")));
            this.picCombi.Location = new System.Drawing.Point(12, 12);
            this.picCombi.Name = "picCombi";
            this.picCombi.Size = new System.Drawing.Size(400, 278);
            this.picCombi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCombi.TabIndex = 0;
            this.picCombi.TabStop = false;
            // 
            // lblTerminal
            // 
            this.lblTerminal.AutoSize = true;
            this.lblTerminal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerminal.Location = new System.Drawing.Point(418, 12);
            this.lblTerminal.Name = "lblTerminal";
            this.lblTerminal.Size = new System.Drawing.Size(139, 17);
            this.lblTerminal.TabIndex = 1;
            this.lblTerminal.Text = "Terminal Obelisco";
            // 
            // lblPasajero
            // 
            this.lblPasajero.AutoSize = true;
            this.lblPasajero.Location = new System.Drawing.Point(501, 35);
            this.lblPasajero.Name = "lblPasajero";
            this.lblPasajero.Size = new System.Drawing.Size(48, 13);
            this.lblPasajero.TabIndex = 2;
            this.lblPasajero.Text = "Pasajero";
            // 
            // txtPasajero
            // 
            this.txtPasajero.Location = new System.Drawing.Point(555, 32);
            this.txtPasajero.Name = "txtPasajero";
            this.txtPasajero.Size = new System.Drawing.Size(200, 20);
            this.txtPasajero.TabIndex = 3;
            // 
            // btnAnotar
            // 
            this.btnAnotar.Location = new System.Drawing.Point(680, 58);
            this.btnAnotar.Name = "btnAnotar";
            this.btnAnotar.Size = new System.Drawing.Size(75, 23);
            this.btnAnotar.TabIndex = 4;
            this.btnAnotar.Text = "Anotar";
            this.btnAnotar.UseVisualStyleBackColor = true;
            this.btnAnotar.Click += new System.EventHandler(this.btnAnotar_Click);
            // 
            // lstPasajeros
            // 
            this.lstPasajeros.HideSelection = false;
            this.lstPasajeros.Location = new System.Drawing.Point(504, 100);
            this.lstPasajeros.Name = "lstPasajeros";
            this.lstPasajeros.Size = new System.Drawing.Size(251, 132);
            this.lstPasajeros.TabIndex = 5;
            this.lstPasajeros.UseCompatibleStateImageBehavior = false;
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(605, 238);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(150, 23);
            this.btnSubir.TabIndex = 6;
            this.btnSubir.Text = "Subir a la combi";
            this.btnSubir.UseVisualStyleBackColor = true;
            // 
            // btnViajar
            // 
            this.btnViajar.Location = new System.Drawing.Point(605, 267);
            this.btnViajar.Name = "btnViajar";
            this.btnViajar.Size = new System.Drawing.Size(150, 23);
            this.btnViajar.TabIndex = 7;
            this.btnViajar.Text = "Iniciar el viaje";
            this.btnViajar.UseVisualStyleBackColor = true;
            // 
            // lblEspera
            // 
            this.lblEspera.AutoSize = true;
            this.lblEspera.Location = new System.Drawing.Point(502, 84);
            this.lblEspera.Name = "lblEspera";
            this.lblEspera.Size = new System.Drawing.Size(55, 13);
            this.lblEspera.TabIndex = 8;
            this.lblEspera.Text = "En espera";
            // 
            // frmCombis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 306);
            this.Controls.Add(this.lblEspera);
            this.Controls.Add(this.btnViajar);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.lstPasajeros);
            this.Controls.Add(this.btnAnotar);
            this.Controls.Add(this.txtPasajero);
            this.Controls.Add(this.lblPasajero);
            this.Controls.Add(this.lblTerminal);
            this.Controls.Add(this.picCombi);
            this.Name = "frmCombis";
            this.Text = "Servicio de combis";
            this.Load += new System.EventHandler(this.frmCombis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCombi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCombi;
        private System.Windows.Forms.Label lblTerminal;
        private System.Windows.Forms.Label lblPasajero;
        private System.Windows.Forms.TextBox txtPasajero;
        private System.Windows.Forms.Button btnAnotar;
        private System.Windows.Forms.ListView lstPasajeros;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.Button btnViajar;
        private System.Windows.Forms.Label lblEspera;
    }
}

