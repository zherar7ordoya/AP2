/** 
 * Gerardo Tordoya
 * 2021-05-24
 */

using System;
using System.Diagnostics;

class LES  {
  //////////////////////////////////////////////////////////// INICIALIZACIONES
  private NS NodoInicio = null, NodoAuxiliar = null;
  private int conteo = 0;
  // *-----------------------------------------------------------=> Constructor
  public LES() {
    NodoInicio = new NS();
    NodoInicio.Siguiente = null;
  }
  // *------------------------------------------------------=> ¿Qué es esto...?
  public int Conteo() { return conteo; }
  // *---------------------------------------------------------------=> Indexer
  public string[] this[int _id] {
    get {
      NodoAuxiliar = NodoEnIndice(_id);
      return new[] {
        NodoAuxiliar.Codigo.ToString(),
        NodoAuxiliar.Nombres,
        NodoAuxiliar.Apellido,
        NodoAuxiliar.Direccion,
        NodoAuxiliar.Telefono
      };
    }
    set {
      NodoAuxiliar = NodoEnIndice(_id);
      if (NodoAuxiliar != null) {
        NodoAuxiliar.Nombres = value[0];
        NodoAuxiliar.Apellido = value[1];
        NodoAuxiliar.Direccion = value[2];
        NodoAuxiliar.Telefono = value[3];
      }
    }
  }
  ///////////////////////////////////////////////////////////////////// MÉTODOS
  public void AgregarNodo(
    string nombres = "(sin dato)",
    string apellido = "(sin dato)",
    string direccion = "(sin dato)",
    string telefono = "(sin dato)"
    ) {
    NodoAuxiliar = NodoInicio;
    while (NodoAuxiliar.Siguiente != null) {
      NodoAuxiliar = NodoAuxiliar.Siguiente;
    }
    conteo++;
    NS Nodo = new NS();
    Nodo.Codigo = conteo;
    Nodo.Nombres = nombres;
    Nodo.Apellido = apellido;
    Nodo.Direccion = direccion;
    Nodo.Telefono = telefono;
    Nodo.Siguiente = null;
    NodoAuxiliar.Siguiente = Nodo;
  }

  public void Transversar() {
    NodoAuxiliar = NodoInicio;
    while (NodoAuxiliar.Siguiente != null) {
      NodoAuxiliar = NodoAuxiliar.Siguiente;
      int codigo = NodoAuxiliar.Codigo;
      Debug.WriteLine(codigo);
    }
  }

  public void Vaciar() { NodoInicio.Siguiente = null; }

  public bool ListaVacia() {
    if (NodoInicio.Siguiente == null) { return true; }
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

  public int IndiceDeCodigo(int codigo) {
    if (ListaVacia() == true) { return 0; }
    NodoAuxiliar = NodoInicio;
    int indice = 0;
    while (NodoAuxiliar.Siguiente != null) {
      NodoAuxiliar = NodoAuxiliar.Siguiente;
      indice++;
      if (NodoAuxiliar.Codigo == codigo) { return indice; }
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

  public NS BuscarNodoAnterior(int codigo) {
    NodoAuxiliar = NodoInicio;
    while (NodoAuxiliar.Siguiente != null && NodoAuxiliar.Siguiente.Codigo != codigo) { NodoAuxiliar = NodoAuxiliar.Siguiente; }
    return NodoAuxiliar;
  }

  public void BorrarNodoPorDato(int codigo) {
    if (ListaVacia() == true) { return; }
    NS anterior = BuscarNodoAnterior(codigo);
    int indice = IndiceDeCodigo(codigo);
    if (indice == 0) { return; }
    NS encontrado = NodoEnIndice(indice);
    if (encontrado == null) { return; }
    anterior.Siguiente = encontrado.Siguiente;
    encontrado.Siguiente = null;
  }

  public void InsertarNodoEnIndice(int indice, int codigo) {
    NodoAuxiliar = NodoEnIndice(indice);
    if (NodoAuxiliar == null) { return; }
    NS Nodo = new NS();
    Nodo.Codigo = codigo;
    Nodo.Siguiente = NodoAuxiliar.Siguiente;
    NodoAuxiliar.Siguiente = Nodo;
  }
}
