using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinarioBusqueda
{
    public class NodoArbolAVL
    {
        public int dato;
        public NodoArbolAVL hijoIzquierdo;
        public NodoArbolAVL hijoDerecha;
        public NodoArbolAVL(int data)
        {
            this.dato = data;
            this.hijoIzquierdo = this.hijoDerecha = null;
        }


        public override string ToString()
        {
            return dato.ToString();
        }
    }
}
