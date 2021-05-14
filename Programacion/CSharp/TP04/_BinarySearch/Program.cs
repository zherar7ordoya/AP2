using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _BinarySearch {
  class Program {
    static void Main(string[] args) {
      // Create an array of 10 elements    
      int[] vector = new int[10] { 1, 3, 5, 7, 11, 13, 17, 19, 23, 31 };
      // Value to search for    
      int objetivo = 11;
      int posicion = Array.BinarySearch(vector, objetivo);
      if (posicion >= 0)
        Console.WriteLine($"Objetivo {vector[posicion].ToString()} encontrado en posición {posicion + 1}.");
      else
        Console.WriteLine("Objetivo no encontrado");
      Console.ReadKey();
    }
  }
}
