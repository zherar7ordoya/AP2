using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Integrador
{
    public partial class frmCombis : Form
    {
        public static string archivo = "../../pasajeros.txt";
        public Queue<string> cola = new Queue<string>();
        string cadena = null;
        public bool generado = false;
        public frmCombis() { InitializeComponent(); }

        private void frmCombis_Load(object sender, EventArgs e)
        {
            Random aleatorio = new Random();
            var horario = DateTime.Now;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.lblInformacion.Text = "Si no hay pasajeros en espera y la combi está vacía, vaya a la terminal de Puerto Madero.";
            this.lblUnidad.Text = lblUnidad.Text + "1972";
            this.lblChofer.Text = lblChofer.Text + "Gerardo Tordoya";
            this.lblKilometraje.Text = lblKilometraje.Text + aleatorio.Next(50, 500);
            this.lblArribo.Text = lblArribo.Text + horario.Hour.ToString("00") + ':' + horario.Minute.ToString("00");
            this.lblEspera.Text = "En espera: " + cola.Count().ToString();
            this.btnSubir.Enabled = false;
            this.btnViajar.Enabled = false;
            this.txtPasajero.Focus();
            // PrepararArchivo(archivo);
            // CargarDatosBobos(archivo);
        }

        #region COMUNES
        public static List<string> LeerArchivo()
        {
            string cadena = File.ReadAllText(archivo);
            List<string> registros = cadena.Split(new[] {
                Environment.NewLine
            }, StringSplitOptions.None).ToList();
            return registros;
        }
        public void GuardarArchivo(dynamic contenido)
        {
            File.WriteAllText(archivo, string.Join(Environment.NewLine, contenido));
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
        #endregion

        #region PREPARATORIO
        /* ¿POR QUÉ?
         * En el parcial anterior, el archivo vino con saltos de línea que me
         * hicieron fallar los primeros intentos hasta que descubrí el origen.
         * Recupera el archivo en una cadena, que luego, separada en líneas,
         * se guarda en un array, que luego se cuenta a partir de sus null (que
         * hacen de saltos de línea), se vuelve a armar el array sin saltos de
         * línea null, se rearma el string y se reemplaza todo en el archivo
         * con este nuevo contenido.
         */
        private void PrepararArchivo(string archivo)
        {
            List<string> registros = LeerArchivo();
            int inicio = 0, final = registros.Count - 1;
            while (inicio < final && String.IsNullOrWhiteSpace(registros[inicio])) { inicio++; }
            while (final >= inicio && String.IsNullOrWhiteSpace(registros[final])) { final--; }
            var despejados = registros.Skip(inicio).Take(final - inicio + 1);
            GuardarArchivo(despejados);
        }
        #endregion

        private void CargarDatosBobos(string archivo)
        {
            if (txtPasajero.Text!="") { cola.Enqueue(txtPasajero.Text); }
            /*
            var cola = new Queue<string>(LeerArchivo());
            ActualizarListado(cola);
            */
        }

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
            /*
            var cola = new Queue<string>(LeerArchivo());
            cola.Enqueue(txtPasajero.Text);
            */

        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            var horario = DateTime.Now;
            this.lblPartida.Text =  lblPartida.Text + 
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
            this.lblInformacion.Text =  "Archivo de registro generado." + Environment.NewLine +
                                        "Se hará un backup del mismo" + Environment.NewLine +
                                        "cuando cierre esta aplicación.";
            foreach (ListViewItem item in lstPasajeros.Items)
            {
                cadena += item.Text + Environment.NewLine;
            }
            File.AppendAllText(archivo, string.Join(Environment.NewLine, cadena));
            generado = true;
        }

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
    }
}
