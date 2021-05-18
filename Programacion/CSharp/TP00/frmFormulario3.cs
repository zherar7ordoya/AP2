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
    public partial class frmFormulario3 : Form
    {
        public frmFormulario3()
        {
            InitializeComponent();
        }

        private void btnVerFecha_Click(object sender, EventArgs e)
        {
            DateTime unaFecha = dateTimePicker1.Value;

            DateTime otraFecha = unaFecha.AddDays(2);

            monthCalendar1.SetDate(otraFecha);

            MessageBox.Show("la fecha actual es " + unaFecha.ToLongDateString());

        }

        private void btnAgregarNodo_Click(object sender, EventArgs e)
        {


            if (txtNodo.Text.Length == 0)
            {
                MessageBox.Show("por favor, ingrese un nombre");
            }
            else
            {

                TreeNode tn = new TreeNode(txtNodo.Text);
                treeView1.Nodes.Add(tn);

            }


        }

        private void btnAgregarNodo2_Click(object sender, EventArgs e)
        {

            if (txtNodo.Text.Length == 0)
            {
                MessageBox.Show("por favor, ingrese un nombre");
            }
            else
            {
                if (treeView1.SelectedNode == null)
                {
                    MessageBox.Show("por favor, seleccione un nodo");
                }
                else
                {
                    TreeNode tn = new TreeNode(txtNodo.Text);
                    treeView1.SelectedNode.Nodes.Add(tn);
                }
            }

            
            
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progress1.Value == 100)
            {
                timer1.Stop();
            }
            else
            {
                progress1.Value = progress1.Value + 1;
            }
           
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
