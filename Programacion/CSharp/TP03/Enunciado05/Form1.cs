using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enunciado05 {
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
      primado();
    }
    private void textBox2_TextChanged(object sender, EventArgs e) {
      primado();
    }
    // *-----------------------------------------------------------=> PRINCIPAL
    private void primado() {
      // Verificación
      string texto1 = textBox1.Text;
      string texto2 = textBox2.Text;
      int numero1, numero2;
      bool correcto1 = Int32.TryParse(texto1, out numero1);
      bool correcto2 = Int32.TryParse(texto2, out numero2);

      // Procesamiento
      if (correcto1 && correcto2) {
        // Haz tu magia.
        listBox1.Items.Clear();
        for (int i = numero1; i <= numero2; i++) {
          if (isPrime(i)) {
            listBox1.Items.Add(i);
          }
        }
      }
      else {
        MessageBox.Show("Uno de los valores ingresados no es correcto", "Error");
      }
    }

    public static bool isPrime(int number) {
      if (number == 1) return false;
      if (number == 2 || number == 3 || number == 5) return true;
      if (number % 2 == 0 || number % 3 == 0 || number % 5 == 0) return false;

      var boundary = (int)Math.Floor(Math.Sqrt(number));

      // You can do less work by observing that at this point, all primes 
      // other than 2 and 3 leave a remainder of either 1 or 5 when divided by 6. 
      // The other possible remainders have been taken care of.
      /*
      int i = 6; // start from 6, since others below have been handled.
      while (i <= boundary) {
        if (number % (i + 1) == 0 || number % (i + 5) == 0)
          return false;

        i += 6;
      }
      */
      for (int i = 6; i <= boundary; i += 6) {
        if (number % (i + 1) == 0 || number % (i + 5) == 0) return false;
      }

        return true;
    }
  }
}
