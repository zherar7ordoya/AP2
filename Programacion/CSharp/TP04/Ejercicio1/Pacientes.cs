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
      LES miLista = new LES();
      miLista.AgregarNodo(3, "Tres");
      miLista.AgregarNodo(5);
      miLista.AgregarNodo(7);
      miLista.AgregarNodo(9);
      miLista.AgregarNodo(11);
      miLista.AgregarNodo(15);

      myLinkedList<ListNode> SimpleLista = new myLinkedList<int>();
      SimpleLista.addBack<int>(5);
      SimpleLista.AgregarNodo<int>(5);
      SimpleLista.AgregarNodo(7);
      SimpleLista.AgregarNodo(9);
      SimpleLista.AgregarNodo(11);
      SimpleLista.AgregarNodo(15);

      SimpleLinkedList<int> SimpleListado = (from item in SimpleLista
                            select new NS() {
                              Dato = item.Dato
                            }).ToList();
                            
  miLista.Transversar();
      // Debug.WriteLine(miLista.EstaVacia());
      // miLista.Vaciar();
      // Debug.WriteLine(miLista.EstaVacia());
      //int encontrado = miLista.IndiceDeDato(11);
      //Debug.WriteLine(encontrado);
      //Debug.WriteLine(miLista.DatoEnIndice(6));
      //Debug.WriteLine(miLista.Largo());
      //Debug.WriteLine(miLista.BuscarNodoAnterior(7));

      //miLista.BorrarNodoPorDato(25);
      //miLista.InsertarNodoEnIndice(1, 20);
      Debug.WriteLine(miLista.NodoEnIndice(4));
      miLista[4] = 25;
      miLista.Transversar();


      
      

    }
    ///////////////////////////////////////////////////////////////// CONTROLES

    ///////////////////////////////////////////////////////////////// FUNCIONES

  }
}

