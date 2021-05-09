using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas2017
{
    public partial class Form1 : Form
    {

        ListaEnlazadaSimple miListaEnlazadaSimple = new ListaEnlazadaSimple();

        NodoSimple nodoSeleccionado;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerarLista();
        }

        private void GenerarLista()
        {
            this.listaNodos.Items.Clear();
            Listar(miListaEnlazadaSimple.NodoInicial);
        }

        private void Listar(NodoSimple nodo)
        {
            if (nodo != null)
            {
                listaNodos.Items.Add(nodo);
                if (nodo.Siguiente !=null)
                    Listar(nodo.Siguiente);
            }
        }

        private void cmdAgregarAlPrincipio_Click(object sender, EventArgs e)
        {
            miListaEnlazadaSimple.AgregarAlPrincipio(this.textBox1.Text);
            GenerarLista();
        }

        private void cmdAgregarAlFinal_Click(object sender, EventArgs e)
        {
            miListaEnlazadaSimple.AgregarAlFinal(this.textBox1.Text);
            GenerarLista();
        }

        private void btnQuitarPrimero_Click(object sender, EventArgs e)
        {
            miListaEnlazadaSimple.QuitarPrimero();
            GenerarLista();
        }

        private void btnQuitarUltimo_Click(object sender, EventArgs e)
        {
            miListaEnlazadaSimple.QuitarUltimo();
            GenerarLista();
        }

        private void listaNodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            nodoSeleccionado = (NodoSimple) this.listaNodos.SelectedItem;
   
        }

        private void btnQuitarSeleccionado_Click(object sender, EventArgs e)
        {
            if (nodoSeleccionado != null)
            {
                 miListaEnlazadaSimple.QuitarPosicion(nodoSeleccionado.Numero);
                GenerarLista();
            }
               
            else
                MessageBox.Show("debe seleccionar un nodo.");
        }
    }
}
