using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP01_Laboratorio2 {
  public partial class frmProgreso : Form {
    public frmProgreso() {
      InitializeComponent();
    }
    private void frmProgreso_Load(object sender, EventArgs e) {
      this.ControlBox = false;
    }
    private void btnComenzar_Click(object sender, EventArgs e) {
      long contador;
      //  Inicializo el valor inicial del ProgressBar 
      progressBar1.Value = 0;
      // Valor maximo para el ProgressBar 
      progressBar1.Maximum = 100;
      while ((progressBar1.Value < progressBar1.Maximum)) {
        progressBar1.Value++;
        // Bucle para simular el delay, esto es mejor hacerlo con hilos  
        for (contador = 1; (contador <= 1000000); contador++) {
          // Nada...
        }

      }
    }
    private void btnSalir_Click(object sender, EventArgs e) {
      Application.Exit();
    }
  }
}
