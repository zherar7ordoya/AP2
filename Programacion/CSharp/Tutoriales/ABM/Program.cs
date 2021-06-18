using System;
using System.IO;

namespace ABM {
  class Program {

    static StreamReader Lectura;
    static StreamWriter Escritura, temporal;
    static string cadena, respuesta;
    static string noSerie, modelo, fabricante, color;
    static short anio;
    static double precio;
    static bool encontrado;
    static string[] campos = new string[6];

    static void Main(string[] args) {

      Menu();

      //////////////////////
      Console.ReadKey(true);
    }


    // MÉTODO MENÚ
    private static void Menu() {
      byte opcion;
      opcion = 0;

      do {
        try {
          Console.WriteLine("Menú de opciones");
          Console.WriteLine("1. Altas");
          Console.WriteLine("2. Bajas");
          Console.WriteLine("3. Consultas");
          Console.WriteLine("4. Modificaciones");
          Console.WriteLine("5. Ver todos los registros");
          Console.WriteLine("6. Salir");

          Console.Write("Seleccione: ");
          opcion = Convert.ToByte(Console.ReadLine());

          switch (opcion) {
            case 1:
              crearArchivo();
              Altas();
              break;
            case 2:
              break;
            case 3:
              break;
            case 4:
              break;
            case 5:
              break;
            case 6:
              Console.WriteLine("APLICACIÓN FINALIZADA");
              break;
            default:
              Console.WriteLine("Opción incorrecta.");
              break;
          }
        }
        catch(FormatException fe) { Console.WriteLine("Error: " + fe.Message); }
        catch (Exception e) { Console.WriteLine("Error: " + e.Message); }
      } while (opcion != 6);
    }

    // CREAR ARCHIVO
    static void crearArchivo() {
      Escritura = File.AppendText("autos.txt");
      Escritura.Close();
    }

    // ALTAS
    static void Altas() {
      encontrado = false;
      try {
        Lectura = File.OpenText("autos.txt");
        Console.Write("Nro de serie: ");
        noSerie = Console.ReadLine();
        noSerie = noSerie.ToUpper();
        cadena = Lectura.ReadLine();

        // Validación (auto serie repetido)
        while(cadena!=null) {

          campos = cadena.Split(',');

          if(campos[0].Trim().Equals(noSerie)) {
            encontrado = true;
            break;
          }

          cadena = Lectura.ReadLine();
        }

        Lectura.Close();

        Escritura = File.AppendText("autos.txt");

        if(encontrado==false) {
          Console.Write("Modelo: ");
          modelo = Console.ReadLine();
          modelo = modelo.ToUpper();

          Console.Write("Año: ");
          anio = Convert.ToInt16(Console.ReadLine());

          Console.Write("Fabricante: ");
          fabricante = Console.ReadLine();
          fabricante = fabricante.ToUpper();

          Console.Write("Color: ");
          color = Console.ReadLine();
          color = color.ToUpper();

          Console.Write("Precio: ");
          precio = Convert.ToDouble(Console.ReadLine());

          // Al archivo
          Escritura.WriteLine(
            noSerie     + ", " +
            modelo      + ", " +
            anio        + ", " +
            fabricante  + ", " +
            color       + ", " +
            precio
            );
          Console.WriteLine("Registro agregado correctamente.");
        }
        else { Console.WriteLine("Ya existe nro de serie.");  }
        Escritura.Close();
      } 
      catch(FileNotFoundException fn) { Console.WriteLine("Error: " + fn.Message); }
      catch(Exception e) { Console.WriteLine("Error: " + e.Message); }
      finally {
        Lectura.Close();
        Escritura.Close();
      }
    }
  }
}
