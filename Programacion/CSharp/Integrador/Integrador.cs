using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador
{
    public partial class frmCombis : Form
    {
        public static string archivo = "../../Pasajeros.txt";
        public frmCombis() { InitializeComponent(); }

        private void frmCombis_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            PrepararArchivo(archivo);
            CargarDatosBobos(archivo);
        }

        public static List<string> LeerArchivo()
        {
            string cadena = File.ReadAllText(archivo);
            List<string> registros = cadena.Split(new[] {
                Environment.NewLine
            }, StringSplitOptions.None).ToList();
            return registros;
        }
        public void GuardarArchivo()
        {

        }

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
            /*
            string cadena = File.ReadAllText(archivo);
            List<string> registros = cadena.Split(new[] { 
                Environment.NewLine 
            }, StringSplitOptions.None).ToList();
            */

            List<string> registros = LeerArchivo();
            int inicio = 0, final = registros.Count - 1;

            while (inicio < final && String.IsNullOrWhiteSpace(registros[inicio])) { inicio++; }
            while (final >= inicio && String.IsNullOrWhiteSpace(registros[final])) { final--; }

            // var despejados = registros.Skip(inicio).Take(final - inicio + 1);
            var despejados = registros.Skip(inicio).Take(final - inicio + 1);
            File.WriteAllText(archivo, string.Join(Environment.NewLine, despejados));
        }
        #endregion
        private void CargarDatosBobos(string archivo)
        {
            string cadena = File.ReadAllText(archivo);
            var registros = cadena.Split(new[] {
                Environment.NewLine
            }, StringSplitOptions.None).ToList();
            var cola = new Queue<string>(registros);

            lstPasajeros.View = View.Details;
            lstPasajeros.Columns.Add("PASAJEROS");

            ListViewItem item;
            foreach (string pasajero in cola)
            {
                item = new ListViewItem(pasajero);
                lstPasajeros.Items.Add(item);
            }
            lstPasajeros.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void btnAnotar_Click(object sender, EventArgs e)
        {

        }
    }
}
