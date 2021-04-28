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
  public partial class frmGroupboxes : Form {
    // *----------------------------------------------------------=> FORMULARIO
    public frmGroupboxes() {
      InitializeComponent();
    }
    private void Groupboxes_Load(object sender, EventArgs e) {
      this.ControlBox = false;
    }


    // *---------------------------------------------------------=> OPERACIONES

    private void btn1_Click(object sender, EventArgs e) {
      if (opt1.Checked == true) {
        lst1.Items.Add(txt1.Text);
        opt1.Checked = false;
      }
      if (opt2.Checked == true) {
        lst1.Items.Add(txt2.Text);
        opt2.Checked = false;
      }
    }

    private void btn2_Click(object sender, EventArgs e) {
      Close();
    }
  }
}
