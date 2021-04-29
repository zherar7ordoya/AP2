namespace TP01_Laboratorio2 {
  partial class frmMensajes {
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
      this.btnMensaje1 = new System.Windows.Forms.Button();
      this.btnMensaje2 = new System.Windows.Forms.Button();
      this.btnMensaje3 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnMensaje1
      // 
      this.btnMensaje1.Location = new System.Drawing.Point(12, 12);
      this.btnMensaje1.Name = "btnMensaje1";
      this.btnMensaje1.Size = new System.Drawing.Size(75, 23);
      this.btnMensaje1.TabIndex = 0;
      this.btnMensaje1.Text = "Mensaje 1";
      this.btnMensaje1.UseVisualStyleBackColor = true;
      this.btnMensaje1.Click += new System.EventHandler(this.btnMensaje1_Click);
      // 
      // btnMensaje2
      // 
      this.btnMensaje2.Location = new System.Drawing.Point(12, 41);
      this.btnMensaje2.Name = "btnMensaje2";
      this.btnMensaje2.Size = new System.Drawing.Size(75, 23);
      this.btnMensaje2.TabIndex = 1;
      this.btnMensaje2.Text = "Mensaje 2";
      this.btnMensaje2.UseVisualStyleBackColor = true;
      this.btnMensaje2.Click += new System.EventHandler(this.btnMensaje2_Click);
      // 
      // btnMensaje3
      // 
      this.btnMensaje3.Location = new System.Drawing.Point(12, 70);
      this.btnMensaje3.Name = "btnMensaje3";
      this.btnMensaje3.Size = new System.Drawing.Size(75, 23);
      this.btnMensaje3.TabIndex = 2;
      this.btnMensaje3.Text = "Mensaje 3";
      this.btnMensaje3.UseVisualStyleBackColor = true;
      this.btnMensaje3.Click += new System.EventHandler(this.btnMensaje3_Click);
      // 
      // frmMensajes
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(120, 114);
      this.Controls.Add(this.btnMensaje3);
      this.Controls.Add(this.btnMensaje2);
      this.Controls.Add(this.btnMensaje1);
      this.Name = "frmMensajes";
      this.Text = "Mensajes de Texto";
      this.Load += new System.EventHandler(this.frmMensajes_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnMensaje1;
    private System.Windows.Forms.Button btnMensaje2;
    private System.Windows.Forms.Button btnMensaje3;
  }
}