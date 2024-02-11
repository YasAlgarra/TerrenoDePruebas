namespace ejercicio13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            try
            {
                double horaNormal = double.Parse(txtHorasNormal.Text);
                double horaExtra = double.Parse(txtHorasExtra.Text);
                double precioHoraNormal = double.Parse(txtPrecioHora.Text);
                double precioHoraExtra = precioHoraNormal * 2;
                double retencion = 0.18;

                double nominaBruto = ((horaNormal * precioHoraNormal) + (horaExtra * precioHoraExtra));
                double nominaNeto = nominaBruto - (nominaBruto * retencion);

                MessageBox.Show("El total de la nómina es: " + nominaNeto + " €");

            }
            catch (FormatException) {

                MessageBox.Show("Error: Los valores introducidos no son numéricos.");
            }
        }
    }
}