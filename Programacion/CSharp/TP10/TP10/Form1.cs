using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP10
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void listar()
        {

            lstlistado.Items.Clear();

            FileStream archivo = new FileStream("archivo.txt", FileMode.OpenOrCreate);
            StreamReader lectorArchivo = new StreamReader(archivo);
            string[] vectorRegAux = new string[0];
            string reg = "";

            string[] campos;

            while (lectorArchivo.Peek() > -1)
            {
                reg = lectorArchivo.ReadLine();
                // lstlistado.Items.Add(reg);
                campos = reg.Split(';');
                lstlistado.Items.Add(new ListViewItem(new string[] { campos[0], campos[1], campos[2] }));
            }

            lectorArchivo.Close();


        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            FileStream archivo = new FileStream("archivo.txt", FileMode.Open);
            FileStream archivoAux = new FileStream("archivoAux.txt", FileMode.Create);
            StreamReader LectorArchivo = new StreamReader(archivo);
            StreamWriter EscritorArchivoAux = new StreamWriter(archivoAux);
            String[] VectorRegAux = new String[0];
            string reg = "";
            string legajo;
            while (LectorArchivo.Peek() > -1)
            {
                reg = LectorArchivo.ReadLine();
                VectorRegAux = reg.Split(';');
                legajo = VectorRegAux[0];
                if (legajo == txtleg.Text)
                {
                    reg = String.Format("{0};{1};{2}", txtleg.Text, txtapynom.Text, txtcat.Text);
                }
                EscritorArchivoAux.WriteLine(reg);
            }
            LectorArchivo.Close();
            archivo.Close();
            EscritorArchivoAux.Close();
            archivoAux.Close();
            //PISO EL ARCHIVO AORIGINAL CON EL AUX 
            File.Delete("archivo.txt");
            File.Move("archivoAux.txt", "archivo.txt");
            txtleg.Text = "";
            txtapynom.Text = "";
            txtcat.Text = "";
            txtleg.Focus();
            listar();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            FileStream archivo = new FileStream("archivo.txt", FileMode.Open);
            FileStream archivoAux = new FileStream("archivoAux.txt", FileMode.Create);
            StreamReader LectorArchivo = new StreamReader(archivo);
            StreamWriter EscritorArchivoAux = new StreamWriter(archivoAux);
            String[] VectorRegAux = new String[0];
            string reg;
            string legajo;
            while (LectorArchivo.Peek() > -1)
            {
                reg = LectorArchivo.ReadLine();
                VectorRegAux = reg.Split(';');
                legajo = VectorRegAux[0];
                if (legajo != txtleg.Text)
                {
                    EscritorArchivoAux.WriteLine(reg);
                }
            }
            //CIERRO ARCHIVOS 
            LectorArchivo.Close();
            archivo.Close();
            EscritorArchivoAux.Close();
            archivoAux.Close();
            //PISO EL ARCHIVO AORIGINAL CON EL AUX 
            File.Delete("archivo.txt");
            File.Move("archivoAux.txt", "archivo.txt");
            txtleg.Text = "";
            txtapynom.Text = "";
            txtcat.Text = "";
            txtleg.Focus();
            listar();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            FileStream archivo = new FileStream("archivo.txt", FileMode.Append);
            StreamWriter EscritorArchivo = new StreamWriter(archivo);
            string reg;
            reg = txtleg.Text + ";" + txtapynom.Text + ";" + txtcat.Text;
            reg = String.Format("{0};{1};{2}", txtleg.Text, txtapynom.Text, txtcat.Text);
            EscritorArchivo.WriteLine(reg);
            EscritorArchivo.Close();
            archivo.Close();
            txtleg.Text = "";
            txtapynom.Text = "";
            txtcat.Text = "";
            txtleg.Focus();
            listar();
        }


        private void lstlistado_Click_1(object sender, EventArgs e)
        {
            txtleg.Text = lstlistado.SelectedItems[0].SubItems[0].Text;
            txtapynom.Text = lstlistado.SelectedItems[0].SubItems[1].Text;
            txtcat.Text = lstlistado.SelectedItems[0].SubItems[2].Text;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            lstlistado.View = View.Details;
            lstlistado.Columns.Add("Legajo");
            lstlistado.Columns.Add("Nombre y Apellido");
            lstlistado.Columns.Add("Categoría");
            // Ordenar();
            listar();
        }


        private void Ordenar()
        {
            string contenido = File.ReadAllText("archivo.txt");
            var lineas = contenido.Split(Environment.NewLine.ToCharArray()).ToList();
            var ordenado = lineas.OrderBy(linea => linea.Split(';')[0]).ToList();
            int inicio = 0, final = ordenado.Count - 1;

            while (inicio < final && String.IsNullOrWhiteSpace(ordenado[inicio])) inicio++;
            while (final >= inicio && String.IsNullOrWhiteSpace(ordenado[final])) final--;

            var limpiado = ordenado.Skip(inicio).Take(final - inicio + 1);
            File.WriteAllText("archivo.txt", string.Join(Environment.NewLine, limpiado));
        }

    }
}
