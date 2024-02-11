namespace Ejercicio_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            try
            {
                int valor1 = int.Parse(txtValor1.Text);
                int valor2 = int.Parse(txtValor2.Text);
                int factorial = 1;
                int resultado = 1;
                string mostrarResultado = "";
                

                //Primero calcular el factorial del num
                /*para calcular un factorial es multiplicar el n�m introducido por todos sus n�meros menores a �l hasta 1*/

                if (valor1 == 0 || valor2 == 0) { //controlamos que no sean 0 los n�meros

                    throw new Exception("El n�mero no puede ser 0. Introduzca otro n�mero.");

                } else {

                    int Factorial(int factorial)
                    {
                        for (int i = 2; i <= valor2; i++)
                        {
                            factorial *= i;

                        }
                        return factorial; //me da el factorial de valor2 como tal, no la secuencia de 2!, 3!, 4!...valor2!

                    }


                    void Secuencia(int factorial)
                    {

                        try
                        {
                            for (int i = 2; i <= valor2; i++)
                            {
                                factorial = Factorial(factorial);

                                mostrarResultado += $" {valor1} + {valor1} ^ {i} / {factorial} + ";

                            }
                            // no funciona(? mostrarResultado = mostrarResultado.TrimEnd('+');
                        } catch (Exception ex)
                        {
                            MessageBox.Show($"Error: {ex.Message}");
                        }
                    }



                    string TextoRespuesta(ref int resultado, ref int factorial)
                    {

                        Secuencia(factorial);
                        return $" {mostrarResultado}";
                    }

                    lblRespuesta.Text = TextoRespuesta(ref resultado, ref factorial);
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}