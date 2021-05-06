/**
 * @author: Gerardo Tordoya
 * @date: 2021-04-22
 * @project: 
 *          Asignación: TP 1 (Laboratorio #1)
 *          Materia:    Programación 1
 *          Comisión:   1-O-N
 *          Carrera:    Analista Programador
 * UAI 2021
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario {
    public partial class frmCalculadora : Form {
        // *------------------------------------------------------=> FORMULARIO
        public frmCalculadora() {
            InitializeComponent();
        }
        private void frmCalculadora_Load(object sender, EventArgs e) {
            this.ControlBox = false;
        }
        private void btnLimpiar_Click(object sender, EventArgs e) {
            txtOp1.Text = "";
            txtOp2.Text = "";
            txtRta.Text = "";
            this.txtOp1.Focus();
        }
        private void btnSalir_Click(object sender, EventArgs e) {
            Close();
        }

        // *-----------------------------------------------------=> OPERACIONES
        private void btnSuma_Click(object sender, EventArgs e) {
            txtRta.Text = (Int32.Parse(txtOp1.Text) + Int32.Parse(txtOp2.Text)).ToString();
        }
        private void btnResta_Click(object sender, EventArgs e) {
            txtRta.Text = Convert.ToString(Convert.ToInt32(txtOp1.Text) - Convert.ToInt32(txtOp2.Text));
        }
        private void btnCoc_Click(object sender, EventArgs e) {
            int num = Int32.Parse(txtOp1.Text);
            int den = Int32.Parse(txtOp2.Text);
            if (den != 0) {
                txtRta.Text = (Int32.Parse(txtOp1.Text) / Int32.Parse(txtOp2.Text)).ToString();
            }
        }
        private void btnProd_Click(object sender, EventArgs e) {
            txtRta.Text = (Int32.Parse(txtOp1.Text) * Int32.Parse(txtOp2.Text)).ToString();
        }
    }
}
