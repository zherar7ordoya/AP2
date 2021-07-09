using System;
using System.Windows.Forms;

namespace Archivos
{
    public partial class Video09 : Form
    {
        GestorAlumnos alumnos = new GestorAlumnos();
        public Video09()
        {
            InitializeComponent();
            LlenarGrilla();
        }
        private void LlenarGrilla()
        {
            this.grillaAlumnos.DataSource = null;
            this.grillaAlumnos.DataSource = alumnos.Lista();
        }
        private void btnAlta_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno((long)this.numDNI.Value)
            {
                Apellido = this.txtApellido.Text,
                Nombre = this.txtNombre.Text
            };
            alumnos.Alta(alumno);
            LlenarGrilla();
        }
        private void btnBaja_Click(object sender, EventArgs e)
        {
            if(this.grillaAlumnos.SelectedRows.Count == 1)
            {
                Alumno seleccionado = (Alumno)this.grillaAlumnos.SelectedRows[0].DataBoundItem;
                alumnos.Baja(seleccionado.DNI);
                LlenarGrilla();
            }
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se lo debo (se me acabó el tiempo).");
        }
    }
}
