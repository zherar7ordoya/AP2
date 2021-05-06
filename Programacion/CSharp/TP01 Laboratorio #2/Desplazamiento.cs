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
  public partial class frmDesplazamiento : Form {
    public frmDesplazamiento() {
      InitializeComponent();
    }

    private void hScrollBar1_Scroll(object sender, ScrollEventArgs e) {
      this.label1.Text = hScrollBar1.Value.ToString();
    }

    private void vScrollBar1_Scroll(object sender, ScrollEventArgs e) {
      label2.Text = vScrollBar1.Value.ToString();
    }

    private void frmDesplazamiento_Load(object sender, EventArgs e) {
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      System.Console.WriteLine("No te preocupes por mí. Solo ignórame...");
    }
  }
}
