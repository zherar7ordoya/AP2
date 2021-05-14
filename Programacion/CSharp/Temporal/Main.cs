using System;
using System.Collections.Generic;
using System.Text;

///////////////////////////////////////////////////////////////////////// ABOUT
/**
 * Esto es lo primero y más básico que habría que responder:
 * Esta estructura de datos, ¿para qué sirve, para qué se usa?
 * USOS:
 * -) (No lo especifica el artículo). 
 * */

namespace _LinkedList {
  class Program {
    static void Main(string[] args) {

      // Create the link list.
      string[] palabras = { "Uno", "Dos", "Tres", "Cuatro", "Cinco", "Seis" };
      LinkedList<string> oracion = new LinkedList<string>(palabras);
      Muestrame(oracion, "Valores de la lista enlazada:");
      Console.WriteLine("oracion.Contains(\"Gerardo\") = {0}", oracion.Contains("Gerardo"));
      Console.WriteLine("oracion.Contains(\"Def Leppard\") = {0}", oracion.Contains("Def Leppard"));

      // Add the word 'today' to the beginning of the linked list.
      oracion.AddFirst("Yo soy");
      Muestrame(oracion, "\nPrueba 1: Añadir 'Yo soy' al principio de la lista enlazada:");

      // Move the first node to be the last node.
      LinkedListNode<string> nodo1 = oracion.First;
      oracion.RemoveFirst();
      oracion.AddLast(nodo1);
      Muestrame(oracion, "\nPrueba 2: Mover el primer nodo a la última posición:");

      // Change the last node to 'yesterday'.
      oracion.RemoveLast();
      oracion.AddLast("Rocks!");
      Muestrame(oracion, "\nPrueba 3: Cambiar el último nodo a 'Rocks!':");

      // Move the last node to be the first node.
      nodo1 = oracion.Last;
      oracion.RemoveLast();
      oracion.AddFirst(nodo1);
      Muestrame(oracion, "\nPrueba 4: Mover el último nodo al primer lugar:");

      // Indicate the last occurence of 'the'.
      oracion.RemoveFirst();
      LinkedListNode<string> nodoActual = oracion.FindLast("es");
      BuscarNodo(nodoActual, "\nPrueba 5: Indicar la última posición de 'es':");

      // Add 'lazy' and 'old' after 'the' (the LinkedListNode named nodoActual).
      oracion.AddAfter(nodoActual, "Def");
      oracion.AddAfter(nodoActual, "Leppard");
      BuscarNodo(nodoActual, "\nPrueba 6: Añadir 'Def' y 'Leppard' despues de 'es':");

      // Indicate 'fox' node.
      nodoActual = oracion.Find("Tordoya");
      BuscarNodo(nodoActual, "\nPrueba 7: Indicar el nodo 'Tordoya' node:");

      // Add 'quick' and 'brown' before 'fox':
      oracion.AddBefore(nodoActual, "Hysteria");
      oracion.AddBefore(nodoActual, "Animal");
      BuscarNodo(nodoActual, "\nPrueba 8: Añadir 'Hysteria' y 'Animal' antes de 'es':");

      // Keep a reference to the nodoActual node, 'fox',
      // and to the previous node in the list. Indicate the 'dog' node.
      nodo1 = nodoActual;
      LinkedListNode<string> nodo2 = nodoActual.Previous;
      nodoActual = oracion.Find("Def");
      BuscarNodo(nodoActual, "\nPrueba 9: Indicar el nodo 'Def':");

      // The AddBefore method throws an InvalidOperationException
      // if you try to add a node that already belongs to a list.
      Console.WriteLine("\nPrueba 10: Lanzar excepción al añadir un nodo existente (es) already in the list:");
      try {
        oracion.AddBefore(nodoActual, nodo1);
      }
      catch (InvalidOperationException error) {
        Console.WriteLine("Mensaje de excepción: {0}", error.Message);
      }
      Console.WriteLine();

      // Remove the node referred to by nodo1, and then add it
      // before the node referred to by nodoActual.
      // Indicate the node referred to by nodoActual.
      oracion.Remove(nodo1);
      oracion.AddBefore(nodoActual, nodo1);
      BuscarNodo(nodoActual, "\nPrueba 11: Mover un nodo referenciado (es) a una posición anterior a nodoActual (¿?):");

      // Remove the node referred to by nodoActual.
      oracion.Remove(nodoActual);
      BuscarNodo(nodoActual, "\nPrueba 12: Borrar nodoActual (¿?) e intentar indicarlo:");

      // Add the node after the node referred to by nodo2.
      oracion.AddAfter(nodo2, nodoActual);
      BuscarNodo(nodoActual, "\nPrueba 13: Añadir el nodo borrado en la Prueba 11 a una posición posterior (¿?):");

      // The Remove method finds and removes the
      // first node that that has the specified value.
      oracion.Remove("Animal");
      Muestrame(oracion, "\nPrueba 14: Borrar nodo 'Animal':");

      // When the linked list is cast to ICollection(of String),
      // the Add method adds a node to the end of the list.
      oracion.RemoveLast();
      ICollection<string> coleccion = oracion;
      coleccion.Add("Rinoceronte");
      Muestrame(oracion, "\nPrueba 15: Borrar el último nodo, enviar a ICollection, y añadir 'Rinoceronte':");

      Console.WriteLine("\nPrueba 16: Copiar la lista a un vector:");
      // Create an array with the same number of
      // elements as the linked list.
      string[] vector = new string[oracion.Count];
      oracion.CopyTo(vector, 0);
      foreach (string cadena in vector) Console.WriteLine(cadena);

      // Release all the nodes.
      oracion.Clear();

      Console.WriteLine();
      Console.WriteLine("\nPrueba 17: Limpiar la lista enlazada: ¿Contiene 'Gerardo'? = {0}", oracion.Contains("Gerardo"));

      Console.ReadLine();
    }

    private static void Muestrame(LinkedList<string> palabras, string prueba) {
      Console.WriteLine(prueba);
      foreach (string palabra in palabras) Console.Write(palabra + " ");
      Console.WriteLine();
    }

    private static void BuscarNodo(LinkedListNode<string> nodo, string prueba) {
      Console.WriteLine(prueba);
      if (nodo.List == null) {
        Console.WriteLine("El nodo '{0}' no está en la lista.\n", nodo.Value);
        return;
      }

      StringBuilder resultado = new StringBuilder("(" + nodo.Value + ")");
      LinkedListNode<string> nodoAnterior = nodo.Previous;

      while (nodoAnterior != null) {
        resultado.Insert(0, nodoAnterior.Value + " ");
        nodoAnterior = nodoAnterior.Previous;
      }

      nodo = nodo.Next;
      while (nodo != null) {
        resultado.Append(" " + nodo.Value);
        nodo = nodo.Next;
      }

      Console.WriteLine(resultado);
      Console.ReadKey();
    }
  }
}
