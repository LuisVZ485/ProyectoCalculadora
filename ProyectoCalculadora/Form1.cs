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
    public partial class Form1 : Form
    {
        private double valor1 = 0;
        private double valor2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void LeerNumero(string numero)
        {
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

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (valor2 == 0)
            {
                valor2 = Convert.ToDouble(cajaResultado.Text);
                lblHistorial.Text += valor2 + " = ";
                double resultado = valor1 + valor2;
                valor1 = 0;
                valor2 = 0;
                cajaResultado.Text = Convert.ToString(resultado);
            }
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
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

        private void btnMas_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(cajaResultado.Text);
            lblHistorial.Text = cajaResultado.Text + " + ";
            cajaResultado.Text = "0";

        }
    }
}
