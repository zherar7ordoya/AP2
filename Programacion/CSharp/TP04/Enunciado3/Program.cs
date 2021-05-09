using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enunciado3 {
  class Program {

    // Secuenciador, nada que explicar.
    static void Main(string[] args) {
      int[] vector = { 64, 25, 12, 22, 11 };

      Console.Write("Vector antes de ordenarlo:\t");
      for (int i = 0; i < vector.Length; i++) Console.Write(vector[i] + " ");

      OrdenarVector(vector, vector.Length, 0);

      Console.Write("\nVector luego de ordenarlo:\t");
      for (int i = 0; i < vector.Length; i++) Console.Write(vector[i] + " ");

      Console.ReadKey();
    }

    /* Uf! Está un poco desordenado...
     * Se llama ordenamiento por selección, y consiste en lo siguiente:
     * 1) Buscar el mínimo elemento de la lista
     * 2) Intercambiarlo con el primero
     * 3) Buscar el siguiente mínimo en el resto de la lista
     * 4) Intercambiarlo con el primero de ese resto de la lista
     * Para arrancar, vector es vector, lenght es el tamaño del vector e 
     * index es el primer elemento por el cual comenzar.
     */
    private static void OrdenarVector(int[] vector, int length, int index) {
      if (index == length) return;

      int minimo = BuscarMinimo(vector, index, length - 1);

      if (minimo != index) {
        int temporal = vector[minimo];
        vector[minimo] = vector[index];
        vector[index] = temporal;
      }

      OrdenarVector(vector, length, index + 1);
    }

    private static int BuscarMinimo(int[] vector, int index, int length) {
      if (index == length) return index;
      int minimo = BuscarMinimo(vector, index + 1, length);
      return (vector[index] < vector[minimo]) ? index : minimo;
    }
  }
}
