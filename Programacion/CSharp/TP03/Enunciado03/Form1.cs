using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enunciado03 {
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

    List<int> Listado = new List<int>();

    private void button1_Click(object sender, EventArgs e) {
      string texto = textBox1.Text;
      int numero;
      bool correcto = Int32.TryParse(texto, out numero);
      if (correcto) {
        Listado.Add(numero);
        int posicion = Listado.Count - 1;
        string anterior = label2.Text;
        label2.Text = anterior + Environment.NewLine + Listado[posicion];
      } else {
        MessageBox.Show("Debe ingresar un número entero", "Error");
      }
    }
  }
}
