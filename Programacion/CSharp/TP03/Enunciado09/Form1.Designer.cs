namespace Enunciado09 {
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
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.label3 = new System.Windows.Forms.Label();
      this.Dado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
      this.label0.TabIndex = 6;
      this.label0.Text = "PORTADA.------------";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Location = new System.Drawing.Point(184, 10);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(200, 200);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 7;
      this.pictureBox1.TabStop = false;
      // 
      // pictureBox2
      // 
      this.pictureBox2.Location = new System.Drawing.Point(390, 10);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(200, 200);
      this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox2.TabIndex = 8;
      this.pictureBox2.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 82.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(224, 213);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(125, 124);
      this.label1.TabIndex = 9;
      this.label1.Text = "X";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 82.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(425, 213);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(125, 124);
      this.label2.TabIndex = 10;
      this.label2.Text = "X";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(21, 210);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(125, 125);
      this.button1.TabIndex = 11;
      this.button1.Text = "Tirar dados";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dado,
            this.Cantidad,
            this.Porcentaje});
      this.dataGridView1.Location = new System.Drawing.Point(596, 10);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(196, 200);
      this.dataGridView1.TabIndex = 12;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 85.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
      this.label3.Location = new System.Drawing.Point(596, 210);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(131, 128);
      this.label3.TabIndex = 13;
      this.label3.Text = "X";
      // 
      // Dado
      // 
      this.Dado.HeaderText = "Dado";
      this.Dado.Name = "Dado";
      this.Dado.Width = 50;
      // 
      // Cantidad
      // 
      this.Cantidad.HeaderText = "Cantidad";
      this.Cantidad.Name = "Cantidad";
      this.Cantidad.Width = 50;
      // 
      // Porcentaje
      // 
      this.Porcentaje.HeaderText = "Porcentaje";
      this.Porcentaje.Name = "Porcentaje";
      this.Porcentaje.Width = 50;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(799, 348);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.pictureBox2);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.label0);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label0;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Dado;
    private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
    private System.Windows.Forms.Label label3;
  }
}

