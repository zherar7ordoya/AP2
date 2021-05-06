namespace Enunciado10 {
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
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.comboBox2 = new System.Windows.Forms.ComboBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Hacia = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Equivalencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
      this.label0.TabIndex = 7;
      this.label0.Text = "PORTADA.------------";
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[] {
            "Celsius",
            "Fahrenheit",
            "Kelvin",
            "Rankine"});
      this.comboBox1.Location = new System.Drawing.Point(240, 12);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(75, 21);
      this.comboBox1.TabIndex = 8;
      this.comboBox1.Text = "Desde";
      this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
      // 
      // comboBox2
      // 
      this.comboBox2.FormattingEnabled = true;
      this.comboBox2.Items.AddRange(new object[] {
            "Celsius",
            "Fahrenheit",
            "Kelvin",
            "Rankine"});
      this.comboBox2.Location = new System.Drawing.Point(321, 12);
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new System.Drawing.Size(75, 21);
      this.comboBox2.TabIndex = 9;
      this.comboBox2.Text = "Hacia";
      this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(184, 12);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(50, 20);
      this.textBox1.TabIndex = 1;
      this.textBox1.Text = "Cantidad";
      this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.Red;
      this.label1.Location = new System.Drawing.Point(402, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(80, 13);
      this.label1.TabIndex = 11;
      this.label1.Text = "Equivalencia";
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Desde,
            this.Hacia,
            this.Equivalencia});
      this.dataGridView1.Location = new System.Drawing.Point(184, 39);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(286, 109);
      this.dataGridView1.TabIndex = 12;
      // 
      // Cantidad
      // 
      this.Cantidad.HeaderText = "Cantidad";
      this.Cantidad.Name = "Cantidad";
      this.Cantidad.Width = 50;
      // 
      // Desde
      // 
      this.Desde.HeaderText = "Desde";
      this.Desde.Name = "Desde";
      this.Desde.Width = 50;
      // 
      // Hacia
      // 
      this.Hacia.HeaderText = "Hacia";
      this.Hacia.Name = "Hacia";
      this.Hacia.Width = 50;
      // 
      // Equivalencia
      // 
      this.Equivalencia.HeaderText = "Equivalencia";
      this.Equivalencia.Name = "Equivalencia";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(480, 161);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.comboBox2);
      this.Controls.Add(this.comboBox1);
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
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.ComboBox comboBox2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    private System.Windows.Forms.DataGridViewTextBoxColumn Desde;
    private System.Windows.Forms.DataGridViewTextBoxColumn Hacia;
    private System.Windows.Forms.DataGridViewTextBoxColumn Equivalencia;
  }
}

