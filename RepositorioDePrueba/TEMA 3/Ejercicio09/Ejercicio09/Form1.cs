using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad, billetes;

                cantidad = int.Parse(tCantidad.Text);
                lResultado.Text = "";

                // Si la cantidad es mayor o igual que 10000 tendremos que ver cuantos billetes de 10000 hay.
                // Si es menor no hay billetes de 10000
                if (cantidad >= 10000)
                {
                    // Obtenemos el número de billetes
                    billetes = cantidad / 10000;
                    // Lo reflejamos en el label
                    lResultado.Text = lResultado.Text + billetes + " billetes de 10000\n";
                    //también podemos montar la cadena con cadenas interpoladas
                    //lResultado.Text += $"{billetes} billetes de 10000\n";


                    // Nos quedamos con el resto de dinero que nos queda
                    cantidad = cantidad % 10000;
                }

                // Hacemos lo mismo con el resto de billetes
                if (cantidad >= 5000)
                {
                    billetes = cantidad / 5000;
                    lResultado.Text = lResultado.Text + billetes + " billetes de 5000\n";

                    cantidad = cantidad % 5000;
                }

                if (cantidad >= 2000)
                {
                    billetes = cantidad / 2000;
                    lResultado.Text = lResultado.Text + billetes + " billetes de 2000\n";
                    cantidad = cantidad % 2000;
                }

                if (cantidad >= 1000)
                {
                    billetes = cantidad / 1000;
                    lResultado.Text = lResultado.Text + billetes + " billetes de 1000\n";
                    cantidad = cantidad % 1000;
                }

                if (cantidad >= 100)
                {
                    billetes = cantidad / 100;
                    lResultado.Text = lResultado.Text + billetes + " billetes de 100\n";
                    cantidad = cantidad % 100;
                }

                if (cantidad >= 25)
                {
                    billetes = cantidad / 25;
                    lResultado.Text = lResultado.Text + billetes + " monedas de 25\n";
                    cantidad = cantidad % 25;
                }

                if (cantidad >= 5)
                {
                    billetes = cantidad / 5;
                    lResultado.Text = lResultado.Text + billetes + " monedas de 5\n";
                    cantidad = cantidad % 5;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error inesperado: " + ex.Message);
            }


        }
    }
}
