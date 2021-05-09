using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas2017
{
   public class NodoSimple
    {
        public int Numero;
        public string Nombre;
        public NodoSimple Siguiente;


        public override string ToString()
        {
            return string.Format("{0} {1}", Numero, Nombre);
        }
    }
}
