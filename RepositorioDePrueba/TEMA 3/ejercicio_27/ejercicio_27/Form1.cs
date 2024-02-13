namespace ejercicio_27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSolucion_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtNum.Text);

            try
            {
                if (num > 0) //asegurarnos de que se introduce un número positivo
                {
                    if ((num % 2 == 0 && num != 2) || (num % 3 == 0 && num != 3) || (num % 5 == 0 && num != 5) || (num % 7 == 0 && num != 7) || (num % 11 == 0 && num != 11))
                    //Para calcular los num primos: descartando los múltiplos de los primero num primos (hasta 11) y los propios num primos
                    //Es decir, si se divide el num ingresado entre alguno de los num primos y el resto da 0, entonces NO es primo
                    {
                        MessageBox.Show($"{num} no es número primo");

                    } else
                    {
                        MessageBox.Show($"{num} es número primo");
                    }
                }
                else
                {
                    MessageBox.Show("Error: El número introducido es 0 o negativo. Por favor introduzca un número positivo.");

                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Formato incorrecto");
            }
        }
    }
}