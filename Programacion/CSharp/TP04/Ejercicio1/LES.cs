using System.Diagnostics;

namespace Ejercicio1 {
  class LES {
    ////////////////////////////////////////////////////////// INICIALIZACIONES
    private NS NodoInicio = null, NodoAuxiliar = null;
    private int conteo = 0;

    // *---------------------------------------------------------=> Constructor
    public LES() {
      NodoInicio = new NS();
      NodoInicio.Siguiente = null;
    }
    public int Conteo() { return conteo; }
    // *-------------------------------------------------------------=> Indexer
    public int this[int indice] {
    get {
        NodoAuxiliar = NodoEnIndice(indice);
        return NodoAuxiliar.Dato;
      }
      set {
        NodoAuxiliar = NodoEnIndice(indice);
        if (NodoAuxiliar != null) { NodoAuxiliar.Dato = value; }
      }
    }
    /////////////////////////////////////////////////////////////////// MÉTODOS
    public void AgregarNodo(int dato, string observaciones = "S/O") {
      NodoAuxiliar = NodoInicio;
      while(NodoAuxiliar.Siguiente != null) {
        NodoAuxiliar = NodoAuxiliar.Siguiente;
      }
      NS temporal = new NS();
      temporal.Dato = dato;
      temporal.Observaciones = observaciones;
      temporal.Siguiente = null;
      NodoAuxiliar.Siguiente = temporal;
      conteo++;
    }

    public void Transversar() {
      NodoAuxiliar = NodoInicio;
      while (NodoAuxiliar.Siguiente != null) {
        NodoAuxiliar = NodoAuxiliar.Siguiente;
        int dato = NodoAuxiliar.Dato;
        string observaciones = NodoAuxiliar.Observaciones;
        Debug.Write(dato + ", ");
      }
      Debug.WriteLine("");
    }

    public void Vaciar() { NodoInicio.Siguiente = null; }

    public bool ListaVacia() {
      if(NodoInicio.Siguiente == null) { return true; }
      else { return false; }
    }

    public int Largo() {
      NodoAuxiliar = NodoInicio;
      int largo = 0;
      while (NodoAuxiliar.Siguiente != null) {
        NodoAuxiliar = NodoAuxiliar.Siguiente;
        largo++;
      }
      return largo;
    }

    public int IndiceDeDato(int dato) {
      if (ListaVacia() == true) { return 0; }
      NodoAuxiliar = NodoInicio;
      int indice = 0;
      while(NodoAuxiliar.Siguiente != null) {
        NodoAuxiliar = NodoAuxiliar.Siguiente;
        indice++;
        if (NodoAuxiliar.Dato == dato) { return indice; }
      }
      return 0;
    }

    public NS NodoEnIndice(int _id) {
      int largo = Largo();
      NS nodo = null;
      if (_id > largo) { return nodo; }
      int indice = -1;
      NodoAuxiliar = NodoInicio;
      do {
        indice++;
        if (indice == _id) { nodo = NodoAuxiliar; }
        if (NodoAuxiliar.Siguiente != null) { NodoAuxiliar = NodoAuxiliar.Siguiente; }
      } while (indice != _id);
      return nodo;
    }

    public NS BuscarNodoAnterior(int dato) {
      NodoAuxiliar = NodoInicio;
      while (NodoAuxiliar.Siguiente != null && NodoAuxiliar.Siguiente.Dato != dato) { NodoAuxiliar = NodoAuxiliar.Siguiente; }
      return NodoAuxiliar;
    }

    public void BorrarNodoPorDato(int dato) {
      if (ListaVacia() == true) { return; }
      NS anterior = BuscarNodoAnterior(dato);
      int indice = IndiceDeDato(dato);
      if (indice == 0) { return; }
      NS encontrado = NodoEnIndice(indice);
      if (encontrado == null) { return;  }
      anterior.Siguiente = encontrado.Siguiente;
      encontrado.Siguiente = null;
    }
    
    public void InsertarNodoEnIndice(int indice, int dato) {
      NodoAuxiliar = NodoEnIndice(indice);
      if(NodoAuxiliar == null) { return; }
      NS temporal = new NS();
      temporal.Dato = dato;
      temporal.Siguiente = NodoAuxiliar.Siguiente;
      NodoAuxiliar.Siguiente = temporal;
    }

  }
}
