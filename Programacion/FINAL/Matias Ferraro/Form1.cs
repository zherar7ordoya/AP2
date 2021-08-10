using Integrador.controllers;
using System;
using System.Windows.Forms;

namespace Integrador
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Controlador del Bondi.
        /// </summary>
        private BondiController Bondi { get; set; }

        public Form1()
        {
            //Inicializa los componentes
            InitializeComponent();
            EstadoInicial();
        }

        private void EstadoInicial()
        {
            //Inicializa el controlador
            Bondi = new BondiController();

            //Establece la visibilidad de los botones
            btnEmprenderViaje.Visible = false;
            btnSubir.Enabled = true;

            //Actualiza la imagen y la lista de espera (valores iniciales).
            ActualizarLista();
            ActualizarImagen();
        }

        private void ActualizarLista()
        {
            lstPasajeros.DataSource = Bondi.ListarCola();
        }

        private void Anotar()
        {
            //Agrega pasajero a la cola.
            Bondi.EncolarPasajero(txtPasajero.Text);
            //Actualiza la lista.
            ActualizarLista();
            //Blanquea el campo de nombre de pasajero.
            txtPasajero.Text = null;
            txtPasajero.Focus();
        }

        private void Subir()
        {
            //Se agrega el pasajero a los subidos.
            Bondi.SubirPasajero();
            //Se actualiza la lista de la cola.
            ActualizarLista();
            //Se actualiza la imagen.
            ActualizarImagen();

            //Verifica si el bondi está lleno.
            if (Bondi.EstaLleno)
            {
                MessageBox.Show("El bondi está lleno, ya puedes emprender viaje.");
                btnEmprenderViaje.Visible = true;
                btnSubir.Enabled = false;
            }
        }

        private void ActualizarImagen()
        {
            //Obtiene la imagen del bondi acorde a la cantidad de pasajeros.
            this.imgBondi.BackgroundImage = Bondi.ObtenerImagen();
        }

        private void btnAnotar_Click(object sender, EventArgs e)
        {
            try
            {
                //Anota a un pasajero a la cola (lo agrega en la misma).
                Anotar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            try
            {
                //Sube un pasajero al bondi
                Subir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPasajero_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                //Si presiona enter hace la misma acción que el botón de anotar (lo agrega a la cola).
                if (e.KeyCode == Keys.Enter)
                {
                    Anotar();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEmprenderViaje_Click(object sender, EventArgs e)
        {
            try
            {
                //Emprende el viaje
                this.Bondi.EmprenderViaje();

                //Notifica al usuario que el bondi ha partido.
                DialogResult dlgResult = MessageBox.Show("¡El bondi ha partido! ¿Desea administrar otro bondi?", "¡Exito!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                //En caso de querer administrar otro bondi genera el backup y reinicia el programa.
                if (dlgResult == DialogResult.Yes)
                {
                    this.Bondi.GenerarBackup();
                    this.EstadoInicial();
                }
                else 
                {
                    //En caso de que no, cierra el programa.
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //Cuando el formulario se está cerrando genera un backup del archivo de pasajeros.
                this.Bondi.GenerarBackup();
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
