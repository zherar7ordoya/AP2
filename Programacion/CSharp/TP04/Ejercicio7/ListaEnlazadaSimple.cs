﻿
namespace Listas2017 {
  class ListaEnlazadaSimple {

    // *----------------------------------------------------=> INICIALIZACIONES
    public NodoSimple NodoInicial = null;
    public NodoSimple Trabajo = null;

    public string this[int Index] {
      get {
        Trabajo = ObtenerPorIndice(Index);
        return Trabajo.Nombre;
      }
      set {
        Trabajo = ObtenerPorIndice(Index);
        if (Trabajo != null) { Trabajo.Nombre = value;  }
      }
    }

    public NodoSimple ObtenerPorIndice(int Index) {
      NodoSimple Auxiliar = null;
      int indice = 0;
      Trabajo = NodoInicial;

      while(Trabajo.Siguiente != null) {
        Trabajo = Trabajo.Siguiente;
        indice++;
        if(indice == Index) { Auxiliar = Trabajo; }
      }

      return Auxiliar;
    }

    /////////////////////////////////////////////////////////////////// MÉTODOS
    public void AgregarAlPrincipio(string nombre) {
      NodoSimple nodo = new NodoSimple();
      nodo.Numero = ProximoNumero();
      nodo.Nombre = nombre;

      if (NodoInicial == null) { NodoInicial = nodo; }
      //si hay elementos en la lista, tenemos que agregarlo entre el inicial y el siguiente
      else {
        NodoSimple aux = NodoInicial;
        NodoInicial = nodo;
        NodoInicial.Siguiente = aux;
      }
    }

    public void AgregarAlFinal(string nombre) {
      NodoSimple nodo = new NodoSimple();
      nodo.Numero = ProximoNumero();
      nodo.Nombre = nombre;
      NodoSimple ultimo = BuscarUltimo(NodoInicial); //necesito buscar el último para agregarlo al final
      ultimo.Siguiente = nodo;
    }

    public void QuitarPosicion(int numero) {
      if (NodoInicial != null) {
        //si el primero es el que se quiere borrar
        if (NodoInicial.Numero == numero) { QuitarPrimero(); }
        // si el ultimo es elq ue se quiere borrar
        else {
          NodoSimple ultimo = BuscarUltimo(NodoInicial);

          if (ultimo != null && ultimo.Numero == numero) { QuitarUltimo(); }
          //si se quiere borrar un nodo intermedio            
          else { 
            NodoSimple nodoAnteriorAlElegido = BuscarAnterior(NodoInicial, numero);

            if (nodoAnteriorAlElegido != null)
              nodoAnteriorAlElegido.Siguiente = nodoAnteriorAlElegido.Siguiente.Siguiente;
          }
        }
      }
    }

    public void QuitarPrimero() {
      // para quitar el primero, necesito usar una variable temporal
      //la lista este vacia
      if (NodoInicial != null) NodoInicial = NodoInicial.Siguiente;
    }

    public void QuitarUltimo() {
      //necesitamos buscar el anteultimo
      NodoSimple anteultimo = BuscarAnteultimo(NodoInicial);

      if (anteultimo != null)
        anteultimo.Siguiente = null;
      else
        NodoInicial = null;
    }

    public void IntercambiarDerecha(int numero) {

    }

    public void IntercambiarIzquierda(int numero) {

    }

    public void Intercambiar(int numero1, int numero2) {
      //NodoSimple auxiliar = BuscarNodo();

      

    }

    ///////////////////////////////////////////////////////////////// FUNCIONES
    private int BuscarMaximo(NodoSimple nodo, int numero) {
      int max = nodo.Numero > numero ? nodo.Numero : numero;

      if (nodo.Siguiente != null) {
        return BuscarMaximo(nodo.Siguiente, max); //no es el ultimo
      }
      else {
        return max;
      }
    }

    private int ProximoNumero() {
      if (NodoInicial == null) return 1;
      int max = BuscarMaximo(NodoInicial, NodoInicial.Numero);
      return max + 1; //busco el maximo y le sumo uno
    }

    private NodoSimple BuscarUltimo(NodoSimple nodo) {
      if (nodo == null) return null; //la lista este vacia

      //que no sea el ultimo
      if (nodo.Siguiente != null)
        return BuscarUltimo(nodo.Siguiente);
      else
        return nodo;
    }

    private NodoSimple BuscarAnteultimo(NodoSimple nodo) {
      if (nodo == null) return null; //lista vacia
      if (nodo.Siguiente == null) return null; //hay un solo elemento

      if (nodo.Siguiente.Siguiente != null)
        return BuscarAnteultimo(nodo.Siguiente);
      else
        return nodo;
    }

    private NodoSimple BuscarAnterior(NodoSimple nodo, int numero) {
      if (nodo.Siguiente != null && nodo.Siguiente.Numero == numero)
        return nodo;
      if (nodo.Siguiente != null)
        return BuscarAnterior(nodo.Siguiente, numero);
      return null; //es el ultimo...
    }

    private NodoSimple BuscarNodo(NodoSimple nodo, int numero) {

      return nodo;
    }

  }
}
