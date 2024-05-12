using ejercicio_002.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ejercicio_002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Instancia del objeto que maneja la BD.
        SqlDBHelper sqlDBHelper;
        // Variable que indica en qué registro estamos situados.
        private int pos;
        private void Form1_Load(object sender, EventArgs e)
        {
            // Creamos el objeto BD
            sqlDBHelper = new SqlDBHelper();
            // Situamos la primera posición
            // y mostramos el registro
            pos = 0;
            mostrarRegistro(pos);
        }

        // Subprograma que muestra el registro situado en la posición pos
        private void mostrarRegistro(int pos)
        {
            Profesor profesor;
            profesor = sqlDBHelper.devuelveProfesor(pos);
            // Ponemos los valores en los textBox correspondientes
            txtDNI.Text = profesor.Dni;
            txtNombre.Text = profesor.Nombre;
            txtApellidos.Text = profesor.Apellidos;
            txtTelefono.Text = profesor.Tlf;
            txtEmail.Text = profesor.eMail;
        }

        private void txtPrimero_Click(object sender, EventArgs e) //se me coló "txt"
        {
            // Ponemos la primera posición
            pos = 0;
            mostrarRegistro(pos);
        }

        private void btnAnterior_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (pos > 0)
                { // si posición es mayor que 0

                    // Vamos a la posición anterior.
                    pos--;
                    mostrarRegistro(pos);
                    lblNumRegistro.Text = $"{pos + 1} de {sqlDBHelper.NumProfesores}"; //mostrar el registro - se pone +1 o sino daría la pos incorrecta

                }
                else
                {
                    MessageBox.Show("Ha llegado al primer registro.");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (pos < sqlDBHelper.NumProfesores - 1) // comprobar la pos en la que nos encontramos no es mayor que el num max de registros
                {
                    // Vamos a la posición siguiente
                    pos++;
                    mostrarRegistro(pos);
                    lblNumRegistro.Text = $"{pos + 1} de {sqlDBHelper.NumProfesores}"; //mostrar el registro

                }
                else
                {
                    MessageBox.Show("Ha llegado al último registro.");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUltimo_Click_1(object sender, EventArgs e)
        {
            // Vamos a la última posición.
            // Tener en cuenta que los registros van del 0 al numero de
            // registros - 1
            pos = sqlDBHelper.NumProfesores - 1;
            mostrarRegistro(pos);
        }

        private void btnAnyadir_Click_1(object sender, EventArgs e)
        {
            txtDNI.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            DialogResult texto = MessageBox.Show("¿Desea revisar el registro antes de añadir?", "Confirmar Guardado", MessageBoxButtons.YesNo);

            if (texto == DialogResult.Yes)
            {
                MessageBox.Show($"DNI: {txtDNI.Text}\nNombre: {txtNombre.Text}\nApellidos: {txtApellidos.Text}\nTeléfono: {txtTelefono.Text}\nEmail: {txtEmail.Text}");

                DialogResult confirmacion = MessageBox.Show("¿Guardar?", "Confirmar Guardado", MessageBoxButtons.YesNo);

                if (confirmacion == DialogResult.Yes)
                {
                    // Creamos el profesor con los datos del formulario
                    Profesor profesor = new Profesor(txtDNI.Text, txtNombre.Text,
                    txtApellidos.Text, txtTelefono.Text, txtEmail.Text);
                    sqlDBHelper.anyadirProfesor(profesor);
                    // Actualizamos la posición
                    pos = sqlDBHelper.NumProfesores - 1;

                    MessageBox.Show("Se ha guardado el registro");

                }
                else if (confirmacion == DialogResult.No)
                {
                    MessageBox.Show("No se ha guardado el registro");
                }

            }
            else if (texto == DialogResult.No)
            {

                // Creamos el profesor con los datos del formulario
                Profesor profesor = new Profesor(txtDNI.Text, txtNombre.Text,
                txtApellidos.Text, txtTelefono.Text, txtEmail.Text);
                sqlDBHelper.anyadirProfesor(profesor);
                // Actualizamos la posición
                pos = sqlDBHelper.NumProfesores - 1;

                MessageBox.Show("Se ha guardado el registro");
            }   
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            // Creamos el profesor con los datos del formulario
            Profesor profesor = new Profesor(txtDNI.Text, txtNombre.Text,
            txtApellidos.Text, txtTelefono.Text, txtEmail.Text);
            sqlDBHelper.actualizarProfesor(profesor, pos);
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            DialogResult texto = MessageBox.Show("¿Está seguro de que desea borrar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo);

            if (texto == DialogResult.Yes)
            {
                sqlDBHelper.eliminarProfesor(pos);
                // Nos vamos al primer registro y lo mostramos
                pos = 0;
                mostrarRegistro(pos);

                MessageBox.Show("Registro eliminado");

            }
            else if (texto == DialogResult.No)
            {

                MessageBox.Show("No se ha eliminado el registro");

            }
            
        }

        private void btnMostrarListado_Click(object sender, EventArgs e)
        {
            int pos = 0;
            string resultado = $"{sqlDBHelper.listadoProfesor(pos)}";

            MessageBox.Show($"{resultado}");

        }
    }
}
