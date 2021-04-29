namespace TP01_Laboratorio2 {
  partial class frmVectoresCarga {
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
      this.btnEjecutar = new System.Windows.Forms.Button();
      this.btnSalir = new System.Windows.Forms.Button();
      this.lst1 = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // btnEjecutar
      // 
      this.btnEjecutar.Location = new System.Drawing.Point(12, 12);
      this.btnEjecutar.Name = "btnEjecutar";
      this.btnEjecutar.Size = new System.Drawing.Size(200, 23);
      this.btnEjecutar.TabIndex = 0;
      this.btnEjecutar.Text = "Cargar";
      this.btnEjecutar.UseVisualStyleBackColor = true;
      this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
      // 
      // btnSalir
      // 
      this.btnSalir.Location = new System.Drawing.Point(12, 194);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new System.Drawing.Size(200, 23);
      this.btnSalir.TabIndex = 1;
      this.btnSalir.Text = "Salir";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
      // 
      // lst1
      // 
      this.lst1.FormattingEnabled = true;
      this.lst1.Location = new System.Drawing.Point(12, 41);
      this.lst1.Name = "lst1";
      this.lst1.Size = new System.Drawing.Size(200, 147);
      this.lst1.TabIndex = 2;
      this.lst1.Tag = "";
      // 
      // frmVectoresCarga
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(222, 229);
      this.Controls.Add(this.lst1);
      this.Controls.Add(this.btnSalir);
      this.Controls.Add(this.btnEjecutar);
      this.Name = "frmVectoresCarga";
      this.Text = "Carga de Vectores";
      this.Load += new System.EventHandler(this.frmVectoresCarga_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnEjecutar;
    private System.Windows.Forms.Button btnSalir;
    private System.Windows.Forms.ListBox lst1;
  }
}

