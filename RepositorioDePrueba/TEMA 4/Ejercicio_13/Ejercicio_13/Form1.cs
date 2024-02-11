namespace Ejercicio_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularFecha_Click(object sender, EventArgs e)
        {
            try
            {

                int dia = int.Parse(txtDia.Text);
                int mes = int.Parse(txtMes.Text);
                int anyo = int.Parse(txtAnyo.Text);

                lblResultado.Text = TextoRespuesta(dia, mes, anyo);


                //Validar que sea bisiesto o no
                bool Bisiesto(ref int anyo)
                {
                   bool esBisiesto = false;

                    if (anyo % 4 == 0 && anyo % 100 != 0 || anyo % 400 == 0) //para que sea bisiesto tiene que ser divisible entre 4, no entre 100 (resto != 0), pero s� entre 400 
                    {
                        esBisiesto = true;
                    }
                   

                    return esBisiesto;
                }

                //Validar fecha
                bool ValidarFecha(ref int dia, ref int mes, ref int anyo)
                {
                    bool valida = true;

                    try
                    {
                        if (anyo < 0 || anyo > DateTime.Now.Year)   //Comprobamos los a�os

                            valida = false;

                        else if (mes < 1 || mes > 12)    //Comprobamos los meses

                            valida = false;

                        else
                        {
                            if (dia < 1 || dia > 31)    //El d�a tiene que estar entre 1 y 31

                                valida = false;

                            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11) //Comprobamos los meses de 30 d�as
                            {

                                if (dia > 30)

                                    valida = false;
                            }
                            else
                            {
                                if (mes == 2)
                                {
                                    if (Bisiesto(ref anyo))
                                    {
                                        if (dia > 29)

                                            valida = false;
                                    }
                                    else
                                    {
                                        if (dia > 28)

                                            valida = false;
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                        valida = false;
                    }

                    return valida;
                }

                void fechaSiguiente(ref int dia, ref int mes,ref int anyo, ref string texto)
                {
                    try
                    {
                        if (ValidarFecha(ref dia, ref mes, ref anyo))
                        { //si la fecha es v�lida

                            

                            //aumentar d�as
                            if (mes == 4 || mes == 6 || mes == 9 || mes == 11) //meses de 30 d�as
                            {

                                if (dia >= 1 && dia < 30) //si d�a es menor que 30 (�ltimo d�a del mes), incrementa
                                {
                                    dia++;
                                }
                                
                            }
                            else if (mes == 2) //febrero (si es bisiesto o no)
                            {
                                if (Bisiesto(ref anyo))
                                {
                                    if (dia > 1 && dia < 29)
                                    {
                                        dia++;  
                                    }
                                   
                                }
                                else
                                {
                                    if (dia >= 1 && dia < 28)
                                    {
                                        dia++; 
                                    }
                                    
                                }
                            }
                            else //resto de meses: los de 31 d�as
                            {
                                if (dia >= 1 && dia < 31)
                                {
                                    dia++;
                                }
                                
                            }

                            //aumentar mes
                            if ((mes == 4 || mes == 6 || mes == 9 || mes == 11) && dia == 30)
                            {
                                mes++;
                                dia = 1;

                            }
                            else if (mes == 2)
                            {
                                if (Bisiesto(ref anyo))
                                {
                                    if (dia == 29)
                                    {
                                        mes++;
                                        dia = 1;
                                    }

                                }
                                else if (dia == 28)
                                {
                                    mes++;
                                    dia = 1;

                                }
                            }
                            else if (dia == 31)
                            {
                                mes++;
                                dia = 1;

                            }

                            //aumentar a�o
                            if (mes == 12 && dia == 31)
                            {
                                anyo++;
                                mes = 1;
                                dia = 1;
                            }

                            texto = $"D�a: {dia}, Mes: {mes}, A�o: {anyo}";

                        } else
                        {
                           MessageBox.Show($"Error: Fecha incorrecta");
                        }
                    } catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }

                //Texto de respuesta
                string TextoRespuesta(int dia, int mes, int anyo)
                {
                    string texto = "";

                    try
                    {
                        //Pruebas
                        /*if (Bisiesto(anyo))
                        {
                            texto = "Es bisiesto";

                            return texto;
                        }
                        else
                        {
                            texto = "No es bisiesto";

                            return texto;
                        }*/

                        fechaSiguiente(ref dia, ref mes, ref anyo, ref texto);
                        return texto;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return "";
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}");
            }

        }
    }
}
