﻿namespace Enunciado07 {
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Tasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
      this.label0.TabIndex = 4;
      this.label0.Text = "PORTADA.------------";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(184, 11);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(55, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "M=Monto:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(184, 41);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(118, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "T=Tasa Nominal Anual:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(184, 67);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(47, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "D=Días:";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(308, 8);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(100, 20);
      this.textBox1.TabIndex = 8;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(308, 38);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(100, 20);
      this.textBox2.TabIndex = 9;
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(308, 64);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(100, 20);
      this.textBox3.TabIndex = 10;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(414, 6);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 11;
      this.button1.Text = "Calcular";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Monto,
            this.Tasa,
            this.Dias,
            this.Resultado});
      this.dataGridView1.Location = new System.Drawing.Point(186, 90);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(302, 375);
      this.dataGridView1.TabIndex = 12;
      // 
      // Monto
      // 
      this.Monto.HeaderText = "M";
      this.Monto.Name = "Monto";
      this.Monto.Width = 50;
      // 
      // Tasa
      // 
      this.Tasa.HeaderText = "T";
      this.Tasa.Name = "Tasa";
      this.Tasa.Width = 50;
      // 
      // Dias
      // 
      this.Dias.HeaderText = "Días";
      this.Dias.Name = "Dias";
      this.Dias.Width = 50;
      // 
      // Resultado
      // 
      this.Resultado.HeaderText = "Resultado";
      this.Resultado.Name = "Resultado";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(500, 477);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.label0);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label0;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
    private System.Windows.Forms.DataGridViewTextBoxColumn Tasa;
    private System.Windows.Forms.DataGridViewTextBoxColumn Dias;
    private System.Windows.Forms.DataGridViewTextBoxColumn Resultado;
  }
}

