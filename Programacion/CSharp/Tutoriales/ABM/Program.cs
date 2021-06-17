using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

      menu();

      //////////////////////
      Console.ReadKey(true);
    }


    // MÉTODO MENÚ
    static void menu() {
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
  }
}
