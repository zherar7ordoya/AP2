using System;
using System.Windows.Forms;

namespace Enunciado2 {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Ingrese un número");
      int numero = Convert.ToInt32(Console.ReadLine());
      double factorial = Factorial(numero);
      Console.WriteLine("El factorial de " + numero + " es " + factorial.ToString());
      MessageBox.Show("¿Te gustó?");
    }
    private static double Factorial(int numero) {
      if (numero == 0) return 1;
      double factorial = 1;
      for (int i = numero; i >= 1; i--) {
        factorial = factorial * i;
      }
      return factorial;
    }
  }
}
