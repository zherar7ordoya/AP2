using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace VideoTuto {
  class Program {
    static void Main() {
      /* VIDEO 64: 
       * CREAR/ESCRIBIR ARCHIVO DE TEXTO
       * 
      StreamWriter escritura = File.CreateText("ejemplo.txt");
      escritura.WriteLine("Bienvenido a la Pachangona");
      escritura.Close();
      */

      /* VIDEO 65:
       * ESCRIBIR CONSERVANDO DATOS
       * 
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

      /* VIDEO 66:
       * LECTURA DE ARCHIVO
       * 
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

      /* VIDEO 67:
       * BUSCAR DATOS EN ARCHIVO
       * 
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
      */

      /* VIDEO 68:
       * ELIMINACION DE REGISTROS
       * 
      StreamReader lectura;
      StreamWriter escribir;
      string cadena, empleado;
      string[] campos = new string[4];
      char[] separador = { ',' };
      bool encontrado = false;

      try {
        lectura = File.OpenText("sueldos.txt");
        escribir = File.CreateText("tmp.txt");
        Console.Write("Nombre a eliminar: ");
        empleado = Console.ReadLine();
        cadena = lectura.ReadLine();
        while (cadena != null) {
          campos = cadena.Split(separador);
          if (campos[0].Trim().Equals(empleado)) {
            encontrado = true;
          }
          else {
            escribir.WriteLine(cadena);
          }
          cadena = lectura.ReadLine();
        }
        if (encontrado == false) {
          Console.WriteLine("El empleado " + empleado + " no existe.");
        } else {
          Console.WriteLine("Registro eliminado.");
        }
        lectura.Close();
        escribir.Close();
        File.Delete("sueldos.txt");
        File.Move("tmp.txt", "sueldos.txt");
      }
      catch (FileNotFoundException fe) {
        Console.WriteLine("ERROR " + fe.Message);
      }
      catch (Exception e) {
        Console.WriteLine("ERROR " + e.Message);
      }
      */

      /* VIDEO 69:
      * REEMPLAZO DE REGISTROS
      * 
      */
      StreamReader lectura;
      StreamWriter escribir;
      string cadena, empleado, nuevoNombre, respuesta;
      string[] campos = new string[4];
      char[] separador = { ',' };
      bool encontrado = false;

      try {
        lectura = File.OpenText("sueldos.txt");
        escribir = File.CreateText("tmp.txt");
        Console.Write("Nombre a modificar: ");
        empleado = Console.ReadLine();
        cadena = lectura.ReadLine();

        while (cadena != null) {
          campos = cadena.Split(separador);

          if (campos[0].Trim().Equals(empleado)) {
            encontrado = true;
            Console.WriteLine();
            Console.WriteLine("Nombre:    " + campos[0].Trim());
            Console.WriteLine("Dirección: " + campos[1].Trim());
            Console.WriteLine("Edad:      " + campos[2].Trim());
            Console.WriteLine("Sueldo:    " + campos[3].Trim());
            Console.WriteLine();
            Console.Write("Editar?: ");
            respuesta = Console.ReadLine();
            respuesta = respuesta.ToUpper();

            if(respuesta.Equals("SI")) {
              Console.Write("Nuevo nombre: ");
              nuevoNombre = Console.ReadLine();
              escribir.WriteLine(nuevoNombre + "," + campos[1] + "," + campos[2] + "," + campos[3]);
              Console.WriteLine("Registro modificado.");
            }
            else { escribir.WriteLine(cadena); }
          }
          else { escribir.WriteLine(cadena); }

          cadena = lectura.ReadLine();
        }

        if (encontrado == false) Console.WriteLine("El empleado " + empleado + " no existe.");

        lectura.Close();
        escribir.Close();
        File.Delete("sueldos.txt");
        File.Move("tmp.txt", "sueldos.txt");
      }
      catch (FileNotFoundException fe) { Console.WriteLine("ERROR " + fe.Message); }
      catch (Exception e) { Console.WriteLine("ERROR " + e.Message); }








      //////////////////////
      Console.ReadKey(true);
//////////////////////
}
}
}
