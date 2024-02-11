namespace ejercicio_23
{
    public partial class Form1 : Form
    {
        private static string InputBox(string texto)
        {
            InputBoxDialog ib = new InputBoxDialog();
            ib.FormPrompt = texto;
            ib.DefaultValue = "";
            ib.ShowDialog();
            string s = ib.InputResponse;
            ib.Close();
            return s;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            int peso;
            //inicializamos variables según rangos de peso
            int numAlumn = 0;
            int menoroIgual50 = 0;
            int mayor65 = 0;
            int mayor50 = 0;
            int mayor80 = 0;
            //inicializamos para porcentajes
            int porcentmenoroIgual50 = 0;
            int porcentmayor65 = 0;
            int porcentmayor50 = 0;
            int porcentmayor80 = 0;

            //sacar estadísticas
            int pesoTotal = 0;
            int pesoMedio = 0;

            //obtenemos número por teclado
            peso = int.Parse(InputBox("Introduzca peso de almuna/o:"));

            while (peso > 0) //controlamos que peso sea número positivo
            {
                if (peso <= 50) //primer rango de peso
                {
                    pesoTotal += peso; //sumar pesos para obtener peso total
                    menoroIgual50++; //cada vez que entra en el bucle sumamos a esta variable
                    numAlumn++; //cada vez que entra en el bucle sumamos a esta variable
                    peso = int.Parse(InputBox("Introduzca peso de almuna/o:")); //para seguir pidiendo números por teclado
                    
                }

                else if (peso > 50 && peso <= 65) //segundo rango de peso
                {
                    pesoTotal += peso;
                    mayor50++;
                    numAlumn++;
                    peso = int.Parse(InputBox("Introduzca peso de almuna/o:"));
                    
                }

                else if (peso > 65 && peso <= 80) //tercer rango de peso
                {
                    pesoTotal += peso;
                    mayor65++;
                    numAlumn++;
                    peso = int.Parse(InputBox("Introduzca peso de almuna/o:"));

                }

                else if (peso > 80) //cuarto rango de peso
                {
                    pesoTotal += peso;
                    mayor80++;
                    numAlumn++;
                    peso = int.Parse(InputBox("Introduzca peso de almuna/o:"));
                }

                //sacar porcentajes

                porcentmenoroIgual50 = (menoroIgual50 * 100) / numAlumn;
                porcentmayor65 = (mayor65 * 100) / numAlumn;
                porcentmayor50 = (mayor50 * 100) / numAlumn;
                porcentmayor80 = (mayor80 * 100) / numAlumn;

                //sacar peso medio
                pesoMedio = pesoTotal / numAlumn;


            } MessageBox.Show($"Número de Alumnos: {numAlumn}\n Porcentaje <=50: {porcentmenoroIgual50} %\n Porcentaje >50 y <=65: {porcentmayor50} %\n Porcentaje >65 y <=80: {porcentmayor65} %\n Porcentaje >80: {porcentmayor80} %\n Peso medio de la clase: {pesoMedio}");


        }
    }
}