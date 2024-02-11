namespace ejercicio_11
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
                int hora = int.Parse(txtHora.Text);
                int minutos = int.Parse(txtMinutos.Text);
                int segundos = int.Parse(txtSegundos.Text);

                //hora
                if (minutos == 59 && segundos == 59)
                //compruebo que se deba sumar realmente la hora
                {
                    if (hora >= 1 && hora <= 22) //entre 1 y 22, ya que si se suma a 23, saldría 24
                    {
                        hora++;

                    }
                    else if (hora == 23) //aquí controlo que si hora es 23, salga 00
                    {
                        hora = 00;
                    }
                }

                //minutos
                if (segundos == 59) //si segundos es 59, entonces podremos sumar minutos
                {

                    if (minutos >= 1 && minutos <= 58) //entre 1 y 58, ya que si sumamos a 59, saldría 60
                    {
                        minutos++;

                    }
                    else if (minutos == 59) //controlo que cuando se entre 59, la salida sea 0
                    {
                        minutos = 0;
                    }
                }

                //segundos
                if (segundos >= 1 && segundos <= 58)
                {
                    segundos++;

                } else if (segundos == 59) {

                    segundos = 0;
                }

                //Mostramos la respuesta
                MessageBox.Show($"La hora siguiente será {hora} : {minutos} : {segundos}");

            } catch (FormatException) {
                MessageBox.Show("Formato incorrecto");
            }
        }
    }
}