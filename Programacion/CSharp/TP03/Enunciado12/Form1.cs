using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enunciado12 {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }
    private void Form1_Load(object sender, EventArgs e) {
      // this.ControlBox = false;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      CambiarColor();
    }
    private void button1_Click(object sender, EventArgs e) {
      CambiarColor();
    }
    private void CambiarColor() {
      colorDialog1.ShowDialog();
      this.BackColor = colorDialog1.Color;
      Portada.BackColor = colorDialog1.Color;
    }
  }
}
