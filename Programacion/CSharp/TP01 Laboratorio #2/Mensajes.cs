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
  public partial class frmMensajes : Form {
    public frmMensajes() {
      InitializeComponent();
    }

    private void frmMensajes_Load(object sender, EventArgs e) {
      this.MaximizeBox = false;
      this.MinimizeBox = false;
    }

    private void btnMensaje1_Click(object sender, EventArgs e) {
      MessageBox.Show("Mensaje", "Título del mensaje");
    }

    private void btnMensaje2_Click(object sender, EventArgs e) {
      MessageBox.Show("Mensaje", "Título del mensaje", MessageBoxButtons.YesNo);
    }

    private void btnMensaje3_Click(object sender, EventArgs e) {
      MessageBox.Show("Mensaje", "Título del mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
    }
  }
}
