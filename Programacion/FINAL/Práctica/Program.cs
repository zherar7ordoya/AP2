using System;
using System.Windows.Forms;

namespace Integrador
{
    static class Program
    {
        /// <summary>
        /// Esto es todo automático.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Combi());
        }
    }
}
