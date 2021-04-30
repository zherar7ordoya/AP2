using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView {
  public partial class frmPrincipal : Form {

    private int n = 0, m = 0;

    public frmPrincipal() {
      InitializeComponent();
    }

    private void dtgvProductos_CellClick(object sender, DataGridViewCellEventArgs e) {
      n = e.RowIndex;
      m = dtgvProductos.CurrentCell.ColumnIndex;

      if (n != -1) {
        lblInformacion.Text = (string)dtgvProductos.Rows[n].Cells[m].Value;
      }
    }

    private void btnAgregar_Click(object sender, EventArgs e) {
      // Añade un renglón
      n = dtgvProductos.Rows.Add();

      // Agrega los datos
      dtgvProductos.Rows[n].Cells[0].Value = txtCodigo.Text;
      dtgvProductos.Rows[n].Cells[1].Value = txtNombre.Text;
      dtgvProductos.Rows[n].Cells[2].Value = txtPrecio.Text;

      // Limpieza
      txtCodigo.Text = "";
      txtNombre.Text = "";
      txtPrecio.Text = "";
    }

    private void btnEliminar_Click(object sender, EventArgs e) {
      if (n != -1) {
        dtgvProductos.Rows.RemoveAt(n);
        lblInformacion.Text = "Información";
      }
    }

  }
}
