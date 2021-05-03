namespace Formulario {
  partial class frmMain {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.menuBoxes = new System.Windows.Forms.ToolStripMenuItem();
      this.menuCalculadora = new System.Windows.Forms.ToolStripMenuItem();
      this.menuCheckboxes = new System.Windows.Forms.ToolStripMenuItem();
      this.menuGroupboxes = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip
      // 
      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
      this.menuStrip.Location = new System.Drawing.Point(0, 0);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Size = new System.Drawing.Size(404, 24);
      this.menuStrip.TabIndex = 1;
      this.menuStrip.Text = "TP1 Laboratorio 1";
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBoxes,
            this.menuCalculadora,
            this.menuCheckboxes,
            this.menuGroupboxes});
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(111, 20);
      this.toolStripMenuItem1.Text = "TP1 Laboratorio 1";
      // 
      // menuBoxes
      // 
      this.menuBoxes.Name = "menuBoxes";
      this.menuBoxes.Size = new System.Drawing.Size(138, 22);
      this.menuBoxes.Text = "Boxes";
      this.menuBoxes.Click += new System.EventHandler(this.menuBoxes_Click);
      // 
      // menuCalculadora
      // 
      this.menuCalculadora.Name = "menuCalculadora";
      this.menuCalculadora.Size = new System.Drawing.Size(138, 22);
      this.menuCalculadora.Text = "Calculadora";
      this.menuCalculadora.Click += new System.EventHandler(this.menuCalculadora_Click);
      // 
      // menuCheckboxes
      // 
      this.menuCheckboxes.Name = "menuCheckboxes";
      this.menuCheckboxes.Size = new System.Drawing.Size(138, 22);
      this.menuCheckboxes.Text = "Checkboxes";
      this.menuCheckboxes.Click += new System.EventHandler(this.menuCheckboxes_Click);
      // 
      // menuGroupboxes
      // 
      this.menuGroupboxes.Name = "menuGroupboxes";
      this.menuGroupboxes.Size = new System.Drawing.Size(138, 22);
      this.menuGroupboxes.Text = "Groupboxes";
      this.menuGroupboxes.Click += new System.EventHandler(this.menuGroupboxes_Click);
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.ClientSize = new System.Drawing.Size(404, 431);
      this.Controls.Add(this.menuStrip);
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.menuStrip;
      this.Name = "frmMain";
      this.Text = "Main";
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem menuBoxes;
    private System.Windows.Forms.ToolStripMenuItem menuCalculadora;
    private System.Windows.Forms.ToolStripMenuItem menuCheckboxes;
    private System.Windows.Forms.ToolStripMenuItem menuGroupboxes;
  }
}