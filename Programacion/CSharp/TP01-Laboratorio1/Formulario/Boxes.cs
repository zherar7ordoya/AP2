/**
 * @author: Gerardo Tordoya
 * @date: 2021-04-22
 * @project: 
 *          Asignación: TP 1 (Laboratorio #1)
 *          Materia:    Programación 1
 *          Comisión:   1-O-N
 *          Carrera:    Analista Programador
 * UAI 2021
 */
 
 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario {
  public partial class frmBoxes : Form {
    // *----------------------------------------------------------=> FORMULARIO
    public frmBoxes() {
      InitializeComponent();
    }
    private void Calculadora2_Load(object sender, EventArgs e) {
      this.ControlBox = false;
    }
    private void limpiar() {
      this.txt1.Text = null;
      this.txt2.Text = null;
      this.txtRta.Text = null;
      this.txt1.Focus();
    }
    private void btnLimpiar_Click(object sender, EventArgs e) {
      limpiar();
    }
    private void btnSalir_Click(object sender, EventArgs e) {
      Close();
    }


    // *---------------------------------------------------------=> OPERACIONES
    private void btnIf_Click(object sender, EventArgs e) {
      if (this.optResta.Checked) {
        this.txtRta.Text = (Int32.Parse(txt1.Text) - Int32.Parse(txt2.Text)).ToString();
      }
      if (this.optSuma.Checked) {
        this.txtRta.Text = (Int32.Parse(txt1.Text) - Int32.Parse(this.txt2.Text)).ToString();
      }
      if (optCoc.Checked) {
        if (Int32.Parse(this.txt2.Text) != 0) {
          this.txtRta.Text = (Int32.Parse(this.txt1.Text) / Int32.Parse(this.txt2.Text)).ToString();
        }
      }
      if (optProd.Checked) {
        this.txtRta.Text = (Convert.ToInt32(this.txt1.Text) * Convert.ToInt32(this.txt2.Text)).ToString();
      }
      if (this.optSuma.Checked) {
        this.txtRta.Text = (Convert.ToInt32(this.txt1.Text) + Convert.ToInt32(this.txt2.Text)).ToString();
      }
    }
    private void btnSwitch_Click(object sender, EventArgs e) {
      bool mayor_cero = true; int opcion = 0;

      if (this.txt1.Text != null && this.txt2.Text != null) {
        if (Int32.Parse(this.txt2.Text) != 0) {
          mayor_cero = true;
        }
        else {
          mayor_cero = false;
        }

        if (this.optSuma.Checked) opcion = 1;
        if (this.optResta.Checked) opcion = 2;
        if (this.optProd.Checked) opcion = 3;
        if (this.optCoc.Checked) {
          if (mayor_cero) opcion = 4;
        }

        switch (opcion) {
          case 1:
            this.txtRta.Text = (Int32.Parse(txt1.Text) + Int32.Parse(this.txt2.Text)).ToString();
            break;

          case 2:
            this.txtRta.Text = (Int32.Parse(txt1.Text) - Int32.Parse(txt2.Text)).ToString();
            break;

          case 3:
            this.txtRta.Text = (Int32.Parse(this.txt1.Text) * Int32.Parse(this.txt2.Text)).ToString();
            break;

          case 4:
            this.txtRta.Text = (Int32.Parse(this.txt1.Text) / Int32.Parse(this.txt2.Text)).ToString();
            break;

          default:
            string mensaje = "La operación no se puede realizar";
            string titulo = "Importante";
            MessageBoxButtons botones = MessageBoxButtons.YesNo; DialogResult resultado;
            resultado = MessageBox.Show(mensaje, titulo, botones);
            if (resultado == System.Windows.Forms.DialogResult.Yes) {
              limpiar();
            }
            break;
        }
      }
    }
  }
}
