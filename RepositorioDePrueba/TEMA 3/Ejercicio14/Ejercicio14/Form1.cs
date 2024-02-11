using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, suma=0;


            for (i = 1; i <= 10; i++)
                suma = suma + i;

            MessageBox.Show("La suma de los 10 primeros números es: " + suma);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i, suma;

            suma = 0;
            i = 1;
            while (i <= 10)
            {
                suma = suma + i;
                i++;
            }
            MessageBox.Show("La suma de los 10 primeros números es: " + suma);

        }
    }
}
