using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1 {
  class NodeExperimental {

    public int Codigo { get; set; }
    public string Nombres { get; set; }
    public string Apellido { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public NodeExperimental Siguiente;

    public NodeExperimental(int codigo, string nombres, string apellido, string direccion, string telefono) {
      this.Codigo = codigo;
      this.Nombres = nombres;
      this.Apellido = apellido;
      this.Direccion = direccion;
      this.Telefono = telefono;
      Siguiente = null;
    }


    public void Agregar(int _id, string nombres, string apellido, string direccion, string telefono) {
      if (Siguiente == null) {
        Siguiente = new NodeExperimental(_id, nombres, apellido, direccion, telefono);
      }
      else {
        Siguiente.Agregar(_id, nombres, apellido, direccion, telefono);
      }
    }

  }
}
