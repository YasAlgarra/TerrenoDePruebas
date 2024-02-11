namespace ejercicio14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //nombre: btnMayor
        //le cambié el nombre pero no sé por qué sigue apareciendo con este nombre
        {
            try
            {
                int numero1 = int.Parse(txtNum1.Text);
                int numero2 = int.Parse(txtNum2.Text);

                if (numero1 > numero2)
                {
                    lblResultado.Text = "True";
                } else
                {
                    lblResultado.Text = "False";
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Error: los valores introducidos no son número enteros");
            }

        }

        private void btnMenor_Click(object sender, EventArgs e)
        {
            try
            {
                int numero1 = int.Parse(txtNum1.Text);
                int numero2 = int.Parse(txtNum2.Text);

                if (numero1 < numero2)
                {
                    lblResultado.Text = "True";
                }
                else
                {
                    lblResultado.Text = "False";
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Error: los valores introducidos no son número enteros");
            }
        }

        private void bntIgual_Click(object sender, EventArgs e)
        {
            try
            {
                int numero1 = int.Parse(txtNum1.Text);
                int numero2 = int.Parse(txtNum2.Text);

                if (numero1 == numero2)
                {
                    lblResultado.Text = "True";
                }
                else
                {
                    lblResultado.Text = "False";
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Error: los valores introducidos no son número enteros");
            }
        }

        private void btnDistinto_Click(object sender, EventArgs e)
        {
            try
            {
                int numero1 = int.Parse(txtNum1.Text);
                int numero2 = int.Parse(txtNum2.Text);

                if (numero1 != numero2)
                {
                    lblResultado.Text = "True";
                }
                else
                {
                    lblResultado.Text = "False";
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Error: los valores introducidos no son número enteros");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}