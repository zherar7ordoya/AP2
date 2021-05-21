using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1 {
  public partial class Pacientes : Form {

    //////////////////////////////////////////////////////////// INICIALIZACIÓN

    ListaEnlazadaSimple ListaPacientes = new ListaEnlazadaSimple();
    NodoSimple NodoActivo;

    public Pacientes() {
      InitializeComponent();
      /*
      var arrEmp = new[] {
        new Emp( 1, "Devesh Omar", "Noida"),
        new Emp( 2, "Roli", "Kanpur"),
        new Emp( 3, "Roli Gupta", "Mainpuri"),
        new Emp( 3, "Roli Gupta", "Kanpur"),
        new Emp( 3, "Devesh Roli ", "Noida"),
      };
      dataGridView1.DataSource = arrEmp;
      */
      ListaPacientes.NodoInicial.Codigo = "777";
      ListaPacientes.NodoInicial.Nombres = "Gerardo Rodolfo";
      ListaPacientes.NodoInicial.Apellido = "Tordoya";
      ListaPacientes.NodoInicial.Direccion = "Pachi Gorriti 1310";
      ListaPacientes.NodoInicial.Telefono = "3885843652";
    }

    ///////////////////////////////////////////////////////////////// CONTROLES
    
    ///////////////////////////////////////////////////////////////// FUNCIONES
    

  }
}
