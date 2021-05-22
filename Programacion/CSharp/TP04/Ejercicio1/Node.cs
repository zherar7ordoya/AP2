using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1 {
  class Node {

    public string data { get; set; }
    public string dato { get; set; }
    public Node next;
    
    
    public Node(string i, string s) {
      data = i;
      dato = s;
      next = null;
    }
    

      
    public void Add(string i, string s) {
      if (next == null) {
        next = new Node(i, s);
      }
      else {
        next.Add(i, s);
      }
    }
    

  }
}
