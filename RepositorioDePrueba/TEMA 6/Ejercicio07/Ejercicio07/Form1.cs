using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int kTAM = 10;

        // Declaramos y damos tamaño al vector.
        int[] vector = new int[kTAM];

        // Leemos el vector obligando a que cada elemento sea mayor que el anterior.
        void leerVectorVersion1(int[] vector)
        {
            try
            {
                // Leemos el primer elemento.
                vector[0] = int.Parse(Interaction.InputBox("Introduzca el elemento: 0"));

                // Leemos el resto de elementos del vector.
                for (int i = 1; i < vector.Length; i++)
                {
                    do
                    {
                        // Solicitamos al usuario que introduzca el elemento mediante un cuadro de diálogo.
                        string input = Interaction.InputBox("Introduzca el elemento: " + i);

                        // Intentamos convertir la entrada a un número entero y asignamos al elemento correspondiente del vector.
                        vector[i] = int.Parse(input);

                        // Verificamos si el nuevo elemento es menor o igual al elemento anterior.
                        if (vector[i] <= vector[i - 1])
                        {
                            // Si es menor o igual, mostramos un mensaje de error y repetimos la lectura del mismo elemento.
                            MessageBox.Show("El número debe ser mayor que el anterior.");
                        }
                    }
                    while (vector[i] <= vector[i - 1]);
                }
            }
            catch (FormatException)
            {
                // Si la conversión falla, mostramos un mensaje de error al usuario.
                MessageBox.Show("Error: Por favor, introduzca un número válido.");
                leerVectorVersion1(vector); // Llamamos recursivamente para repetir la lectura.
            }
            catch (Exception ex)
            {
                // Si ocurre alguna excepción diferente de FormatException, la capturamos y mostramos un mensaje de error personalizado.
                MessageBox.Show("Error inesperado al leer el vector: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Leemos el vector obligando a que cada elemento sea mayor que el anterior.
        void leerVectorVersion2(int[] vector)
        {
            try
            {
                // Leemos el primer elemento.
                vector[0] = int.Parse(Interaction.InputBox("Introduzca el elemento: 0"));

                // Leemos el resto de elementos del vector.
                int i = 1;
                while (i < vector.Length)
                {
                    // Solicitamos al usuario que introduzca el elemento mediante un cuadro de diálogo.
                    string input = Interaction.InputBox("Introduzca el elemento: " + i);

                    // Intentamos convertir la entrada a un número entero y asignamos al elemento correspondiente del vector.
                    vector[i] = int.Parse(input);

                    // Verificamos si el nuevo elemento es menor o igual al elemento anterior.
                    if (vector[i] <= vector[i - 1])
                    {
                        // Si es menor o igual, mostramos un mensaje de error y repetimos la lectura del mismo elemento.
                        MessageBox.Show("El número debe ser mayor que el anterior.");
                    }
                    else
                    {
                        // Si es mayor, pasamos a la siguiente posición.
                        i = i + 1;
                    }
                }
            }
            catch (FormatException)
            {
                // Si la conversión falla, mostramos un mensaje de error al usuario.
                MessageBox.Show("Error: Por favor, introduzca un número válido.");
                leerVectorVersion2(vector); // Llamamos recursivamente para repetir la lectura.
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
            int i;

            texto = "Elementos del vector: \n";
            for (i = 0; i < vector.Length; i++)
                texto = texto + vector[i] + ", ";

            return texto;
        }


        private void bLeer1_Click(object sender, EventArgs e)
        {
            leerVectorVersion1(vector);
        }

        private void bLeerVersion2_Click(object sender, EventArgs e)
        {
            leerVectorVersion2(vector);
        }

        private void bMostrar_Click(object sender, EventArgs e)
        {
            string texto;

            texto = mostrarVector(vector);
            MessageBox.Show(texto);
        }

    }
}
