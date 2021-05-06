using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enunciado10 {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }
    // *------------------------------------------------------------=> GLOBALES
    string texto, desde, hacia;
    int numero;

    private void Form1_Load(object sender, EventArgs e) {
      // *-----------------------------------------------------------------=> *
      label0.Text = "PORTADA.------------" + Environment.NewLine +
                    "2021-05-06" + Environment.NewLine +
                    "Gerardo Tordoya" + Environment.NewLine +
                    "Trabajo Práctico 3" + Environment.NewLine +
                    "Programación I" + Environment.NewLine +
                    "Comisión 1-O-N" + Environment.NewLine +
                    "Analista Programador" + Environment.NewLine +
                    "UAI 2021";
      // this.ControlBox = false;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      // *-----------------------------------------------------------------=> *
    }
    // *-------------------------------------------------------------=> EVENTOS
    private void textBox1_TextChanged(object sender, EventArgs e) {
      convertir();
    }
    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
      convertir();
    }
    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) {
      convertir();
    }
    // *-----------------------------------------------------------=> PRINCIPAL
    private void convertir() {
      // Verificación.
      texto = textBox1.Text;
      desde = comboBox1.Text;
      hacia = comboBox2.Text;
      bool correcto1 = Int32.TryParse(texto, out numero);

      bool correcto2 = false, correcto3 = false;
      if (desde != "Desde") correcto2 = true;
      if (hacia != "Hacia") correcto3 = true;

      // Operaciones.
      if (correcto1 && correcto2 && correcto3) {
        calcular();
        grabar();
      }
    }

    private void calcular() {
      if (desde == "Celsius" && hacia == "Celsius") label1.Text = (numero * 1).ToString();
      if (desde == "Celsius" && hacia == "Fahrenheit") label1.Text = (numero * 1.8 + 32).ToString();
      if (desde == "Celsius" && hacia == "Kelvin") label1.Text = (numero + 273.15).ToString();
      if (desde == "Celsius" && hacia == "Rankine") label1.Text = (numero * 1.8 + 32 + 459.67).ToString();

      if (desde == "Fahrenheit" && hacia == "Fahrenheit") label1.Text = (numero * 1).ToString();
      if (desde == "Fahrenheit" && hacia == "Celsius") label1.Text = ((numero - 32) / 1.8).ToString();
      if (desde == "Fahrenheit" && hacia == "Kelvin") label1.Text = ((numero + 459.67) / 1.8).ToString();
      if (desde == "Fahrenheit" && hacia == "Rankine") label1.Text = (numero + 459.67).ToString();

      if (desde == "Kelvin" && hacia == "Kelvin") label1.Text = (numero * 1).ToString();
      if (desde == "Kelvin" && hacia == "Celsius") label1.Text = (numero - 273.15).ToString();
      if (desde == "Kelvin" && hacia == "Fahrenheit") label1.Text = (numero * 1.8 - 459.67).ToString();
      if (desde == "Kelvin" && hacia == "Rankine") label1.Text = (numero * 1.8).ToString();

      if (desde == "Rankine" && hacia == "Rankine") label1.Text = (numero * 1).ToString();
      if (desde == "Rankine" && hacia == "Celsius") label1.Text = ((numero - 32 - 459.67) / 1.8).ToString();
      if (desde == "Rankine" && hacia == "Fahrenheit") label1.Text = (numero - 459.67).ToString();
      if (desde == "Rankine" && hacia == "Kelvin") label1.Text = (numero / 1.8).ToString();
    }

    private void grabar() {
      var index = dataGridView1.Rows.Add();
      dataGridView1.Rows[index].Cells["Cantidad"].Value = textBox1.Text;
      dataGridView1.Rows[index].Cells["Desde"].Value = comboBox1.Text;
      dataGridView1.Rows[index].Cells["Hacia"].Value = comboBox2.Text;
      dataGridView1.Rows[index].Cells["Equivalencia"].Value = label1.Text;
    }
  }
}
