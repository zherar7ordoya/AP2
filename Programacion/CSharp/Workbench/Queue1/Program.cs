using System;
using System.Collections.Generic; // Este lo contiene y es default.
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///////////////////////////////////////////////////////////////////////// ABOUT
/**
 * Esto es lo primero y más básico que habría que responder:
 * Esta estructura de datos, ¿para qué sirve, para qué se usa?
 * USOS:
 * -) El sistema desde el punto de venta de un restaurante.
 * */

using System.Collections;

namespace _Queue1 {
  class Program {
    static void Main(string[] args) {

      // Creates and initializes a new Queue.
      Queue Cola = new Queue();
      Cola.Enqueue("Uno");
      Cola.Enqueue("Dos");
      Cola.Enqueue("Tres");

      // Displays the properties and values of the Queue.
      Console.WriteLine("COLA");
      Console.WriteLine("\tConteo:\t\t{0}", Cola.Count);
      Console.Write("\tValores:");
      PrintValues(Cola);

      // Hold your horses, cowboy!
      Console.ReadKey();
    }
    public static void PrintValues(IEnumerable cola) {
      foreach (Object objeto in cola) Console.Write("\t{0}", objeto);
      Console.WriteLine();
    }
  }
}
