namespace ejercicio_25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            int resultado = 0; //inicializamos la variable resultado de la multiplicación
            
            for (int i = 1; i <= 10; i++) //Controlamos el multiplicando
            {
                string mostrarTabla = "";
                /*inicializamos cadena vacía para después poder obtener la tabla
                conjunta, y no las multiplicaciones sueltas de una en una*/

                for (int j = 1; j <= 10; j++) //Controlamos el multiplicador
                {
                    resultado = i * j;

                    mostrarTabla += $"{i} * {j} = {resultado} \n";
                    //mostramos el multiplicando, multiplicador y resultado del 1 al 10
           
                }

                MessageBox.Show($"Tabla del {i}\n {mostrarTabla}");

                //Si hay otra forma que no fuera así, me gustaría saberla :) gracias!
            }
        }
    }
}