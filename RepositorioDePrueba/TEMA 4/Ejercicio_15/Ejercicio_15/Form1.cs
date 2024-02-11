using System.Configuration;
using System.Drawing;

namespace Ejercicio_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            int euros = 0;
            int centimos = 0;

            try
            {
                double valor = double.Parse(txtValor.Text);
                lblResultado.Text = "";
                euros = (int)valor; //castear a enteros para quitar la parte decimal
                centimos = (int)(valor * 100 - euros * 100); //castear + calcular céntimos en base a los euros

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular el número de billetes: " + ex.Message);
            }

            lblResultado.Text = TextoRespuesta(euros, centimos);



            string TextoRespuesta(int euros, int centimos)
            {
                string texto = "";
             

                try
                {
                    //Cálculo de billetes
                    CalcularBilletes(ref euros, ref texto);
                    return texto;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return "";
                }
            }


            void CalcularBilletes(ref int euros, ref string texto)
            {

                int billetes;
                int monedas;

                try
                {

                    //Billetes de 500
                    if (euros >= 500)
                    {

                        billetes = euros / 500;

                        if (billetes == 1)
                        {

                            texto += billetes + " billete de 500 euros\n";
                        }
                        else
                        {
                            texto += billetes + " billetes de 500 euros\n";
                        }

                        euros %= 500; //Asignamos nuevo valor para poder seguir calculando otros billetes
                    }

                    //Billetes 200
                    if (euros >= 200)
                    {


                        billetes = euros / 200;

                        if (billetes == 1)
                        {

                            texto += billetes + " billete de 200 euros\n";
                        }
                        else
                        {
                            texto += billetes + " billetes de 200 euros\n";
                        }

                        euros %= 200; //Asignamos nuevo valor para poder seguir calculando otros billetes
                    }

                    //Billetes 100
                    if (euros >= 100)
                    {

                        billetes = euros / 100;

                        if (billetes == 1)
                        {

                            texto += billetes + " billete de 100 euros\n";
                        }
                        else
                        {
                            texto += billetes + " billetes de 100 euros\n";
                        }

                        euros %= 100; //Asignamos nuevo valor para poder seguir calculando otros billetes
                    }

                    //Billetes de 50
                    if (euros >= 50)
                    {

                        billetes = euros / 50;

                        if (billetes == 1)
                        {

                            texto += billetes + " billete de 50 euros\n";
                        }
                        else
                        {
                            texto += billetes + " billetes de 50 euros\n";
                        }

                        euros %= 50; //Asignamos nuevo valor para poder seguir calculando otros billetes
                    }

                    //Billetes de 10
                    if (euros >= 10)
                    {

                        billetes = euros / 10;

                        if (billetes == 1)
                        {

                            texto += billetes + " billete de 10 euros\n";
                        }
                        else
                        {
                            texto += billetes + " billetes de 10 euros\n";
                        }

                        euros %= 10; //Asignamos nuevo valor para poder seguir calculando otros billetes
                    }

                    //Billetes de 5
                    if (euros >= 5)
                    {

                        billetes = euros / 5;

                        if (billetes == 1)
                        {

                            texto += billetes + " billete de 5 euros\n";
                        }
                        else
                        {
                            texto += billetes + " billetes de 5 euros\n";
                        }

                        euros %= 5; //Asignamos nuevo valor para poder seguir calculando otros billetes
                    }

                    //Monedas de 2
                    if (euros >= 2)
                    {

                        billetes = euros / 2;

                        if (billetes == 1)
                        {

                            texto += billetes + " moneda de 2 euros\n";
                        }
                        else
                        {
                            texto += billetes + " monedas de 2 euros\n";
                        }

                        euros %= 2; //Asignamos nuevo valor para poder seguir calculando otros billetes
                    }

                    //Moneda de 1
                    if (euros >= 1)
                    {

                        billetes = euros / 1;

                        if (billetes == 1)
                        {

                            texto += billetes + " moneda de 1 euro\n";
                        }
                        else
                        {
                            texto += billetes + " monedas de 1 euro\n";
                        }

                        euros %= 1; //Asignamos nuevo valor para poder seguir calculando otros billetes

                    }

                    /*if (euros != 0)
                    {
                        centimos = euros * 100 + centimos;
                    }*/
                    //Monedas de 50
                    if (centimos >= 50)
                    {

                        monedas = centimos / 50;

                        if (monedas == 1)
                        {

                            texto += monedas + " moneda de 50 céntimos\n";
                        }
                        else
                        {
                            texto += monedas + " monedas de 50 céntimos\n";
                        }

                        centimos %= 50; //Asignamos nuevo valor para poder seguir calculando otros billetes
                    }

                    //Monedas de 20
                    if (centimos >= 20)
                    {

                        monedas = centimos / 20;

                        if (monedas == 1)
                        {

                            texto += monedas + " moneda de 20 céntimos\n";
                        }
                        else
                        {
                            texto += monedas + " monedas de 20 céntimos\n";
                        }

                        centimos %= 20; //Asignamos nuevo valor para poder seguir calculando otros billetes
                    }

                    //Monedas de 10
                    if (centimos >= 10)
                    {

                        monedas = centimos / 10;

                        if (monedas == 1)
                        {

                            texto += monedas + " moneda de 10 céntimos\n";
                        }
                        else
                        {
                            texto += monedas + " monedas de 10 céntimos\n";
                        }

                        centimos %= 10; //Asignamos nuevo valor para poder seguir calculando otras monedas
                    }

                    //Monedas de 5
                    if (centimos >= 5)
                    {

                        monedas = centimos / 5;

                        if (monedas == 1)
                        {

                            texto += monedas + " moneda de 5 céntimos\n";
                        }
                        else
                        {
                            texto += monedas + " monedas de 5 céntimos\n";
                        }

                        centimos %= 5; //Asignamos nuevo valor para poder seguir calculando otras monedas
                    }

                    //Monedas de 2
                    if (centimos >= 2)
                    {

                        monedas = centimos / 2;

                        if (monedas == 1)
                        {

                            texto += monedas + " moneda de 2 céntimos\n";
                        }
                        else
                        {
                            texto += monedas + " monedas de 2 céntimos\n";
                        }

                        centimos %= 2; //Asignamos nuevo valor para poder seguir calculando otras monedas

                    }

                    //Monedas de 1
                    if (centimos >= 1)
                    {

                        monedas = centimos / 1;

                        if (monedas == 1)
                        {

                            texto += monedas + " moneda de 1 céntimo\n";
                        }
                        else
                        {
                            texto += monedas + " monedas de 1 céntimos\n";
                        }
     
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}