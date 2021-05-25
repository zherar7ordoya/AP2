using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1 {
  public class myLinkedList<T> : IEnumerable<T> {
    

    //priavte fields
    //===============
    private ListNode<T> front;
    private int size;

    //Constructor
    //===========
    public myLinkedList() {
      front = null;
      size = 0;
    }


    //public methods
    //===============
    public bool isEmpty() {
      return (size == 0);
    }

    public bool addFront(T element) {
      front = new ListNode<T>(element, front);
      size++;
      return true;
    }

    public bool addBack(T element) {
      ListNode<T> current = front;
      while (current.next != null) {
        current = current.next;
      }

      current.next = new ListNode<T>(element);
      size++;
      return true;
    }

    public override string ToString() {
      ListNode<T> current = front;
      if (current == null) {
        return "**** Empty ****";
      }
      else {
        StringBuilder sb = new StringBuilder();
        while (current.next != null) {
          sb.Append(current.data + ", ");
          current = current.next;
        }
        sb.Append(current.data);

        return sb.ToString();
      }
    }

    // These make myLinkedList<T> implement IEnumerable<T> allowing
    // a LinkedList to be used in a foreach statement.
    public IEnumerator<T> GetEnumerator() {
      var node = front;
      while (node != null) {
        yield return node.data;
        node = node.next;
      }
    }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
      return GetEnumerator();
    }
        
  }
}
