using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;


namespace ejercicio_001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        DataSet dataSetProfs;
        SqlDataAdapter dataAdapterProfs;
        private int pos;
        private int maxRegistros;

        private void mostrarRegistro(int pos)
        {
            DataRow dRegistro; //recoger un registro de la tabla

            dRegistro = dataSetProfs.Tables["Profesores"].Rows[pos]; //coger registro de la posición pos en la tabla Profesores

            txtDNI.Text = dRegistro[0].ToString();
            txtNombre.Text = dRegistro[1].ToString();
            txtApellidos.Text = dRegistro[2].ToString();
            txtTelefono.Text = dRegistro[3].ToString();
            txtEmail.Text = dRegistro[4].ToString();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
            string cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Yas\\Desktop\\DAM\\1º\\PROGRAMACIÓN\\TEMA 10\\ejercicio_001\\ejercicio_001\\App_Data\\Instituto.mdf;Integrated Security=True;Connect Timeout=30";
          
            SqlConnection con = new SqlConnection(cadenaConexion);
            // Abrimos la conexión.
            con.Open();
            //MessageBox.Show("Conectada");

            string cadenaSQL = "SELECT * From Profesores";
            dataAdapterProfs = new SqlDataAdapter(cadenaSQL, con);

            dataSetProfs = new DataSet();

            dataAdapterProfs.Fill(dataSetProfs, "Profesores");

            //poner la primera posición
            pos = 0;
            mostrarRegistro(pos);

            maxRegistros = dataSetProfs.Tables["Profesores"].Rows.Count;


            // Cerramos la conexión.
            con.Close();
            //MessageBox.Show("Desconectada");

            lblNumRegistro.Text = $"1 de {maxRegistros}"; //mostrar el registro
        }

        private void txtPrimero_Click(object sender, EventArgs e)
        {
            // Ponemos la primera posición
            pos = 0;
            mostrarRegistro(pos);
            lblNumRegistro.Text = $"1 de {maxRegistros}"; //mostrar el registro

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {

            try
            {
                if (pos > 0) { // si posición es mayor que 0

                    // Vamos a la posición anterior.
                    pos--;
                    mostrarRegistro(pos);
                    lblNumRegistro.Text = $"{pos + 1} de {maxRegistros}"; //mostrar el registro - se pone +1 o sino daría la pos incorrecta

                } else
                {
                    MessageBox.Show("Ha llegado al primer registro.");

                }

            } catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                if (pos < maxRegistros - 1) // comprobar la pos en la que nos encontramos no es mayor que el num max de registros
                {
                    // Vamos a la posición siguiente
                    pos++;
                    mostrarRegistro(pos);
                    lblNumRegistro.Text = $"{pos + 1} de {maxRegistros}"; //mostrar el registro

                } else
                {
                    MessageBox.Show("Ha llegado al último registro.");
                }

            } catch (Exception ex) {

                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            // Vamos a la última posición.
            // Los registros van del 0 al numero de registros - 1
            pos = maxRegistros - 1;
            mostrarRegistro(pos);
            lblNumRegistro.Text = $"{maxRegistros} de {maxRegistros}"; //mostrar el registro

        }

        private void btnAnyadir_Click(object sender, EventArgs e)
        {
            txtDNI.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            lblNumRegistro.Text = ""; //mostrar el registro

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult texto = MessageBox.Show("¿Desea revisar el registro antes de añadir?", "Confirmar Guardado", MessageBoxButtons.YesNo);

            if (texto == DialogResult.Yes)
            {
                MessageBox.Show($"DNI: {txtDNI.Text}\nNombre: {txtNombre.Text}\nApellidos: {txtApellidos.Text}\nTeléfono: {txtTelefono.Text}\nEmail: {txtEmail.Text}");

                DialogResult confirmacion = MessageBox.Show("¿Guardar?", "Confirmar Guardado", MessageBoxButtons.YesNo);

                if (confirmacion == DialogResult.Yes)
                {
                    // Creamos un nuevo registro.
                    DataRow dRegistro = dataSetProfs.Tables["Profesores"].NewRow();

                    dRegistro[0] = txtDNI.Text;
                    dRegistro[1] = txtNombre.Text;
                    dRegistro[2] = txtApellidos.Text;
                    dRegistro[3] = txtTelefono.Text;
                    dRegistro[4] = txtEmail.Text;

                    //Añadir al dataset
                    dataSetProfs.Tables["Profesores"].Rows.Add(dRegistro);

                    // Reconectamos con el dataAdapter y actualizamos la BD
                    SqlCommandBuilder cb = new SqlCommandBuilder(dataAdapterProfs);
                    dataAdapterProfs.Update(dataSetProfs, "Profesores");
                    // Actualizamos el número de registros y la posición en la tabla
                    maxRegistros++;
                    pos = maxRegistros - 1;

                    MessageBox.Show("Se ha guardado el registro");

                } else if (confirmacion == DialogResult.No)
                {
                    MessageBox.Show("No se ha guardado el registro");
                }

            } else if (texto == DialogResult.No) {

                // Creamos un nuevo registro.
                DataRow dRegistro = dataSetProfs.Tables["Profesores"].NewRow();

                dRegistro[0] = txtDNI.Text;
                dRegistro[1] = txtNombre.Text;
                dRegistro[2] = txtApellidos.Text;
                dRegistro[3] = txtTelefono.Text;
                dRegistro[4] = txtEmail.Text;

                //Añadir al dataset
                dataSetProfs.Tables["Profesores"].Rows.Add(dRegistro);

                // Reconectamos con el dataAdapter y actualizamos la BD
                SqlCommandBuilder cb = new SqlCommandBuilder(dataAdapterProfs);
                dataAdapterProfs.Update(dataSetProfs, "Profesores");
                // Actualizamos el número de registros y la posición en la tabla
                maxRegistros++;
                pos = maxRegistros - 1;

                MessageBox.Show("Se ha guardado el registro");
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Cogemos el registro situado en la posición actual.
            DataRow dRegistro = dataSetProfs.Tables["Profesores"].Rows[pos];

            // Metemos los datos en el registro
            dRegistro[0] = txtDNI.Text;
            dRegistro[1] = txtNombre.Text;
            dRegistro[2] = txtApellidos.Text;
            dRegistro[3] = txtTelefono.Text;
            dRegistro[4] = txtEmail.Text;

            // Reconectamos con el dataAdapter y actualizamos la BD
            SqlCommandBuilder cb = new SqlCommandBuilder(dataAdapterProfs);
            dataAdapterProfs.Update(dataSetProfs, "Profesores");

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            DialogResult texto = MessageBox.Show("¿Está seguro de que desea borrar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo);

            if (texto == DialogResult.Yes) {
                // Eliminamos el registro situado en la posición actual.
                dataSetProfs.Tables["Profesores"].Rows[pos].Delete();

                // Tenemos un registro menos
                maxRegistros--;

                // Nos vamos al primer registro y lo mostramos
                pos = 0;
                mostrarRegistro(pos);

                // Reconectamos con el dataAdapter y actualizamos la BD
                SqlCommandBuilder cb = new SqlCommandBuilder(dataAdapterProfs);
                dataAdapterProfs.Update(dataSetProfs, "Profesores");

                MessageBox.Show("Registro eliminado");

            } else if (texto == DialogResult.No) {

                MessageBox.Show("No se ha eliminado el registro");
            
            }

        }

        private void btnMostrarListado_Click(object sender, EventArgs e)
        {
            string texto = "";
            int contador = 1;

            foreach (DataRow r in dataSetProfs.Tables["Profesores"].Rows) //recorrer tabla de Profesores
            {
                texto += $"Registro {contador}\n";
                texto += $"DNI: {r[0]}, Nombre: {r[1]}, Apellidos: {r[2]}, Teléfono: {r[3]}, Email: {r[4]}\n\n";

                contador++;
            }

            MessageBox.Show($"{texto}");
        }

        //FALTA POR AFINAR: QUE APUNTE AL REGISTRO AL QUE APUNTA EN CONCRETO
        private void btnBuscarPorApellido_Click(object sender, EventArgs e)
        {
            string apellido = Interaction.InputBox("Escriba el apellido por el que desea buscar", "Buscar Por Apellido");
            string resultado = "";

            foreach (DataRow r in dataSetProfs.Tables["Profesores"].Rows)
            {
                if (txtApellidos.Text == apellido)
                {
                    resultado = $"Registro\n\n";
                    resultado += $"DNI: {r[0]}, Nombre: {r[1]}, Apellidos: {r[2]}, Teléfono: {r[3]}, Email: {r[4]}\n\n";
                } 
            }


            MessageBox.Show($"{resultado}");
        }
    }
}
