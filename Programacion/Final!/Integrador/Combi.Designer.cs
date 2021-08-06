
namespace Integrador
{
    partial class Combi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Combi));
            this.picCombi = new System.Windows.Forms.PictureBox();
            this.lblTerminal = new System.Windows.Forms.Label();
            this.lblPasajero = new System.Windows.Forms.Label();
            this.txtPasajero = new System.Windows.Forms.TextBox();
            this.btnAnotar = new System.Windows.Forms.Button();
            this.lstPasajeros = new System.Windows.Forms.ListView();
            this.btnSubir = new System.Windows.Forms.Button();
            this.btnViajar = new System.Windows.Forms.Button();
            this.lblEspera = new System.Windows.Forms.Label();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.lblChofer = new System.Windows.Forms.Label();
            this.lblKilometraje = new System.Windows.Forms.Label();
            this.lblArribo = new System.Windows.Forms.Label();
            this.lblPartida = new System.Windows.Forms.Label();
            this.grpVentanilla = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCombi)).BeginInit();
            this.grpVentanilla.SuspendLayout();
            this.SuspendLayout();
            // 
            // picCombi
            // 
            this.picCombi.Image = ((System.Drawing.Image)(resources.GetObject("picCombi.Image")));
            this.picCombi.InitialImage = ((System.Drawing.Image)(resources.GetObject("picCombi.InitialImage")));
            this.picCombi.Location = new System.Drawing.Point(12, 46);
            this.picCombi.Name = "picCombi";
            this.picCombi.Size = new System.Drawing.Size(312, 144);
            this.picCombi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCombi.TabIndex = 0;
            this.picCombi.TabStop = false;
            // 
            // lblTerminal
            // 
            this.lblTerminal.AutoSize = true;
            this.lblTerminal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerminal.Location = new System.Drawing.Point(12, 9);
            this.lblTerminal.Name = "lblTerminal";
            this.lblTerminal.Size = new System.Drawing.Size(139, 17);
            this.lblTerminal.TabIndex = 1;
            this.lblTerminal.Text = "Terminal Obelisco";
            // 
            // lblPasajero
            // 
            this.lblPasajero.Location = new System.Drawing.Point(6, 16);
            this.lblPasajero.Name = "lblPasajero";
            this.lblPasajero.Size = new System.Drawing.Size(64, 15);
            this.lblPasajero.TabIndex = 2;
            this.lblPasajero.Text = "Pasajero";
            // 
            // txtPasajero
            // 
            this.txtPasajero.Location = new System.Drawing.Point(76, 13);
            this.txtPasajero.Name = "txtPasajero";
            this.txtPasajero.Size = new System.Drawing.Size(227, 20);
            this.txtPasajero.TabIndex = 3;
            this.txtPasajero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPasajero_KeyDown);
            // 
            // btnAnotar
            // 
            this.btnAnotar.Location = new System.Drawing.Point(199, 39);
            this.btnAnotar.Name = "btnAnotar";
            this.btnAnotar.Size = new System.Drawing.Size(104, 23);
            this.btnAnotar.TabIndex = 4;
            this.btnAnotar.Text = "Anotar (Enter)";
            this.btnAnotar.UseVisualStyleBackColor = true;
            this.btnAnotar.Click += new System.EventHandler(this.btnAnotar_Click);
            // 
            // lstPasajeros
            // 
            this.lstPasajeros.HideSelection = false;
            this.lstPasajeros.Location = new System.Drawing.Point(333, 64);
            this.lstPasajeros.Name = "lstPasajeros";
            this.lstPasajeros.Size = new System.Drawing.Size(211, 279);
            this.lstPasajeros.TabIndex = 5;
            this.lstPasajeros.UseCompatibleStateImageBehavior = false;
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(330, 351);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(104, 23);
            this.btnSubir.TabIndex = 6;
            this.btnSubir.Text = "Abordar";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // btnViajar
            // 
            this.btnViajar.Location = new System.Drawing.Point(440, 351);
            this.btnViajar.Name = "btnViajar";
            this.btnViajar.Size = new System.Drawing.Size(104, 23);
            this.btnViajar.TabIndex = 7;
            this.btnViajar.Text = "Arrancar";
            this.btnViajar.UseVisualStyleBackColor = true;
            this.btnViajar.Click += new System.EventHandler(this.btnViajar_Click);
            // 
            // lblEspera
            // 
            this.lblEspera.AutoSize = true;
            this.lblEspera.Location = new System.Drawing.Point(330, 46);
            this.lblEspera.Name = "lblEspera";
            this.lblEspera.Size = new System.Drawing.Size(61, 13);
            this.lblEspera.TabIndex = 8;
            this.lblEspera.Text = "En espera: ";
            // 
            // lblInformacion
            // 
            this.lblInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.ForeColor = System.Drawing.Color.Red;
            this.lblInformacion.Location = new System.Drawing.Point(12, 236);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(312, 73);
            this.lblInformacion.TabIndex = 9;
            this.lblInformacion.Text = "Info";
            this.lblInformacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(12, 193);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(47, 13);
            this.lblUnidad.TabIndex = 10;
            this.lblUnidad.Text = "Unidad: ";
            // 
            // lblChofer
            // 
            this.lblChofer.AutoSize = true;
            this.lblChofer.Location = new System.Drawing.Point(168, 193);
            this.lblChofer.Name = "lblChofer";
            this.lblChofer.Size = new System.Drawing.Size(44, 13);
            this.lblChofer.TabIndex = 11;
            this.lblChofer.Text = "Chofer: ";
            // 
            // lblKilometraje
            // 
            this.lblKilometraje.AutoSize = true;
            this.lblKilometraje.Location = new System.Drawing.Point(12, 208);
            this.lblKilometraje.Name = "lblKilometraje";
            this.lblKilometraje.Size = new System.Drawing.Size(131, 13);
            this.lblKilometraje.TabIndex = 12;
            this.lblKilometraje.Text = "Kilometraje recorrido hoy:  ";
            // 
            // lblArribo
            // 
            this.lblArribo.AutoSize = true;
            this.lblArribo.Location = new System.Drawing.Point(12, 223);
            this.lblArribo.Name = "lblArribo";
            this.lblArribo.Size = new System.Drawing.Size(40, 13);
            this.lblArribo.TabIndex = 13;
            this.lblArribo.Text = "Arribo: ";
            // 
            // lblPartida
            // 
            this.lblPartida.AutoSize = true;
            this.lblPartida.Location = new System.Drawing.Point(168, 223);
            this.lblPartida.Name = "lblPartida";
            this.lblPartida.Size = new System.Drawing.Size(46, 13);
            this.lblPartida.TabIndex = 14;
            this.lblPartida.Text = "Partida: ";
            // 
            // grpVentanilla
            // 
            this.grpVentanilla.Controls.Add(this.btnEliminar);
            this.grpVentanilla.Controls.Add(this.lblPasajero);
            this.grpVentanilla.Controls.Add(this.txtPasajero);
            this.grpVentanilla.Controls.Add(this.btnAnotar);
            this.grpVentanilla.Location = new System.Drawing.Point(15, 312);
            this.grpVentanilla.Name = "grpVentanilla";
            this.grpVentanilla.Size = new System.Drawing.Size(309, 72);
            this.grpVentanilla.TabIndex = 15;
            this.grpVentanilla.TabStop = false;
            this.grpVentanilla.Text = "Ventanilla";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(9, 39);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(104, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Combi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(557, 396);
            this.Controls.Add(this.grpVentanilla);
            this.Controls.Add(this.lblPartida);
            this.Controls.Add(this.lblArribo);
            this.Controls.Add(this.lblKilometraje);
            this.Controls.Add(this.lblChofer);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.lblEspera);
            this.Controls.Add(this.btnViajar);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.lstPasajeros);
            this.Controls.Add(this.lblTerminal);
            this.Controls.Add(this.picCombi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Combi";
            this.Text = "Servicio de combis (ESC para salir)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Combi_FormClosing);
            this.Load += new System.EventHandler(this.Combi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCombi)).EndInit();
            this.grpVentanilla.ResumeLayout(false);
            this.grpVentanilla.PerformLayout();
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
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.Label lblChofer;
        private System.Windows.Forms.Label lblKilometraje;
        private System.Windows.Forms.Label lblArribo;
        private System.Windows.Forms.Label lblPartida;
        private System.Windows.Forms.GroupBox grpVentanilla;
        private System.Windows.Forms.Button btnEliminar;
    }
}

