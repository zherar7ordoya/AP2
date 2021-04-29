namespace TP01_Laboratorio2 {
  partial class frmDesplazamiento {
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
      this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
      this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // hScrollBar1
      // 
      this.hScrollBar1.Location = new System.Drawing.Point(144, 20);
      this.hScrollBar1.Name = "hScrollBar1";
      this.hScrollBar1.Size = new System.Drawing.Size(100, 20);
      this.hScrollBar1.TabIndex = 0;
      this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
      // 
      // vScrollBar1
      // 
      this.vScrollBar1.Location = new System.Drawing.Point(144, 56);
      this.vScrollBar1.Name = "vScrollBar1";
      this.vScrollBar1.Size = new System.Drawing.Size(20, 100);
      this.vScrollBar1.TabIndex = 1;
      this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(129, 31);
      this.label1.TabIndex = 2;
      this.label1.Text = "Horizontal";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(41, 56);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(100, 31);
      this.label2.TabIndex = 3;
      this.label2.Text = "Vertical";
      // 
      // frmDesplazamiento
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(252, 170);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.vScrollBar1);
      this.Controls.Add(this.hScrollBar1);
      this.Name = "frmDesplazamiento";
      this.Text = "Barras de Desplazamiento";
      this.Load += new System.EventHandler(this.frmDesplazamiento_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.HScrollBar hScrollBar1;
    private System.Windows.Forms.VScrollBar vScrollBar1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
  }
}