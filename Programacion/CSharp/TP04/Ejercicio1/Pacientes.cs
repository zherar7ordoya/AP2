using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Ejercicio1 {
  public partial class Pacientes : Form {
    //////////////////////////////////////////////////////////// INICIALIZACIÓN
    /** 
     * Referencia
     *  NS:   Nodo Simple
     *  LES:  Lista Enlazada Simple
     *  FD:   Fuente de Datos 
     */
    public Pacientes() { InitializeComponent(); }
    private void Pacientes_Load(object sender, EventArgs e) {

      
      /*
      string texto = "Bueno, estoy siendo referenciado...";
      string respuesta = Herramientas.InputBox("AVISO", "Asunto", ref texto).ToString();
      MessageBox.Show(texto);
      */

      LES miLista = new LES();
      miLista.AgregarNodo("Gerardo", "Tordoya", "Pachi Gorriti", "3885843652");
      miLista.AgregarNodo("5");
      miLista.AgregarNodo("7");
      miLista.AgregarNodo("9");
      miLista.AgregarNodo("11");
      miLista.AgregarNodo("15");

      var registro = miLista.NodoEnIndice(1);
      List<NS> list = new List<NS>();

      list.Add(new NS {
        Codigo = registro.Codigo,
        Nombres = registro.Nombres,
        Apellido = registro.Apellido,
        Direccion = registro.Direccion,
        Telefono = registro.Telefono
      });

      registro = miLista.NodoEnIndice(2);

      list.Add(new NS {
        Codigo = registro.Codigo,
        Nombres = registro.Nombres,
        Apellido = registro.Apellido,
        Direccion = registro.Direccion,
        Telefono = registro.Telefono
      });

      dgvPacientes.DataSource = new BindingSource(list, null);




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

