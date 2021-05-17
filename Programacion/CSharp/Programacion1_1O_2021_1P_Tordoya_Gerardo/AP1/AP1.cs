using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP1 {
  public partial class AP1 : Form {
    //////////////////////////////////////////////////////////// INICIALIZACIÓN
    public AP1() { InitializeComponent(); }

    private void AP1_Load(object sender, EventArgs e) {
      this.MaximizeBox = false;
      this.MinimizeBox = false;
    }

    private void btnResultado_Click(object sender, EventArgs e) {
      if(
        txtNombre.Text.Length > 0 &&
        (optAzul.Checked || optRojo.Checked)
        ) {
        lblResultado.ForeColor = Color.White;
        lblResultado.Font = new Font(lblResultado.Font, FontStyle.Bold);
        lblResultado.Text = txtNombre.Text;

        if (nmbNumero.Value > 0) {
          if (optAzul.Checked) { lblResultado.BackColor = Color.Blue; }
          else { lblResultado.BackColor = Color.Red; }
        }

        if (nmbNumero.Value < 0) {
          if (optAzul.Checked) { lblResultado.BackColor = Color.Red; }
          else { lblResultado.BackColor = Color.Blue; }
        }

        if (nmbNumero.Value == 0) { MessageBox.Show("No se puede ingresar el valor cero. \nSeleccione otro número"); }
      }
    }
    ///////////////////////////////////////////////////////////////// PRINCIPAL
  }
}
