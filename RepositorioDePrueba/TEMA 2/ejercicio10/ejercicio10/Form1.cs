namespace ejercicio10
{
    public partial class Conversor : Form
    {
        public Conversor()
        {
            InitializeComponent();
        }

        private void btnAPesetas_Click(object sender, EventArgs e)
        {
            try { 
                double euros = double.Parse(txtEuros.Text);

                double pesetas = euros * 166.386;

                MessageBox.Show($"{euros:F2} euros son {pesetas:F2} pesetas.");
                //F2 para que solo aparezcan 2 decimales

            }
            catch (FormatException)
            {
                MessageBox.Show("Se ha producido el error: El valor ingresado no es numérico");
            }
        }

        private void btnAEuros_Click(object sender, EventArgs e)
        {

            try
            {
                double pesetas = double.Parse(txtPesetas.Text);

                double euros = pesetas / 166.386;

                MessageBox.Show($"{pesetas:F2} pesetas son {euros:F2} euros.");

            } catch (FormatException)
            {
                MessageBox.Show("Se ha producido el error: El valor ingresado no es numérico");
            } //necesitaría más catch con otros errores?
        }

    }
}
