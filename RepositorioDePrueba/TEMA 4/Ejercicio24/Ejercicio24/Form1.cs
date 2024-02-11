using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Función que nos devuelve el número de cifras de un número.
        // ncifras(3456) = 1 + ncifras(345)
        int ncifras(int num)
        {
            int res;

            if (num < 10)
                res = 1;
            else
                res = 1 + ncifras(num / 10);

            return res;
        }

        // Función que calcula recursivamente la potencia de una base elevada a un exponente.
        // 5 elevado a 4 es igual a 5 multiplicado por 5 elevado a 3.
        // potencia (5, 4) = 5 * potencia (5, 3)
        int potencia(int bbase, int exp)
        {
            int res;

            if (exp == 0)
                res = 1;
            else
                res = bbase * potencia(bbase, exp - 1);

            return res;
        }

        // Función que da la vuelta a un número. Es decir 3456 devuelve 6543.
        // La idea es tener en cuenta que DarVuelta(3456) = 6000 + DarVuelta(345)
        // 6000 son 6*1000. Para obtener 1000 elevamos 10 al número de cifras - 1
        // Utilizamos funciones de ejercicios anteriores ncifras y potencia.
        int DarVueltaRecursivo(int num)
        {
            int res;

            if (num < 10)
                res = num;
            else
            {
                int unidad, potenciade10;

                // obtenemos el 6 del ejemplo.
                unidad = num % 10; 
                // obtenemos el 1000 del ejemplo
                potenciade10 = potencia(10, ncifras(num) - 1);

                res = unidad * potenciade10 + DarVueltaRecursivo(num / 10);
            }

            return res;
        }

        private void bDarVuelta_Click(object sender, EventArgs e)
        {
            int num, vuelta;

            num = int.Parse(tNumero.Text);

            vuelta = DarVueltaRecursivo(num);

            MessageBox.Show(num + " al revés es: " + vuelta);
        }
    }
}
