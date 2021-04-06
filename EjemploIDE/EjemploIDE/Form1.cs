using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploIDE
{
    public partial class FormularioInicial : Form
    {
        public FormularioInicial()
        {
            InitializeComponent();
        }

        

        private void Paises_SelectedIndexChanged(object sender, EventArgs e)
        {
            string texto = Paises.GetItemText(Paises.SelectedItem);
            MessageBox.Show(texto);
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            string nombre = NombreUsuario.Text;
            string direccion = DireccionUsuario.Text;
            MessageBox.Show(nombre + '\n' + direccion);
        }
    }
}
