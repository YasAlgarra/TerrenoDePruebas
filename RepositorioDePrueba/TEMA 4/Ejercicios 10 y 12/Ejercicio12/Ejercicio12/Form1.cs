using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Función que devuelve si un año es bisiesto.
        bool Bisiesto(int anyo)
        {
            bool esBisiesto = false;

            if (anyo % 4 == 0)
            {
                // Si es divisible entre 4 consideramos que es bisiesto.
                esBisiesto = true;

                if (anyo % 100 == 0 && anyo % 400 != 0)
                    esBisiesto = false;    // Si es divisible entre 100 y no entre 400.
            }

            return esBisiesto;
        }

        bool FechaValida(int dia, int mes, int anyo)
        {
            bool esValida = true;

            try
            {
                if (anyo < 0 || anyo > DateTime.Now.Year)    // Comprobamos los años
                    esValida = false;
                else if (mes < 1 || mes > 12)    // Comprobamos los meses.
                    esValida = false;
                else
                {
                    if (dia < 1 || dia > 31)    // El día tiene que estar entre 1 y 31.
                        esValida = false;
                    else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                    {
                        // Comprobamos los meses de 30 días.
                        if (dia > 30)
                            esValida = false;
                    }
                    else
                    {
                        if (mes == 2)
                        {
                            if (Bisiesto(anyo))
                            {
                                if (dia > 29)
                                    esValida = false;
                            }
                            else
                            {
                                if (dia > 28)
                                    esValida = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
                esValida = false;
            }

            return esValida;
        }
        // Otra versión de la función de fecha válida.
        bool FechaValidaVersion2(int dia, int mes, int anyo)
        {
            bool res = true;
            // Consideramos que la fecha es correcta y 
            // vamos viendo los casos en que la fecha es incorrecta.

            if (anyo < 0 || anyo > 2019)    // Comprobamos los años
                res = false;
            else
                switch (mes)
                {
                        // Meses de 31 días.
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        if (dia < 1 || dia > 31)
                            res = false;
                        break;

                        // Meses de 30 días
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        if (dia < 1 || dia > 30)
                            res = false;
                        break;

                        // Febrero
                    case 2:
                        if (Bisiesto(anyo))
                        {
                            if (dia > 29)
                                res = false;
                        }
                        else
                        {
                            if (dia > 28)
                                res = false;
                        }
                        break;

                        // Si el mes no está entre 1 y 12 es incorrecto
                    default:
                        res = false;
                        break;
                }

            return res;
        }

        private void bCorrecta_Click(object sender, EventArgs e)
        {
            int dia, mes, anyo;

            dia = int.Parse(TDia.Text);
            mes = int.Parse(TMes.Text);
            anyo = int.Parse(TAnyo.Text);

            // ATENCIÓN: Tenéis dos versiones de la función para comprobar si una fecha es válida.

            //if (fechaValida(dia, mes, anyo))
            if (FechaValida(dia, mes, anyo))
                MessageBox.Show("La fecha es correcta.");
            else
                MessageBox.Show("La fecha NO es correcta.");
        }
    }
}
