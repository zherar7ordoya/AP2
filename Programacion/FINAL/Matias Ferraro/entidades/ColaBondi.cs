namespace Integrador.entidades
{
    public class ColaBondi
    {
        public ColaBondiNodo PrimerNodo { get; private set; }

        public ColaBondi()
        {
            this.PrimerNodo = null;
        }

        public void Encolar(string nombrePasajero)
        {
            this.Encolar(new ColaBondiNodo
            {
                NodoSiguiente = null,
                Pasajero = nombrePasajero,
            });
        }

        public void Encolar(ColaBondiNodo nodo)
        {
            nodo.NodoSiguiente = null;

            if (this.PrimerNodo == null)
            {
                this.PrimerNodo = nodo;
            }
            else
            {
                this._UbicarAlFinal(nodo, this.PrimerNodo);
            }
        }

        private void _UbicarAlFinal(ColaBondiNodo nodoAEncolar, ColaBondiNodo nodoActual)
        {
            if (nodoActual.NodoSiguiente == null)
            {
                nodoActual.NodoSiguiente = nodoAEncolar;
            }
            else
            {
                this._UbicarAlFinal(nodoAEncolar, nodoActual.NodoSiguiente);
            }
        }

        public ColaBondiNodo Desencolar()
        {
            ColaBondiNodo nodoDesencolado = null;

            if (this.PrimerNodo != null)
            {
                nodoDesencolado = this.PrimerNodo;
                this.PrimerNodo = this.PrimerNodo.NodoSiguiente;
            }

            return nodoDesencolado;
        }

        public int Contar()
        {
            var contador = 0;
            var nodo = this.PrimerNodo;

            while (nodo != null)
            {
                contador++;
                nodo = nodo.NodoSiguiente;
            }

            return contador;
        }
    }
}
