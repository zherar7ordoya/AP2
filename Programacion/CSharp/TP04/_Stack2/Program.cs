using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

      Console.WriteLine("\npila.Contains(\"four\") = {0}", pila.Contains("four"));
      Console.WriteLine("pila.Clear()"); pila.Clear();
      Console.WriteLine("pila.Count = {0}", pila.Count);

      // Cálmate...
      Console.ReadKey();
    }
  }
}
