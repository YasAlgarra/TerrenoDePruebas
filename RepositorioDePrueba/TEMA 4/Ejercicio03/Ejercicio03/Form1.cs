using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Subprograma que intercambiar el valor de dos variables enteras.
        // Son parámetros por ref, ya que son de entrada/salida.
        void Intercambiar(ref int n1, ref int n2)
        {
            int aux;

            aux = n1;
            n1 = n2;
            n2 = aux;
        }

        private void bIntercambiar_Click(object sender, EventArgs e)
        {
            int num1, num2;

            num1 = int.Parse(tNum1.Text);
            num2 = int.Parse(tNum2.Text);

            Intercambiar(ref num1, ref num2);

            tNum1.Text = num1.ToString();
            tNum2.Text = num2.ToString();

        }
    }
}
