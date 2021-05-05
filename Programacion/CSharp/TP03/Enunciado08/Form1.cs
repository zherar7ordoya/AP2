using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enunciado08 {
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
      pictureBox1.Load("https://cdn1.iconfinder.com/data/icons/inked/100/Dice-512.png");
    }

    private void button1_Click(object sender, EventArgs e) {
      Random aleatorio = new Random();
      int dado = aleatorio.Next(1, 6);
      label1.Text = dado.ToString();

      switch (dado) {
        case 1:
          pictureBox1.Load("https://cdn2.iconfinder.com/data/icons/dice-roll/100/dice_1-512.png");
          break;
        case 2:
          pictureBox1.Load("https://cdn2.iconfinder.com/data/icons/dice-roll/100/dice_2-512.png");
          break;
        case 3:
          pictureBox1.Load("https://cdn2.iconfinder.com/data/icons/dice-roll/100/dice_3-512.png");
          break;
        case 4:
          pictureBox1.Load("https://cdn2.iconfinder.com/data/icons/dice-roll/100/dice_4-512.png");
          break;
        case 5:
          pictureBox1.Load("https://cdn2.iconfinder.com/data/icons/dice-roll/100/dice_5-512.png");
          break;
        case 6:
          pictureBox1.Load("https://cdn2.iconfinder.com/data/icons/dice-roll/100/dice_6-512.png");
          break;

        // Houston, we have a problem...
        default:
          MessageBox.Show("Algo inesperado sucedió", "Error");
          break;
      }
    }

  }
}
  