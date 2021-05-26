/** 
 * Gerardo Tordoya
 * 2021-05-24
 */
 
public class NS {
  
  private int codigo { get; set; }

  public int Codigo {
    get => codigo;
    set => codigo = value;
  }

  public string Nombres { get; set; }
  public string Apellido { get; set; }
  public string Direccion { get; set; }
  public string Telefono { get; set; }
  private NS siguiente { get; set; }
  
  internal NS Siguiente { get; set; } = null;
  
  /*
  public override string ToString() {
    return string.Format("[{0}]", codigo);
  }
  */
}
