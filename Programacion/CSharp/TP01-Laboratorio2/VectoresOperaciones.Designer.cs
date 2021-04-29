namespace TP01_Laboratorio2 {
  partial class frmVectoresOperaciones {
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
      this.Lst1 = new System.Windows.Forms.ListBox();
      this.btnOrdenar = new System.Windows.Forms.Button();
      this.btnCopiar = new System.Windows.Forms.Button();
      this.btnLimites = new System.Windows.Forms.Button();
      this.btnBusqueda = new System.Windows.Forms.Button();
      this.btnSalir = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnEjecutar
      // 
      this.btnEjecutar.Location = new System.Drawing.Point(93, 12);
      this.btnEjecutar.Name = "btnEjecutar";
      this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
      this.btnEjecutar.TabIndex = 0;
      this.btnEjecutar.Text = "Cargar";
      this.btnEjecutar.UseVisualStyleBackColor = true;
      this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
      // 
      // Lst1
      // 
      this.Lst1.FormattingEnabled = true;
      this.Lst1.Location = new System.Drawing.Point(12, 41);
      this.Lst1.Name = "Lst1";
      this.Lst1.Size = new System.Drawing.Size(237, 199);
      this.Lst1.TabIndex = 1;
      // 
      // btnOrdenar
      // 
      this.btnOrdenar.Location = new System.Drawing.Point(12, 246);
      this.btnOrdenar.Name = "btnOrdenar";
      this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
      this.btnOrdenar.TabIndex = 2;
      this.btnOrdenar.Text = "Ordenar";
      this.btnOrdenar.UseVisualStyleBackColor = true;
      this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
      // 
      // btnCopiar
      // 
      this.btnCopiar.Location = new System.Drawing.Point(174, 246);
      this.btnCopiar.Name = "btnCopiar";
      this.btnCopiar.Size = new System.Drawing.Size(75, 23);
      this.btnCopiar.TabIndex = 3;
      this.btnCopiar.Text = "Copiar";
      this.btnCopiar.UseVisualStyleBackColor = true;
      this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
      // 
      // btnLimites
      // 
      this.btnLimites.Location = new System.Drawing.Point(12, 275);
      this.btnLimites.Name = "btnLimites";
      this.btnLimites.Size = new System.Drawing.Size(75, 23);
      this.btnLimites.TabIndex = 4;
      this.btnLimites.Text = "Límites";
      this.btnLimites.UseVisualStyleBackColor = true;
      this.btnLimites.Click += new System.EventHandler(this.btnLimites_Click);
      // 
      // btnBusqueda
      // 
      this.btnBusqueda.Location = new System.Drawing.Point(174, 275);
      this.btnBusqueda.Name = "btnBusqueda";
      this.btnBusqueda.Size = new System.Drawing.Size(75, 23);
      this.btnBusqueda.TabIndex = 5;
      this.btnBusqueda.Text = "Búsq Binaria";
      this.btnBusqueda.UseVisualStyleBackColor = true;
      this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
      // 
      // btnSalir
      // 
      this.btnSalir.Location = new System.Drawing.Point(93, 304);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new System.Drawing.Size(75, 23);
      this.btnSalir.TabIndex = 6;
      this.btnSalir.Text = "Salir";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
      // 
      // frmVectoresOperaciones
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(260, 340);
      this.Controls.Add(this.btnSalir);
      this.Controls.Add(this.btnBusqueda);
      this.Controls.Add(this.btnLimites);
      this.Controls.Add(this.btnCopiar);
      this.Controls.Add(this.btnOrdenar);
      this.Controls.Add(this.Lst1);
      this.Controls.Add(this.btnEjecutar);
      this.Name = "frmVectoresOperaciones";
      this.Text = "Operaciones con Vectores";
      this.Load += new System.EventHandler(this.frmVectoresOperaciones_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnEjecutar;
    private System.Windows.Forms.ListBox Lst1;
    private System.Windows.Forms.Button btnOrdenar;
    private System.Windows.Forms.Button btnCopiar;
    private System.Windows.Forms.Button btnLimites;
    private System.Windows.Forms.Button btnBusqueda;
    private System.Windows.Forms.Button btnSalir;
  }
}