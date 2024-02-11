using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Función potencia.
        // Calcula el resultado de elevar la base al exponente.
        int Potencia(int bBase, int exp)
        {
            int res;

            res = 1;
            for(int i = 1; i <= exp; i++)
            {
                res = res * bBase;
            }

            return res;
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(tNum.Text);

                int res2 = Potencia(num, 2);
                int res5 = Potencia(num, 5);
                int res7 = Potencia(num, 7);

                MessageBox.Show($"El número {num} elevado a 2: {res2}, elevado a 5: {res5}, elevado a 7: {res7}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }
    }
}
