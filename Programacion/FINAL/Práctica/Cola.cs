namespace Integrador
{
    class Cola
    {
        Nodo _inicio;
        public int Contador = 0;
        public void Encolar(Nodo nodoIngreso)
        {
            if (_inicio==null)
            {
                _inicio = nodoIngreso;
            }
            else
            {
                Nodo nodoTemporal = BuscarUltimo(_inicio);
                nodoTemporal.Siguiente = nodoIngreso;
            }
            Contador++;
        }
        public void Desencolar()
        {
            _inicio = _inicio.Siguiente;
            Contador--;
        }
        private Nodo BuscarUltimo(Nodo nodoReceptor)
        {
            if (nodoReceptor.Siguiente == null)
            {
                return nodoReceptor;
            }
            else
            {
                return BuscarUltimo(nodoReceptor.Siguiente);
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
