using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enunciado04 {
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

    // *---------------------------------------------------------=> OPERACIONES
    private void operador(string operacion) {
      // Verificación
      string texto1 = textBox1.Text;
      string texto2 = textBox2.Text;
      int numero1, numero2;
      bool correcto1 = Int32.TryParse(texto1, out numero1);
      bool correcto2 = Int32.TryParse(texto2, out numero2);

      // Procesamiento
      if (correcto1 && correcto2) {
        double resultado = 0;

        switch (operacion) {
          case "+":
            resultado = numero1 + numero2;
            MessageBox.Show(resultado.ToString(), "Resultado");
            break;

          case "-":
            resultado = numero1 - numero2;
            MessageBox.Show(resultado.ToString(), "Resultado");
            break;

          case "*":
            resultado = numero1 * numero2;
            MessageBox.Show(resultado.ToString(), "Resultado");
            break;

          case "/":
            resultado = numero1 / numero2;
            MessageBox.Show(resultado.ToString(), "Resultado");
            break;

          case "P":
            resultado = Math.Pow(numero1, numero2);
            MessageBox.Show(resultado.ToString(), "Resultado");
            break;

          case "R":
            resultado = Math.Sqrt(numero1);
            MessageBox.Show(resultado.ToString(), "La raíz cuadrada del 1er número es:");
            resultado = Math.Sqrt(numero2);
            MessageBox.Show(resultado.ToString(), "La raíz cuadrada del 2do número es:");
            break;

          // Houston, we have a problem...
          default:
            MessageBox.Show("Algo inesperado sucedió", "Error");
            break;
        }
      }
      else {
        MessageBox.Show("Uno de los valores ingresados no es correcto", "Error");
      }
    }

    // *------------------------------------------------------------=> BOTONERA
    private void button1_Click(object sender, EventArgs e) {
      operador("+");
    }
    private void button2_Click(object sender, EventArgs e) {
      operador("-");
    }
    private void button3_Click(object sender, EventArgs e) {
      operador("*");
    }
    private void button4_Click(object sender, EventArgs e) {
      operador("/");
    }
    private void button5_Click(object sender, EventArgs e) {
      operador("P");
    }
    private void button6_Click(object sender, EventArgs e) {
      operador("R");
    }
  }
}
