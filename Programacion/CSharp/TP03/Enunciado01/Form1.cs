using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enunciado01 {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) {
      string texto = Microsoft.VisualBasic.Interaction.InputBox(
        "Texto de la pregunta",
        "Titulo del diálogo",
        "Respuesta por defecto");
    }
  }
  }
}
