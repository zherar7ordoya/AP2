using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinarioBusqueda
{

    class NodoArbolBinario
    {
        #region Atributos Privados
        private NodoArbolBinario hijoIzquierdo; // enlace al hijo izquierdo
        private int datos; // datos almacenados en el nodo
        private NodoArbolBinario hijoDerecho; // enlace al hijo derecho
        #endregion

        #region Constructor
        // inicializa datos del nodo y lo convierte en nodo hoja
        public NodoArbolBinario(int datosNodo)
        {
            datos = datosNodo;
            hijoIzquierdo = hijoDerecho = null; // el nodo no tiene hijos
        }
        #endregion

        #region Propiedades Públicas
        // propiedad NodoIzquierdo
        public NodoArbolBinario HijoIzquierdo
        {
            get
            {
                return hijoIzquierdo;
            } 
            set
            {
                hijoIzquierdo = value;
            } 
        }


        // propiedad Datos
        public int Datos
        {
            get
            {
                return datos;
            }
            set
            {
                datos = value;
            }
        }

        // propiedad NodoDerecho
        public NodoArbolBinario HijoDerecho
        {
            get
            {
                return hijoDerecho;
            } 
            set
            {
            } 
        }
        #endregion

        #region Métodos Públicos
        // inserta NodoArbolBinario en el Arbol que contiene nodos;
        // ignora los valores duplicados
        public void AgregarHijo(int valorInsercion)
        {
            if (valorInsercion < datos) // inserta en el subárbol izquierdo
            {
                // inserta nuevo NodoArbol
                if (hijoIzquierdo == null)
                    hijoIzquierdo = new NodoArbolBinario(valorInsercion);
                else // continúa recorriendo el subárbol izquierdo
                    hijoIzquierdo.AgregarHijo(valorInsercion);
            } // fin de if
            else if (valorInsercion > datos) // inserta en el subárbol derecho
            {
                // inserta nuevo NodoArbol
                if (hijoDerecho == null)
                    hijoDerecho = new NodoArbolBinario(valorInsercion);
                else // continua recorriendo el subárbol derecho
                    hijoDerecho.AgregarHijo(valorInsercion);
            } 
        }
        #endregion

        #region Métodos Sobreescritos
        public override string ToString()
        {
            return datos.ToString();
        }
        #endregion
    }




}
