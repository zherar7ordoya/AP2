using System;

namespace Ejercicio1 {
  class NodoSimple {
    public int Codigo;
    public string Nombres;
    public string Apellido;
    public string Direccion;
    public string Telefono;
    public NodoSimple Siguiente;

    public NodoSimple(int _id, string nombres, string apellido, string direccion, string telefono) {
      Codigo = _id;
      Nombres = nombres;
      Apellido = apellido;
      Direccion = direccion;
      Telefono = telefono;
      Siguiente = null;
    }

  }
}

