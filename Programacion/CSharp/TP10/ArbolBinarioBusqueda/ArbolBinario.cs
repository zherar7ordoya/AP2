using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinarioBusqueda
{
    class ArbolBinario
    {
        private NodoArbolBinario raiz;

        #region Métodos Públicos

        // construye un Arbol de enteros vacío
        public ArbolBinario()
        {
            raiz = null;
        } 

        // Inserta un nuevo nodo en el árbol binario de búsqueda.
        // Si el nodo raíz es null, crea el nodo raíz aquí.
        // En cualquier otro caso, llama al método Insertar de la clase NodoArbol.
        public void AgregarDato(int valorInsercion)
        {
            if (raiz == null)
                raiz = new NodoArbolBinario(valorInsercion);
            else
                raiz.AgregarHijo(valorInsercion);
        } 

        // empieza el recorrido preorden
        public void MostrarRecorridoPreorden()
        {
            AyudantePreorden(raiz, "R", 1);
        }


        // empieza recorrido inorden
        public void MostrarRecorridoInorden()
        {
            AyudanteInorden(raiz, "R", 1);
        }

        // empieza recorrido postorden
        public void MostrarRecorridoPostorden()
        {
            AyudantePostorden(raiz, "R", 1);
        }

        #endregion

        #region Métodos Privados
        // método recursivo para realizar el recorrido preorden
        private void AyudantePreorden(NodoArbolBinario nodo, string prefijo, int nivel)
        {
            if (nodo == null)
                return;

            // imprime los datos del nodo
            Console.Write($"{prefijo}-N{nivel}-{nodo.Datos} ");
            // recorre el subárbol izquierdo
            AyudantePreorden(nodo.HijoIzquierdo, "I", nivel+1);

            // recorre el subárbol derecho
            AyudantePreorden(nodo.HijoDerecho, "D", nivel + 1);
        } 


        // método recursivo para realizar el recorrido inorden
        private void AyudanteInorden(NodoArbolBinario nodo, string prefijo, int nivel)
        {
            if (nodo == null)
                return;

            // recorre el subárbol izquierdo
            AyudanteInorden(nodo.HijoIzquierdo, "I", nivel+1);

            // imprime datos del nodo
            Console.Write($"{prefijo}-N{nivel}-{nodo.Datos} ");

            // recorre el subárbol derecho
            AyudanteInorden(nodo.HijoDerecho, "D", nivel+1);
        } 


        // método recursivo para realizar el recorrido postorden
        private void AyudantePostorden(NodoArbolBinario nodo, string prefijo, int nivel)
        {
            if (nodo == null)
                return;

            // recorre el subárbol izquierdo
            AyudantePostorden(nodo.HijoIzquierdo, "I", nivel+1);

            // recorre el subárbol derecho
            AyudantePostorden(nodo.HijoDerecho, "D", nivel+1);

            // imprime datos del nodo
            Console.Write($"{prefijo}-N{nivel}-{nodo.Datos} ");
        }

        #endregion
    }
}
