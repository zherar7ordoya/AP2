using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1 {
  class Node {


    public int data;
    public Node next;

    /*
    public Node(int i) {
      data = i;
      next = null;
    }
    */
    public Node(int i) {
      this.data = i;
      this.next = null;
    }

    public void Add(int i) {
      if (next == null) {
        next = new Node(i);
      }
      else {
        next.Add(i);
      }
    }


  }
}
