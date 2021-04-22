using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploClaseN3.Winform1
{
    public partial class frmFormulario2 : Form
    {
        public frmFormulario2()
        {
            InitializeComponent();
        }

        private void btnVerSeleccionado_Click(object sender, EventArgs e)
        {
            if (rdAzul.Checked)
            {
                MessageBox.Show("el color seleccionado es azul");
            }
            else
            {
                if (rdRojo.Checked)
                {
                    MessageBox.Show("el color seleccionado es rojo");
                }
                else
                {
                    MessageBox.Show("el color seleccionado es verde");
                }
            }
        }
    }
}
