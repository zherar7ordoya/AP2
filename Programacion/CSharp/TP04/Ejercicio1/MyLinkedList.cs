using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1 {
  public class MyLinkedList : IEnumerable<string> {
  

    private Node headNode;

    private int count;

    public MyLinkedList() {
      headNode = null;
      count = 0;
    }

    public int Count() {
      return count;
    }

    
    public void Add(string i, string s) {
      if (headNode == null) {
        headNode = new Node(i, s);
      }
      else {
        headNode.Add(i, s);
      }
      count++;
    }
    
    
    // *---------------------------------=> *
    

    public IEnumerator<string> GetEnumerator() {
      Node current = headNode;
      while (current != null) {
        yield return current.data;
        yield return current.dato;
        current = current.next;
      }
    }

    IEnumerator IEnumerable.GetEnumerator() {
      return GetEnumerator();
    }
    // *-----------------------------------------------------------=> *

  }
}


