namespace TP10 {
  partial class Form1 {
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txtleg = new System.Windows.Forms.TextBox();
      this.txtapynom = new System.Windows.Forms.TextBox();
      this.txtcat = new System.Windows.Forms.TextBox();
      this.btnAlta = new System.Windows.Forms.Button();
      this.btnBaja = new System.Windows.Forms.Button();
      this.btnModificar = new System.Windows.Forms.Button();
      this.btnSalir = new System.Windows.Forms.Button();
      this.lstlistado = new System.Windows.Forms.ListView();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(55, 28);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "legajo";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(58, 75);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(89, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "apellido y nombre";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(58, 125);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(53, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "categoría";
      // 
      // txtleg
      // 
      this.txtleg.Location = new System.Drawing.Point(153, 28);
      this.txtleg.Name = "txtleg";
      this.txtleg.Size = new System.Drawing.Size(223, 20);
      this.txtleg.TabIndex = 3;
      // 
      // txtapynom
      // 
      this.txtapynom.Location = new System.Drawing.Point(153, 72);
      this.txtapynom.Name = "txtapynom";
      this.txtapynom.Size = new System.Drawing.Size(223, 20);
      this.txtapynom.TabIndex = 4;
      // 
      // txtcat
      // 
      this.txtcat.Location = new System.Drawing.Point(153, 122);
      this.txtcat.Name = "txtcat";
      this.txtcat.Size = new System.Drawing.Size(223, 20);
      this.txtcat.TabIndex = 5;
      // 
      // btnAlta
      // 
      this.btnAlta.Location = new System.Drawing.Point(58, 328);
      this.btnAlta.Name = "btnAlta";
      this.btnAlta.Size = new System.Drawing.Size(75, 23);
      this.btnAlta.TabIndex = 7;
      this.btnAlta.Text = "Alta";
      this.btnAlta.UseVisualStyleBackColor = true;
      this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
      // 
      // btnBaja
      // 
      this.btnBaja.Location = new System.Drawing.Point(139, 328);
      this.btnBaja.Name = "btnBaja";
      this.btnBaja.Size = new System.Drawing.Size(75, 23);
      this.btnBaja.TabIndex = 8;
      this.btnBaja.Text = "Baja";
      this.btnBaja.UseVisualStyleBackColor = true;
      this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
      // 
      // btnModificar
      // 
      this.btnModificar.Location = new System.Drawing.Point(220, 328);
      this.btnModificar.Name = "btnModificar";
      this.btnModificar.Size = new System.Drawing.Size(75, 23);
      this.btnModificar.TabIndex = 9;
      this.btnModificar.Text = "Modificación";
      this.btnModificar.UseVisualStyleBackColor = true;
      this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
      // 
      // btnSalir
      // 
      this.btnSalir.Location = new System.Drawing.Point(301, 328);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new System.Drawing.Size(75, 23);
      this.btnSalir.TabIndex = 10;
      this.btnSalir.Text = "Salir";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
      // 
      // lstlistado
      // 
      this.lstlistado.FullRowSelect = true;
      this.lstlistado.HideSelection = false;
      this.lstlistado.Location = new System.Drawing.Point(58, 189);
      this.lstlistado.Name = "lstlistado";
      this.lstlistado.Size = new System.Drawing.Size(318, 97);
      this.lstlistado.TabIndex = 11;
      this.lstlistado.UseCompatibleStateImageBehavior = false;
      this.lstlistado.Click += new System.EventHandler(this.lstlistado_Click_1);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(422, 392);
      this.Controls.Add(this.lstlistado);
      this.Controls.Add(this.btnSalir);
      this.Controls.Add(this.btnModificar);
      this.Controls.Add(this.btnBaja);
      this.Controls.Add(this.btnAlta);
      this.Controls.Add(this.txtcat);
      this.Controls.Add(this.txtapynom);
      this.Controls.Add(this.txtleg);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "archivo secuencial";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtleg;
    private System.Windows.Forms.TextBox txtapynom;
    private System.Windows.Forms.TextBox txtcat;
    private System.Windows.Forms.Button btnAlta;
    private System.Windows.Forms.Button btnBaja;
    private System.Windows.Forms.Button btnModificar;
    private System.Windows.Forms.Button btnSalir;
    private System.Windows.Forms.ListView lstlistado;
  }
}

