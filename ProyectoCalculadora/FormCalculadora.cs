using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoCalculadora
{
    public enum Operacion
    {
        NoDefinida = 0,
        Suma = 1,
        Resta = 2,
        Division = 3,
        Multiplicacion= 4,
        Modulo = 5
    }
    public partial class FormCalculadora : Form
    {
        private double valor1 = 0;
        private double valor2 = 0;
        Operacion operador = Operacion.NoDefinida;
        bool numeroLeido = false;

        private double EjecutarOperacion()
        {
            double resultado = 0;

            switch (operador)
            {
                case Operacion.NoDefinida:
                    break;
                case Operacion.Suma:
                    resultado = valor1 + valor2;
                    break;
                case Operacion.Resta:
                    resultado = valor1 - valor2;
                    break;
                case Operacion.Division:
                    if (valor2 == 0)
                    {
                        MessageBox.Show("No se puede dividir entre 0");
                        resultado = 0;
                    }
                    else
                    {
                        resultado = valor1 / valor2;
                    }
                    break;
                case Operacion.Multiplicacion:
                    resultado = valor1 * valor2;
                    break;
                case Operacion.Modulo:
                    resultado = valor1 % valor2;
                    break;
            }
            return resultado;
        }
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void LeerNumero(string numero)
        {
            numeroLeido = true;
            if (cajaResultado.Text == "0" && cajaResultado.Text != null)
            {
                cajaResultado.Text = numero;
            }
            else
            {
                cajaResultado.Text += numero;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void btnCero_Click(object sender, EventArgs e)
        {
            numeroLeido = true;
            if (cajaResultado.Text == "0")
            {
                return;
            }
            else if (cajaResultado.Text != "0")
            {
                cajaResultado.Text += "0";
            }
            else
            {
                cajaResultado.Text = "0";
            }
            
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            LeerNumero("1");
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            LeerNumero("2");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            LeerNumero("3");
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            LeerNumero("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            LeerNumero("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            LeerNumero("6");
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            LeerNumero("7");
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            LeerNumero("8");
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            LeerNumero("9");
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (valor2 == 0 && numeroLeido)
            {
                valor2 = Convert.ToDouble(cajaResultado.Text);
                lblHistorial.Text += valor2 + " = ";
                double resultado = EjecutarOperacion();
                valor1 = 0;
                valor2 = 0;
                numeroLeido = false;
                cajaResultado.Text = Convert.ToString(resultado);
            }
        }

        private void ObtenerValor(string signo)
        {
            valor1 = Convert.ToDouble(cajaResultado.Text);
            lblHistorial.Text = cajaResultado.Text + signo;
            cajaResultado.Text = "0";
        }
        private void btnMas_Click(object sender, EventArgs e)
        {
            operador = Operacion.Suma;
            ObtenerValor(" + ");

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = Operacion.Resta;
            ObtenerValor(" - ");
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operador = Operacion.Multiplicacion;
            ObtenerValor(" * ");
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operador = Operacion.Division;
            ObtenerValor(" / ");
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            operador = Operacion.Modulo;
            ObtenerValor(" % ");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cajaResultado.Text = "0";
            lblHistorial.Text = "";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string txtResultado = cajaResultado.Text;
            txtResultado = txtResultado.Substring(0, txtResultado.Length - 1);


            if (txtResultado.Length == 1 && txtResultado.Contains("-"))
            {
                cajaResultado.Text = "0";
            }
            else
            {
                cajaResultado.Text = txtResultado;
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (cajaResultado.Text.Contains("."))
            {
                return;
            }
            else
            {
                cajaResultado.Text += ".";
            }
        }
    }
}
