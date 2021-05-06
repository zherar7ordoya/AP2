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
  public partial class frmCheckboxes : Form {
    // *----------------------------------------------------------=> FORMULARIO
    public frmCheckboxes() {
      InitializeComponent();
    }
    private void frmCheckboxes_Load(object sender, EventArgs e) {
      this.ControlBox = false;
    }
    private void btnSalir_Click(object sender, EventArgs e) {
      Close();
    }

    // *---------------------------------------------------------=> OPERACIONES
    private void btnEjecutar_Click(object sender, EventArgs e) {
      if ((this.chk1.Checked == true) & (this.chk2.Checked == false)) {
        lbl1.BackColor = Color.Aquamarine;
        lbl2.BackColor = Color.Beige;
        lbl3.BackColor = Color.Black;
      }
      else if ((chk1.Checked == false) & (chk2.Checked == true)) {
        lbl1.BackColor = Color.Green;
        lbl2.BackColor = Color.LightPink;
        lbl3.BackColor = Color.Linen;
      }
      else if ((chk1.Checked == true) & (chk2.Checked == true)) {
        lbl1.BackColor = Color.Blue;
        lbl2.BackColor = Color.White;
        lbl3.BackColor = Color.Blue;
      }
    }
    // *-------------------------------------------------------------------=> *
  }
}
