namespace Ejercicio1 {
  class NS {
    // *----------------------------=> DATOS
    private int indice;
    private string Nombres;
    private string Apellido;
    private string Direccion;
    private string Telefono;
    private NS siguiente = null;
    // *----------------------=> PROPIEDADES
    public int Indice {
      get => indice;
      set => indice = value;
    }
    internal NS Siguiente {
      get => siguiente;
      set => siguiente = value;
    }
    // *------------------------=> IMPRESIÓN
    public override string ToString() {
      return string.Format("[{0}]", indice);
    }
  }
}
