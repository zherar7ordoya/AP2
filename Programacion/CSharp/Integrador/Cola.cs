namespace Integrador
{
    class Cola
    {
        Nodo _inicio;
        public int Contador = 0;
        public void Encolar(Nodo unNodo)
        {
            if (_inicio==null)
            {
                _inicio = unNodo;
            }
            else
            {
                Nodo auxiliar = BuscarUltimo(_inicio);
                auxiliar.Siguiente = unNodo;
            }
            Contador++;
        }
        public void Desencolar()
        {
            _inicio = _inicio.Siguiente;
            Contador--;
        }
        private Nodo BuscarUltimo(Nodo unNodo)
        {
            if (unNodo.Siguiente == null)
            {
                return unNodo;
            }
            else
            {
                return BuscarUltimo(unNodo.Siguiente);
            }
        }
        public bool Vacia()
        {
            return (_inicio == null);
        }
        public Nodo Inicio
        {
            get
            {
                return _inicio;
            }
        }
    }
}
