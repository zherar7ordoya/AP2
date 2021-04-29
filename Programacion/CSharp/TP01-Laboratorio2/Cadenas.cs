using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP01_Laboratorio2 {
  public partial class frmCadenas : Form {
    public frmCadenas() {
      InitializeComponent();
    }
    private void frmCadenas_Load(object sender, EventArgs e) {
      this.ControlBox = false;
      // this.MaximizeBox = false;
      // this.MinimizeBox = false;
      System.Console.WriteLine("No te preocupes por mí. Solo ignórame...");
    }

    private void btnEjecutar_Click(object sender, EventArgs e) {
      string variable = textBox1.Text; // Asigno el valor a la variable del texbox1 
      textBox2.Text = variable.Length.ToString(); // Asigno al texbox2 el tamaño de la palabra ingresada 

      // Si en el txtdato es > 0, devuelvo, el caracter en la posicion indicada 
      if ((textBox3a.Text.Length > 0)) {
        int pos = Convert.ToInt32(textBox3a.Text);
        textBox3b.Text = (variable[pos]).ToString();
      }

      textBox4.Text = variable.Insert(3, "12345"); // A la cadena le inserto 12345 
      textBox5.Text = variable.TrimStart(); // Quito los espacios en blanco la final de la cadena 

      // NO COMENTES EL QUÉ HACES SINO EL POR QUÉ LO HACES...
      if (textBox6.Text == "ABC") {
        textBox6.Text = "Si";
      } else {
        textBox6.Text = "No";
      }

      // Le agrego ceros a la derecha hasta llegar a los 10 caracteres
      if ((variable.Length < 10)) {
                textBox7.Text = variable.PadRight(10, '0');
      }
      
      textBox8b.Text = string.Concat(textBox8a.Text, variable); // Concateno la cadena
    }

    private void btnSalir_Click(object sender, EventArgs e) {
      Application.Exit();
    }
  }
}
