    public NodoSimple NodoInicial = null, NodoActivo = null;

    public string this[int _id] {
      get {
        NodoActivo = Indexado(Index);
        return NodoActivo.Codigo;
      }
      set {
        NodoActivo = Indexado(Index);
        if (NodoActivo != null) { NodoActivo.Codigo = value; }
      }
    }
    // [🠕] Indexer [🠕] <=-------------------------------=>  [🠗] Indexado [🠗] \\
    private NodoSimple Indexado(int Index) {
      NodoSimple Auxiliar = null;
      int indice = 0;
      NodoActivo = NodoInicial;

      do {
        indice++;
        if (indice == Index) { Auxiliar = NodoActivo; }
        if (NodoActivo.Siguiente != null) { NodoActivo = NodoActivo.Siguiente; }
      } while (indice != Index);

      return Auxiliar;
    }
