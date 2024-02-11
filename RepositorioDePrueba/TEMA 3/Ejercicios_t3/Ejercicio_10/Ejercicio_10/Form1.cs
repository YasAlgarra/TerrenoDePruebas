namespace Ejercicio_10
{
    /*Realizar un programa en el que el usuario introduzca una cantidad en euros (con decimales) y 
    obtengamos los billetes y monedas de euro correspondientes, así como las monedas de céntimos 
    correspondientes.*/
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
                int billetes, monedas, euros, centimos;
                double valor = double.Parse(txtValor.Text);
                lblResultado.Text = "";

                euros = (int)valor; //castear a enteros para quitar la parte decimal
                centimos = (int)(valor * 100 - euros * 100); //castear + calcular céntimos en base a los euros


                // HAY QUE SEPARAR LOS EUROS DE LOS CÉNTIMOS, QUITAR LOS CÉNTIMOS DE LOS EUROS PARA PODER TENER NÚMEROS ENTEROS Y ASÍ NO TENER EL FALLO DEL DOUBLE
                
                //Billetes de 500
                if (euros >= 500){

                    billetes = euros / 500;

                    if (billetes ==1) {

                        lblResultado.Text = lblResultado.Text + billetes + " billete de 500 euros\n";
                    } else
                    {
                        lblResultado.Text = lblResultado.Text + billetes + " billetes de 500 euros\n";
                    }

                    euros %= 500; //Asignamos nuevo valor para poder seguir calculando otros billetes
                }

                //Billetes 200
                if (euros >= 200){

                    
                    billetes = euros / 200;

                    if (billetes == 1)
                    {

                        lblResultado.Text = lblResultado.Text + billetes + " billete de 200 euros\n";
                    }
                    else
                    {
                        lblResultado.Text = lblResultado.Text + billetes + " billetes de 200 euros\n";
                    }

                    euros %= 200; //Asignamos nuevo valor para poder seguir calculando otros billetes
                }

                //Billetes 100
                if (euros >= 100)
                {

                    billetes = euros / 100;

                    if (billetes == 1)
                    {

                        lblResultado.Text = lblResultado.Text + billetes + " billete de 100 euros\n";
                    }
                    else
                    {
                        lblResultado.Text = lblResultado.Text + billetes + " billetes de 100 euros\n";
                    }

                    euros %= 100; //Asignamos nuevo valor para poder seguir calculando otros billetes
                }

                //Billetes de 50
                if (euros >= 50)
                {

                    billetes = euros / 50;

                    if (billetes == 1)
                    {

                        lblResultado.Text = lblResultado.Text + billetes + " billete de 50 euros\n";
                    }
                    else
                    {
                        lblResultado.Text = lblResultado.Text + billetes + " billetes de 50 euros\n";
                    }

                    euros %= 50; //Asignamos nuevo valor para poder seguir calculando otros billetes
                }

                //Billetes de 10
                if (euros >= 10)
                {

                    billetes = euros / 10;

                    if (billetes == 1)
                    {

                        lblResultado.Text = lblResultado.Text + billetes + " billete de 10 euros\n";
                    }
                    else
                    {
                        lblResultado.Text = lblResultado.Text + billetes + " billetes de 10 euros\n";
                    }

                    euros %= 10; //Asignamos nuevo valor para poder seguir calculando otros billetes
                }

                //Billetes de 5
                if (euros >= 5)
                {

                    billetes = euros / 5;

                    if (billetes == 1)
                    {

                        lblResultado.Text = lblResultado.Text + billetes + " billete de 5 euros\n";
                    }
                    else
                    {
                        lblResultado.Text = lblResultado.Text + billetes + " billetes de 5 euros\n";
                    }

                    euros %= 5; //Asignamos nuevo valor para poder seguir calculando otros billetes
                }

                //Monedas de 2
               if (centimos >= 2)
                {

                    monedas = euros / 2;

                    if (monedas == 1)
                    {

                        lblResultado.Text = lblResultado.Text + monedas + " moneda de 2 euros\n";
                    }
                    else
                    {
                        lblResultado.Text = lblResultado.Text + monedas + " monedas de 2 euros\n";
                    }

                    euros %= 2; //Asignamos nuevo valor para poder seguir calculando otros billetes
                }

                //Moneda de 1
                if (euros >= 1)
                {

                    monedas = euros / 1; 

                    if (monedas == 1)
                    {

                        lblResultado.Text = lblResultado.Text + monedas + " moneda de 1 euro\n";
                    }
                    else
                    {
                        lblResultado.Text = lblResultado.Text + monedas + " monedas de 1 euro\n";
                    }

                    euros %= 1; //Asignamos nuevo valor para poder seguir calculando otros billetes
                }

                //Monedas de 50
                if (centimos >= 50)
                {

                    monedas = centimos / 50;

                    if (monedas == 1)
                    {

                        lblResultado.Text = lblResultado.Text + monedas + " moneda de 50 céntimos\n";
                    }
                    else
                    {
                        lblResultado.Text = lblResultado.Text + monedas + " monedas de 50 céntimos\n";
                    }

                    centimos %= 50; //Asignamos nuevo valor para poder seguir calculando otros billetes
                }

                //Monedas de 20
                if (centimos >= 20)
                {

                    monedas = centimos / 20;

                    if (monedas == 1)
                    {

                        lblResultado.Text = lblResultado.Text + monedas + " moneda de 20 céntimos\n";
                    }
                    else
                    {
                        lblResultado.Text = lblResultado.Text + monedas + " monedas de 20 céntimos\n";
                    }

                    centimos %= 20; //Asignamos nuevo valor para poder seguir calculando otros billetes
                }

                //Monedas de 10
                if (centimos >= 10)
                {

                    monedas = centimos / 10;

                    if (monedas == 1)
                    {

                        lblResultado.Text = lblResultado.Text + monedas + " moneda de 10 céntimos\n";
                    }
                    else
                    {
                        lblResultado.Text = lblResultado.Text + monedas + " monedas de 10 céntimos\n";
                    }

                    centimos %= 10; //Asignamos nuevo valor para poder seguir calculando otros billetes
                }

                //Monedas de 5
                if (centimos >= 5)
                {

                    monedas = centimos / 5;

                    if (monedas == 1)
                    {

                        lblResultado.Text = lblResultado.Text + monedas + " moneda de 5 céntimos\n";
                    }
                    else
                    {
                        lblResultado.Text = lblResultado.Text + monedas + " monedas de 5 céntimos\n";
                    }

                    centimos %= 5; //Asignamos nuevo valor para poder seguir calculando otros billetes
                }

                //Monedas de 2
                if (centimos >= 2)
                {

                    monedas = centimos / 2;

                    if (monedas == 1)
                    {

                        lblResultado.Text = lblResultado.Text + monedas + " moneda de 2 céntimos\n";
                    }
                    else
                    {
                        lblResultado.Text = lblResultado.Text + monedas + " monedas de 2 céntimos\n";
                    }

                }


            } catch (FormatException)
            {
                MessageBox.Show("Formato incorrecto, por favor vuelva a introducir valor numérico.");
            }
        }
    }
}