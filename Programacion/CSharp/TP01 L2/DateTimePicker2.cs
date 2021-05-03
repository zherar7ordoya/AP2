using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP01_Laboratorio2 {
  public partial class frmDateTimePicker2 : Form {
    public frmDateTimePicker2() {
      InitializeComponent();
    }

    private void frmDateTimePicker2_Load(object sender, EventArgs e) {
      // this.ControlBox = false;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      System.Console.WriteLine("No te preocupes por mí. Solo ignórame...");
    }

    private void btnDiferencia_Click(object sender, EventArgs e) {
      DateTime fecha1 = this.dateTimePicker1.Value;
      DateTime fecha2 = this.dateTimePicker2.Value;
      textBox1.Text = fecha1.Subtract(fecha2).ToString();
    }
  }
}
