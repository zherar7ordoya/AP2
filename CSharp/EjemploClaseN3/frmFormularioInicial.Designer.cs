namespace EjemploClaseN3.Winform1
{
    partial class frmFormularioInicial
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
            this.btnAbrirForm2 = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnSaludar = new System.Windows.Forms.Button();
            this.numProgresoActual = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnCambiarFuente = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.bntCambiarColor = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnAbrirCarpetas = new System.Windows.Forms.Button();
            this.cmdAbrirForm3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numProgresoActual)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbrirForm2
            // 
            this.btnAbrirForm2.Location = new System.Drawing.Point(79, 95);
            this.btnAbrirForm2.Name = "btnAbrirForm2";
            this.btnAbrirForm2.Size = new System.Drawing.Size(206, 60);
            this.btnAbrirForm2.TabIndex = 0;
            this.btnAbrirForm2.Text = "Abrir formulario 2";
            this.btnAbrirForm2.UseVisualStyleBackColor = true;
            this.btnAbrirForm2.Click += new System.EventHandler(this.btnAbrirForm2_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(79, 244);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(366, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(76, 213);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(126, 17);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Ingrese su nombre";
            // 
            // btnSaludar
            // 
            this.btnSaludar.Location = new System.Drawing.Point(79, 290);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(160, 51);
            this.btnSaludar.TabIndex = 3;
            this.btnSaludar.Text = "Saludar!";
            this.btnSaludar.UseVisualStyleBackColor = true;
            this.btnSaludar.Click += new System.EventHandler(this.btnSaludar_Click);
            // 
            // numProgresoActual
            // 
            this.numProgresoActual.Location = new System.Drawing.Point(79, 417);
            this.numProgresoActual.Name = "numProgresoActual";
            this.numProgresoActual.Size = new System.Drawing.Size(284, 22);
            this.numProgresoActual.TabIndex = 4;
            this.numProgresoActual.ValueChanged += new System.EventHandler(this.numProgresoActual_ValueChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(79, 471);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(544, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // btnCambiarFuente
            // 
            this.btnCambiarFuente.Location = new System.Drawing.Point(74, 554);
            this.btnCambiarFuente.Name = "btnCambiarFuente";
            this.btnCambiarFuente.Size = new System.Drawing.Size(153, 51);
            this.btnCambiarFuente.TabIndex = 6;
            this.btnCambiarFuente.Text = "Cambiar fuente";
            this.btnCambiarFuente.UseVisualStyleBackColor = true;
            this.btnCambiarFuente.Click += new System.EventHandler(this.btnCambiarFuente_Click);
            // 
            // bntCambiarColor
            // 
            this.bntCambiarColor.Location = new System.Drawing.Point(247, 554);
            this.bntCambiarColor.Name = "bntCambiarColor";
            this.bntCambiarColor.Size = new System.Drawing.Size(158, 51);
            this.bntCambiarColor.TabIndex = 7;
            this.bntCambiarColor.Text = "Cambiar color";
            this.bntCambiarColor.UseVisualStyleBackColor = true;
            this.bntCambiarColor.Click += new System.EventHandler(this.bntCambiarColor_Click);
            // 
            // btnAbrirCarpetas
            // 
            this.btnAbrirCarpetas.Location = new System.Drawing.Point(422, 554);
            this.btnAbrirCarpetas.Name = "btnAbrirCarpetas";
            this.btnAbrirCarpetas.Size = new System.Drawing.Size(149, 51);
            this.btnAbrirCarpetas.TabIndex = 8;
            this.btnAbrirCarpetas.Text = "Abrir carpetas";
            this.btnAbrirCarpetas.UseVisualStyleBackColor = true;
            this.btnAbrirCarpetas.Click += new System.EventHandler(this.btnAbrirCarpetas_Click);
            // 
            // cmdAbrirForm3
            // 
            this.cmdAbrirForm3.Location = new System.Drawing.Point(316, 96);
            this.cmdAbrirForm3.Name = "cmdAbrirForm3";
            this.cmdAbrirForm3.Size = new System.Drawing.Size(189, 58);
            this.cmdAbrirForm3.TabIndex = 9;
            this.cmdAbrirForm3.Text = "Abrir formulario 3";
            this.cmdAbrirForm3.UseVisualStyleBackColor = true;
            this.cmdAbrirForm3.Click += new System.EventHandler(this.cmdAbrirForm3_Click);
            // 
            // frmFormularioInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(840, 642);
            this.Controls.Add(this.cmdAbrirForm3);
            this.Controls.Add(this.btnAbrirCarpetas);
            this.Controls.Add(this.bntCambiarColor);
            this.Controls.Add(this.btnCambiarFuente);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.numProgresoActual);
            this.Controls.Add(this.btnSaludar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnAbrirForm2);
            this.Name = "frmFormularioInicial";
            this.Text = "Formulario 1";
            this.Load += new System.EventHandler(this.frmFormularioInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numProgresoActual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirForm2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnSaludar;
        private System.Windows.Forms.NumericUpDown numProgresoActual;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnCambiarFuente;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button bntCambiarColor;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnAbrirCarpetas;
        private System.Windows.Forms.Button cmdAbrirForm3;
    }
}

