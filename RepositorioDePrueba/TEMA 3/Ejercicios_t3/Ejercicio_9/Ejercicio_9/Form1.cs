namespace Ejercicio_9
{ /*Realizar un programa que pida una cantidad de dinero (en pesetas), y muestre en una etiqueta 
    cuantos billetes de 10.000, de 5.000, de 2.000, de 1000 y monedas de 100 y 25 le corresponden*/
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
                int billetes, monedas;
                int valor = int.Parse(txtValor.Text);
                lblResultado.Text = "";

                //Billetes de 10.000
                if (valor >= 10000)
                { //Si tenemos un valor de más de 10.000 -> saber billetes 10.000

                    billetes = valor / 10000; //calcular los billetes de 10.000

                    if (billetes == 1) //Para que no salga "1 billeteS de 10.000" en el resultado
                    {

                        lblResultado.Text = lblResultado.Text + billetes + " billete de 10.000\n";
                        /*ponemos lblResultado.Txt en el restulado para tener en cuenta los demás resultados
                        y que no salga únicamente uno, por ejemplo si ponemos 25.000 que salga 2 biletes 10.000
                        y 1 5.000. De otra forma, solo saldría: 1 billete de 5 mil*/
                    } else
                    {
                        lblResultado.Text = lblResultado.Text + billetes + " billetes de 10.000\n";
                    }

                    valor %= 10000; //Asignamos valor a partir del resto para calcular otros billetes
                }

                //Billetes de 5.000
                if (valor >= 5000)
                {
                    billetes = valor / 5000; // calcular billetes de 5.000

                    if (billetes == 1) { 

                        lblResultado.Text = lblResultado.Text + billetes + " billete de 5.000\n";

                    } else
                    {
                        lblResultado.Text = lblResultado.Text + billetes + " billetes de 5.000\n";
                    }
                    valor %= 5000; //Asignamos valor a partir del resto para calcular otros billetes
                }

                //Billetes de 2.000
                if (valor >= 2000)
                {
                    billetes = valor / 2000; // calcular billetes de 2.000

                    if (billetes == 1)
                    {

                        lblResultado.Text = lblResultado.Text + billetes + " billete de 2.000\n";

                    }
                    else
                    {
                        lblResultado.Text = lblResultado.Text + billetes + " billetes de 2.000\n";
                    }
                    valor %= 2000; //Asignamos valor a partir del resto para calcular otros billetes
                }

                //Billetes de 1.000
                if (valor >= 1000)
                {
                    billetes = valor / 1000; // calcular billetes de 1.000

                    if (billetes == 1)
                    {

                        lblResultado.Text = lblResultado.Text + billetes + " billete de 1.000\n";

                    }
                    else
                    {
                        lblResultado.Text = lblResultado.Text + billetes + " billetes de 1.000\n";
                    }
                    valor %= 1000; //Asignamos valor a partir del resto para calcular otros billetes
                }

                //Monedas de 100
                if (valor >= 100)
                {
                    monedas = valor / 100; // calcular monedas de 100

                    if (monedas == 1)
                    {

                        lblResultado.Text = lblResultado.Text + monedas + " moneda de 100\n";

                    }
                    else
                    {
                        lblResultado.Text = lblResultado.Text + monedas + " monedas de 100\n";
                    }
                    valor %= 100; //Asignamos valor a partir del resto para calcular otras monedas
                }

                //Monedas de 25
                if (valor >= 25)
                {
                    monedas = valor / 25; // calcular monedas de 25

                    if (monedas == 1)
                    {

                        lblResultado.Text = lblResultado.Text + monedas + " moneda de 25\n";

                    }
                    else
                    {
                        lblResultado.Text = lblResultado.Text + monedas + " monedas de 25\n";
                    }
                }


            }
            catch (FormatException)
            {
                MessageBox.Show("Valor introducido no válido. Por favor introduzca valor de nuevo.");
;            }
        }
    }
}