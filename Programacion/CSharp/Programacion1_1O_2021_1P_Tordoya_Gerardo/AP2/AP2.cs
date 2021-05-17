using System;
using System.Windows.Forms;

namespace AP2 {
  public partial class AP2 : Form {
    ///////////////////////////////////////////////// GLOBALES & INICIALIZACIÓN
    Cola miCola = new Cola();

    public AP2() { InitializeComponent(); }

    private void AP2_Load(object sender, EventArgs e) {
      this.MaximizeBox = false;
      this.MinimizeBox = false;
    }
    ///////////////////////////////////////////////////////////////// CONTROLES
    private void btnEncolar_Click(object sender, EventArgs e) {
      if (txtNodo.Text.Length == 0) { MessageBox.Show("Ingrese un nombre en el cuadro de texto"); }
      else {
        Nodo unNuevoNodo = new Nodo();
        unNuevoNodo.Nombre = txtNodo.Text;
        miCola.Encolar(unNuevoNodo);
        MostrarCola();
      }
    }

    private void btnDesencolar_Click(object sender, EventArgs e) {
      if (miCola.Vacia()) { MessageBox.Show("Cola vacía"); }
      else {
        miCola.Desencolar();
        MostrarCola();
      }
    }
    ///////////////////////////////////////////////////////////////// FUNCIONES
    private void MostrarCola() {
      lstCola.Items.Clear();
      MostrarNodo(miCola.Inicio);
    }

    /* Función de función */
    private void MostrarNodo(Nodo unNodo) {
      if (unNodo != null) {
        lstCola.Items.Add(unNodo.Nombre);
        if (unNodo.Siguiente != null) { MostrarNodo(unNodo.Siguiente); }
      }
    }
    ///////////////////////////////////////////////////////////////////////////
  }
}
