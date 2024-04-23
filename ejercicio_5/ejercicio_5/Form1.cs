using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //lista personas
        ListaPersonas personas = new ListaPersonas();
        private void btnAnyadirCurso_Click(object sender, EventArgs e)
        {
            try
            {
                // Creamos un objeto del formulario de cursos
                frmAnyadirCurso fCursos = new frmAnyadirCurso();

                // Abrimos el formulario
                fCursos.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al abrir el formulario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnyadirProfesor_Click(object sender, EventArgs e)
        {
            try
            {
                // Creamos un objeto del formulario de profesores
                frmAnyadirProfesor fProfesor = new frmAnyadirProfesor(personas);

                // Abrimos el formulario
                fProfesor.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al abrir el formulario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnyadirAlumno_Click(object sender, EventArgs e)
        {

        }

        private void btnVerCursos_Click(object sender, EventArgs e)
        {

        }

        private void btnVerProfesores_Click(object sender, EventArgs e)
        {
            MessageBox.Show(personas.MostrarProfesores());
        }

        private void btnVerAlumnos_Click(object sender, EventArgs e)
        {

        }

        private void btnVerTodo_Click(object sender, EventArgs e)
        {

        }

        private void btnAutorrelleno_Click(object sender, EventArgs e)
        {

            //profesores
            List<string> asignaturasP1 = new List<string>()
           {
               "Desarrollo UI/UX",
               "Bases de Datos"
           };

            Profesor profesor1 = new Profesor("Álvaro", "1236789J", "600700800","DAW", "alvaro@gmail.com", asignaturasP1);

            personas.AnyadirProfesor(profesor1);
        }
    }
}
