using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int kTAM = 5;

        // Declaramos y damos tamaño al vector.
        int[] vectorA= new int[kTAM];

        void leerVector(int[] vectorA)
        {
            try
            {
                // Leemos todos los elementos del vector.
                for (int i = 0; i < vectorA.Length; i++)
                {
                    // Solicitamos al usuario que introduzca el elemento mediante un cuadro de diálogo.
                    string input = Interaction.InputBox("Introduzca el elemento: vector[" + i + "]=");

                    // Convertimos la entrada a un número entero y asignamos al elemento correspondiente del vector.
                    vectorA[i] = int.Parse(input);
                }
            }
            catch (FormatException)
            {
                // Si la conversión falla, mostramos un mensaje de error al usuario y decrementamos i para repetir la lectura del mismo elemento.
                MessageBox.Show("Error: Por favor, introduzca un número válido.");
                leerVector(vectorA); // Llamamos recursivamente para repetir la lectura del mismo elemento.
            }
            catch (Exception ex)
            {
                // Si ocurre alguna excepción diferente de FormatException, la capturamos y mostramos un mensaje de error personalizado.
                MessageBox.Show("Error inesperado al leer el vector: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        string mostrarVector(int[] vector)
        {
            string texto;
            int j;

            texto = "Elementos del vector: \n";
            for (j = 0; j < vector.Length; j++)
                texto = texto + vector[j] + ", ";

            return texto;
        }

        // Función que devuelve la media de los elementos del vector
        double mediaVector(int[] vector)
        {
            double suma;

            suma = 0;
            for (int i = 0; i < vector.Length; i++)
                suma = suma + vector[i];

            suma = suma / vector.Length;

            return suma;
        }

        private void bLeer_Click(object sender, EventArgs e)
        {
            leerVector(vectorA);
        }

        private void bMostrar_Click(object sender, EventArgs e)
        {
            string texto;
            double media;

            texto = mostrarVector(vectorA);
            media = mediaVector(vectorA);

            texto = texto + "\nLa media es: " + media;
            MessageBox.Show(texto);
        }

    }
}
