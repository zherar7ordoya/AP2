using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Ejercicio1 {
  public partial class Pacientes : Form {
    //////////////////////////////////////////////////////////// INICIALIZACIÓN
    /** Referencia
     *  NS: Nodo Simple
     *  LES: Lista Enlazada Simple
     *  FD: Fuente de Datos */
    public Pacientes() { InitializeComponent(); }
    private void Pacientes_Load(object sender, EventArgs e) {
      LinkedList<PacientesNS> PacientesLES = new LinkedList<PacientesNS>();
      for (int i = 1; i <= 5; i++) {
        var nodo = new PacientesNS {
          Codigo = i,
          Nombres = "Nombre " + i,
          Apellido = "Apellido " + i,
          Direccion = "Dirección" + i,
          Telefono = "+54..." + i
        };
        PacientesLES.AddLast(nodo);
        Debug.WriteLine(nodo.Codigo);
      }
      List<PacientesNS> PacientesFD = (from item in PacientesLES
                                       select new PacientesNS() {
                                         Codigo = item.Codigo,
                                         Nombres = item.Nombres,
                                         Apellido = item.Apellido,
                                         Direccion = item.Direccion,
                                         Telefono = item.Telefono,
                                       }).ToList();
      dgvPacientes.DataSource = PacientesFD;
      // *----------------------------------------------------------=> TEMPORAL
      /*
      string texto = "Bueno, estoy siendo referenciado...";
      string respuesta = Herramientas.InputBox("AVISO", "Asunto", ref texto).ToString();
      MessageBox.Show(texto);
      */

    }
    ///////////////////////////////////////////////////////////////// CONTROLES

    ///////////////////////////////////////////////////////////////// FUNCIONES

  }
}

