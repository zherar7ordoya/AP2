using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class formCalculadora : Form
    {
        double PrimerNumero;
        string Operacion;
        public formCalculadora()
        {
            InitializeComponent();
        }

        private void boton0_Click(object sender, EventArgs e)
        {
            textoDisplay.Text += "0";
        }

        private void botonPunto_Click(object sender, EventArgs e)
        {
            textoDisplay.Text += ".";
        }

        private void botonIgual_Click(object sender, EventArgs e)
        {
            double SegundoNumero;
            double Resultado;

            SegundoNumero = Convert.ToDouble(textoDisplay.Text);

            if (Operacion == "+")
            {
                Resultado = (PrimerNumero + SegundoNumero);
                textoDisplay.Text = Convert.ToString(Resultado);
                PrimerNumero = Resultado;
            }
            if (Operacion == "-")
            {
                Resultado = (PrimerNumero - SegundoNumero);
                textoDisplay.Text = Convert.ToString(Resultado);
                PrimerNumero = Resultado;
            }
            if (Operacion == "*")
            {
                Resultado = (PrimerNumero * SegundoNumero);
                textoDisplay.Text = Convert.ToString(Resultado);
                PrimerNumero = Resultado;
            }
            if (Operacion == "/")
            {
                if (SegundoNumero == 0)
                {
                    textoDisplay.Text = "No se puede dividir por cero.";

                }
                else
                {
                    Resultado = (PrimerNumero / SegundoNumero);
                    textoDisplay.Text = Convert.ToString(Resultado);
                    PrimerNumero = Resultado;
                }
            }
        }

        private void botonResta_Click(object sender, EventArgs e)
        {
            PrimerNumero = Convert.ToDouble(textoDisplay.Text);
            textoDisplay.Text = "0";
            Operacion = "-";
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            if (textoDisplay.Text == "0" && textoDisplay.Text != null)
            {
                textoDisplay.Text = "1";
            }
            else
            {
                textoDisplay.Text = textoDisplay.Text + "1";
            }
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            if (textoDisplay.Text == "0" && textoDisplay.Text != null)
            {
                textoDisplay.Text = "2";
            }
            else
            {
                textoDisplay.Text = textoDisplay.Text + "2";
            }
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            if (textoDisplay.Text == "0" && textoDisplay.Text != null)
            {
                textoDisplay.Text = "3";
            }
            else
            {
                textoDisplay.Text = textoDisplay.Text + "3";
            }
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            if (textoDisplay.Text == "0" && textoDisplay.Text != null)
            {
                textoDisplay.Text = "4";
            }
            else
            {
                textoDisplay.Text = textoDisplay.Text + "4";
            }
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            if (textoDisplay.Text == "0" && textoDisplay.Text != null)
            {
                textoDisplay.Text = "5";
            }
            else
            {
                textoDisplay.Text = textoDisplay.Text + "5";
            }
        }

        private void boton6_Click(object sender, EventArgs e)
        {
            if (textoDisplay.Text == "0" && textoDisplay.Text != null)
            {
                textoDisplay.Text = "6";
            }
            else
            {
                textoDisplay.Text = textoDisplay.Text + "6";
            }
        }

        private void boton7_Click(object sender, EventArgs e)
        {
            if (textoDisplay.Text == "0" && textoDisplay.Text != null)
            {
                textoDisplay.Text = "7";
            }
            else
            {
                textoDisplay.Text = textoDisplay.Text + "7";
            }
        }

        private void boton8_Click(object sender, EventArgs e)
        {
            if (textoDisplay.Text == "0" && textoDisplay.Text != null)
            {
                textoDisplay.Text = "8";
            }
            else
            {
                textoDisplay.Text = textoDisplay.Text + "8";
            }
        }

        private void boton9_Click(object sender, EventArgs e)
        {
            if (textoDisplay.Text == "0" && textoDisplay.Text != null)
            {
                textoDisplay.Text = "9";
            }
            else
            {
                textoDisplay.Text = textoDisplay.Text + "9";
            }
        }

        private void botonSuma_Click(object sender, EventArgs e)
        {
            PrimerNumero = Convert.ToDouble(textoDisplay.Text);
            textoDisplay.Text = "0";
            Operacion = "-";
        }

        private void botonMultiplicacion_Click(object sender, EventArgs e)
        {
            PrimerNumero = Convert.ToDouble(textoDisplay.Text);
            textoDisplay.Text = "0";
            Operacion = "*";
        }

        private void botonDivision_Click(object sender, EventArgs e)
        {
            PrimerNumero = Convert.ToDouble(textoDisplay.Text);
            textoDisplay.Text = "0";
            Operacion = "/";
        }
    }
}
