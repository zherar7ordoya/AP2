using System;
using System.Windows.Forms;

namespace Enunciado1 {
  class Program {
    static void Main(string[] args) {
      Console.Write("Ingrese un número:\t");
      string texto = Console.ReadLine();
      int numero;
      bool correcto = Int32.TryParse(texto, out numero);
      Console.Write("\nCuenta regresiva:\t");
      Regresiva(numero);
      MessageBox.Show("¿Te gustó?");
    }
    private static void Regresiva(int numero) {
      if (numero == 0) return;
      Console.Write(numero + " ");
      Regresiva(numero - 1);
    }
  }
}
