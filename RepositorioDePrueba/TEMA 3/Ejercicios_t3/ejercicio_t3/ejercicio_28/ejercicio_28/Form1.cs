namespace ejercicio_28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSolucion_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtMultiplicando.Text);
            int num2 = int.Parse(txtMultiplicador.Text);
            string solucion = "";


            try
            {
                if (num2 > 0) { //para el multiplicador positivo
                    for (int i = 1; i <= num1; i++) //inicializo la i en 1, porque sino el num de veces que pasaría por el bucle sería 1 más
                    {

                        solucion += $"{num2} + "; //acumulando la solución como cadena de caracteres, ya que si fuera un int se sumarían los valores

                    }
                } else //en caso de multiplicador negativo
                {
                    for (int i = 1; i <= num1; i++)
                    {

                        solucion += $"({num2}) + "; //añadir paréntesis para salida por pantalla

                    }
                }


                solucion = solucion.TrimEnd(' ', '+'); //eliminar el + del final
                lblSolucion.Text = $"{num1} * {num2} = {solucion} ";

            } catch (FormatException)
            {
               MessageBox.Show("Formato incorrecto");
            }
        }
    }
}