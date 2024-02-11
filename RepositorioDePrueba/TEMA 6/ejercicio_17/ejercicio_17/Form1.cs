using System.Numerics;
using System.Xml.Linq;

namespace ejercicio_17
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

        const int TAM = 10;

        //declarar vector
        int[] vector = new int[TAM];

        void leerVector(int[] vector)
        {
            try
            {
                for (int i = 0; i < vector.Length; i++)
                {
                    vector[i] = int.Parse(InputBox("Introduzca el número " + i));
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

        //leer elemento
        int leerElemento(int [] vector)
        {
            int elemento = 0;
            try
            {
                elemento = int.Parse(InputBox("Introduzca el número "));
                return elemento;

            }
            catch (FormatException) //capturar errores de formato
            {
                MessageBox.Show("Error: Por favor, introduzca un número válido");
                leerElemento(vector); //llamar recursivamente para repetir la lectura del mismo elemento

            }
            catch (Exception ex) //capturar errores inesperados
            {
                MessageBox.Show("Error inesperado al leer el vector: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return elemento;
        }
        
        //Buscar primera posición en la que se encuentra un valor
        int encontrarPosicion(int [] vector, int elemento)
        {
            int i = 0;
            int resultado;
            bool encontrado = false;

            while (!encontrado && i < vector.Length) //mientras encontrado sea false y no se haya llegado al fianl del vector
            {
                if (elemento == vector[i]) //si el elemento buscado es igual a un elemento el el vector, encontrado será true
                {
                    encontrado = true;
                } else
                {
                    i++;
                }
            }

            if (encontrado)
            {
                resultado = i; //devolvemos la posicón en la que se encuentra el elemento encontrado
            } else
            {
                resultado = -1; //si no existe el elemento buscado, el resultado será -1 (no es posible tener una posición negativa en un vector)
            }

            return resultado;
        }

        //Ordenar el vector
        void ordenarVector(int[] vector)
        {
            int aux, tam;

            tam = vector.Length;

            for (int i = 0; i < tam - 1; i++) //recorrer el vector
            {
                for (int j = i + 1; j < tam; j++) /* la variable j comienza en la posición siguiente a la de la i, y servirá para comparar con
                el elemento la posición i */
                {
                    if (vector[j] > vector[i]) // si j es mayor que i se intercambiarán de posición para ordenarlo de forma descendente
                    {
                        aux = vector[i];
                        vector[i] = vector[j];
                        vector[j] = aux;
                    }
                }
            }
        }
        //mostrar el vector ordenado
        string mostrarOrdeado(int[] vector)
        {
            string texto = "Los elementos ordenados: \n";

            for (int i = 0; i < vector.Length; i++) 
            {
                texto += vector[i] + " , ";
            }

            return texto;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIntroducir_Click(object sender, EventArgs e)
        {
            leerVector(vector);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int elemento = leerElemento(vector);
            int posicion = encontrarPosicion(vector, elemento);

            if (posicion == -1)
            {
                MessageBox.Show("No existe el elemento indicado");
            } else
            {
                MessageBox.Show($"La posición es {posicion}");
            }

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            ordenarVector(vector);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string texto = mostrarOrdeado(vector);

            MessageBox.Show(texto);
        }
    }
}