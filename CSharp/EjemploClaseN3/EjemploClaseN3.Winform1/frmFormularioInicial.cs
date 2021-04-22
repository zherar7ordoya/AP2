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
    public partial class frmFormularioInicial : Form
    {
        public  frmFormularioInicial()
        {
            InitializeComponent();
        }

        private void frmFormularioInicial_Load(object sender, EventArgs e)
        {

        }

        private void btnAbrirForm2_Click(object sender, EventArgs e)
        {
            frmFormulario2 frm = new frmFormulario2();

                      
            frm.Show();


        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length == 0)
            {
                MessageBox.Show("Por favor, ingrese un nombre");
            }
            else
            {
                MessageBox.Show("Bienvenido " + txtNombre.Text);
            }
        }

        private void numProgresoActual_ValueChanged(object sender, EventArgs e)
        {
            progressBar1.Value = (int) numProgresoActual.Value;

        }

        private void btnCambiarFuente_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();

            lblNombre.Font = fontDialog1.Font;
        }

        private void bntCambiarColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            lblNombre.BackColor = colorDialog1.Color;
        }

        private void btnAbrirCarpetas_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
        }

        private void cmdAbrirForm3_Click(object sender, EventArgs e)
        {
            frmFormulario3 frm = new frmFormulario3();
            frm.Show();
        }
    }
}
