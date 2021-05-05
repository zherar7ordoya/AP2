using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enunciado07 {
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
    private void button1_Click(object sender, EventArgs e) {
      int numero1, numero2, numero3;
      string texto1 = textBox1.Text;
      string texto2 = textBox2.Text;
      string texto3 = textBox3.Text;
      bool correcto1 = Int32.TryParse(texto1, out numero1);
      bool correcto2 = Int32.TryParse(texto2, out numero2);
      bool correcto3 = Int32.TryParse(texto3, out numero3);

      if(correcto1 && correcto2 && correcto3) {
        var index = dataGridView1.Rows.Add();
        dataGridView1.Rows[index].Cells["Monto"].Value = numero1;
        dataGridView1.Rows[index].Cells["Tasa"].Value = numero2;
        dataGridView1.Rows[index].Cells["Dias"].Value = numero3;
        dataGridView1.Rows[index].Cells["Resultado"].Value = numero1 * numero2 * numero3 / 36500;
      }
    }
  }
}
