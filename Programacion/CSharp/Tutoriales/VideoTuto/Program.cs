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

    }
  }
}
