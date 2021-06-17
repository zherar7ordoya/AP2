using System;
using System.IO;

namespace VideoTuto {
  class Program {
    static void Main() {
      /* VIDEO 64
      StreamWriter escritura = File.CreateText("ejemplo.txt");
      escritura.WriteLine("Bienvenido a la Pachangona");
      escritura.Close();
      */

      /* VIDEO 65
      string respuesta, cadena;
      respuesta = "";
      cadena = "";
      StreamWriter escribir = File.AppendText("datos.txt");
      do {
        Console.Write("Ingresa texto: ");
        cadena = Console.ReadLine();
        escribir.WriteLine(cadena);
        Console.Write("¿Seguir escribiendo? (SI/NO): ");
        respuesta = Console.ReadLine();
        respuesta = respuesta.ToUpper();
      } while (respuesta.Equals("SI"));
      escribir.Close();
      */

      /* VIDEO 66
      StreamReader lectura;
      string cadena;
      try {
        lectura = File.OpenText("sueldos.txt");
        cadena = lectura.ReadLine();
        while(cadena!=null) {
          Console.WriteLine(cadena);
          cadena = lectura.ReadLine();
        }
        lectura.Close();
      } catch(FileNotFoundException fe) {
        Console.WriteLine("ERROR " + fe.Message);
      }
      */

      StreamReader lectura;
      string cadena, empleado;
      bool encontrado = false;
      string[] campos = new string[4];
      char[] separador = { ',' };

      try {
        lectura = File.OpenText("sueldos.txt");
        Console.Write("Nombre: ");
        empleado = Console.ReadLine();
        cadena = lectura.ReadLine();
        while(cadena!=null && encontrado==false) {
          campos = cadena.Split(separador);
          if(campos[0].Trim().Equals(empleado)) {
            Console.WriteLine("Nombre: " + campos[0].Trim());
            Console.WriteLine("Dirección: " + campos[1].Trim());
            Console.WriteLine("Edad: " + campos[2].Trim());
            Console.WriteLine("Sueldo: " + campos[3].Trim());
            encontrado = true;
          } else {
            cadena = lectura.ReadLine();
          }
        }
        if(encontrado==false) {
          Console.WriteLine("El empleado " + empleado + " no existe.");
        }
        lectura.Close();
      }
      catch (FileNotFoundException fe) {
        Console.WriteLine("ERROR " + fe.Message);
      }
      catch (Exception e) {
        Console.WriteLine("ERROR " + e.Message);
      }


        // *******************
        Console.ReadKey(true);
      // *******************
    }
  }
}
