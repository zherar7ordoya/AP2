﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enunciado1 {
  class Program {
    static void Main(string[] args) {
      Console.Write("Ingrese un número:\t");
      string texto = Console.ReadLine();
      int numero;
      bool correcto = Int32.TryParse(texto, out numero);
      Console.Write("\nCuenta regresiva:\t");
      Regresiva(numero);
      Console.ReadKey();
    }
    private static void Regresiva(int numero) {
      if (numero == 0) return;
      Console.Write(numero + " ");
      Regresiva(numero - 1);
    }
  }
}
