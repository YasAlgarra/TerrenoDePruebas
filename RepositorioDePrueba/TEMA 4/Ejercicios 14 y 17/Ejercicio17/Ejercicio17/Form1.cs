using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Función que realiza una división entera mediante restas sucesivas.
        // Contamos cuantas veces "cabe" el dividendo en el divisor.
        int divisionRestas(int dividendo, int divisor)
        {
            // Declaramos una variable para almacenar el resultado.
            int cont = 0;

            // Mientras el dividendo sea mayor o igual que el divisor,
            // restamos el divisor al dividendo y aumentamos el contador.
            while (dividendo >= divisor)
            {
                try
                {
                    dividendo -= divisor;
                    cont++;
                }
                catch (Exception ex)
                {
                    // Si se produce una excepción, devolvemos un valor negativo.
                    return -1;
                }
            }

            // Devolvemos el resultado.
            return cont;
        }

        // Evento que se llama al pulsar el botón "Iterativa".
        private void bDIterativa_Click(object sender, EventArgs e)
        {
            try
            {
                // Declaramos las variables necesarias.
                int dividendo, divisor, res;

                // Leemos los valores del cuadro de texto.
                dividendo = int.Parse(txtDividendo.Text);
                divisor = int.Parse(txtDivisor.Text);

                // Comprobamos que el divisor no sea cero.
                if (divisor == 0)
                {
                    // Lanzamos una excepción.
                    throw new Exception("El divisor no puede ser cero.");
                }
                // Comprobamos que el dividendo no sea menor que el divisor.
                if (dividendo < divisor)
                {
                    // Lanzamos una excepción.
                    throw new Exception("El dividendo no puede ser menor que el divisor.");
                }

                // Llamamos a la función para realizar la división.
                res = divisionRestas(dividendo, divisor);

                // Mostramos el resultado.
                MessageBox.Show("El resultado de dividir " + dividendo + " entre " + divisor + " es : " + res);
            }
            catch (FormatException ex)
            {
                // Capturamos la excepción de formato incorrecto.
                MessageBox.Show("Error de formato: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Capturamos cualquier otra excepción.
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Evento que se llama al pulsar el botón "Recursiva".
        private void bDRecursiva_Click(object sender, EventArgs e)
        {
            // Declaramos las variables necesarias.
            int dividendo, divisor, res;

            // Leemos los valores del cuadro de texto.
            dividendo = int.Parse(txtDividendo.Text);
            divisor = int.Parse(txtDivisor.Text);

            // Comprobamos que el divisor no sea cero.
            if (divisor == 0)
            {
                // Lanzamos una excepción.
                throw new Exception("El divisor no puede ser cero.");
            }

            // Comprobamos que el dividendo no sea menor que el divisor.
            if (dividendo < divisor)
            {
                // Lanzamos una excepción.
                throw new Exception("El dividendo no puede ser menor que el divisor.");
            }

            // Llamamos a la función recursiva para realizar la división.
            res = divisionRestasRec(dividendo, divisor);

            // Mostramos el resultado.
            if (res >= 0)
            {
                MessageBox.Show("El resultado de dividir " + dividendo + " entre " + divisor + " es : " + res);
            }
            else
            {
                MessageBox.Show("Error al dividir.");
            }
        }

        // Función recursiva que realiza una división entera mediante restas sucesivas.
        // Contamos cuantas veces "cabe" el dividendo en el divisor.
        int divisionRestasRec(int dividendo, int divisor)
        {
            // Comprobamos que el dividendo no sea menor que el divisor.
            if (dividendo < divisor)
            {
                // Lanzamos una excepción.
                throw new Exception("El dividendo no puede ser menor que el divisor.");
            }

            // Si el dividendo es menor que el divisor,
            // el resultado es 0.
            if (dividendo < divisor)
            {
                return 0;
            }

            // Declaramos una variable para almacenar el resultado.
            int res;

            // Llamamos a la función recursiva para realizar la división.
            res = divisionRestasRec(dividendo - divisor, divisor) + 1;

            // Devolvemos el resultado.
            return res;
        }



    }
}
/*Realizar un programa con una función que permita calcular la división entera de un número
entre otro mediante restas sucesivas.*/