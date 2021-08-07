using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador
{
    /// <summary>
    /// 
    /// Título:      Trabajo Práctico Integrador (UAI 2021 Programación I).
    /// Descripción: Aplicación control de ingreso de pasajeros a una combi
    /// Profesor:    ALEJANDRO HUNT
    /// 
    /// Autor:       Gerardo Tordoya
    /// Fecha:       2021-07(JUL)-21
    /// 
    /// EDICIONES    ------------------------------------------------------
    /// 
    /// Fecha:       2021-08(AGO)-06
    ///              Uso de File.Copy
    ///              Prolijado de nombres de clases
    ///              Uso de estructura de datos interna
    ///              Adecuar comentarios a la presente edición
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

    public partial class Combi : Form
    {
        #region LINEAMIENTOS
        /** En general, trataré de codificar según los principios KISS y DRY.
         *  Debo agradecer a la cátedra, en especial al profesor, el haberme
         *  incorporado el principio YAGNI.
         *  Los comentarios, acorde a lo aconsejado por nuestros programadores
         *  predecesores, evitarán el "WHAT" y preferirán el "WHY".
         *  La estrategia general implementada en esta edición ha sido la de
         *  basarse en dos colas (una nativa y otra implementada), manteniendo
         *  la lógica del frontend y agregando la implementada para el backend
         *  a manera de estructura interna de datos.
         */
        #endregion

        #region GLOBALES
        /** En general, usaré globales para evitar errores en los pasajes de
         *  parámetros entre distintos procedimientos que necesiten de estos
         *  datos. Eso por un lado. Por otro lado, según el principio KISS,
         *  prefiero tener procedimientos y funciones desacoplados ante posibles
         *  futuras modificaciones.
         *  
         *  ARCHIVO: para tener un lugar dónde definir un archivo de salida.
         *  PASAJEROS: para disponer de esos datos sin pasajes entre funciones.
         *  COLAFRONTEND: por ser la forma más sencilla de alimentar al ListView.
         *  COLABACKEND: ¿por qué no?
         *  GENERADO: para evitar que el cierre del Form haga operaciones dependientes.
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
            Random aleatorio         = new Random();
            this.MaximizeBox         = false;
            this.MinimizeBox         = false;
            this.lblUnidad.Text      = lblUnidad.Text + "1972";
            this.lblChofer.Text      = lblChofer.Text + "Gerardo Tordoya";
            this.lblKilometraje.Text = lblKilometraje.Text + aleatorio.Next(50, 500);
            InicializarSesion();                            // Ver nota en FUNCIONES.
        }
        #endregion

        #region FUNCIONES
        /** En el "booteo", se hacen las operaciones que ya no son necesarias
         *  cambiar. Aquí, las que ante cada ciclo (reinicio) lo necesitan.
         * 
         *  NOTA:   En una aplicación real, esos datos (chofer, unidad, etc.) 
         *          no se mantendrían porque, obviamente, se trata de otra combi
         *          para otro viaje con otro chofer.
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

        /** Para evitar redundancia y errores ya que, como se ve, el tratamiento
         *  del ListView es medio artesanal, se pone a disposición esta función.
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

        /** Siguiendo el principio KISS y DRY, es una forma de recuperar los
         *  datos de la cola en la variable al mismo tiempo de vaciar la cola.
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

        /** Nada, una gansada, un detalle que no me resistí a meter. Y sí, lo 
         *  sé, no hice una condición de salida. Pendiente.
         */
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
        /** En general, todos los botones tienen un código secuencial,
         *  estructurado. Para no estorbar la lectura, se hará un comentario
         *  solo si hay relevancia justificada.
         */

        // ¿POR QUÉ ELIMINAR ESTÁ DESHABILITADO? Por el principio YAGNI.
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

        /** ¿POR QUÉ NO ANIDAR LOS IF? Porque es más fácil el debug de una
         *  secuencia de condicionales que de un anidamiento (Principio KISS).
         *  ¿Y qué del REGEX? Bueno, es cierto. Pero hasta ahora, el profesor
         *  no objetó validaciones. Pienso que no está demás.
         */
        private void btnAnotar_Click(object sender, EventArgs e)
        {
            if (
                txtPasajero.Text != string.Empty && 
                Regex.Match(txtPasajero.Text, "^[A-Za-zÑñÁáÉéÍíÓóÚúü ,.'-]+$").Success
                )
            {
                lblInformacion.Text = null;
                Nodo nodoTemporal   = new Nodo();
                colaFrontend.Enqueue(txtPasajero.Text);
                nodoTemporal.Nombre = colaFrontend.ElementAt(colaFrontend.Count() - 1);
                colaBackend.Encolar(nodoTemporal);
                txtPasajero.Text    = String.Empty;
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre válido.",
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
            
            Titilar();                  // ¿Qué es esto? Ver nota a la función.
            this.btnSubir.Enabled    = false;
            this.btnViajar.Enabled   = true;
            this.btnViajar.Focus();
            colaFrontend.Clear();
            Imprimir();
            this.lblInformacion.Text = "Status:" + Environment.NewLine +
                                       "Cola frontal vacía." + Environment.NewLine +
                                       "Cola interna retiene los datos.";
            // Para recorrer la cola nativa, usé FOREACH. Para recorrer esta cola
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
            generado  = true;
            pasajeros = null;
            InicializarSesion();
        }
        #endregion

        #region TECLADO
        // ¿Y esto? Bueno, el evento KeyPress se considera estándar en
        // cualquier aplicación de escritorio. Es más bien una formalidad.
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void txtPasajero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAnotar_Click(this, new EventArgs());
            }
        }
        #endregion

        #region CIERRE
        /** Básicamente, la estrategia de cierre está basada en un booleano que
         *  evita posibles errores si hay un cierre prematuro del formulario. Si
         *  todo está bien, genera el respaldo (backup).
         */
        private void Combi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Salir?",
                                "Pregunta",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else if (generado)
            {
                var fecha       = DateTime.Now;
                string respaldo = "../../pasajeros." +
                                  fecha.Year.ToString() + '_' +
                                  fecha.Month.ToString("00") + '_' +
                                  fecha.Day.ToString("00") + ".bak";
                File.Copy(archivo, respaldo, true);       // TRUE sobreescribe.
            }
        }
        #endregion
    }
}
