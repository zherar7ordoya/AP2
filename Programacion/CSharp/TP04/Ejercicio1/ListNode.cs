using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1 {
  //List Node class
  //===============
  class ListNode<T> {
    public T data;
    public ListNode<T> next;

    public ListNode(T d) {
      this.data = d;
      this.next = null;
    }

    public ListNode(T d, ListNode<T> n) {
      this.data = d;
      this.next = n;
    }
  }
}
