using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_5
{
    public partial class frmAnyadirProfesor : Form
    {

        public ListaPersonas personas;
        public ListaCursos cursos;
        public frmAnyadirProfesor(ListaPersonas personas, ListaCursos cursos)
        {
            InitializeComponent();

            this.personas = personas;
            this.cursos = cursos;
        }

        //método obtener profesor

        void obtenerDatosProfesor(out string nombre, out string dni, out string telefono, out string email, out Curso codCurso)
        {
            nombre = txtNombre.Text;
            dni = txtDNI.Text;
            telefono = txtTelefono.Text;
            email = txtEmail.Text;
            codCurso = txtCodigoCurso.Text;
            
        }

        void obtenerListaAsignaturas(List<string> listatAsignaturas)
        {
            string texto = "";

            texto = Interaction.InputBox("Introduzca asignatura");
            listatAsignaturas.Add(texto);

        }
        /*private void btnAnyadirAsignatura_Click(object sender, EventArgs e)
        {

           // obtenerListaAsignaturas(listatAsignaturas);
        }*/

        private void btnAnyadirProfesor_Click(object sender, EventArgs e)
        {
            string nombre, dni, telefono, email;
            Curso codCurso;
            List<string> listatAsignaturas = new List<string>();

            obtenerListaAsignaturas(listatAsignaturas);
            obtenerDatosProfesor(out nombre, out dni, out telefono, out email, out codCurso);

            //vereficamos que el código del curso exista
            bool Existe = cursos.Existe(codCurso);

            if (!Existe) // si no existe
            {
                MessageBox.Show($"El código: {codCurso} no existe o no es válido.");
            }
            else {


             Profesor profesor = new Profesor(nombre, dni, telefono, codCurso, email, listatAsignaturas);

            personas.AnyadirProfesor(profesor);

            MessageBox.Show($"Profesor/a añadido: {profesor}");
            }
        }
    }
}
