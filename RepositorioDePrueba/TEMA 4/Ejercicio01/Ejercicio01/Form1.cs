using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int suma(int num1, int num2)
        {
            int res;

            res = num1 + num2;

            return res;
        }

        private void bSumar_Click(object sender, EventArgs e)
        {
            int result, n1, n2;

            n1 = int.Parse(tNum1.Text);
            n2 = int.Parse(tNum2.Text);

            result = suma(n1, n2);

            MessageBox.Show("El resultado de la suma es: " + result);
        }
    }
}
