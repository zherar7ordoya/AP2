using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP08
{
    public partial class Form1 : Form
    {
        public Form1() { InitializeComponent(); }
        private void btnTipos_Click(object sender, EventArgs e) { pictureBox1.Image = Image.FromFile(@"../../tiposdenodos.png"); }
        private void btnPreorden_Click(object sender, EventArgs e) { pictureBox1.Image = Image.FromFile(@"../../preorden.png"); }
        private void btnInorden_Click(object sender, EventArgs e) { pictureBox1.Image = Image.FromFile(@"../../inorden.png"); }
        private void btnPostorden_Click(object sender, EventArgs e) { pictureBox1.Image = Image.FromFile(@"../../postorden.png"); }

        Nodo raiz;
        Nodo seleccionado;
        Nodo CrearNodo()
        {
            string nombre = Interaction.InputBox("Ingrese nombre del nodo:");
            return new Nodo(nombre);
        }
        void EvaluarArbol()
        {
            this.lblAltura.Text = $"Altura: {Alto(raiz)}";
            int inicio = 0;
            this.lblAncho.Text = $"Ancho: {Ancho(raiz, ref inicio)}";
        }
        int Ancho(Nodo n, ref int ancho)
        {
            if(n.Derecha==null && n.Izquierda==null) { ancho += 1; }
            if(n.Derecha!=null) { Ancho(n.Derecha, ref ancho);  }
            if(n.Izquierda!=null) { Ancho(n.Izquierda, ref ancho);  }
            return ancho;
        }
        int Alto(Nodo n)
        {
            if(n==null) { return 0; }
            int izq = Alto(n.Izquierda) + 1;
            int der = Alto(n.Derecha) + 1;
            return Math.Max(izq, der);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(raiz!=null)
            {
                DialogResult r = MessageBox.Show("Se eliminará el árbol.\n¿Continuar?", "Advertencia", MessageBoxButtons.OKCancel);
                if(r==DialogResult.Yes) { raiz = CrearNodo(); }
            }
            else { raiz = CrearNodo(); }
            CambiarSeleccion(raiz);
            LlenarTreeView();
        }
        void CambiarSeleccion(Nodo n)
        {
            seleccionado = n;
            this.lblNombreNodo.Text = n.Nombre;
        }
        public void LlenarTreeView()
        {
            treeView1.Nodes.Clear();
            MostrarNodo(raiz, null, string.Empty);
            treeView1.ExpandAll();
            EvaluarArbol();
        }
        public void MostrarNodo(Nodo n, TreeNode tnpadre, string lado)
        {
            if (n == null) return;
            TreeNode nuevo = new TreeNode();
            if(tnpadre==null && lado == String.Empty)
            {
                tnpadre = new TreeNode();
                nuevo.Text = n.Nombre;
                nuevo.Tag = n;
                treeView1.Nodes.Add(nuevo);
            }
            else
            {
                nuevo.Text = $"{lado} - {n.Nombre}";
                nuevo.Tag = n;
                tnpadre.Nodes.Add(nuevo);
            }
            if(n.Derecha!=null) { MostrarNodo(n.Derecha, nuevo, "D"); }
            if (n.Izquierda != null) { MostrarNodo(n.Izquierda, nuevo, "I"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (seleccionado != null)
            {
                seleccionado.Derecha = CrearNodo();
                LlenarTreeView();
            }
            else { MessageBox.Show("Seleccione un nodo."); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (seleccionado != null)
            {
                seleccionado.Izquierda = CrearNodo();
                LlenarTreeView();
            }
            else { MessageBox.Show("Seleccione un nodo."); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.txtRecorrido.Text = string.Empty;
            RecorridoPreOrden(raiz);
        }
        void RecorridoPreOrden(Nodo n)
        {
            Visitar(n);
            if(n.Izquierda!=null) { RecorridoPreOrden(n.Izquierda); }
            if(n.Derecha!=null) { RecorridoPreOrden(n.Derecha); }
        }
        void Visitar(Nodo n) { this.txtRecorrido.Text += n.Nombre + " - "; }

        private void button5_Click(object sender, EventArgs e)
        {
            this.txtRecorrido.Text = string.Empty;
            RecorridoInOrden(raiz);
        }
        void RecorridoInOrden(Nodo n)
        {
            if (n.Izquierda != null) { RecorridoPreOrden(n.Izquierda); }
            Visitar(n);
            if (n.Derecha != null) { RecorridoPreOrden(n.Derecha); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.txtRecorrido.Text = string.Empty;
            RecorridoPostOrden(raiz);
        }
        void RecorridoPostOrden(Nodo n)
        {
            if (n.Izquierda != null) { RecorridoPreOrden(n.Izquierda); }
            if (n.Derecha != null) { RecorridoPreOrden(n.Derecha); }
            Visitar(n);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) { CambiarSeleccion((Nodo)e.Node.Tag); }
    }
}
