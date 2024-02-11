using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Función que realiza una división entera mediante restas sucesivas.
        // Contamos cuantas veces "cabe" el dividendo en el divisor.
        int divisionIterativa(int dividendo, int divisor)
        {
            int cont;

            cont = 0;
            while (dividendo >= divisor)
            {
                dividendo = dividendo - divisor;
                cont++;
            }
        
            return cont;
        }
        
        private void bDIterativa_Click(object sender, EventArgs e)
        {
            int dividendo, divisor, res;

            dividendo = int.Parse(tDividendo.Text);
            divisor = int.Parse(tDivisor.Text);

            res = divisionIterativa(dividendo, divisor);

            MessageBox.Show("El resultado de dividir " + dividendo + " entre " + divisor + " es : " + res);
        }

        // Función que realiza una división entera mediante restas  recursivamente.
        // El concepto es ver si cabe el divisor en el dividendo y si es así cabe 1 vez mas las que quepa restarle al dividendo el divisor.
        // Por ejemplo la division (19, 5) = 1 + division(14, 5)
        int divisionRecursiva(int dividendo, int divisor)
        {
            int res;

            if (divisor > dividendo)
                res = 0;
            else
                res = 1 + divisionRecursiva(dividendo - divisor, divisor);

            return res;        
        }
        
        private void bDRecursiva_Click(object sender, EventArgs e)
        {
            int dividendo, divisor, res;

            dividendo = int.Parse(tDividendo.Text);
            divisor = int.Parse(tDivisor.Text);

            res = divisionRecursiva(dividendo, divisor);

            MessageBox.Show("El resultado de dividir " + dividendo + " entre " + divisor + " es : " + res);

        }
    }
}
