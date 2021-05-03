namespace TP01_Laboratorio2 {
  partial class frmDateTimePicker3 {
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
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.label2 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.btnSumar = new System.Windows.Forms.Button();
      this.btnRestar = new System.Windows.Forms.Button();
      this.btnSalir = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(40, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Fecha:";
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.Location = new System.Drawing.Point(100, 10);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
      this.dateTimePicker1.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 39);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(33, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Días:";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(51, 36);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(50, 20);
      this.textBox1.TabIndex = 3;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(200, 36);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(100, 20);
      this.textBox2.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(139, 39);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(55, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Resultado";
      // 
      // btnSumar
      // 
      this.btnSumar.Location = new System.Drawing.Point(15, 62);
      this.btnSumar.Name = "btnSumar";
      this.btnSumar.Size = new System.Drawing.Size(75, 23);
      this.btnSumar.TabIndex = 6;
      this.btnSumar.Text = "Sumar";
      this.btnSumar.UseVisualStyleBackColor = true;
      this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
      // 
      // btnRestar
      // 
      this.btnRestar.Location = new System.Drawing.Point(120, 62);
      this.btnRestar.Name = "btnRestar";
      this.btnRestar.Size = new System.Drawing.Size(75, 23);
      this.btnRestar.TabIndex = 7;
      this.btnRestar.Text = "Restar";
      this.btnRestar.UseVisualStyleBackColor = true;
      this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
      // 
      // btnSalir
      // 
      this.btnSalir.Location = new System.Drawing.Point(225, 62);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new System.Drawing.Size(75, 23);
      this.btnSalir.TabIndex = 8;
      this.btnSalir.Text = "Salir";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
      // 
      // frmDateTimePicker3
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(313, 101);
      this.Controls.Add(this.btnSalir);
      this.Controls.Add(this.btnRestar);
      this.Controls.Add(this.btnSumar);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.dateTimePicker1);
      this.Controls.Add(this.label1);
      this.Name = "frmDateTimePicker3";
      this.Text = "Parte C (Formulario 3)";
      this.Load += new System.EventHandler(this.frmDateTimePicker3_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnSumar;
    private System.Windows.Forms.Button btnRestar;
    private System.Windows.Forms.Button btnSalir;
  }
}