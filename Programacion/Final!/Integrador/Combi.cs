using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador
{
    public partial class Combi : Form
    {
        #region PORTADA
        /// <summary>
        /// 
        /// Título:      Trabajo Práctico Integrador (UAI 2021 Programación I).
        /// Descripción: Aplicación control de ingreso de pasajeros a una combi
        /// Profesor:    Alejandro Hunt.
        /// 
        /// Autor:       Gerardo Tordoya
        /// Fecha:       2021-07(JUL)-21
        /// 
        /// EDICIONES    ------------------------------------------------------
        /// 
        /// Fecha:       2021-08(AGO)-05
        ///              Prolijado de nombres de clases
        ///              Uso de estructura de datos interna
        ///              Uso de File.Copy
        ///              
        /// Fecha:       XXXX-XX(XXX)-XX
        ///              ...
        ///              
        /// PENDIENTE    ------------------------------------------------------
        ///              Procesar por lotes
        ///              Cambio de combi y chofer
        ///              Visibilizar pasajeros a bordo
        ///              Recuperar datos de archivo para control
        /// 
        /// </summary>
        #endregion

        #region GLOBALES
        /**
         * ¿POR QUÉ?
         *  ARCHIVO: para tener un lugar dónde definir un archivo de salida.
         *  PASAJEROS: para disponer de esos datos sin pasajes entre funciones.
         *  COLAFRONTEND: por ser la forma más sencilla de alimentar al ListView
         *  COLABACKEND: ¿por qué no?
         *  GENERADO: para evitar que el cierre del Form haga operaciones dependientes
         */
        public static string archivo      = "../../pasajeros.txt";
        public string pasajeros           = null;
        public Queue<string> colaFrontend = new Queue<string>();
        Cola colaBackend                  = new Cola();
        public bool generado              = false;
        #endregion

        #region INICIO
        public Combi() { InitializeComponent(); }
        private void Combi_Load(object sender, EventArgs e)
        {
            Random aleatorio = new Random();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.lblUnidad.Text = lblUnidad.Text + "1972";
            this.lblChofer.Text = lblChofer.Text + "Gerardo Tordoya";
            this.lblKilometraje.Text = lblKilometraje.Text + aleatorio.Next(50, 500);
            InicializarSesion();                            // Ver nota en FUNCIONES.
        }
        #endregion

        #region FUNCIONES
        /**
         * InicializarSesión hace operaciones propias del inicio de la
         * aplicación. Sin embargo, hay algunas que deben actualizarse cuando
         * le damos la posibilidad a la aplicación de reiniciar la secuencia.
         * Por eso, ahí en el "booteo", se hacen las operaciones que no son ya
         * necesarias de cambiar, y aquí, las que ante cada ciclo lo necesitan.
         * 
         * NOTA: En una aplicación real, esos datos (chofer, unidad, etc.) 
         *       deberían cambiar porque, obviamente, se trata de otra combi 
         *       para otro viaje con otro chofer.
         */
        private void InicializarSesion()
        {
            var horario              = DateTime.Now;
            this.lblInformacion.Text = "Si no hay pasajeros en espera" + Environment.NewLine +
                                       "y la combi está vacía," + Environment.NewLine +
                                       "vaya a la terminal de Puerto Madero.";
            this.lblArribo.Text      = "Arribo: " + 
                                       horario.Hour.ToString("00") + ':' + 
                                       horario.Minute.ToString("00");
            this.lblPartida.Text     = "Partida: ";
            this.lblEspera.Text      = "En espera: " + colaFrontend.Count().ToString();
            this.txtPasajero.Enabled = true;              // Ver nota en CLEAR.
            this.btnAnotar.Enabled   = true;              // Ver nota en CLEAR.
            this.btnSubir.Enabled    = false;
            this.btnViajar.Enabled   = false;
            this.lstPasajeros.Clear();                    // Por el reincio.
            this.txtPasajero.Focus();
        }

        /**
         * ¿POR QUÉ IMPRIMIR?
         * Para evitar redundancia y errores ya que, como se ve, el tratamiento
         * del ListView es medio artesanal.
         */
        public void Imprimir()
        {
            lstPasajeros.Clear();
            lstPasajeros.View = View.Details;
            lstPasajeros.Columns.Add("PASAJEROS");
            ListViewItem item;
            // Para esta cola uso FOREACH, para la otra, recursión.
            foreach (string pasajero in colaFrontend)
            {
                item = new ListViewItem(pasajero);
                lstPasajeros.Items.Add(item);
            }
            lstPasajeros.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstPasajeros.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            this.lblEspera.Text = "En espera: " + colaFrontend.Count().ToString();
        }

        /**
         * ¿POR QUÉ?
         * Siguiendo el principio KISS y DRY, es una forma de recuperar los
         * datos de la cola en la variable al mismo tiempo de vaciarla.
         * Al terminar, ambos componentes quedan listos: la variable completa y
         * la cola vacía.
         */
        private void DesdeColaHaciaCadena()
        {
            if (colaBackend.Contador == 0) { return; }
            else
            {
                pasajeros += colaBackend.Inicio.Nombre + Environment.NewLine;
                colaBackend.Desencolar();
                DesdeColaHaciaCadena();
            }
        }
        // Sí, lo sé, no hice una condición de salida. Pendiente.
        private async void Titilar()
        {
            while (true)
            {
                await Task.Delay(500);
                lblPartida.BackColor = lblPartida.BackColor == Color.LightBlue ?
                                                               Color.Yellow :
                                                               Color.LightBlue;
            }
        }
        #endregion

        #region BOTONES
        /**
         * En general, en esta primera edición, la estrategia es trabajar con
         * ambas colas en paralelo hasta que ya no sea necesario.
         * Repito lo expuesto en GLOBALES: la cola incorporada de C# es una
         * sencilla de alimentar al control de usuario, y por eso queda. La 
         * cola implementada es... poner la carne al asador para el examen.
         */

        // ¿POR QUÉ DESHABILITADO?
        // Porque el profesor no pidió esto, solo lo puse para pruebas.
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (colaFrontend.Count()!=0)
            {
                colaFrontend.Dequeue();
                colaBackend.Desencolar();
                Imprimir();
            }
            else
            {
                MessageBox.Show("Lista vacía.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        /**
         * ¿POR QUÉ NO ANIDAR LOS IF?
         * Porque es más fácil de desbichificar (debuguear) una secuencia de
         * condicionales que un anidamiento (Principio KISS).
         */
        private void btnAnotar_Click(object sender, EventArgs e)
        {
            if (txtPasajero.Text != String.Empty) {
                lblInformacion.Text = null;
                Nodo nodoTemporal   = new Nodo();
                colaFrontend.Enqueue(txtPasajero.Text);
                nodoTemporal.Nombre = colaFrontend.ElementAt(colaFrontend.Count()-1);
                colaBackend.Encolar(nodoTemporal);
                txtPasajero.Text    = String.Empty;
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            Imprimir();
            if (colaFrontend.Count < 19) { txtPasajero.Focus(); }
            else
            {
                this.txtPasajero.Enabled = false;
                this.btnAnotar.Enabled   = false;
                this.btnSubir.Enabled    = true;
                this.lblInformacion.Text = "Ha alcancado la capacidad máxima." + Environment.NewLine +
                                           "Pida a los pasajeros que suban.";
                this.btnSubir.Focus();
            }
        }
        private void btnSubir_Click(object sender, EventArgs e)
        {
            var horario              = DateTime.Now;
            this.lblPartida.Text     = "Partida: " + 
                                       horario.Hour.ToString("00") + ':' + 
                                       horario.Minute.ToString("00");
            Titilar(); // ¿Qué es esto? Nada, un detalle ganso que quise poner.
            this.btnSubir.Enabled    = false;
            this.btnViajar.Enabled   = true;
            this.btnViajar.Focus();
            colaFrontend.Clear();
            Imprimir();
            this.lblInformacion.Text = "Status:" + Environment.NewLine +
                                       "Cola frontal vacía." + Environment.NewLine +
                                       "Cola interna retiene los datos.";
            // Para recorrer la cola nativa, usé FOREACH. Para recorrer la cola
            // implementada, uso un llamado a una función recursiva.
            DesdeColaHaciaCadena();
            MessageBox.Show("Pasajeros a bordo:" + Environment.NewLine + pasajeros,
                            "Información",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
        private void btnViajar_Click(object sender, EventArgs e)
        {
            this.btnViajar.Enabled = false;
            MessageBox.Show("Archivo de registro generado." + Environment.NewLine +
                            "Se hará un backup del mismo" + Environment.NewLine +
                            "cuando cierre esta aplicación.", 
                            "Información", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            File.AppendAllText(archivo, string.Join(Environment.NewLine, pasajeros));
            generado = true;
            pasajeros = null;
            InicializarSesion();
        }
        #endregion

        #region CIERRE
        private void frmCombis_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Salir?",
                               "Pregunta",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else if (generado)
            {
                var fecha = DateTime.Now;
                string respaldo = "../../pasajeros." +
                                  fecha.Year.ToString() + '_' +
                                  fecha.Month.ToString("00") + '_' +
                                  fecha.Day.ToString("00") + ".bak";
                File.Copy(archivo, respaldo, true);
            }
        }
        #endregion
    }
}
