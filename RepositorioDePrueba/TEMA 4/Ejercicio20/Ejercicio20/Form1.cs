using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int potenciaIterativa(int b, int exp)
        {
            int i, res;

            res = 1;

            for (i = 1; i <= exp; i++)
            {
                res = res * b;
            }

            return res;
        }

        private void bIterativa_Click(object sender, EventArgs e)
        {
            int bbase, exponente, res;

            bbase = int.Parse(tBase.Text);
            exponente = int.Parse(tExponente.Text);

            res = potenciaIterativa(bbase, exponente);

            MessageBox.Show("El resultado de la potencia es: " + res);
        }

        int potenciaRecursiva(int b, int exp)
        {
            int res;

            if (exp == 0)
                res = 1;
            else
                res = b * potenciaRecursiva(b, exp - 1);

            return res;
        }

        private void bRecursiva_Click(object sender, EventArgs e)
        {
            int bbase, exponente, res;

            bbase = int.Parse(tBase.Text);
            exponente = int.Parse(tExponente.Text);

            res = potenciaRecursiva(bbase, exponente);

            MessageBox.Show("El resultado de la potencia es: " + res);
        }
    }
}
