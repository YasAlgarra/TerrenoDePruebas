using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_6
{


    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
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

        //tamaño de nuestros vectores
        const int TAM = 10;

        //Declarar y dar tamaño a los vectores
        int[] vector1 = new int[TAM];
        int[] vector2 = new int[TAM];

        void lecturaVectores(int[] vector1, int[] vector2)
        {
            
            try
            {
                //leer vector 1
                for (int i = 0; i < vector1.Length; i++)
                {
                    vector1[i] = int.Parse(InputBox("Introduzca el vector 1: " + i));
                }

                //leer vector 2
                for (int j = 0; j < vector2.Length; j++)
                {
                    vector2[j] = int.Parse(InputBox("Ahora, introduzca el vector 2: " + j));
                }

            } catch (FormatException) //capturar errores de formato, pero cuando le doy a "cancelar" también me sale este error, ¿cómo puedo evitarlo?
            {
                MessageBox.Show("Error: Por favor, introduzca un número válido");
                lecturaVectores(vector1, vector2);

            } catch (Exception ex) //capturar errores inesperados
            {
                MessageBox.Show("Error inesperado al leer el vector: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        //Función que compara ambos vectores
        bool sonIguales(int[] vector1, int[] vector2)
        {
            for (int i = 0; i < vector1.Length; i++) { //recorrer vector1

                for (int j = 0; j < vector2.Length; j++) { //recorrer vector2

                    if (vector1[i] != vector2[j]) //comparar vectores
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            lecturaVectores(vector1, vector2);
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            bool comparar = sonIguales(vector1, vector2);

            if (comparar) //mostrar si son o no iguales
            {
                MessageBox.Show("Son iguales");

            } else
            {
                MessageBox.Show("NO son iguales");
            }
        }
    }
}
