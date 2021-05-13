using System;
using System.Collections.Generic;

///////////////////////////////////////////////////////////////////////// ABOUT
/**
 * Esto es lo primero y más básico que habría que responder:
 * Esta estructura de datos, ¿para qué sirve, para qué se usa?
 * USOS:
 * -) El sistema desde el punto de venta de un restaurante.
 * */


namespace _Queue2 {
  class Program {
    static void Main(string[] args) {
      Queue<string> numeros = new Queue<string>();
      numeros.Enqueue("Uno");
      numeros.Enqueue("Dos");
      numeros.Enqueue("Tres");
      numeros.Enqueue("Cuatro");
      numeros.Enqueue("Cinco");

      // A queue can be enumerated without disturbing its contents.
      foreach (string numero in numeros) Console.WriteLine(numero);

      Console.WriteLine("\nQuitar de la cola '{0}'", numeros.Dequeue());
      Console.WriteLine("Próximo valor a quitar de la cola: {0}", numeros.Peek());
      Console.WriteLine("Quitar de la cola '{0}'", numeros.Dequeue());

      // Create a copy of the queue, using the ToArray method and the
      // constructor that accepts an IEnumerable<T>.
      Queue<string> copia = new Queue<string>(numeros.ToArray());

      Console.WriteLine("\nContenido de la copia:");
      foreach (string numero in copia) Console.WriteLine(numero);

      // Create an array twice the size of the queue and copy the
      // elements of the queue, starting at the middle of the
      // array.
      string[] vector = new string[numeros.Count * 2];
      numeros.CopyTo(vector, numeros.Count);

      // Create a second queue, using the constructor that accepts an
      // IEnumerable(Of T).
      Queue<string> otra = new Queue<string>(vector);

      Console.WriteLine("\nContenido de la segunda copia (con duplicados y nulls):");
      foreach (string numero in otra) Console.WriteLine(numero);

      Console.WriteLine("\ncopia.Contains(\"Dos\") = {0}", copia.Contains("Dos"));
      Console.WriteLine("copia.Contains(\"Tres\") = {0}", copia.Contains("Tres"));
      Console.WriteLine("copia.Clear()");
      copia.Clear();
      Console.WriteLine("copia.Count = {0}", copia.Count);

      // Stop Forrest!
      Console.ReadKey();
    }
  }
}
