using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Función donde metemos en el texto el número de billetes correspondiente.
        // dinero será el dinero que nos queda por analizar (es ref porque es de entrada salida)
        // texto es ref porque entra con un texto y sale con más texto...
        // billete es el billete que nos toca analizar. 10000, 5000, ...
        void CalcularBilletes(ref int dinero, ref string texto, int billete)
        {
            int numBilletes;

            try
            {
                if (dinero >= billete)
                {
                    // Obtenemos el número de billetes
                    numBilletes = dinero / billete;
                    // Lo reflejamos en el texto
                    texto = texto + numBilletes + " billetes de " + billete + "\n";
                    // Nos quedamos con el resto de dinero que nos queda
                    dinero = dinero % billete;
                }
            }
            catch (Exception ex)
            {
                // Mostrar el error
                MessageBox.Show("Error al calcular el número de billetes: " + ex.Message);
            }

        }

        string ObtenerTextoConBilletes(int dinero)
        {
            string texto = "";

            try
            {
                CalcularBilletes(ref dinero, ref texto, 10000);
                CalcularBilletes(ref dinero, ref texto, 5000);
                CalcularBilletes(ref dinero, ref texto, 2000);
                CalcularBilletes(ref dinero, ref texto, 1000);
                CalcularBilletes(ref dinero, ref texto, 100);
                // Realmente deberíamos hacer algo para que con 25 y 5 
                // salga el texto "moneda" en vez de "billete".
                CalcularBilletes(ref dinero, ref texto, 25);
                CalcularBilletes(ref dinero, ref texto, 5);

                return texto;
            }
            catch (Exception ex)
            {
                // Mostrar el error
                MessageBox.Show("Error al calcular el texto con los billetes: " + ex.Message);
                return "";
            }
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            int dinero;

            try
            {
                dinero = int.Parse(txtCantidad.Text);
            }
            catch (Exception ex)
            {
                // Mostrar el error
                MessageBox.Show("Error al leer la cantidad: " + ex.Message);
                return;
            }

            lResultado.Text = ObtenerTextoConBilletes(dinero);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

/*Realizar el ejercicio 9 del tema 3 (aquel en el que a partir de una cantidad en pesetas
obteníamos los billetes), modularizando lo que se pueda.
Por ejemplo podemos tener una función a la que se le pasen las pesetas y nos devuelva un
texto con la lista de billetes.
También podemos tratar de modularizar cada una de las partes que calculaba cuantos
billetes de una cantidad resultaban, haciendo una función que haga eso.

 Ejercicio9 del tema3: Realizar un programa que pida una cantidad de dinero (en pesetas), y muestre en una etiqueta
cuantos billetes de 10.000, de 5.000, de 2.000, de 1000 y monedas de 100 y 25 le corresponden.
Por ejemplo: 27.375 le corresponde 2 de 10.000, 1 de 5.000, 1 de 2.000, 3 de 100 y 3 de 25.
Hacerlo de forma que si corresponde 0 billetes no aparezca
 
 */