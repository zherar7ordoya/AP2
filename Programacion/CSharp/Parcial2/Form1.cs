using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class Parcial2 : Form
    {
        public Parcial2()
        {
            InitializeComponent();
            Carga();
            Prueba();
        }

        private void Carga()
        {
            string[] empleados = File.ReadAllLines(@"../../empleados.txt");
            string[] ingresos = File.ReadAllLines(@"../../ingresos.txt");

            IEnumerable<string> consultaAntes =
            from empleado in empleados
            let registroEmpleado = empleado.Split(',')
            from ingreso in ingresos
            let registroIngreso = ingreso.Split(',')
            where Convert.ToInt32(registroEmpleado[0]) == Convert.ToInt32(registroIngreso[3])
            select registroEmpleado[0] + "\t" +
                    registroIngreso[0] + "\t" +
                    registroIngreso[1] + "\t" +
                    registroIngreso[2];

        }
        private void Prueba()
        {
            string[] myTable = File.ReadAllLines(@"../../myTable.csv");

            var results = from row in myTable
                          let registro = row.Split(';')
                          group registro by registro[0] into registros
                          select new
                          {
                              Id = registros.Key,
                              AverageScore = registros.Average(registro => Convert.ToInt32(registro[1]))
                          };
            
            MessageBox.Show("");
        }
    }
}
