using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas2017
{
    class ListaEnlazadaSimple
    {

        public NodoSimple NodoInicial = null;

        public void AgregarAlPrincipio(string nombre)
        {
            NodoSimple nodo = new NodoSimple();
            nodo.Numero = ProximoNumero();
            nodo.Nombre = nombre;

            if (NodoInicial == null)
                NodoInicial = nodo;
            else
            {
                //si hay elementos en la lista, tenemos que agregarlo entre el inicial y el siguiente

                NodoSimple aux = NodoInicial;
                NodoInicial = nodo;
                NodoInicial.Siguiente = aux;

            }

        }

        public void AgregarAlFinal(string nombre)
        {
            NodoSimple nodo = new NodoSimple();
            nodo.Numero = ProximoNumero(); 
            nodo.Nombre = nombre;

            //necesito buscar el último para agregarlo al final
            NodoSimple ultimo = BuscarUltimo(NodoInicial);
            ultimo.Siguiente= nodo;
        }


        private int BuscarMaximo(NodoSimple nodo, int numero)
        {
            int max = nodo.Numero > numero ? nodo.Numero : numero;
            if (nodo.Siguiente!=null) //no es el ultimo
            {
                
                return BuscarMaximo(nodo.Siguiente, max);

            }
            else
            {
                return max;     
            }

           
        }

        private int ProximoNumero()
        {
            if (NodoInicial == null) return 1;
            int max= BuscarMaximo(NodoInicial, NodoInicial.Numero);

            //busco el maximo y le sumo uno
        
                return max + 1;

        }
        private NodoSimple BuscarUltimo(NodoSimple nodo)
        {
            //la lista este vacia
            if (nodo == null) return null;

            //que no sea el ultimo
            if (nodo.Siguiente != null)
                return BuscarUltimo(nodo.Siguiente);
            else
                return nodo;

        }


        public void QuitarPrimero()
        {
            //par aquitar el primero, necesito usar una variable temporal
            //la lista este vacia
            if (NodoInicial != null)
            {
                NodoInicial = NodoInicial.Siguiente;
            }
        }

        public void QuitarUltimo()
        {
            //necesitamos buscar el anteultimo
            NodoSimple anteultimo = BuscarAnteultimo(NodoInicial);


            if (anteultimo != null)
               anteultimo.Siguiente = null;
            else
                NodoInicial = null;

        }

        private NodoSimple BuscarAnteultimo(NodoSimple nodo)
        {
            if (nodo == null) return null; //lista vacia



            if (nodo.Siguiente == null) return null; //hay un solo elemento

            if (nodo.Siguiente.Siguiente != null)
                    return BuscarAnteultimo(nodo.Siguiente);
                else
                    return nodo;
            
        }


        private NodoSimple BuscarAnterior(NodoSimple nodo, int numero)
        {


            if (nodo.Siguiente != null && nodo.Siguiente.Numero == numero)
                return nodo;
            if (nodo.Siguiente!=null)
                return BuscarAnterior(nodo.Siguiente, numero);
            return null; //es el ultimo...


        }

        public void QuitarPosicion(int numero)
        {
            if (NodoInicial!=null)
            {
                //si el primero es el que se quiere borrar
                if (NodoInicial.Numero == numero)
                {
                    QuitarPrimero();
                }
                else
                {
                    // si el ultimo es elq ue se quiere borrar
                    NodoSimple ultimo = BuscarUltimo(NodoInicial);
                    if (ultimo != null && ultimo.Numero == numero)
                        QuitarUltimo();
                    else
                    { //si se quiere borrar un nodo intermedio
                        NodoSimple nodoAnteriorAlElegido = BuscarAnterior(NodoInicial, numero);
                        if (nodoAnteriorAlElegido != null)
                            nodoAnteriorAlElegido.Siguiente = nodoAnteriorAlElegido.Siguiente.Siguiente;
                    }
                }
            }
         
          
        }

        public void IntercambiarDerecha(int numero)
        {

        }

        public void IntercambiarIzquierda(int numero)
        {

        }

        public void Intercambiar(int numero1, int numero2)
        {

        }
    }
}
