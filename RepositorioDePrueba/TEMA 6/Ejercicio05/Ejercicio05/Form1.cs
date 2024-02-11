using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int kTAM = 10;

        // Declaramos y damos tamaño al vector.
        int[] vectorA = new int[kTAM];
        int[] vectorB = new int[kTAM];
        int[] vectorRes = new int[kTAM];

        void leerVector(int[] vector)
        {
            try
            {
                // Leemos todos los elementos del vector.
                for (int i = 0; i < vector.Length; i++)
                {
                    // Solicitamos al usuario que introduzca el elemento mediante un cuadro de diálogo.
                    string input = Interaction.InputBox("Introduzca el elemento: " + i);

                    // Intentamos convertir la entrada a un número entero y asignamos al elemento correspondiente del vector.
                    vector[i] = int.Parse(input);
                }
            }
            catch (FormatException)
            {
                // Si la conversión falla, mostramos un mensaje de error al usuario y decrementamos i para repetir la lectura del mismo elemento.
                MessageBox.Show("Error: Por favor, introduzca un número válido.");
                leerVector(vector); // Llamamos recursivamente para repetir la lectura del mismo elemento.
            }
            catch (Exception ex)
            {
                // Si ocurre alguna excepción diferente de FormatException, la capturamos y mostramos un mensaje de error personalizado.
                MessageBox.Show("Error inesperado al leer el vector: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Hacemos la suma elemento a elemento
        void sumarVector(int[] vA, int []vB, int[] vRes)
        {
            int i;

            for (i = 0; i < vA.Length; i++)
                vRes[i] = vA[i] + vB[i];
                
        }

        string mostrarVector(int[] vector)
        {
            string texto;
            int i;

            texto = "Elementos del vector: \n";
            for (i = 0; i < vector.Length; i++)
                texto = texto + vector[i] + ", ";

            return texto;
        }

        private void bLeer_Click(object sender, EventArgs e)
        {
            leerVector(vectorA);
            leerVector(vectorB);
        }

        private void bMostrar_Click(object sender, EventArgs e)
        {
            string texto;

            sumarVector(vectorA, vectorB, vectorRes);
            texto = mostrarVector(vectorRes);

            MessageBox.Show(texto);
        }

    }
}
