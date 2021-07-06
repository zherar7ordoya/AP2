using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinarioBusqueda
{
    class ArbolAVL
    {
        NodoArbolAVL raiz;

        #region Constructor

        public ArbolAVL()
        {
            raiz = null;
        }

        #endregion

        #region Metodos Públicos

        public void AgregarDato(int dato)
        {
            NodoArbolAVL nuevoNodo = new NodoArbolAVL(dato);
            if (raiz == null)
            {
                raiz = nuevoNodo;
            }
            else
            {
                raiz = AgregarRecursivo(raiz, nuevoNodo);
            }
            Imprimir.Print(raiz);
        }
       
        public void Delete(int target)
        {//and here
            raiz = Eliminar(raiz, target);
        }
        
        public void Buscar(int key)
        {
            if (Find(key, raiz).dato == key)
            {
                Console.WriteLine("{0} se encontró!", key);
            }
            else
            {
                Console.WriteLine("No se encontró nada!");
            }
        }

        public void MostrarArbolInOrder()
        {
            if (raiz == null)
            {
                Console.WriteLine("El Árbol esta vacio");
                return;
            }
            InOrderMostrarArbol(raiz, "R", 1);
            Console.WriteLine();
        }


        private NodoArbolAVL Find(int target, NodoArbolAVL current)
        {

            if (target < current.dato)
            {
                if (target == current.dato)
                {
                    return current;
                }
                else
                    return Find(target, current.hijoIzquierdo);
            }
            else
            {
                if (target == current.dato)
                {
                    return current;
                }
                else
                    return Find(target, current.hijoDerecha);
            }

        }

        #endregion

        #region Métodos Privados
        private NodoArbolAVL AgregarRecursivo(NodoArbolAVL nodoActual, NodoArbolAVL nodoHijo)
        {
            if (nodoActual == null)
            {
                nodoActual = nodoHijo;
                return nodoActual;
            }
            else if (nodoHijo.dato < nodoActual.dato)
            {
                nodoActual.hijoIzquierdo = AgregarRecursivo(nodoActual.hijoIzquierdo, nodoHijo);
                nodoActual = balancear_arbol(nodoActual);
            }
            else if (nodoHijo.dato > nodoActual.dato)
            {
                nodoActual.hijoDerecha = AgregarRecursivo(nodoActual.hijoDerecha, nodoHijo);
                nodoActual = balancear_arbol(nodoActual);
            }
            return nodoActual;
        }
        private NodoArbolAVL balancear_arbol(NodoArbolAVL nodoActual)
        {
            int b_factor = factor_equilibrio(nodoActual);
            if (b_factor > 1)
            {
                if (factor_equilibrio(nodoActual.hijoIzquierdo) > 0)
                {
                    nodoActual = RotarII(nodoActual);
                }
                else
                {
                    nodoActual = RotarID(nodoActual);
                }
            }
            else if (b_factor < -1)
            {
                if (factor_equilibrio(nodoActual.hijoDerecha) > 0)
                {
                    nodoActual = RotarDI(nodoActual);
                }
                else
                {
                    nodoActual = RootarDD(nodoActual);
                }
            }
            return nodoActual;
        }


        private NodoArbolAVL Eliminar(NodoArbolAVL nodoActual, int target)
        {
            NodoArbolAVL padre;
            if (nodoActual == null)
            { return null; }
            else
            {
                //left subtree
                if (target < nodoActual.dato)
                {
                    nodoActual.hijoIzquierdo = Eliminar(nodoActual.hijoIzquierdo, target);
                    if (factor_equilibrio(nodoActual) == -2)//here
                    {
                        if (factor_equilibrio(nodoActual.hijoDerecha) <= 0)
                        {
                            nodoActual = RootarDD(nodoActual);
                        }
                        else
                        {
                            nodoActual = RotarDI(nodoActual);
                        }
                    }
                }
                //right subtree
                else if (target > nodoActual.dato)
                {
                    nodoActual.hijoDerecha = Eliminar(nodoActual.hijoDerecha, target);
                    if (factor_equilibrio(nodoActual) == 2)
                    {
                        if (factor_equilibrio(nodoActual.hijoIzquierdo) >= 0)
                        {
                            nodoActual = RotarII(nodoActual);
                        }
                        else
                        {
                            nodoActual = RotarID(nodoActual);
                        }
                    }
                }
                //if target is found
                else
                {
                    if (nodoActual.hijoDerecha != null)
                    {
                        //delete its inorder successor
                        padre = nodoActual.hijoDerecha;
                        while (padre.hijoIzquierdo != null)
                        {
                            padre = padre.hijoIzquierdo;
                        }
                        nodoActual.dato = padre.dato;
                        nodoActual.hijoDerecha = Eliminar(nodoActual.hijoDerecha, padre.dato);
                        if (factor_equilibrio(nodoActual) == 2)//rebalancing
                        {
                            if (factor_equilibrio(nodoActual.hijoIzquierdo) >= 0)
                            {
                                nodoActual = RotarII(nodoActual);
                            }
                            else { nodoActual = RotarID(nodoActual); }
                        }
                    }
                    else
                    {   //if current.left != null
                        return nodoActual.hijoIzquierdo;
                    }
                }
            }
            return nodoActual;
        }

        private void InOrderMostrarArbol(NodoArbolAVL nodoActual, string prefijo, int nivel)
        {
            if (nodoActual != null)
            {
                InOrderMostrarArbol(nodoActual.hijoIzquierdo, "I", nivel+1);
                Console.Write($"{prefijo}-N{nivel}-{nodoActual.dato} ");
                InOrderMostrarArbol(nodoActual.hijoDerecha, "D", nivel+1);
            }
        }
        private int max(int l, int r)
        {
            return l > r ? l : r;
        }
        private int getAltura(NodoArbolAVL nodoActual)
        {
            int height = 0;
            if (nodoActual != null)
            {
                int l = getAltura(nodoActual.hijoIzquierdo);
                int r = getAltura(nodoActual.hijoDerecha);
                int m = max(l, r);
                height = m + 1;
            }
            return height;
        }
        private int factor_equilibrio(NodoArbolAVL nodoActual)
        {
            int l = getAltura(nodoActual.hijoIzquierdo);
            int r = getAltura(nodoActual.hijoDerecha);
            int b_factor = l - r;
            return b_factor;
        }
        private NodoArbolAVL RootarDD(NodoArbolAVL parent)
        {
            NodoArbolAVL pivot = parent.hijoDerecha;
            parent.hijoDerecha = pivot.hijoIzquierdo;
            pivot.hijoIzquierdo = parent;
            return pivot;
        }
        private NodoArbolAVL RotarII(NodoArbolAVL parent)
        {
            NodoArbolAVL pivot = parent.hijoIzquierdo;
            parent.hijoIzquierdo = pivot.hijoDerecha;
            pivot.hijoDerecha = parent;
            return pivot;
        }
        private NodoArbolAVL RotarID(NodoArbolAVL parent)
        {
            NodoArbolAVL pivot = parent.hijoIzquierdo;
            parent.hijoIzquierdo = RootarDD(pivot);
            return RotarII(parent);
        }
        private NodoArbolAVL RotarDI(NodoArbolAVL parent)
        {
            NodoArbolAVL pivot = parent.hijoDerecha;
            parent.hijoDerecha = RotarII(pivot);
            return RootarDD(parent);
        }

        #endregion
    }
}
