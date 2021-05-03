﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP01_Laboratorio2 {
  public partial class frmDateTimePicker1 : Form {
    public frmDateTimePicker1() {
      InitializeComponent();
    }
    private void frmDateTimePicker1_Load(object sender, EventArgs e) {
      // this.ControlBox = false;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      System.Console.WriteLine("No te preocupes por mí. Solo ignórame...");
    }

    private void btnEjecutar_Click(object sender, EventArgs e) {
      DateTime Fecha = this.dateTimePicker1.Value;
      textBox1.Text = Convert.ToString(Fecha);
      //Fecha Corta 
      textBox2.Text = string.Format("{0:d}", Fecha);
      //Fecha Larga + tiempo 
      textBox3.Text = string.Format("{0:D}", Fecha);
      //Fecha larga + tiempocorto 
      textBox4.Text = string.Format("{0:f}", Fecha);
      //Fecha corta + tiempo corto 
      textBox5.Text = string.Format("{0:g}", Fecha);
      //Fecha corta + tiempo largo 
      textBox6.Text = string.Format("{0:G}", Fecha);
    }
  }
}
