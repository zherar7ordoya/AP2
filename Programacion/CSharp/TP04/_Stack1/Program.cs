using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///////////////////////////////////////////////////////// WELCOME TO THE JUNGLE
using System.Collections;

namespace _Stack1 {
  class Program {
    static void Main(string[] args) {
      // Creates and initializes a new Stack.
      Stack Pila = new Stack();
      Pila.Push("Primero");
      Pila.Push("Segundo");
      Pila.Push("Tercero");

      // Displays the properties and values of the Stack.
      Console.WriteLine("PILA");
      Console.WriteLine("\tConteo:\t{0}", Pila.Count);
      Console.Write("\tValores:");
      PrintValues(Pila);

      // Cálmate...
      Console.ReadKey();
    }
    public static void PrintValues(IEnumerable pila) {
      foreach (Object objeto in pila) Console.Write("\n\t\t{0}", objeto);
    }
  }
}
