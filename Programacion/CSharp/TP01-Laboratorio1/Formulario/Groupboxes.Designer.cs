namespace Formulario {
  partial class frmGroupboxes {
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
      this.lbl1 = new System.Windows.Forms.Label();
      this.lbl2 = new System.Windows.Forms.Label();
      this.txt1 = new System.Windows.Forms.TextBox();
      this.txt2 = new System.Windows.Forms.TextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.opt1 = new System.Windows.Forms.RadioButton();
      this.opt2 = new System.Windows.Forms.RadioButton();
      this.btn1 = new System.Windows.Forms.Button();
      this.btn2 = new System.Windows.Forms.Button();
      this.lst1 = new System.Windows.Forms.ListBox();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // lbl1
      // 
      this.lbl1.AutoSize = true;
      this.lbl1.Location = new System.Drawing.Point(12, 9);
      this.lbl1.Name = "lbl1";
      this.lbl1.Size = new System.Drawing.Size(48, 13);
      this.lbl1.TabIndex = 0;
      this.lbl1.Text = "1er valor";
      // 
      // lbl2
      // 
      this.lbl2.AutoSize = true;
      this.lbl2.Location = new System.Drawing.Point(12, 33);
      this.lbl2.Name = "lbl2";
      this.lbl2.Size = new System.Drawing.Size(51, 13);
      this.lbl2.TabIndex = 1;
      this.lbl2.Text = "2do valor";
      // 
      // txt1
      // 
      this.txt1.Location = new System.Drawing.Point(66, 6);
      this.txt1.Name = "txt1";
      this.txt1.Size = new System.Drawing.Size(100, 20);
      this.txt1.TabIndex = 2;
      // 
      // txt2
      // 
      this.txt2.Location = new System.Drawing.Point(66, 30);
      this.txt2.Name = "txt2";
      this.txt2.Size = new System.Drawing.Size(100, 20);
      this.txt2.TabIndex = 3;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.opt1);
      this.groupBox1.Location = new System.Drawing.Point(12, 56);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(154, 47);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "1ra selección";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.opt2);
      this.groupBox2.Location = new System.Drawing.Point(12, 109);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(154, 47);
      this.groupBox2.TabIndex = 5;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "2da selección";
      // 
      // opt1
      // 
      this.opt1.AutoSize = true;
      this.opt1.Location = new System.Drawing.Point(6, 19);
      this.opt1.Name = "opt1";
      this.opt1.Size = new System.Drawing.Size(66, 17);
      this.opt1.TabIndex = 0;
      this.opt1.TabStop = true;
      this.opt1.Text = "1er valor";
      this.opt1.UseVisualStyleBackColor = true;
      // 
      // opt2
      // 
      this.opt2.AutoSize = true;
      this.opt2.Location = new System.Drawing.Point(6, 19);
      this.opt2.Name = "opt2";
      this.opt2.Size = new System.Drawing.Size(69, 17);
      this.opt2.TabIndex = 0;
      this.opt2.TabStop = true;
      this.opt2.Text = "2do valor";
      this.opt2.UseVisualStyleBackColor = true;
      // 
      // btn1
      // 
      this.btn1.Location = new System.Drawing.Point(12, 162);
      this.btn1.Name = "btn1";
      this.btn1.Size = new System.Drawing.Size(75, 23);
      this.btn1.TabIndex = 6;
      this.btn1.Text = "Mostrar";
      this.btn1.UseVisualStyleBackColor = true;
      this.btn1.Click += new System.EventHandler(this.btn1_Click);
      // 
      // btn2
      // 
      this.btn2.Location = new System.Drawing.Point(91, 162);
      this.btn2.Name = "btn2";
      this.btn2.Size = new System.Drawing.Size(75, 23);
      this.btn2.TabIndex = 7;
      this.btn2.Text = "Salir";
      this.btn2.UseVisualStyleBackColor = true;
      this.btn2.Click += new System.EventHandler(this.btn2_Click);
      // 
      // lst1
      // 
      this.lst1.FormattingEnabled = true;
      this.lst1.Location = new System.Drawing.Point(12, 191);
      this.lst1.Name = "lst1";
      this.lst1.Size = new System.Drawing.Size(154, 43);
      this.lst1.TabIndex = 8;
      // 
      // frmGroupboxes
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(173, 242);
      this.Controls.Add(this.lst1);
      this.Controls.Add(this.btn2);
      this.Controls.Add(this.btn1);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.txt2);
      this.Controls.Add(this.txt1);
      this.Controls.Add(this.lbl2);
      this.Controls.Add(this.lbl1);
      this.Name = "frmGroupboxes";
      this.Text = "Groupboxes";
      this.Load += new System.EventHandler(this.Groupboxes_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lbl1;
    private System.Windows.Forms.Label lbl2;
    private System.Windows.Forms.TextBox txt1;
    private System.Windows.Forms.TextBox txt2;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton opt1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.RadioButton opt2;
    private System.Windows.Forms.Button btn1;
    private System.Windows.Forms.Button btn2;
    private System.Windows.Forms.ListBox lst1;
  }
}