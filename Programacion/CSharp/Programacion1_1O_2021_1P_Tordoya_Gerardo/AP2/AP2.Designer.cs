namespace AP2 {
  partial class AP2 {
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
      this.lstCola = new System.Windows.Forms.ListBox();
      this.txtNodo = new System.Windows.Forms.TextBox();
      this.btnEncolar = new System.Windows.Forms.Button();
      this.btnDesencolar = new System.Windows.Forms.Button();
      this.Portada = new System.Windows.Forms.TextBox();
      this.lblContador = new System.Windows.Forms.Label();
      this.btnUltimo = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lstCola
      // 
      this.lstCola.FormattingEnabled = true;
      this.lstCola.Location = new System.Drawing.Point(12, 44);
      this.lstCola.Name = "lstCola";
      this.lstCola.Size = new System.Drawing.Size(100, 95);
      this.lstCola.TabIndex = 3;
      // 
      // txtNodo
      // 
      this.txtNodo.Location = new System.Drawing.Point(12, 145);
      this.txtNodo.Name = "txtNodo";
      this.txtNodo.Size = new System.Drawing.Size(100, 20);
      this.txtNodo.TabIndex = 0;
      this.txtNodo.Text = "Escriba un nombre";
      // 
      // btnEncolar
      // 
      this.btnEncolar.Location = new System.Drawing.Point(12, 171);
      this.btnEncolar.Name = "btnEncolar";
      this.btnEncolar.Size = new System.Drawing.Size(100, 23);
      this.btnEncolar.TabIndex = 1;
      this.btnEncolar.Text = "Encolar";
      this.btnEncolar.UseVisualStyleBackColor = true;
      this.btnEncolar.Click += new System.EventHandler(this.btnEncolar_Click);
      // 
      // btnDesencolar
      // 
      this.btnDesencolar.Location = new System.Drawing.Point(12, 200);
      this.btnDesencolar.Name = "btnDesencolar";
      this.btnDesencolar.Size = new System.Drawing.Size(100, 23);
      this.btnDesencolar.TabIndex = 2;
      this.btnDesencolar.Text = "Desencolar";
      this.btnDesencolar.UseVisualStyleBackColor = true;
      this.btnDesencolar.Click += new System.EventHandler(this.btnDesencolar_Click);
      // 
      // Portada
      // 
      this.Portada.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.Portada.Enabled = false;
      this.Portada.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Portada.Location = new System.Drawing.Point(12, 258);
      this.Portada.Name = "Portada";
      this.Portada.ReadOnly = true;
      this.Portada.Size = new System.Drawing.Size(100, 13);
      this.Portada.TabIndex = 4;
      this.Portada.Text = "Gerardo Tordoya";
      this.Portada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // lblContador
      // 
      this.lblContador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblContador.Location = new System.Drawing.Point(12, 9);
      this.lblContador.Name = "lblContador";
      this.lblContador.Size = new System.Drawing.Size(100, 32);
      this.lblContador.TabIndex = 5;
      this.lblContador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btnUltimo
      // 
      this.btnUltimo.Location = new System.Drawing.Point(12, 229);
      this.btnUltimo.Name = "btnUltimo";
      this.btnUltimo.Size = new System.Drawing.Size(100, 23);
      this.btnUltimo.TabIndex = 6;
      this.btnUltimo.Text = "Último";
      this.btnUltimo.UseVisualStyleBackColor = true;
      this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
      // 
      // AP2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(124, 284);
      this.Controls.Add(this.btnUltimo);
      this.Controls.Add(this.lblContador);
      this.Controls.Add(this.Portada);
      this.Controls.Add(this.btnDesencolar);
      this.Controls.Add(this.btnEncolar);
      this.Controls.Add(this.txtNodo);
      this.Controls.Add(this.lstCola);
      this.Name = "AP2";
      this.Text = "AP2";
      this.Load += new System.EventHandler(this.AP2_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox lstCola;
    private System.Windows.Forms.TextBox txtNodo;
    private System.Windows.Forms.Button btnEncolar;
    private System.Windows.Forms.Button btnDesencolar;
    private System.Windows.Forms.TextBox Portada;
    private System.Windows.Forms.Label lblContador;
    private System.Windows.Forms.Button btnUltimo;
  }
}

