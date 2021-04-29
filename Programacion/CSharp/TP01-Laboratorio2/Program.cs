/**
 * @author: Gerardo Tordoya
 * @date: 2021-04-28
 * @project: 
 *          Asignación: TP 1 (Laboratorio #2)
 *          Materia:    Programación 1
 *          Comisión:   1-O-N
 *          Carrera:    Analista Programador
 * UAI 2021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP01_Laboratorio2 {
  static class Program {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new frmDateTimePicker3());
    }
  }
}
