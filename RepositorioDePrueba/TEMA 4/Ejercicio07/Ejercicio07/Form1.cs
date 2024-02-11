using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Función que devuelve el menor de dos números
        int numMenor(int n1, int n2)
        {
            int menor;

            if (n1 < n2)
                menor = n1;
            else
                menor = n2;

            return menor;
        }

        // Función que obtiene el máximo común divisor.
        // Empezamos desde 1 y vamos subiendo hasta el número menor de los dos
        // Nos quedamos con el último número que divide a ambos.
        int calcularMCDVersion1(int n1, int n2)
        {
            int mcd = 1, menor;

            menor = numMenor(n1, n2);

            for(int i = 1; i <= menor; i++)
            {
                // Si el número es divisor de ambos pasa a ser el MCD
                if (n1 % i == 0 && n2 % i == 0)
                    mcd = i;
            }

            return mcd;
        }

        // Función que obtiene el máximo común divisor.
        // Empezamos desde el número menor 
        // y vamos bajando hasta que encontremos un número que divida a ambos
        // Ese será el MCD
        int calcularMCDVersion2(int n1, int n2)
        {
            int mcd;
            bool encontrado = false;

            mcd = numMenor(n1, n2);

            while(!encontrado)
            {
                // Si el número es divisor hemos encontrado el MCD
                // En otro caso pasamos a un número menor
                if (n1 % mcd == 0 && n2 % mcd == 0)
                    encontrado = true;
                else
                    mcd--;
            }

            return mcd;
        }


        private void bMCD1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            int mcd;

            num1 = int.Parse(tNum1.Text);
            num2 = int.Parse(tNum2.Text);

            mcd = calcularMCDVersion1(num1, num2);

            MessageBox.Show("El MCD es : " + mcd);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            int mcd;

            num1 = int.Parse(tNum1.Text);
            num2 = int.Parse(tNum2.Text);

            mcd = calcularMCDVersion2(num1, num2);

            MessageBox.Show("El MCD es : " + mcd);
        }
    }
}
