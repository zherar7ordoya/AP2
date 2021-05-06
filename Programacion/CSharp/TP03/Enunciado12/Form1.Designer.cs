namespace Enunciado12 {
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
      this.Portada = new System.Windows.Forms.TextBox();
      this.colorDialog1 = new System.Windows.Forms.ColorDialog();
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // Portada
      // 
      this.Portada.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.Portada.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Portada.Location = new System.Drawing.Point(12, 12);
      this.Portada.Multiline = true;
      this.Portada.Name = "Portada";
      this.Portada.ReadOnly = true;
      this.Portada.Size = new System.Drawing.Size(500, 30);
      this.Portada.TabIndex = 2;
      this.Portada.Text = "Práctico 3 || 2021-05-06\r\nGerardo Tordoya || Comisión 1-ON || Programación 1 || A" +
    "nalista Programador || UAI";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(12, 189);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(500, 30);
      this.button1.TabIndex = 1;
      this.button1.Text = "Tócame suavemente...";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(524, 231);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.Portada);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox Portada;
    private System.Windows.Forms.ColorDialog colorDialog1;
    private System.Windows.Forms.Button button1;
  }
}

