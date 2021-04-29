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
  public partial class frmCronometro : Form {
    public frmCronometro() {
      InitializeComponent();
    }
    int hora = 0, min = 0, seg = 0;

    private void frmCronometro_Load(object sender, EventArgs e) {
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      System.Console.WriteLine("No te preocupes por mí. Solo ignórame...");
    }



    private void btnComenzar_Click(object sender, EventArgs e) {
      timer1.Enabled = true; // habilito el timer 
    }



    private void btnParar_Click(object sender, EventArgs e) {
      timer1.Enabled = false;
    }


    private void btnIniciar_Click(object sender, EventArgs e) {
      timer1.Enabled = false;
      label1.Text = "00:00:00";
      seg = 0;
      min = 0;
      hora = 0;
    }

    private void timer1_Tick(object sender, EventArgs e) {
      seg++;
      if (seg == 60) {
        min++;
        seg = 0;
      }
      else if (min == 60) {
        hora++;
        min = 0;
      }

      label1.Text = hora.ToString().PadLeft(2, '0') + ":" + min.ToString().PadLeft(2, '0') + ":" + seg.ToString().PadLeft(2, '0');
    }
    /* Método String.PadLeft (Int32, Char) 
    Devuelve una nueva cadena que alinea a la derecha los caracteres de la     
  instancia e inserta a la izquierda un carácter Unicode especificado 
          hasta alcanzar la longitud total especificada. */
  }

}

