using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///////////////////////////////////////////////////////////////////////// ABOUT
/**
 * Esto es lo primero y más básico que habría que responder:
 * Esta estructura de datos, ¿para qué sirve, para qué se usa?
 * USOS:
 * -) funcionalidad deshacer/rehacer
 * -) inversión de palabras
 * -) en los navegadores: avanzar/retroceder
 * -) algoritmos de retroceso (¿y esto qué es?)
 * -) verificación de soporte (¿y esto qué es?)
 * */

namespace _Stack2 {
  class Program {
    static void Main(string[] args) {
      Stack<string> numeros = new Stack<string>();
      numeros.Push("Uno");
      numeros.Push("Dos");
      numeros.Push("Tres");
      numeros.Push("Cuatro");
      numeros.Push("Cinco");

      // A stack can be enumerated without disturbing its contents.
      foreach (string numero in numeros) Console.WriteLine(numero);

      Console.WriteLine("\nDescartar '{0}'", numeros.Pop());
      Console.WriteLine("Próximo a desapilar: {0}", numeros.Peek());
      Console.WriteLine("Descartar '{0}'", numeros.Pop());

      // Create a copy of the stack, using the ToArray method and the
      // constructor that accepts an IEnumerable<T>.
      Stack<string> pila = new Stack<string>(numeros.ToArray());

      Console.WriteLine("\nContenido del original:");
      foreach (string numero in pila) Console.WriteLine(numero);

      // Create an array twice the size of the stack and copy the
      // elements of the stack, starting at the middle of the array.
      string[] vector = new string[numeros.Count * 2];
      numeros.CopyTo(vector, numeros.Count);

      // Create a second stack, using the constructor that accepts an
      // IEnumerable(Of T).
      Stack<string> copia = new Stack<string>(vector);

      Console.WriteLine("\nContenido de la copia (con duplicados y nulls):");
      foreach (string numero in copia) Console.WriteLine(numero);

      Console.WriteLine("pila.Contains(\"Cuatro\") = {0}", pila.Contains("Cuatro"));
      Console.WriteLine("pila.Contains(\"Tres\") = {0}", pila.Contains("Tres"));
      Console.WriteLine("pila.Clear()"); pila.Clear();
      Console.WriteLine("pila.Count = {0}", pila.Count);

      // Cálmate...
      Console.ReadKey();
    }
  }
}
