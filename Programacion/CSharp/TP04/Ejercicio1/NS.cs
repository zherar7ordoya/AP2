/** 
 * Gerardo Tordoya
 * 2021-05-24
 */
 
class NS {
  // *----------------------------=> DATOS
  private string Codigo;
  private string Nombres;
  private string Apellido;
  private string Direccion;
  private string Telefono;
  private string observaciones;
  private int dato;
  // *----------------------=> PROPIEDADES
  public string Observaciones {
    get => observaciones;
    set => observaciones = value;
  }
  public int Dato {
    get => dato;
    set => dato = value;
  }
  internal NS Siguiente { get; set; } = null;
  // *------------------------=> IMPRESIÓN
  public override string ToString() {
    return string.Format("[{0}]", dato);
  }
}
