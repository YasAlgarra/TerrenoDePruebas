namespace ejercicio_15
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

        //cantidad enteros que va a constar el vector
        const int TAM = 20;

        //Declarar vector
        int[] vector = new int[TAM];

        void leerVector(int[] vector) //leer el vector por teclado
        {
            try
            {
                for (int i = 0; i < vector.Length; i++)
                {
                    vector[i] = int.Parse(InputBox("Introduzca números enteros " + i));
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

        //sacar el mayor
        int sacarMayor(int[] vector)
        {
            int mayor = vector[0]; /*inicializar "mayor" en el elemento 0
            para evitar inicializarlo a 0 y que no de un resultado correcto, por ejemlpo en caso de nums negativos */
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] > mayor)
                {
                    mayor = vector[i];
                }
            }

            return mayor;
        }

        //cuántas veces se repite el mayor
        int repiteMayor(int[] vector, int sacarMayor)
        {
            int repite = 0; //inicializarlo

            for (int i = 0; i < vector.Length; i++) //recorrer vector
            {
                if (vector[i] == sacarMayor) //si el número es igual que sacarMayor (el mayor), el contador suma
                {
                    repite++;
                }
            }

            return repite;
        }

        //sacar el menor
        int sacarMenor(int[] vector)
        {
            int menor = vector[0]; /*inicializar "menor" en el elemento 0
            para evitar inicializarlo a 0 y que no de un resultado correcto y no caer en que siempre nos de como resultado el 0 */

            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] < menor)
                {
                    menor = vector[i];
                }
            }

            return menor;
        }

        //cuántas veces se repite el menor
        int repiteMenor(int[] vector, int sacarMenor)
        {
            int repite = 0; //inicializarlo

            for (int i = 0; i < vector.Length; i++) //recorrer vector
            {
                if (vector[i] == sacarMenor) //si el número es igual que sacarMenor (el menor), el contador suma
                {
                    repite++;
                }
            }

            return repite;
        }


        private void btnIntroducir_Click(object sender, EventArgs e)
        {
            leerVector(vector);
        }

        private void btnMayor_Click(object sender, EventArgs e)
        {
            int mayor = sacarMayor(vector);
            int repite = repiteMayor(vector, mayor);

            MessageBox.Show($"El mayor es {mayor} y se introdujo {repite} veces");
        }

        private void btnMenor_Click(object sender, EventArgs e)
        {
            int menor = sacarMenor(vector);
            int repite = repiteMenor(vector, menor);

            MessageBox.Show($"El menor es {menor} y se introdujo {repite} veces");
        }
    }
}