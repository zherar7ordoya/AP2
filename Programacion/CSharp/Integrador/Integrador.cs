using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Integrador
{
    public partial class frmCombis : Form
    {
        #region PORTADA
        /// <summary>
        /// 
        /// Trabajo Práctico Integrador pedido por la 
        /// Cátedra de Programación I (UAI) -2021-
        /// El trabajo se ha enfocado a una mini-aplicación de escritorio
        /// que supervisa el ingreso de pasajeros a una combi de transporte.
        /// 
        /// Autor: Gerardo Tordoya
        /// Fecha: 2021-07(JUL)-21
        /// 
        /// </summary>
        #endregion

        /**
         * NOTA:
         * 
         * En la consigna D (1ra parte del práctico) se lee:
         *                      «Codificar los botones SUBIR A LA COMBI 
         *                      para quitar elementos de la estructura.»
         *                      
         * Hay al menos 3 formas de interpretar esto:
         *      1) Que SUBIR quite TODOS los elementos de la estructura.
         *      2) Que SUBIR quite UNO A UNO los elementos de la estructura.
         *      3) Que SUBIR quite LOTES de elementos de la estructura.
         * 
         * Para el presente trabajo se eligió la opción 1 para coordinar de una
         * manera simple y limpia la segunda parte del práctico: las
         * operaciones de generación de archivos debían encontrar, en ese
         * punto, una estructura vacía. Para ello, los datos debían permanecer
         * en algún lado para ser recuperados. Se hizo así. La grabación del
         * archivo se hace sin recurrir a una estructura vacía y, en cambio, se
         * hace el recupero (para el grabado) desde el control de usuario.
         * 
         * De todas maneras, para patentar de alguna manera el procedimiento de
         * "eliminar" elementos de la cola, se hizo una ADENDA, la cual
         * habilita la posibilidad de eliminar un elemento (acorde a las reglas
         * de FIFO) al hacer click en la lista de pasajeros.
         * 
         * Las respuestas a los incisos A y B (de carácter teórico) están en el
         * archivo MSWord adjunto a este mismo directorio.
         */

        #region GLOBALES
        /**
         * ¿POR QUÉ?
         *  -)  Para archivo, para ubicar un lugar cómodo para definir un 
         *      archivo de salida.
         *  -)  Para cola, para que esté disponible entre los distintos 
         *      procedimientos ya que, como se verá, traté de dividir el código
         *      de forma que sea lo más equilibrado y razonable posible.
         *  -)  Finalmente, el booleano es para evitar que el cierre del form
         *      intente hacer operaciones que dependían de anteriores. El
         *      cierre del form es imprevisible, así que mejor dejar flotando
         *      una condición sobre la cual apoyarse.
         */
        public static string archivo = "../../pasajeros.txt";
        public Queue<string> cola    = new Queue<string>();
        public bool generado         = false;
        #endregion

        #region BOOT
        public frmCombis() { InitializeComponent(); }
        private void frmCombis_Load(object sender, EventArgs e)
        {
            Random aleatorio         = new Random();
            this.MaximizeBox         = false;
            this.MinimizeBox         = false;
            this.lblUnidad.Text      = lblUnidad.Text + "1972";
            this.lblChofer.Text      = lblChofer.Text + "Gerardo Tordoya";
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
            this.lblEspera.Text      = "En espera: " + cola.Count().ToString();
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
            foreach (string pasajero in cola)
            {
                item = new ListViewItem(pasajero);
                lstPasajeros.Items.Add(item);
            }
            lstPasajeros.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstPasajeros.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            this.lblEspera.Text = "En espera: " + cola.Count().ToString();
        }
        
        /**
         * ¿POR QUÉ LEER ARCHIVO? Es una función que no se usa tanto...
         * Si bien es cierto que no justifica hacer una función para una tarea
         * que se llama a hacer una sola vez, sin embargo quise aprovechar el 
         * código que ya había escrito para otro trabajo en esta misma materia.
         */
        public static List<string> LeerArchivo()
        {
            string cadena          = File.ReadAllText(archivo);
            List<string> registros = cadena.Split(new[] {
                Environment.NewLine
            }, StringSplitOptions.None).ToList();
            return registros;
        }
        #endregion

        #region BOTONES
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
                cola.Enqueue(txtPasajero.Text);
                txtPasajero.Text = "";
            }
            Imprimir();
            if (cola.Count < 19) {
                txtPasajero.Focus();
            } else
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
         * reducir a tan solo a dos cosas: vaciar la cola y no imprimir.
         * Vaciar la cola cumpliría con lo pedido por el inciso D.
         * No imprimir permite cumplir con el punto 1 de la 2da parte del
         * integrador (que necesita recuperar de algún lado los datos para
         * grabarlos en el archivo).
         * Todo el resto del código son para cuestiones propias del formulario.
         */
        private void btnSubir_Click(object sender, EventArgs e)
        {
            var horario = DateTime.Now;
            this.lblPartida.Text     = "Partida: " + 
                                       horario.Hour.ToString("00") + ':' + 
                                       horario.Minute.ToString("00");
            this.btnSubir.Enabled    = false;
            this.btnViajar.Enabled   = true;
            this.btnViajar.Focus();
            cola.Clear();
            this.lblInformacion.Text = "Se ha vaciado la estructura." + Environment.NewLine +
                                       "Los únicos datos que persisten" + Environment.NewLine +
                                       "son los del control de usuario.";
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
            string cadena          = null;
            this.btnViajar.Enabled = false;
            MessageBox.Show("Archivo de registro generado." + Environment.NewLine +
                            "Se hará un backup del mismo" + Environment.NewLine +
                            "cuando cierre esta aplicación.", 
                            "Información", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            foreach (ListViewItem item in lstPasajeros.Items)
            {
                cadena += item.Text + Environment.NewLine;
            }
            // El archivo de registro, a diferencia del de respaldo (backup) va
            // a ser de agregado, y por eso el uso de AppendAllText. Ver notas
            // en el evento de cierre del form.
            File.AppendAllText(archivo, string.Join(Environment.NewLine, cadena));
            generado = true;
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
                List<string> registros = LeerArchivo();
                var fecha = DateTime.Now;
                string respaldo = "../../pasajeros." +
                                  fecha.Year.ToString() + '_' +
                                  fecha.Month.ToString("00") + '_' +
                                  fecha.Day.ToString("00") + ".bak";
                File.WriteAllText(respaldo,
                                  string.Join(Environment.NewLine,
                                  registros));
            }
        }
        #endregion

        #region ADENDA
        // VER NOTA GENERAL.
        private void lstPasajeros_Click(object sender, EventArgs e)
        {
            cola.Dequeue();
            Imprimir();
        }
        #endregion
    }
}
