﻿namespace TP01_Laboratorio2 {
  partial class frmProgreso {
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
      this.btnComenzar = new System.Windows.Forms.Button();
      this.btnSalir = new System.Windows.Forms.Button();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.SuspendLayout();
      // 
      // btnComenzar
      // 
      this.btnComenzar.Location = new System.Drawing.Point(50, 12);
      this.btnComenzar.Name = "btnComenzar";
      this.btnComenzar.Size = new System.Drawing.Size(76, 23);
      this.btnComenzar.TabIndex = 0;
      this.btnComenzar.Text = "Comenzar";
      this.btnComenzar.UseVisualStyleBackColor = true;
      this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
      // 
      // btnSalir
      // 
      this.btnSalir.Location = new System.Drawing.Point(50, 70);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new System.Drawing.Size(76, 23);
      this.btnSalir.TabIndex = 1;
      this.btnSalir.Text = "Salir";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(12, 41);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(152, 23);
      this.progressBar1.TabIndex = 2;
      // 
      // frmProgreso
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(170, 104);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.btnSalir);
      this.Controls.Add(this.btnComenzar);
      this.Name = "frmProgreso";
      this.Text = "Barra de Progreso";
      this.Load += new System.EventHandler(this.frmProgreso_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnComenzar;
    private System.Windows.Forms.Button btnSalir;
    private System.Windows.Forms.ProgressBar progressBar1;
  }
}