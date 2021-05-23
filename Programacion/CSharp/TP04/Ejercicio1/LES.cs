using System.Diagnostics;

namespace Ejercicio1 {
  class LES {
    ////////////////////////////////////////////////////////// INICIALIZACIONES
    private NS NodoInicio = null,
      NodoActivo = null,
      NodoAuxiliar = null,
      NodoTemporal = null;
    // *---------------------------------------------------------=> Constructor
    public LES() {
      NodoInicio = new NS();
      NodoInicio.Siguiente = null;
    }
    // *-------------------------------------------------------------=> Indexer
    public int this[int _id] {
      get {
        NodoActivo = Indexado(_id);
        return NodoActivo.Indice;
      }
      set {
        NodoActivo = Indexado(_id);
        if (NodoActivo != null) { NodoActivo.Indice = value; }
      }
    }
    // *------------------------------------------------------------=> Indexado
    private NS Indexado(int _id) {
      NS nodo = null;
      int indice = 0;
      NodoActivo = NodoInicio;

      do {
        indice++;
        if (indice == _id) { nodo = NodoActivo; }
        if (NodoActivo.Siguiente != null) { NodoActivo = NodoActivo.Siguiente; }
      } while (indice != _id);

      return nodo;
    }
    /////////////////////////////////////////////////////////////////// MÉTODOS
    public void Transversar() {
      NodoAuxiliar = NodoInicio;
      while(NodoAuxiliar.Siguiente != null) {
        NodoAuxiliar = NodoAuxiliar.Siguiente;
        int dato = NodoAuxiliar.Indice;
        Debug.WriteLine("{0", dato);
      }
    }
    public void Adicionar(int _id) {
      NodoAuxiliar = NodoInicio;
      while(NodoAuxiliar.Siguiente != null) {
        NodoAuxiliar = NodoAuxiliar.Siguiente;
      }
      NS temporal = new NS();
      temporal.Indice = _id;
      temporal.Siguiente = null;
      NodoAuxiliar.Siguiente = temporal;
    }

  }
}
