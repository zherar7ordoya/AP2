using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enunciado02 {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {
      // *-----------------------------------------------------------------=> *
      label0.Text = "Gerardo Tordoya" + Environment.NewLine +
                    "2021-05-03" + Environment.NewLine +
                    "Trabajo Práctico 3" + Environment.NewLine +
                    "Programación I" + Environment.NewLine +
                    "Comisión 1-O-N" + Environment.NewLine +
                    "Analista Programador" + Environment.NewLine +
                    "UAI 2021";
      // this.ControlBox = false;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      // *-----------------------------------------------------------------=> *

    }

    private void sumador() {
      string texto1 = textBox1.Text;
      string texto2 = textBox2.Text;
      int numero1, numero2;
      bool correcto1 = Int32.TryParse(texto1, out numero1);
      bool correcto2 = Int32.TryParse(texto2, out numero2);
      if (correcto1 && correcto2) {
        int resultado = numero1 + numero2;
        label1.Text = resultado.ToString();
      }
    }

    private void textBox1_TextChanged(object sender, EventArgs e) {
      sumador();
    }
    private void textBox2_TextChanged(object sender, EventArgs e) {
      sumador();
    }
  }
}
