using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace TP01_Laboratorio2 {
  public partial class frmVectoresCarga : Form {
    public frmVectoresCarga() {
      AllocConsole();
      InitializeComponent();
    }
    [System.Runtime.InteropServices.DllImport("kernel32.dll")]
    private static extern bool AllocConsole();
    [System.Runtime.InteropServices.DllImport("kernel32.dll")]
    public static extern bool FreeConsole();



    private void frmVectoresCarga_Load(object sender, EventArgs e) {
      this.ControlBox = false;

      // System.Console.WriteLine("What ever you want");

    }

    private void btnEjecutar_Click(object sender, EventArgs e) {
      string dato;
      int[] vector; // Declaro mi vector 
      vector = new int[10]; // Inicializo mi vector  
      
      int i; // Recorro con el ciclo for las 10 posiciones del vector para cargar el mismo
      for (i = 1; i < 10; i++) {
        System.Console.WriteLine("Ingrese un valor: "); // Imprimo en pantalla 
        dato = System.Console.ReadLine(); // Guardo en mi variable dato el valor ingresado por consola
        vector[i] = Int32.Parse(dato); // Guardo el dato en el vector, en la posición i (i toma el valor del bucle)
      }
      Console.WriteLine("Los datos del vector fueron impresos");
      // Recorro nuevamente el vector, para cargar los datos en mi listBox
      for (i = 1; i < 10; i++) {
        lst1.Items.Add("En la posición : " + i + " el valor es: " + vector[i]);
      }
      
    }

    private void btnSalir_Click(object sender, EventArgs e) {
      Close();
    }
  }
}
