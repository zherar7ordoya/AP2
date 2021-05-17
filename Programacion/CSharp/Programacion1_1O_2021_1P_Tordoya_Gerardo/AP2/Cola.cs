using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP2 {
  class Cola {

    Nodo _inicio;

    public void Encolar(Nodo unNodo) {
      if (_inicio == null) { _inicio = unNodo; }
      else {

      }
    }

    private Nodo BuscarUltimo(Nodo unNodo) {

    }

    public void Desencolar() { _inicio = _inicio.Siguiente; }

    public Nodo Inicio {
      get { return _inicio; }
    }
  }
}
