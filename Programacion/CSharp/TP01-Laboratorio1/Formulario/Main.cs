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
  public partial class frmMain : Form {
    public frmMain() {
      InitializeComponent();
    }

    private void menuBoxes_Click(object sender, EventArgs e) {
      //Creo el formulario que deseo mostrar 
      frmBoxes formBoxes = new frmBoxes();
      //Digo que es Hijo del MDI 
      formBoxes.MdiParent = this;
      //Muestro el form 
      formBoxes.Show();
    }

    private void menuCalculadora_Click(object sender, EventArgs e) {
      frmCalculadora formCalculadora = new frmCalculadora();
      formCalculadora.MdiParent = this;
      formCalculadora.Show();
    }

    private void menuCheckboxes_Click(object sender, EventArgs e) {
      frmCheckboxes formCheckboxes = new frmCheckboxes();
      formCheckboxes.MdiParent = this;
      formCheckboxes.Show();
    }

    private void menuGroupboxes_Click(object sender, EventArgs e) {
      frmGroupboxes formGroupboxes = new frmGroupboxes();
      formGroupboxes.MdiParent = this;
      formGroupboxes.Show();
    }
  }
}
