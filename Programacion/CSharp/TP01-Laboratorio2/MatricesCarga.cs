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
  public partial class frmMatricesCarga : Form {
    public frmMatricesCarga() {
      AllocConsole();
      InitializeComponent();
    }
    [System.Runtime.InteropServices.DllImport("kernel32.dll")]
    private static extern bool AllocConsole();
    [System.Runtime.InteropServices.DllImport("kernel32.dll")]
    public static extern bool FreeConsole();



    private void frmMatricesCarga_Load(object sender, EventArgs e) {
      this.ControlBox = false;

      // System.Console.WriteLine("What ever you want");

    }

    private void btnEjecutar_Click(object sender, EventArgs e) {

      string dato;
      int[,] matriz; //declaro mi vector 
      matriz = new int[3, 4];//inicializo mi matriz 
                             //recorro la matriz anidando dos ciclos for 
      int i, j;
      for (i = 0; i < 3; i++)//con este bucle recorro las filas 
      {
        for (j = 0; j < 4; j++)//con este bucle recorro las columnas 
        {
          Console.WriteLine("Ingrese un valor: ");//Imprimo en pantalla
                              dato = Console.ReadLine();//Guardo en mi variable dato el valor ingresado por consola
                    matriz[i, j] = Int32.Parse(dato);
        }
      }

      Console.WriteLine("Los datos de la matriz fueron impresos");
      //Recorro nuevamente la matriz, para cargar los datos en mi listBox
            for (i = 0; i < 3; i++) {
        for (j = 0; j < 4; j++) {
          int ver = matriz[i, j];
          lst1.Items.Add("En la fila: " + i + " columna:" + j + " el valor es: " + matriz[i,j]); 
                }
      }

    }

    private void btnSalir_Click(object sender, EventArgs e) {
      Close();
    }
  }
}
