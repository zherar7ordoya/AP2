using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinarioBusqueda
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolBinario arbolBinarioBusqueda = new ArbolBinario();
            ArbolAVL arbolAVL = new ArbolAVL();

            int valorInsercion;

            Console.WriteLine("CREAR ÁRBOL ALEATORIO");
            Console.WriteLine("Presione una tecla para continuar..");
            Console.ReadKey();
            Random aleatorio = new Random();

            // inserta 10 enteros aleatorios del 0-99 en el árbol
            for (int i = 1; i <= 10; i++)
            {
                valorInsercion = aleatorio.Next(100);
                Console.Write(valorInsercion + " ");
                
                arbolBinarioBusqueda.AgregarDato(valorInsercion);
                arbolAVL.AgregarDato(valorInsercion);
            } 

            // realiza recorrido preorden del árbol
            Console.WriteLine("\n\nRecorrer preorden");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();

            arbolBinarioBusqueda.MostrarRecorridoPreorden();

            
            
            // realiza recorrido inorden del arbol
            Console.WriteLine("\n\nRecorrer inorden");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();

            arbolBinarioBusqueda.MostrarRecorridoInorden();
            Console.WriteLine();
            arbolAVL.MostrarArbolInOrder();

            // realiza recorrido postorden del árbol
            Console.WriteLine("\n\nRecorrer postorden");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            arbolBinarioBusqueda.MostrarRecorridoPostorden();

            Console.WriteLine("\n\nFIN\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
