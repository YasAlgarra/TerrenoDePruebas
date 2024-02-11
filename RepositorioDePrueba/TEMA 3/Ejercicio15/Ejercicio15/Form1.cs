using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio15
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //La variable num nos sirve para leer los números sucesivos.
            // Las variables mayor y menor nos sirve para ir guardando el mayor 
            // y el menor hasta el momento.
            int num, mayor, menor;

            // Leemos un número utilizando int.Parse para convertir texto en entero.
            num = int.Parse(Interaction.InputBox("Introduzca un número:", "Ejercicio 15", "0"));
            if (num >= 0)
            {
                // El primer número leído será, hasta el momento el mayor y el menor.
                mayor = num;
                menor = num;

                while (num > 0)
                {
                    // Vemos si el número leído es mayor que 
                    if (num > mayor)
                        mayor = num;
                    if (num < menor)
                        menor = num;

                    // Leemos el siguiente número.
                    num = int.Parse(Interaction.InputBox("Introduzca un número:", "Ejercicio 15", "0"));
                }

                MessageBox.Show("El número mayor es: " + mayor + " y el menor: " + menor);
            }
            else
                MessageBox.Show("Ha introducido un primer número negativo. No hay mayor ni menor.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
