﻿namespace Enunciado08 {
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
      this.label0 = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.button1 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // label0
      // 
      this.label0.AutoSize = true;
      this.label0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label0.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label0.Location = new System.Drawing.Point(10, 10);
      this.label0.Margin = new System.Windows.Forms.Padding(1);
      this.label0.Name = "label0";
      this.label0.Size = new System.Drawing.Size(170, 19);
      this.label0.TabIndex = 5;
      this.label0.Text = "PORTADA.------------";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Location = new System.Drawing.Point(184, 10);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(500, 500);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pictureBox1.TabIndex = 6;
      this.pictureBox1.TabStop = false;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(10, 487);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(168, 23);
      this.button1.TabIndex = 7;
      this.button1.Text = "Tirar dado";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 106F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 323);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(163, 161);
      this.label1.TabIndex = 8;
      this.label1.Text = "X";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(699, 543);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.label0);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label0;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label1;
  }
}

