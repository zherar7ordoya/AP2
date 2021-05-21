using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1 {
  class LESExperimental {


    private NodeExperimental NodoInicio, Activo;

    private int contador;

    public LESExperimental() {
      NodoInicio = null;
      Activo = null;
      contador = 0;
    }

    public int Contador() {
      return contador;
    }

    public void Agregar(int _id, string nombres, string apellido, string direccion, string telefono) {
      if (NodoInicio == null) {
        NodoInicio = new NodeExperimental(_id, nombres, apellido, direccion, telefono);
      }
      else {
        NodoInicio.Agregar(_id, nombres, apellido, direccion, telefono);
      }
      contador++;
    }

    ///////////////////////////////////////////////////////////////////////////

    public int this[int Index] {
      get {
        Activo = Indexado(Index);
        return Activo.Codigo;
      }
      set {
        Activo = Indexado(Index);
        if (Activo != null) { Activo.Codigo = value; }
      }
    }
    // [🠕] Indexer [🠕] <=-------------------------------=>  [🠗] Indexado [🠗] \\
    private NodeExperimental Indexado(int Index) {
      NodeExperimental Auxiliar = null;
      int indice = 0;
      Activo = NodoInicio;

      do {
        indice++;
        if (indice == Index) { Auxiliar = Activo; }
        if (Activo.Siguiente != null) { Activo = Activo.Siguiente; }
      } while (indice != Index);

      return Auxiliar;
    }

    ///////////////////////////////////////////////////////////////////////////
    
    public NodeExperimental Encontrar(int _id) {
      NodeExperimental Resultado = Indexado(_id);
      return Resultado;
    }

  }
}
