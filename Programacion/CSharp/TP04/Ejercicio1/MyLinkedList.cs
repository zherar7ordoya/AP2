using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1 {
  public class MyLinkedList : IEnumerable<int> {
  

    private Node headNode;

    private int count;

    public MyLinkedList() {
      headNode = null;
      count = 0;
    }

    public int Count() {
      return count;
    }

    public void Add(int i) {
      if (headNode == null) {
        headNode = new Node(i);
      }
      else {
        headNode.Add(i);
      }
      count++;
    }

    
    // *---------------------------------=> *
    public IEnumerator<int> GetEnumerator() {
      Node current = headNode;
      while (current != null) {
        yield return current.data;
        current = current.next;
      }
    }
    IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
    // *-----------------------------------------------------------=> *
    
  }
}


