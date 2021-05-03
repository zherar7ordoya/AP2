namespace Formulario {
  partial class frmCheckboxes {
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
      this.chk1 = new System.Windows.Forms.CheckBox();
      this.chk2 = new System.Windows.Forms.CheckBox();
      this.lbl1 = new System.Windows.Forms.Label();
      this.lbl2 = new System.Windows.Forms.Label();
      this.lbl3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnEjecutar
      // 
      this.btnEjecutar.Location = new System.Drawing.Point(15, 162);
      this.btnEjecutar.Name = "btnEjecutar";
      this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
      this.btnEjecutar.TabIndex = 0;
      this.btnEjecutar.Text = "Ejecutar";
      this.btnEjecutar.UseVisualStyleBackColor = true;
      this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
      // 
      // btnSalir
      // 
      this.btnSalir.Location = new System.Drawing.Point(117, 162);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new System.Drawing.Size(75, 23);
      this.btnSalir.TabIndex = 1;
      this.btnSalir.Text = "Salir";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
      // 
      // chk1
      // 
      this.chk1.AutoSize = true;
      this.chk1.Location = new System.Drawing.Point(15, 120);
      this.chk1.Name = "chk1";
      this.chk1.Size = new System.Drawing.Size(84, 17);
      this.chk1.TabIndex = 2;
      this.chk1.Text = "1ra elección";
      this.chk1.UseVisualStyleBackColor = true;
      // 
      // chk2
      // 
      this.chk2.AutoSize = true;
      this.chk2.Location = new System.Drawing.Point(105, 120);
      this.chk2.Name = "chk2";
      this.chk2.Size = new System.Drawing.Size(87, 17);
      this.chk2.TabIndex = 3;
      this.chk2.Text = "2da elección";
      this.chk2.UseVisualStyleBackColor = true;
      // 
      // lbl1
      // 
      this.lbl1.AutoSize = true;
      this.lbl1.BackColor = System.Drawing.Color.Red;
      this.lbl1.Location = new System.Drawing.Point(15, 15);
      this.lbl1.Name = "lbl1";
      this.lbl1.Size = new System.Drawing.Size(172, 13);
      this.lbl1.TabIndex = 4;
      this.lbl1.Text = "- - - - - - - - - - - - - - - - - - - - - - - - - - - -";
      // 
      // lbl2
      // 
      this.lbl2.AutoSize = true;
      this.lbl2.BackColor = System.Drawing.Color.Red;
      this.lbl2.Location = new System.Drawing.Point(15, 45);
      this.lbl2.Name = "lbl2";
      this.lbl2.Size = new System.Drawing.Size(172, 13);
      this.lbl2.TabIndex = 5;
      this.lbl2.Text = "- - - - - - - - - - - - - - - - - - - - - - - - - - - -";
      // 
      // lbl3
      // 
      this.lbl3.AutoSize = true;
      this.lbl3.BackColor = System.Drawing.Color.Red;
      this.lbl3.Location = new System.Drawing.Point(15, 75);
      this.lbl3.Name = "lbl3";
      this.lbl3.Size = new System.Drawing.Size(172, 13);
      this.lbl3.TabIndex = 6;
      this.lbl3.Text = "- - - - - - - - - - - - - - - - - - - - - - - - - - - -";
      // 
      // frmCheckboxes
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(204, 202);
      this.Controls.Add(this.lbl3);
      this.Controls.Add(this.lbl2);
      this.Controls.Add(this.lbl1);
      this.Controls.Add(this.chk2);
      this.Controls.Add(this.chk1);
      this.Controls.Add(this.btnSalir);
      this.Controls.Add(this.btnEjecutar);
      this.Name = "frmCheckboxes";
      this.Text = "Checkboxes";
      this.Load += new System.EventHandler(this.frmCheckboxes_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnEjecutar;
    private System.Windows.Forms.Button btnSalir;
    private System.Windows.Forms.CheckBox chk1;
    private System.Windows.Forms.CheckBox chk2;
    private System.Windows.Forms.Label lbl1;
    private System.Windows.Forms.Label lbl2;
    private System.Windows.Forms.Label lbl3;
  }
}