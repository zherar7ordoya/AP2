    public NodoSimple Activo = null;

    public string this[int Index] {
      get {
        Activo = ObtenerPorIndice(Index);
        return Activo.Nombre;
      }
      set {
        Activo = ObtenerPorIndice(Index);
        if (Activo != null) { Activo.Nombre = value;  }
      }
    }

    private NodoSimple ObtenerPorIndice(int Index) {
      NodoSimple Auxiliar = null;
      int indice = 0;
      Activo = NodoInicial;

       do {
        indice++;
        if (indice == Index) { Auxiliar = Activo; }
        if (Activo.Siguiente != null) { Activo = Activo.Siguiente; }
      } while (indice != Index);

      return Auxiliar;
    }
