namespace ejercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            try
            { //int porque double me mostraría los decimales, claro

                int alturacms;

                alturacms = int.Parse(txtAlturacms.Text); 
                int metros = alturacms / 100;
                int cms = alturacms % 100;

                lblResultado.Text = "Mide: " + metros + " metros y " + cms + " cms.";

            } catch (Exception ex)
            {
                //manejar otro tipo de errores: no se ingresa un número entero
                MessageBox.Show("Error: El valor introducido no es válido");
            }
        }
    }
}