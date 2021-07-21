using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Integrador
{
    public partial class frmCombis : Form
    {
        public static string archivo = "../../Pasajeros.txt";
        public Queue<string> cola = new Queue<string>();
        public frmCombis() { InitializeComponent(); }

        private void frmCombis_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            PrepararArchivo(archivo);
            CargarDatosBobos(archivo);
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
        public void ActualizarListado(Queue<string> lista)
        {
            lstPasajeros.Clear();
            lstPasajeros.View = View.Details;
            lstPasajeros.Columns.Add("PASAJEROS");
            ListViewItem item;
            foreach (string pasajero in lista)
            {
                item = new ListViewItem(pasajero);
                lstPasajeros.Items.Add(item);
            }
            lstPasajeros.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
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
            if (txtPasajero.Text != "") { cola.Enqueue(txtPasajero.Text); }
            ActualizarListado(cola);
            /*
            var cola = new Queue<string>(LeerArchivo());
            cola.Enqueue(txtPasajero.Text);
            */

        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            cola.Clear();
        }

        private void btnViajar_Click(object sender, EventArgs e)
        {

        }
    }
}
