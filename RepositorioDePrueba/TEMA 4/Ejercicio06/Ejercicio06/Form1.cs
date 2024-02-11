using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Subprograma que devuelve a través de dos parámetros out (salida)
        // el cociente y el resto entre dos números.
        void CocienteYResto(int num1, int num2, out int cociente, out int resto)
        {
            cociente = num1 / num2;
            resto = num1 % num2;
        }
        
        private void bIntercambiar_Click(object sender, EventArgs e)
        {
            int num1, num2;
            int result, resto;

            num1 = int.Parse(tNum1.Text);
            num2 = int.Parse(tNum2.Text);

            CocienteYResto(num1, num2, out result, out resto);

            MessageBox.Show("El cociente es : " + result + " y el resto: " + resto);
        }
    }
}
