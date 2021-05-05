using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enunciado09 {
  public partial class Form1 : Form {

    public Form1() {
      InitializeComponent();
    }

    int tirada = 1, dado1 = 0, dado2 = 0;

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
      pictureBox2.Load("https://cdn1.iconfinder.com/data/icons/inked/100/Dice-512.png");
      estadisticas(true);
    }

    private void button1_Click(object sender, EventArgs e) {
      Random aleatorio = new Random();

      dado1 = aleatorio.Next(1, 7);
      dado2 = aleatorio.Next(1, 7);

      string url1 = imagen(dado1);
      string url2 = imagen(dado2);

      pictureBox1.Load(url1);
      pictureBox2.Load(url2);

      label1.Text = dado1.ToString();
      label2.Text = dado2.ToString();

      label3.Text = tirada.ToString();
      estadisticas(false);
      tirada++;
    }

    // *-----------------------------------------------------------=> FUNCIONES
    private string imagen(int dado) {

      switch (dado) {
        case 1:
          return "https://cdn2.iconfinder.com/data/icons/dice-roll/100/dice_1-512.png";
        case 2:
          return "https://cdn2.iconfinder.com/data/icons/dice-roll/100/dice_2-512.png";
        case 3:
          return "https://cdn2.iconfinder.com/data/icons/dice-roll/100/dice_3-512.png";
        case 4:
          return "https://cdn2.iconfinder.com/data/icons/dice-roll/100/dice_4-512.png";
        case 5:
          return "https://cdn2.iconfinder.com/data/icons/dice-roll/100/dice_5-512.png";
        case 6:
          return "https://cdn2.iconfinder.com/data/icons/dice-roll/100/dice_6-512.png";

        // Houston, we have a problem...
        default:
          MessageBox.Show("Algo inesperado sucedió", "Error");
          return "";
      }
    }

    private void estadisticas(bool inicializa) {
      // Default.
      if (inicializa) {
        for (int i = 0; i < 6; i++) {
          var index = dataGridView1.Rows.Add();
          dataGridView1.Rows[index].Cells["Dado"].Value = i + 1;
          dataGridView1.Rows[index].Cells["Cantidad"].Value = 0;
          dataGridView1.Rows[index].Cells["Porcentaje"].Value = "0 %";
        }
      } else {
        // Normal.
        int conteo1 = (int)dataGridView1.Rows[dado1-1].Cells["Cantidad"].Value;
        dataGridView1.Rows[dado1 - 1].Cells["Cantidad"].Value = conteo1 + 1;
        conteo1 = (int)dataGridView1.Rows[dado1 - 1].Cells["Cantidad"].Value;
        dataGridView1.Rows[dado1 - 1].Cells["Porcentaje"].Value = conteo1 * 100 / tirada / 2 + " %";

        int conteo2 = (int)dataGridView1.Rows[dado2-1].Cells["Cantidad"].Value;
        dataGridView1.Rows[dado2 - 1].Cells["Cantidad"].Value = conteo2 + 1;
        conteo2 = (int)dataGridView1.Rows[dado2 - 1].Cells["Cantidad"].Value;
        dataGridView1.Rows[dado2 - 1].Cells["Porcentaje"].Value = conteo2 * 100 / tirada / 2 + " %";
      }
    }
  }
}
