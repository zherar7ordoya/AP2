﻿namespace Ejercicio1 {
  partial class Pacientes {
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
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.listView1 = new System.Windows.Forms.ListView();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(12, 12);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(400, 200);
      this.dataGridView1.TabIndex = 0;
      // 
      // listView1
      // 
      this.listView1.HideSelection = false;
      this.listView1.Location = new System.Drawing.Point(513, 81);
      this.listView1.Name = "listView1";
      this.listView1.Size = new System.Drawing.Size(121, 97);
      this.listView1.TabIndex = 1;
      this.listView1.UseCompatibleStateImageBehavior = false;
      // 
      // Pacientes
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(691, 229);
      this.Controls.Add(this.listView1);
      this.Controls.Add(this.dataGridView1);
      this.Name = "Pacientes";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Pacientes_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.ListView listView1;
  }
}

