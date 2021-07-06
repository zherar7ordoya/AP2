using System;

namespace Video1ArbolesAVL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Nodo raiz = new Nodo();
            raiz.Nombre = "A".PadLeft(2, ' ').PadRight(3, ' ');
            raiz.Izquierda = new Nodo();
            raiz.Izquierda.Nombre = "B".PadLeft(2, ' ').PadRight(3, ' ');
            raiz.Derecha = new Nodo();
            raiz.Derecha.Nombre = "C".PadLeft(2, ' ').PadRight(3, ' ');
            raiz.Izquierda.Derecha = new Nodo();
            raiz.Izquierda.Derecha.Nombre = "D".PadLeft(2, ' ').PadRight(3, ' ');
            raiz.Derecha.Izquierda = new Nodo();
            raiz.Derecha.Izquierda.Nombre = "E".PadLeft(2, ' ').PadRight(3, ' ');
            raiz.Derecha.Derecha = new Nodo();
            raiz.Derecha.Derecha.Nombre = "F".PadLeft(2, ' ').PadRight(3, ' ');

            BTreePrinter.Print(raiz);
            Console.WriteLine(Environment.NewLine);
        }
    }
}
