namespace AP1 {
  partial class AP1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.Portada = new System.Windows.Forms.TextBox();
      this.txtNombre = new System.Windows.Forms.TextBox();
      this.lblNombre = new System.Windows.Forms.Label();
      this.nmbNumero = new System.Windows.Forms.NumericUpDown();
      this.lblNumero = new System.Windows.Forms.Label();
      this.grpColores = new System.Windows.Forms.GroupBox();
      this.optAzul = new System.Windows.Forms.RadioButton();
      this.optRojo = new System.Windows.Forms.RadioButton();
      this.btnResultado = new System.Windows.Forms.Button();
      this.lblResultado = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.nmbNumero)).BeginInit();
      this.grpColores.SuspendLayout();
      this.SuspendLayout();
      // 
      // Portada
      // 
      this.Portada.BackColor = System.Drawing.Color.White;
      this.Portada.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.Portada.Enabled = false;
      this.Portada.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Portada.Location = new System.Drawing.Point(15, 123);
      this.Portada.Name = "Portada";
      this.Portada.ReadOnly = true;
      this.Portada.Size = new System.Drawing.Size(349, 13);
      this.Portada.TabIndex = 5;
      this.Portada.Text = "Gerardo Tordoya";
      this.Portada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // txtNombre
      // 
      this.txtNombre.Location = new System.Drawing.Point(115, 6);
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Size = new System.Drawing.Size(80, 20);
      this.txtNombre.TabIndex = 6;
      // 
      // lblNombre
      // 
      this.lblNombre.AutoSize = true;
      this.lblNombre.Location = new System.Drawing.Point(12, 9);
      this.lblNombre.Name = "lblNombre";
      this.lblNombre.Size = new System.Drawing.Size(97, 13);
      this.lblNombre.TabIndex = 7;
      this.lblNombre.Text = "Cargue un nombre:";
      this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // nmbNumero
      // 
      this.nmbNumero.Location = new System.Drawing.Point(324, 7);
      this.nmbNumero.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.nmbNumero.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
      this.nmbNumero.Name = "nmbNumero";
      this.nmbNumero.Size = new System.Drawing.Size(40, 20);
      this.nmbNumero.TabIndex = 8;
      this.nmbNumero.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // lblNumero
      // 
      this.lblNumero.AutoSize = true;
      this.lblNumero.Location = new System.Drawing.Point(221, 9);
      this.lblNumero.Name = "lblNumero";
      this.lblNumero.Size = new System.Drawing.Size(97, 13);
      this.lblNumero.TabIndex = 9;
      this.lblNumero.Text = "Cargue un número:";
      this.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // grpColores
      // 
      this.grpColores.Controls.Add(this.optRojo);
      this.grpColores.Controls.Add(this.optAzul);
      this.grpColores.Location = new System.Drawing.Point(12, 32);
      this.grpColores.Name = "grpColores";
      this.grpColores.Size = new System.Drawing.Size(352, 51);
      this.grpColores.TabIndex = 10;
      this.grpColores.TabStop = false;
      this.grpColores.Text = "Colores";
      // 
      // optAzul
      // 
      this.optAzul.AutoSize = true;
      this.optAzul.Location = new System.Drawing.Point(103, 19);
      this.optAzul.Name = "optAzul";
      this.optAzul.Size = new System.Drawing.Size(45, 17);
      this.optAzul.TabIndex = 0;
      this.optAzul.TabStop = true;
      this.optAzul.Text = "Azul";
      this.optAzul.UseVisualStyleBackColor = true;
      // 
      // optRojo
      // 
      this.optRojo.AutoSize = true;
      this.optRojo.Location = new System.Drawing.Point(212, 19);
      this.optRojo.Name = "optRojo";
      this.optRojo.Size = new System.Drawing.Size(47, 17);
      this.optRojo.TabIndex = 1;
      this.optRojo.TabStop = true;
      this.optRojo.Text = "Rojo";
      this.optRojo.UseVisualStyleBackColor = true;
      // 
      // btnResultado
      // 
      this.btnResultado.Location = new System.Drawing.Point(289, 91);
      this.btnResultado.Name = "btnResultado";
      this.btnResultado.Size = new System.Drawing.Size(75, 23);
      this.btnResultado.TabIndex = 11;
      this.btnResultado.Text = "Resultado";
      this.btnResultado.UseVisualStyleBackColor = true;
      this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
      // 
      // lblResultado
      // 
      this.lblResultado.AutoSize = true;
      this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblResultado.Location = new System.Drawing.Point(10, 86);
      this.lblResultado.Name = "lblResultado";
      this.lblResultado.Size = new System.Drawing.Size(110, 26);
      this.lblResultado.TabIndex = 12;
      this.lblResultado.Text = "Resultado";
      this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // AP1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(375, 148);
      this.Controls.Add(this.lblResultado);
      this.Controls.Add(this.btnResultado);
      this.Controls.Add(this.grpColores);
      this.Controls.Add(this.lblNumero);
      this.Controls.Add(this.nmbNumero);
      this.Controls.Add(this.lblNombre);
      this.Controls.Add(this.txtNombre);
      this.Controls.Add(this.Portada);
      this.Name = "AP1";
      this.Text = "AP1";
      this.Load += new System.EventHandler(this.AP1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.nmbNumero)).EndInit();
      this.grpColores.ResumeLayout(false);
      this.grpColores.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox Portada;
    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.Label lblNombre;
    private System.Windows.Forms.NumericUpDown nmbNumero;
    private System.Windows.Forms.Label lblNumero;
    private System.Windows.Forms.GroupBox grpColores;
    private System.Windows.Forms.RadioButton optRojo;
    private System.Windows.Forms.RadioButton optAzul;
    private System.Windows.Forms.Button btnResultado;
    private System.Windows.Forms.Label lblResultado;
  }
}

