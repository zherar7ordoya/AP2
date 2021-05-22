namespace Ejercicio1 {
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
      this.PayoffTable = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.PayoffTable)).BeginInit();
      this.SuspendLayout();
      // 
      // PayoffTable
      // 
      this.PayoffTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.PayoffTable.Location = new System.Drawing.Point(12, 12);
      this.PayoffTable.Name = "PayoffTable";
      this.PayoffTable.Size = new System.Drawing.Size(400, 200);
      this.PayoffTable.TabIndex = 1;
      // 
      // Pacientes
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(424, 233);
      this.Controls.Add(this.PayoffTable);
      this.Name = "Pacientes";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Pacientes_Load);
      ((System.ComponentModel.ISupportInitialize)(this.PayoffTable)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.DataGridView PayoffTable;
  }
}

