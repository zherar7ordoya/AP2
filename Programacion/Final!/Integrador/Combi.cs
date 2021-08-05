using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Integrador
{
    public partial class Combi : Form
    {

        /**
         * TODO:
         * -) Botón subir: generar un string desde backend y mostrar en msgbox
         *    usando recursión.
         * -) Botón viajar: generar listado a grabar a partir de backend (usar 
         *    el punto anterior): ¿hacer un string global para esto?
         */

        #region PORTADA
        /// <summary>
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
        /// </summary>
        #endregion

        #region GLOBALES
        /**
         * ¿POR QUÉ?
         *  -)  Para archivo, para ubicar un lugar cómodo para definir un 
         *      archivo de salida.
         *  -)  Para colaFrontend, para que esté disponible entre los distintos 
         *      procedimientos ya que, como se verá, traté de dividir el código
         *      de forma que sea lo más equilibrado y razonable posible.
         *  -)  Finalmente, el booleano es para evitar que el cierre del Form
         *      intente hacer operaciones que dependían de anteriores. El
         *      cierre del form es imprevisible, así que mejor dejar flotando
         *      una condición sobre la cual apoyarse.
         */
        public static string archivo      = "../../pasajeros.txt";
        public string pasajeros           = null;
        public Queue<string> colaFrontend = new Queue<string>();
        Cola colaBackend                  = new Cola();
        public bool generado              = false;
        #endregion

        #region BOOT
        public Combi() { InitializeComponent(); }
        private void Combi_Load(object sender, EventArgs e)
        {
            Random aleatorio = new Random();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.lblUnidad.Text = lblUnidad.Text + "1972";
            this.lblChofer.Text = lblChofer.Text + "Gerardo Tordoya";
            this.lblKilometraje.Text = lblKilometraje.Text + aleatorio.Next(50, 500);
            InicializarSesion();    // Ver nota en FUNCIONES.
        }
        #endregion

        #region FUNCIONES
        /**
         * InicializarSesión hace operaciones propias del inicio de la
         * aplicación. Sin embargo, hay algunas que deben actualizarse cuando
         * le damos la posibilidad a la aplicación de trabajar por ciclos (es
         * decir, terminadas las operaciones, poder reiniciar la secuencia).
         * Por eso, ahí en el "booteo", se hacen las operaciones que no son ya
         * necesarias de cambiar y aquí las que ante cada ciclo lo necesitan.
         * 
         * NOTA: Esto se hizo solo para diferenciar un "booteo" que consta de
         *       operaciones que deben mantenerse y de otras que no. Es decir,
         *       es una aplicación que una vez que termina sus operaciones
         *       reinicia para volver a hacerlas. En una aplicación real, esos
         *       datos (chofer, unidad, etc.) deberían cambiar porque,
         *       obviamente, se trata de otra combi para otro viaje con otro
         *       chofer.
         */
        private void InicializarSesion()
        {
            var horario = DateTime.Now;
            this.lblInformacion.Text = "Si no hay pasajeros en espera" + Environment.NewLine +
                                       "y la combi está vacía," + Environment.NewLine +
                                       "vaya a la terminal de Puerto Madero.";
            this.lblArribo.Text      = "Arribo: " + 
                                       horario.Hour.ToString("00") + ':' + 
                                       horario.Minute.ToString("00");
            this.lblPartida.Text     = "Partida: ";
            this.lblEspera.Text      = "En espera: " + colaFrontend.Count().ToString();
            this.txtPasajero.Enabled = true;    // Ver nota en CLEAR.
            this.btnAnotar.Enabled   = true;    // Ver nota en CLEAR.
            this.btnSubir.Enabled    = false;
            this.btnViajar.Enabled   = false;
            this.lstPasajeros.Clear();          // ¿Por qué? Necesario para reincio de ciclo.
            this.txtPasajero.Focus();
        }

        /**
         * ¿POR QUÉ IMPRIMIR? Para evitar redundancia y errores ya que, como se
         * ve, el tratamiento del ListView es medio artesanal.
         */
        public void Imprimir()
        {
            lstPasajeros.Clear();
            lstPasajeros.View = View.Details;
            lstPasajeros.Columns.Add("PASAJEROS");
            ListViewItem item;
            foreach (string pasajero in colaFrontend)
            {
                item = new ListViewItem(pasajero);
                lstPasajeros.Items.Add(item);
            }
            lstPasajeros.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstPasajeros.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            this.lblEspera.Text = "En espera: " + colaFrontend.Count().ToString();
        }
        private void PasajerosAbordados()
        {
            if (colaBackend.Contador == 0) { return; }
            else
            {
                pasajeros += colaBackend.Inicio.Nombre + Environment.NewLine;
                colaBackend.Desencolar();
                PasajerosAbordados();
            }
        }

        #endregion

        #region BOTONES
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
         * Porque en el pasado no tuve buena experiencia anidando. Siempre me 
         * ha parecido más fácil de desbichificar (debuguear) una secuencia de
         * condicionales que un anidamiento.
         * Es algo parecido a lo que pasa con los WHILE combinados: en 
         * situaciones que no afectan a la lógica del programa, pueden saltar
         * por cuestiones específicas del lenguaje que pueden hacer fallar tu
         * algoritmo (y de hecho, lo hacen).
         * Es menos elegante, lo sé, pero yo sigo el principio romano en esto.
         */
        private void btnAnotar_Click(object sender, EventArgs e)
        {
            if (txtPasajero.Text != "") {
                lblInformacion.Text = null;
                Nodo nodoTemporal = new Nodo();
                colaFrontend.Enqueue(txtPasajero.Text);
                nodoTemporal.Nombre = colaFrontend.ElementAt(colaFrontend.Count()-1);
                colaBackend.Encolar(nodoTemporal);
                txtPasajero.Text = "";
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
        
        /**
         * Bueno, el disputado inciso D. Todo este procedimiento se podría
         * reducir a tan solo a dos cosas: vaciar la colaFrontend y no imprimir.
         * Vaciar la colaFrontend cumpliría con lo pedido por el inciso D.
         * No imprimir permite cumplir con el punto 1 de la 2da parte del
         * integrador (que necesita recuperar de algún lado los datos para
         * grabarlos en el archivo).
         * Todo el resto del código son para cuestiones propias del formulario.
         */
        private void btnSubir_Click(object sender, EventArgs e)
        {
            var horario              = DateTime.Now;
            this.lblPartida.Text     = "Partida: " + 
                                       horario.Hour.ToString("00") + ':' + 
                                       horario.Minute.ToString("00");
            this.btnSubir.Enabled    = false;
            this.btnViajar.Enabled   = true;
            this.btnViajar.Focus();
            colaFrontend.Clear();
            Imprimir();
            this.lblInformacion.Text = "Status:" + Environment.NewLine +
                                       "Cola frontal vacía." + Environment.NewLine +
                                       "Cola interna retiene los datos.";
            PasajerosAbordados();
            MessageBox.Show("Pasajeros a bordo:" + Environment.NewLine + pasajeros,
                            "Información",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
        /**
         * Bueno, aquí está lo explicado en el botón SUBIR. Así que las
         * operaciones allí van de la mano con las de aquí:
         *  -)  En una cadena, recupero los datos del control
         *  -)  Uso esa cadena para grabar los datos al archivo
         *  -)  Genero el booleano explicado en las notas de los globales
         */
        private void btnViajar_Click(object sender, EventArgs e)
        {
            this.btnViajar.Enabled = false;
            MessageBox.Show("Archivo de registro generado." + Environment.NewLine +
                            "Se hará un backup del mismo" + Environment.NewLine +
                            "cuando cierre esta aplicación.", 
                            "Información", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            // El archivo de registro, a diferencia del de respaldo (backup) va
            // a ser de agregado, y por eso el uso de AppendAllText. Ver notas
            // en el evento de cierre del form.
            File.AppendAllText(archivo, string.Join(Environment.NewLine, pasajeros));
            generado = true;
            pasajeros = null;
            InicializarSesion();
        }
        #endregion

        #region FINALE
        /**
         * Recupero lo grabado en el archivo y grabo esos datos en un único
         * archivo (por eso el uso de WriteAllText), es decir, no hay 
         * agregación: es un respaldo único.
         */
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
