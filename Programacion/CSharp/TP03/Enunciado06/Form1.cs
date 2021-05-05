using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enunciado06 {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {
      // *-----------------------------------------------------------------=> *
      label0.Text = "PORTADA.------------" + Environment.NewLine +
                    "2021-05-05" + Environment.NewLine +
                    "Gerardo Tordoya" + Environment.NewLine +
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
    // *-------------------------------------------------------------=> EVENTOS
    private void textBox1_TextChanged(object sender, EventArgs e) {
      fibonacci();
    }
    // *-----------------------------------------------------------=> PRINCIPAL
    private void fibonacci() {
      int numero1, n1 = 0, n2 = 1, n3;
      // Verificación
      string texto1 = textBox1.Text;
      bool correcto1 = Int32.TryParse(texto1, out numero1);

      // Procesamiento
      if (correcto1) {
        // Haz tu magia.
        listBox1.Items.Clear();

        if(numero1 > 2) {
          listBox1.Items.Add(n1);
          listBox1.Items.Add(n2);
        }

        for (int i = 2; i < numero1; i++) {
          n3 = n1 + n2;
          listBox1.Items.Add(n3);
          n1 = n2;
          n2 = n3;
        }
      }
    }
  }
}
