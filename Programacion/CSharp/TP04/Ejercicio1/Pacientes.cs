﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1 {
  public partial class Pacientes : Form {
    //////////////////////////////////////////////////////////// INICIALIZACIÓN
    public Pacientes() { InitializeComponent(); }

    private void Pacientes_Load(object sender, EventArgs e) {
      /*
      var arrEmp = new[] {
        new Emp( 1, "Devesh Omar", "Noida"),
        new Emp( 2, "Roli", "Kanpur"),
        new Emp( 3, "Roli Gupta", "Mainpuri"),
        new Emp( 3, "Roli Gupta", "Kanpur"),
        new Emp( 3, "Devesh Roli ", "Noida"),
      };
      dataGridView1.DataSource = arrEmp;
      */

      MyLinkedList myList = new MyLinkedList();
      myList.Add("10", "diez");
      myList.Add("15", "quince");
      myList.Add("20", "veinte");
      List<String> mySimpleList = new List<string>(myList);

      /*
      var alumnos = new List<Alumno>
      {
        new Alumno {Nombre = "Pedro", Nota = 5},
        new Alumno {Nombre = "Jorge", Nota = 8},
        new Alumno {Nombre = "Andres", Nota = 3}
      };
      */
      var alumnos = new List<Node>
      {
        new Node {data = "Pedro", dato = "5"},
        new Node {data = "Jorge", dato = "8"},
        new Node {data = "Andres", dato = "3"},
        
      };
      dataGridView1.DataSource = alumnos;


      /*
      LESExperimental MisPacientes = new LESExperimental();
      MisPacientes.Agregar(1, "uno", "I", "Calle Norte", "4255221");
      MisPacientes.Agregar(2, "dos", "II", "Calle Sur", "4255222");
      MisPacientes.Agregar(3, "tres", "III", "Calle Este", "4255223");
      MisPacientes.Agregar(4, "cuatro", "IV", "Calle Oeste", "4255224");
      */

      /*
      var listado = new[] {
        new NodeExperimental(1, "uno", "I", "Calle Norte", "4255221"),
        new NodeExperimental(2, "dos", "II", "Calle Sur", "4255222"),
        new NodeExperimental(3, "tres", "III", "Calle Este", "4255223"),
        new NodeExperimental(4, "cuatro", "IV", "Calle Oeste", "4255224"),
      };
      */

      /*
      string[] array = myList.ToArray();
      array.Select((x, index) => new { REGISTRO = index + 1, CODIGO = x }).ToArray();
      List<string> list = myList.ToList();
      // items above 13
      // var items = myList.Where(i => i > 13);
      */

      //dataGridView1.DataSource = arrEmp;
      //dataGridView1.DataSource = array.Select((x, y) => new { REGISTRO = x, CODIGO = y }).ToArray();

      /*

      int[] theData = new int[] { 14, 17, 5, 11, 2 };
      dataGridView1.DataSource = theData.Select((x, index) =>
            new { REGISTRO = index + 1, CODIGO = x }).ToList();
      // .Where(x => x > 0)
      // .OrderByDescending(x => x.CODIGO)

  */
    }
    ///////////////////////////////////////////////////////////////// CONTROLES

    ///////////////////////////////////////////////////////////////// FUNCIONES

  }
}

