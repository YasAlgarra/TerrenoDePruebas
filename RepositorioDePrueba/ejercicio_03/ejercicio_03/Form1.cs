using Microsoft.VisualBasic;
using System;
using System.Diagnostics.Eventing.Reader;

namespace ejercicio_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declarar la lista original donde entrar�n los n�meros primero
        List<int> listaOriginal = new List<int>();

        //declarar la lista en donde entrar�n los n�meros primos
        List<int> listaPrimos = new List<int>();

        private void leerLista(List<int> lista)
        {
            try
            {

                DialogResult continuar; //representa el resultado de un cuadro de di�logo en Windows Forms
                int valor;

                do
                {

                    valor = int.Parse(Interaction.InputBox("Introduzca un n�mero: "));
                    lista.Add(valor);

                    //a�adir mensaje par sacar bot�n de S� o NO
                    continuar = MessageBox.Show("�Desea continuar?", "Continuar", MessageBoxButtons.YesNo);
                    // DialogResult utilizado para obtener la respuesta del usuario

                } while (continuar == DialogResult.Yes);

            } catch
            {
                MessageBox.Show("Por favor, introduzca un valor num�rico v�lido.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //devolver string con UNA lista
        private string mostrarLista (List<int> lista)
        {

            string texto = "";

            for (int i = 0; i < lista.Count; i++)
            {
                texto = texto + lista[i] + " , ";

            }

            return texto.TrimEnd(','); //no recorta el final y no s� por qu� 
        }

        //devolver un string con las DOS listas
        private string mostrarListas(List<int> listaOriginal, List<int> listaPrimos)
        {
            string texto;

            texto = $"Primera lista: {mostrarLista(listaOriginal)} \n";

            texto = texto + $"Lista n�m. primos: {mostrarLista(listaPrimos)}";

            return texto;
        }
        private void btnLectura_Click(object sender, EventArgs e)
        {
            leerLista(listaOriginal);
        }

        //copiar la lista en la segunad lista. NO SE ELIMINAN DE LA LISTA ORIGINAL
        void copiarPrimosSegundaLista(List<int> listaOriginal,List<int> listaPrimos)
        {

            foreach (int num in listaOriginal)
            {

                if ((num % 2 == 0 && num != 2) || (num % 3 == 0 && num != 3) || (num % 5 == 0 && num != 5) || (num % 7 == 0 && num != 7) || (num % 11 == 0 && num != 11))
                {
                    break;
                } else
                {
                    listaPrimos.Add(num);
                }
                
            }
        }
        private void btnCopiar_Click(object sender, EventArgs e)
        {
            //borramos lista de destino
            listaPrimos.Clear();


            //copiar lista
            copiarPrimosSegundaLista(listaOriginal, listaPrimos);

            MessageBox.Show(mostrarListas(listaOriginal, listaPrimos));
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mostrarListas(listaOriginal,listaPrimos));
        }

        // Esta funci�n MUEVE los n�meros pares a la segunda lista.
        // Los n�meros pares SE ELIMINAN de la lista original
        // No se puede en este caso utilizar foreach ya que se modifica la lista original 
        void moverPrimosASegundaLista(List<int> listaOriginal, List<int> listaPrimos)
        {
            int i;

            i = 0;
            while (i < listaOriginal.Count)
            {
                if (listaOriginal[i] % 2 == 0)
                {
                    // Si es par lo a�adimos a la otra lista y eliminamos su posici�n de la original.
                    // No avanzamos la i ya que al eliminar un elemento, los siguientes se corren.
                    // 11, 33, 44, 55, 66. -> 11, 33, 55, 66
                    listaPrimos.Add(listaOriginal[i]);
                    listaOriginal.RemoveAt(i);
                }
                else
                    i++; // Si el elemento es impar pasamos al siguiente.
            }
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            listaPrimos.Clear();
            moverPrimosASegundaLista(listaOriginal, listaPrimos);

            MessageBox.Show(mostrarListas(listaOriginal, listaPrimos));
        }
    }
}