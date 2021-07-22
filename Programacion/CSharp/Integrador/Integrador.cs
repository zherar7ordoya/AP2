using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Integrador
{
    public partial class frmCombis : Form
    {
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

        /**
         * NOTA:
         * Profesor, estoy revisando el trabajo (limpiando código y completando
         * comentarios) y me parece que tuve una confusión con respecto al
         * punto D de la primera parte del Trabajo Práctico Integrador.
         * 
         * En la consigna se lee:
         *                      «Codificar los botones SUBIR A LA COMBI 
         *                      para quitar elementos de la estructura.»
         *                      
         * ¿Cuál creo fue mi confusión? Que yo interpreté TODOS los elementos y
         * por ello inyecté una lógica al proyecto que cumplimente con ese 
         * requisito tal como yo lo había interpretado. 
         * Pero, volviendo a mirar la consigna, me ha parecido que tal vez el
         * pedido era UN elemento. 
         * 
         * No quise dejar esta otra arista sin solución, y para no tocar lo ya
         * hecho, agregué una ADENDA que responde a esa solicitud:
         * Si usted hace click en cualquier pasajero de la lista, se removerá
         * el elemento del principio de la cola (acorde a la FIFO propia del
         * concepto de cola).
         * 
         * Si eso es lo que debiera hacer el botón ANOTAR, toda la lógica queda
         * igual pues implicó más planificación hacer lo que yo hice: ejecutar
         * el vaciamiento de la estructura pero cuidando de tener en algún lado
         * los datos para los pasos siguientes (grabación en el archivo, etc.).
         * 
         * Ahora bien, hay una tercera interpretación: si la idea era subir
         * lotes de pasajeros (por ejemplo 5 y esperar por otros 7), bueno, la
         * lógica era completamente diferente y eso (en mi humilde opinión)
         * podría haber sido aclarado.
         */

        #region GLOBALES
        public static string archivo = "../../pasajeros.txt";
        public Queue<string> cola = new Queue<string>();
        string cadena = null;
        public bool generado = false;
        #endregion

        #region BOOT
        public frmCombis() { InitializeComponent(); }
        private void frmCombis_Load(object sender, EventArgs e)
        {
            Random aleatorio = new Random();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.lblUnidad.Text = lblUnidad.Text + "1972";
            this.lblChofer.Text = lblChofer.Text + "Gerardo Tordoya";
            this.lblKilometraje.Text = lblKilometraje.Text + aleatorio.Next(50, 500);
            InicializarSesion();
        }
        #endregion

        #region FUNCIONES
        private void InicializarSesion()
        {
            var horario = DateTime.Now;
            this.lblInformacion.Text =  "Si no hay pasajeros en espera" + Environment.NewLine +
                                        "y la combi está vacía," + Environment.NewLine +
                                        "vaya a la terminal de Puerto Madero.";
            this.lblArribo.Text =   "Arribo: " + 
                                    horario.Hour.ToString("00") + ':' + 
                                    horario.Minute.ToString("00");
            this.lblPartida.Text = "Partida: ";
            this.lblEspera.Text = "En espera: " + cola.Count().ToString();
            this.txtPasajero.Enabled = true;
            this.btnAnotar.Enabled = true;
            this.btnSubir.Enabled = false;
            this.btnViajar.Enabled = false;
            this.lstPasajeros.Clear();
            this.txtPasajero.Focus();
        }
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
        public static List<string> LeerArchivo()
        {
            string cadena = File.ReadAllText(archivo);
            List<string> registros = cadena.Split(new[] {
                Environment.NewLine
            }, StringSplitOptions.None).ToList();
            return registros;
        }
        #endregion

        #region BOTONES
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
                this.btnAnotar.Enabled = false;
                this.btnSubir.Enabled = true;
                this.btnSubir.Focus();
                this.lblInformacion.Text =  "Ha alcancado la capacidad máxima." + Environment.NewLine +
                                            "Pida a los pasajeros que suban.";
            }
        }
        private void btnSubir_Click(object sender, EventArgs e)
        {
            var horario = DateTime.Now;
            this.lblPartida.Text =  "Partida: " + 
                                    horario.Hour.ToString("00") + ':' + 
                                    horario.Minute.ToString("00");
            this.btnSubir.Enabled = false;
            this.btnViajar.Enabled = true;
            this.btnViajar.Focus();
            cola.Clear();
            this.lblInformacion.Text =  "Se ha vaciado la estructura." + Environment.NewLine +
                                        "Los únicos datos que persisten" + Environment.NewLine +
                                        "son los del control de usuario.";
        }
        private void btnViajar_Click(object sender, EventArgs e)
        {
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
            File.AppendAllText(archivo, string.Join(Environment.NewLine, cadena));
            generado = true;
            InicializarSesion();
        }
        #endregion

        #region FINALE
        private void frmCombis_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (generado)
            {
                List<string> registros = LeerArchivo();
                var fecha = DateTime.Now;
                string respaldo = "../../pasajeros." +
                                    fecha.Year.ToString() + '_' +
                                    fecha.Month.ToString("00") + '_' +
                                    fecha.Day.ToString("00") + ".bak";
                File.WriteAllText(respaldo, string.Join(Environment.NewLine, registros));
            }
        }
        #endregion

        #region ADENDA
        private void lstPasajeros_Click(object sender, EventArgs e)
        {
            cola.Dequeue();
            Imprimir();
        }
        #endregion
    }
}
