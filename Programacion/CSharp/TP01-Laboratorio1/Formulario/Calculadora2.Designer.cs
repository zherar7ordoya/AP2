namespace Formulario {
  partial class frmCalculadora2 {
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
      this.btnLimpiar = new System.Windows.Forms.Button();
      this.btnIf = new System.Windows.Forms.Button();
      this.btnSwitch = new System.Windows.Forms.Button();
      this.btnSalir = new System.Windows.Forms.Button();
      this.lbl1 = new System.Windows.Forms.Label();
      this.lbl2 = new System.Windows.Forms.Label();
      this.lbl3 = new System.Windows.Forms.Label();
      this.txt1 = new System.Windows.Forms.TextBox();
      this.txt2 = new System.Windows.Forms.TextBox();
      this.txtRta = new System.Windows.Forms.TextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.optCoc = new System.Windows.Forms.RadioButton();
      this.optProd = new System.Windows.Forms.RadioButton();
      this.optResta = new System.Windows.Forms.RadioButton();
      this.optSuma = new System.Windows.Forms.RadioButton();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnLimpiar
      // 
      this.btnLimpiar.Location = new System.Drawing.Point(113, 87);
      this.btnLimpiar.Name = "btnLimpiar";
      this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
      this.btnLimpiar.TabIndex = 0;
      this.btnLimpiar.Text = "Limpiar";
      this.btnLimpiar.UseVisualStyleBackColor = true;
      this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
      // 
      // btnIf
      // 
      this.btnIf.Location = new System.Drawing.Point(15, 192);
      this.btnIf.Name = "btnIf";
      this.btnIf.Size = new System.Drawing.Size(80, 23);
      this.btnIf.TabIndex = 1;
      this.btnIf.Text = "Con IF";
      this.btnIf.UseVisualStyleBackColor = true;
      this.btnIf.Click += new System.EventHandler(this.btnIf_Click);
      // 
      // btnSwitch
      // 
      this.btnSwitch.Location = new System.Drawing.Point(108, 192);
      this.btnSwitch.Name = "btnSwitch";
      this.btnSwitch.Size = new System.Drawing.Size(80, 23);
      this.btnSwitch.TabIndex = 2;
      this.btnSwitch.Text = "Con SWITCH";
      this.btnSwitch.UseVisualStyleBackColor = true;
      this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
      // 
      // btnSalir
      // 
      this.btnSalir.Location = new System.Drawing.Point(113, 221);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new System.Drawing.Size(75, 23);
      this.btnSalir.TabIndex = 3;
      this.btnSalir.Text = "Salir";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
      // 
      // lbl1
      // 
      this.lbl1.AutoSize = true;
      this.lbl1.Location = new System.Drawing.Point(12, 12);
      this.lbl1.Name = "lbl1";
      this.lbl1.Size = new System.Drawing.Size(67, 13);
      this.lbl1.TabIndex = 4;
      this.lbl1.Text = "1er operador";
      // 
      // lbl2
      // 
      this.lbl2.AutoSize = true;
      this.lbl2.Location = new System.Drawing.Point(12, 38);
      this.lbl2.Name = "lbl2";
      this.lbl2.Size = new System.Drawing.Size(70, 13);
      this.lbl2.TabIndex = 5;
      this.lbl2.Text = "2do operador";
      // 
      // lbl3
      // 
      this.lbl3.AutoSize = true;
      this.lbl3.Location = new System.Drawing.Point(12, 64);
      this.lbl3.Name = "lbl3";
      this.lbl3.Size = new System.Drawing.Size(55, 13);
      this.lbl3.TabIndex = 6;
      this.lbl3.Text = "Resultado";
      // 
      // txt1
      // 
      this.txt1.Location = new System.Drawing.Point(88, 9);
      this.txt1.Name = "txt1";
      this.txt1.Size = new System.Drawing.Size(100, 20);
      this.txt1.TabIndex = 7;
      // 
      // txt2
      // 
      this.txt2.Location = new System.Drawing.Point(88, 35);
      this.txt2.Name = "txt2";
      this.txt2.Size = new System.Drawing.Size(100, 20);
      this.txt2.TabIndex = 8;
      // 
      // txtRta
      // 
      this.txtRta.Location = new System.Drawing.Point(88, 61);
      this.txtRta.Name = "txtRta";
      this.txtRta.Size = new System.Drawing.Size(100, 20);
      this.txtRta.TabIndex = 9;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.optCoc);
      this.groupBox1.Controls.Add(this.optProd);
      this.groupBox1.Controls.Add(this.optResta);
      this.groupBox1.Controls.Add(this.optSuma);
      this.groupBox1.Location = new System.Drawing.Point(15, 116);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(173, 70);
      this.groupBox1.TabIndex = 10;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Operaciones";
      // 
      // optCoc
      // 
      this.optCoc.AutoSize = true;
      this.optCoc.Location = new System.Drawing.Point(6, 42);
      this.optCoc.Name = "optCoc";
      this.optCoc.Size = new System.Drawing.Size(67, 17);
      this.optCoc.TabIndex = 3;
      this.optCoc.TabStop = true;
      this.optCoc.Text = "Cociente";
      this.optCoc.UseVisualStyleBackColor = true;
      // 
      // optProd
      // 
      this.optProd.AutoSize = true;
      this.optProd.Location = new System.Drawing.Point(98, 42);
      this.optProd.Name = "optProd";
      this.optProd.Size = new System.Drawing.Size(68, 17);
      this.optProd.TabIndex = 2;
      this.optProd.TabStop = true;
      this.optProd.Text = "Producto";
      this.optProd.UseVisualStyleBackColor = true;
      // 
      // optResta
      // 
      this.optResta.AutoSize = true;
      this.optResta.Location = new System.Drawing.Point(98, 19);
      this.optResta.Name = "optResta";
      this.optResta.Size = new System.Drawing.Size(53, 17);
      this.optResta.TabIndex = 1;
      this.optResta.TabStop = true;
      this.optResta.Text = "Resta";
      this.optResta.UseVisualStyleBackColor = true;
      // 
      // optSuma
      // 
      this.optSuma.AutoSize = true;
      this.optSuma.Checked = true;
      this.optSuma.Location = new System.Drawing.Point(15, 19);
      this.optSuma.Name = "optSuma";
      this.optSuma.Size = new System.Drawing.Size(52, 17);
      this.optSuma.TabIndex = 0;
      this.optSuma.TabStop = true;
      this.optSuma.Text = "Suma";
      this.optSuma.UseVisualStyleBackColor = true;
      // 
      // frmCalculadora2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(203, 253);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.txtRta);
      this.Controls.Add(this.txt2);
      this.Controls.Add(this.txt1);
      this.Controls.Add(this.lbl3);
      this.Controls.Add(this.lbl2);
      this.Controls.Add(this.lbl1);
      this.Controls.Add(this.btnSalir);
      this.Controls.Add(this.btnSwitch);
      this.Controls.Add(this.btnIf);
      this.Controls.Add(this.btnLimpiar);
      this.Name = "frmCalculadora2";
      this.Text = "Calculadora con Radio-Botón";
      this.Load += new System.EventHandler(this.Calculadora2_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnLimpiar;
    private System.Windows.Forms.Button btnIf;
    private System.Windows.Forms.Button btnSwitch;
    private System.Windows.Forms.Button btnSalir;
    private System.Windows.Forms.Label lbl1;
    private System.Windows.Forms.Label lbl2;
    private System.Windows.Forms.Label lbl3;
    private System.Windows.Forms.TextBox txt1;
    private System.Windows.Forms.TextBox txt2;
    private System.Windows.Forms.TextBox txtRta;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton optCoc;
    private System.Windows.Forms.RadioButton optProd;
    private System.Windows.Forms.RadioButton optResta;
    private System.Windows.Forms.RadioButton optSuma;
  }
}