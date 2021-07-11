using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class Parcial2 : Form
    {
        public Parcial2()
        {
            InitializeComponent();
        }
        private void Parcial2_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            PrepararArchivo("../../empleados.txt");
            PrepararArchivo("../../ingresos.txt");
            AntesMediodia();    // Vista izquierda
            DespuesMediodia();  // Vista derecha
        }

        #region COMUNES
        private void PrepararArchivo(string archivo)
        {
            string contenido = File.ReadAllText(archivo);
            var lineas = contenido.Split(Environment.NewLine.ToCharArray()).ToList();
            var ordenado = lineas.OrderBy(linea => linea.Split(',')[0]).ToList();
            int inicio = 0, final = ordenado.Count - 1;

            while (inicio < final && String.IsNullOrWhiteSpace(ordenado[inicio])) inicio++;
            while (final >= inicio && String.IsNullOrWhiteSpace(ordenado[final])) final--;

            var limpiado = ordenado.Skip(inicio).Take(final - inicio + 1);
            File.WriteAllText(archivo, string.Join(Environment.NewLine, limpiado));
        }
        #endregion

        #region IZQUIERDO
        private void AntesMediodia()
        {
            string[] empleados = File.ReadAllLines(@"../../empleados.txt");
            string[] ingresos =  File.ReadAllLines(@"../../ingresos.txt") ;
            int hora = 12;
            string intercambio = "../../temporal.txt";

            IEnumerable<string> resultados = from empleado in empleados
                                             let registroEmpleado = empleado.Split(',')
                                             from ingreso in ingresos
                                             let registroIngreso = ingreso.Split(',')
                                             where Convert.ToInt32(registroEmpleado[0]) == Convert.ToInt32(registroIngreso[3])
                                             where Convert.ToInt32(registroIngreso[0]) < hora
                                             select registroEmpleado[0] + "\t" +
                                                    registroIngreso[0]  + "\t" +
                                                    registroIngreso[1]  + "\t" +
                                                    registroIngreso[2]  + "\t" +
                                                    registroEmpleado[1] + "\t" +
                                                    registroEmpleado[2];

            File.WriteAllText(intercambio, string.Join(Environment.NewLine, resultados));
            string[] individuales = File.ReadAllLines(intercambio);

            var agrupados = from fila in individuales
                            let registro = fila.Split('\t')
                            group registro by registro[0] into REGISTROS
                            select new
                            {
                                Legajo = REGISTROS.Key,
                                Promedio = REGISTROS.Average(registro => Convert.ToInt32(registro[1])),
                            };

            grillaAntes.View = View.Details;
            grillaAntes.Columns.Add("Legajo");
            grillaAntes.Columns.Add("Promedio");

            foreach (var agrupado in agrupados)
            {
                grillaAntes.Items.Add(new ListViewItem(new string[] {
                                                                      agrupado.Legajo,
                                                                      agrupado.Promedio.ToString()
                }));
            }
        }
        #endregion

        #region DERECHO
        private void DespuesMediodia()
        {
            string[] empleados = File.ReadAllLines(@"../../empleados.txt");
            string[] ingresos =  File.ReadAllLines(@"../../ingresos.txt") ;
            int hora = 12;

            IEnumerable<string> resultados = from empleado in empleados
                                             let registroEmpleado = empleado.Split(',')
                                             from ingreso in ingresos
                                             let registroIngreso = ingreso.Split(',')
                                             where Convert.ToInt32(registroEmpleado[0]) == Convert.ToInt32(registroIngreso[3])
                                             where Convert.ToInt32(registroIngreso[0]) > hora
                                             select registroEmpleado[0] + "\t" +
                                                    registroEmpleado[1] + "\t" +
                                                    registroEmpleado[2] + "\t" +
                                                    registroIngreso[0]  + "\t" +
                                                    registroIngreso[1]  + "\t" +
                                                    registroIngreso[2];
            grillaDespues.View = View.Details;
            grillaDespues.Columns.Add("Legajo");
            grillaDespues.Columns.Add("Nombre");
            grillaDespues.Columns.Add("Apellido");
            grillaDespues.Columns.Add("Hora");
            grillaDespues.Columns.Add("Minuto");
            grillaDespues.Columns.Add("Segundo");

            string[] campos;

            foreach (string resultado in resultados)
            {
                campos = resultado.Split('\t');
                grillaDespues.Items.Add(new ListViewItem(new string[] {
                                                                        campos[0],
                                                                        campos[1],
                                                                        campos[2],
                                                                        campos[3],
                                                                        campos[4],
                                                                        campos[5]
                }));
            }
        }
        #endregion
    
    }
}
