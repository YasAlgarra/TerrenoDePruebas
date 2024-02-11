using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_14
{
    public partial class Form1 : Form
    {
        private static string InputBox(string texto)
        {
            InputBoxDialog ib = new InputBoxDialog();
            ib.FormPrompt = texto;
            ib.DefaultValue = "";
            ib.ShowDialog();
            string s = ib.InputResponse;
            ib.Close();
            return s;
        }
        public Form1()
        {
            InitializeComponent();
        }

        const int TAM = 24;

        //Declarar vector
        double[] vector = new double[TAM];

        void leerVector(double[] vector) //leer el vector por teclado
        {
            try
            {
                for (int i = 0; i < vector.Length; i++)
                {
                    vector[i] = double.Parse(InputBox("Introduzca temperaturas " + i));
                }
            }
            catch (FormatException) //capturar errores de formato
            {
                MessageBox.Show("Error: Por favor, introduzca un número válido");
                leerVector(vector); //llamar recursivamente para repetir la lectura del mismo elemento

            }
            catch (Exception ex) //capturar errores inesperados
            {
                MessageBox.Show("Error inesperado al leer el vector: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        double Media(double[] vector)
        {
            double total = 0;

            for (int i = 0; i < vector.Length; i++) //recorrer el vector
            { 
                total += vector[i]; //calcular el total de la suma de temperaturas para poder hacer la media
            }

            double media = total / 24.00; //calcular media

            return media;
            
        }

   


        private void btnIntroducir_Click(object sender, EventArgs e)
        {
            leerVector(vector);
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            double media = Media(vector);

            for (int i = 0; i < vector.Length; i++) //recorrer vector
            {
                if (vector[i] >= media) //seleccionar temperaturas mayores o iguales a la media
                {
                    MessageBox.Show($"Temperatura igual o mayor a la media: {vector[i]}");
                }
            }
        }
    }
}
