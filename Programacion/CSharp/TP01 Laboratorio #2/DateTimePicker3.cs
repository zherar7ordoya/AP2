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
  public partial class frmDateTimePicker3 : Form {
    public frmDateTimePicker3() {
      InitializeComponent();
    }

    private void frmDateTimePicker3_Load(object sender, EventArgs e) {
      this.ControlBox = false;
      // this.MaximizeBox = false;
      // this.MinimizeBox = false;
      System.Console.WriteLine("No te preocupes por mí. Solo ignórame...");
    }

    private void btnSalir_Click(object sender, EventArgs e) {
      Application.Exit();
    }

    private void btnSumar_Click(object sender, EventArgs e) {
      DateTime fecha1 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
      textBox2.Text = (fecha1.AddDays(Convert.ToInt32(textBox1.Text)).ToString("dd/MM/yyyy")).ToString();
    }

    private void btnRestar_Click(object sender, EventArgs e) {
      DateTime fecha1 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
      textBox2.Text = (fecha1.AddDays(-1 * Convert.ToInt32(textBox1.Text)).ToString("dd/MM/yyyy")).ToString();
    }
  }
}
