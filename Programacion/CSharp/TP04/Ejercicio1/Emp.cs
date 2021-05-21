namespace Ejercicio1 {
  public class Emp {
    public int ID { get; set; }
    public string Nombre { get; set; }
    public string City { get; set; }

    public Emp(int id, string name, string city) {
      this.ID = id;
      this.Nombre = name;
      this.City = city;
    }
  }
}
