using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ejercicio1 {
  public partial class Pacientes : Form {
    //////////////////////////////////////////////////////////// INICIALIZACIÓN
    public Pacientes() { InitializeComponent(); }
    private void Pacientes_Load(object sender, EventArgs e) {

      /*
      string respuesta = "Escriba su respuesta aquí";
      string status = Herramientas.InputBox("Título", "Asunto", ref respuesta).ToString();
      MessageBox.Show(status);
      MessageBox.Show(respuesta);
      */

      LES lesPacientes = new LES();
      lesPacientes.AgregarNodo("Gerardo", "Tordoya", "Pachi Gorriti", "3885843652");
      lesPacientes.AgregarNodo("5");
      lesPacientes.AgregarNodo("7");
      lesPacientes.AgregarNodo("9");
      lesPacientes.AgregarNodo("11");
      lesPacientes.AgregarNodo("15");

      var registro = lesPacientes.NodoEnIndice(1);
      List<NS> listPacientes = new List<NS>();

      listPacientes.Add(new NS {
        Codigo = registro.Codigo,
        Nombres = registro.Nombres,
        Apellido = registro.Apellido,
        Direccion = registro.Direccion,
        Telefono = registro.Telefono
      });

      registro = lesPacientes.NodoEnIndice(2);

      listPacientes.Add(new NS {
        Codigo = registro.Codigo,
        Nombres = registro.Nombres,
        Apellido = registro.Apellido,
        Direccion = registro.Direccion,
        Telefono = registro.Telefono
      });

      dgvPacientes.DataSource = new BindingSource(listPacientes, null);

      ////////////////////////////////////////////////////////////////// TESTEO
      /*
      Debug.WriteLine(registro.Codigo.ToString());
      Debug.WriteLine(registro.Nombres);
      Debug.WriteLine(registro.Apellido);
      Debug.WriteLine(registro.Direccion);
      Debug.WriteLine(registro.Telefono);
      */
      /*
      miLista.Transversar();
      Debug.WriteLine(miLista.Conteo());
      Debug.WriteLine(miLista.ListaVacia());
      miLista.Vaciar();
      Debug.WriteLine(miLista.ListaVacia());
      */
      /*
      int encontrado = miLista.IndiceDeDato(11);
      Debug.WriteLine(encontrado);
      Debug.WriteLine(miLista.DatoEnIndice(6));
      Debug.WriteLine(miLista.Largo());
      Debug.WriteLine(miLista.BuscarNodoAnterior(7));
      miLista.BorrarNodoPorDato(25);
      miLista.InsertarNodoEnIndice(1, 20);
      Debug.WriteLine(miLista.NodoEnIndice(4));
      miLista[4] = 25;
      miLista.Transversar();
      */
    }


    ///////////////////////////////////////////////////////////////// CONTROLES

    ///////////////////////////////////////////////////////////////// FUNCIONES





  }
}

