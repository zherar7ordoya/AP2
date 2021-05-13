using System;
using System.Collections.Generic;
using System.Text;

///////////////////////////////////////////////////////////////////////// ABOUT
/**
 * Esto es lo primero y más básico que habría que responder:
 * Esta estructura de datos, ¿para qué sirve, para qué se usa?
 * USOS:
 * -) (No lo especifica el artículo). => https://dev.to/adavidoaiei/fundamental-data-structures-and-algorithms-in-c-4ocf
 * */

namespace _LinkedList {
  class Program {
    static void Main(string[] args) {

      // Create the link list.
      string[] palabras =
          { "the", "fox", "jumps", "over", "the", "dog" };
      LinkedList<string> oracion = new LinkedList<string>(palabras);
      Display(oracion, "The linked list values:");
      Console.WriteLine("oracion.Contains(\"jumps\") = {0}", oracion.Contains("jumps"));

      // Add the word 'today' to the beginning of the linked list.
      oracion.AddFirst("today");
      Display(oracion, "Test 1: Add 'today' to beginning of the list:");

      // Move the first node to be the last node.
      LinkedListNode<string> nodo1 = oracion.First;
      oracion.RemoveFirst();
      oracion.AddLast(nodo1);
      Display(oracion, "Test 2: Move first node to be last node:");

      // Change the last node to 'yesterday'.
      oracion.RemoveLast();
      oracion.AddLast("yesterday");
      Display(oracion, "Test 3: Change the last node to 'yesterday':");

      // Move the last node to be the first node.
      nodo1 = oracion.Last;
      oracion.RemoveLast();
      oracion.AddFirst(nodo1);
      Display(oracion, "Test 4: Move last node to be first node:");

      // Indicate the last occurence of 'the'.
      oracion.RemoveFirst();
      LinkedListNode<string> nodoActual = oracion.FindLast("the");
      IndicateNode(nodoActual, "Test 5: Indicate last occurence of 'the':");

      // Add 'lazy' and 'old' after 'the' (the LinkedListNode named nodoActual).
      oracion.AddAfter(nodoActual, "old");
      oracion.AddAfter(nodoActual, "lazy");
      IndicateNode(nodoActual, "Test 6: Add 'lazy' and 'old' after 'the':");

      // Indicate 'fox' node.
      nodoActual = oracion.Find("fox");
      IndicateNode(nodoActual, "Test 7: Indicate the 'fox' node:");

      // Add 'quick' and 'brown' before 'fox':
      oracion.AddBefore(nodoActual, "quick");
      oracion.AddBefore(nodoActual, "brown");
      IndicateNode(nodoActual, "Test 8: Add 'quick' and 'brown' before 'fox':");

      // Keep a reference to the nodoActual node, 'fox',
      // and to the previous node in the list. Indicate the 'dog' node.
      nodo1 = nodoActual;
      LinkedListNode<string> mark2 = nodoActual.Previous;
      nodoActual = oracion.Find("dog");
      IndicateNode(nodoActual, "Test 9: Indicate the 'dog' node:");

      // The AddBefore method throws an InvalidOperationException
      // if you try to add a node that already belongs to a list.
      Console.WriteLine("Test 10: Throw exception by adding node (fox) already in the list:");
      try {
        oracion.AddBefore(nodoActual, nodo1);
      }
      catch (InvalidOperationException ex) {
        Console.WriteLine("Exception message: {0}", ex.Message);
      }
      Console.WriteLine();

      // Remove the node referred to by nodo1, and then add it
      // before the node referred to by nodoActual.
      // Indicate the node referred to by nodoActual.
      oracion.Remove(nodo1);
      oracion.AddBefore(nodoActual, nodo1);
      IndicateNode(nodoActual, "Test 11: Move a referenced node (fox) before the nodoActual node (dog):");

      // Remove the node referred to by nodoActual.
      oracion.Remove(nodoActual);
      IndicateNode(nodoActual, "Test 12: Remove nodoActual node (dog) and attempt to indicate it:");

      // Add the node after the node referred to by mark2.
      oracion.AddAfter(mark2, nodoActual);
      IndicateNode(nodoActual, "Test 13: Add node removed in test 11 after a referenced node (brown):");

      // The Remove method finds and removes the
      // first node that that has the specified value.
      oracion.Remove("old");
      Display(oracion, "Test 14: Remove node that has the value 'old':");

      // When the linked list is cast to ICollection(Of String),
      // the Add method adds a node to the end of the list.
      oracion.RemoveLast();
      ICollection<string> icoll = oracion;
      icoll.Add("rhinoceros");
      Display(oracion, "Test 15: Remove last node, cast to ICollection, and add 'rhinoceros':");

      Console.WriteLine("Test 16: Copy the list to an array:");
      // Create an array with the same number of
      // elements as the linked list.
      string[] sArray = new string[oracion.Count];
      oracion.CopyTo(sArray, 0);

      foreach (string s in sArray) {
        Console.WriteLine(s);
      }

      // Release all the nodes.
      oracion.Clear();

      Console.WriteLine();
      Console.WriteLine("Test 17: Clear linked list. Contains 'jumps' = {0}",
          oracion.Contains("jumps"));

      Console.ReadLine();
    }

    private static void Display(LinkedList<string> palabras, string test) {
      Console.WriteLine(test);
      foreach (string word in palabras) {
        Console.Write(word + " ");
      }
      Console.WriteLine();
      Console.WriteLine();
    }

    private static void IndicateNode(LinkedListNode<string> node, string test) {
      Console.WriteLine(test);
      if (node.List == null) {
        Console.WriteLine("Node '{0}' is not in the list.\n",
            node.Value);
        return;
      }

      StringBuilder result = new StringBuilder("(" + node.Value + ")");
      LinkedListNode<string> nodeP = node.Previous;

      while (nodeP != null) {
        result.Insert(0, nodeP.Value + " ");
        nodeP = nodeP.Previous;
      }

      node = node.Next;
      while (node != null) {
        result.Append(" " + node.Value);
        node = node.Next;
      }

      Console.WriteLine(result);
      Console.ReadKey();
    }
  }
}
