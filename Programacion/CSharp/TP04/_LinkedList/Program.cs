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

      /////////////////////////////////////////////////////////////////////////
      // Create the link list.
      string[] palabras = { "Red", "es", "rojo,", "Green", "es", "azul." };
      LinkedList<string> oracion = new LinkedList<string>(palabras);

      Muestrame(oracion, "\nValores de la lista enlazada:");
      Console.WriteLine("\noracion.Contains(\"Gerardo\") = {0}", oracion.Contains("Gerardo"));
      Console.WriteLine("oracion.Contains(\"Green\") = {0}", oracion.Contains("Green"));

      // Add the word 'today' to the beginning of the linked list.
      oracion.AddFirst("XXX");
      Muestrame(oracion, "\nPrueba 1: Añadir 'XXX' al principio de la lista enlazada:");

      // Move the first node to be the last node.
      LinkedListNode<string> nodo1 = oracion.First; // "XXX"
      oracion.RemoveFirst();
      oracion.AddLast(nodo1);
      Muestrame(oracion, "\nPrueba 2: Mover el primer nodo a la última posición:");

      // Change the last node to 'yesterday'.
      oracion.RemoveLast();
      oracion.AddLast("TMP");
      Muestrame(oracion, "\nPrueba 3: Cambiar el último nodo a 'TMP':");

      // Move the last node to be the first node.
      nodo1 = oracion.Last; // "igual"
      oracion.RemoveLast();
      oracion.AddFirst(nodo1);
      Muestrame(oracion, "\nPrueba 4: Mover el último nodo al primer lugar:");

      // Indicate the last occurence of 'the'.
      oracion.RemoveFirst(); // ¿para qué? <=---* SIN ESTO, FALLA LA PRUEBA 13
      LinkedListNode<string> nodoActual = oracion.FindLast("es");
      BuscarNodo(nodoActual, "\nPrueba 5: Indicar la última posición de 'es':");

      // Add 'lazy' and 'old' after 'the' (the LinkedListNode named nodoActual).
      oracion.AddAfter(nodoActual, "BLUE");
      oracion.AddAfter(nodoActual, "verde,");
      BuscarNodo(nodoActual, "\nPrueba 6: Añadir 'verde,' y 'BLUE' despues de 'es':");

      // Indicate 'fox' node.
      nodoActual = oracion.Find("azul.");
      BuscarNodo(nodoActual, "\nPrueba 7: Indicar el nodo 'azul.':");

      // Add 'quick' and 'brown' before 'fox':
      oracion.AddBefore(nodoActual, "Blue");
      oracion.AddBefore(nodoActual, "es");
      BuscarNodo(nodoActual, "\nPrueba 8: Añadir 'Blue' y 'es' antes de 'azul.':");

      // Keep a reference to the nodoActual node, 'fox',
      // and to the previous node in the list. Indicate the 'dog' node.
      nodo1 = nodoActual; // 'seis'
      LinkedListNode<string> nodo2 = nodoActual.Previous; // 'Tordoya'
      nodoActual = oracion.Find("BLUE");
      BuscarNodo(nodoActual, "\nPrueba 9: Indicar el nodo 'BLUE':");

      // The AddBefore method throws an InvalidOperationException
      // if you try to add a node that already belongs to a list.
      Console.WriteLine("\nPrueba 10: Lanzar excepción al añadir un nodo existente (BLUE):");
      try {
        // En otros lados (sin error): oracion.AddBefore(nodoActual, "Gerardo");
        oracion.AddBefore(nodoActual, nodo1); // 'Tordoya' / 'seis'
      }
      catch (InvalidOperationException error) {
        Console.WriteLine("Mensaje de excepción: {0}", error.Message);
      }

      // Remove the node referred to by nodo1, and then add it
      // before the node referred to by nodoActual.
      // Indicate the node referred to by nodoActual.
      oracion.Remove(nodo1);
      oracion.AddBefore(nodoActual, nodo1); 
      BuscarNodo(nodoActual, "\nPrueba 11: Mover un nodo referenciado a una posición anterior al nodo actual:");

      // Remove the node referred to by nodoActual.
      oracion.Remove(nodoActual); 
      BuscarNodo(nodoActual, "\nPrueba 12: Borrar nodo actual e intentar señalarlo:");

      // Add the node after the node referred to by nodo2.
      oracion.AddAfter(nodo2, nodoActual);
      BuscarNodo(nodoActual, "\nPrueba 13: Añadir el nodo borrado en la Prueba 11 a una posición posterior:");

      // The Remove method finds and removes the
      // first node that that has the specified value.
      oracion.Remove("azul.");
      Muestrame(oracion, "\nPrueba 14: Borrar nodo 'azul.':");

      // When the linked list is cast to ICollection (of Strings),
      // the Add method adds a node to the end of the list.
      oracion.RemoveLast();
      ICollection<string> coleccion = oracion;
      coleccion.Add("azul.");
      Muestrame(oracion, "\nPrueba 15: Borrar el último nodo, enviar a ICollection, y añadir 'azul.':");

      Console.WriteLine("\nPrueba 16: Copiar la lista a un vector:");
      // Create an array with the same number of
      // elements as the linked list.
      string[] vector = new string[oracion.Count];
      oracion.CopyTo(vector, 0);
      foreach (string cadena in vector) Console.WriteLine(cadena);

      // Release all the nodes.
      oracion.Clear();
      Console.WriteLine("\nPrueba 17: Limpiar la lista enlazada: ¿Contiene 'Red'? = {0}", oracion.Contains("Red"));

      // Espérate tantito...
      Console.ReadLine();
    }

    private static void Muestrame(LinkedList<string> palabras, string prueba) {
      Console.WriteLine(prueba);
      foreach (string palabra in palabras) Console.Write(palabra + "  ");
      Console.WriteLine();
    }

    private static void BuscarNodo(LinkedListNode<string> nodo, string prueba) {
      Console.WriteLine(prueba);
      if (nodo.List == null) {
        Console.WriteLine("El nodo '{0}' no está en la lista.", nodo.Value);
        return;
      }
      StringBuilder resultado = new StringBuilder("<" + nodo.Value + ">");
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
    }
    ///////////////////////////////////////////////////////////////////////////

  }
}
