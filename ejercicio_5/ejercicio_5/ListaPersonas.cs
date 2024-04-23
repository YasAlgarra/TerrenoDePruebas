using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_5
{
    public class ListaPersonas
    {

        private List<Persona> _listaPersonas;
        private List<Persona> _listaAlumnos;
        private List<Persona> _listaProfesores;
        public ListaPersonas()
        {
            _listaPersonas = new List<Persona>();
            _listaAlumnos = new List<Persona>();
            _listaProfesores = new List<Persona>();
        }
        public void AnadirAlumno(string nombre, string dni, string telefono, string codigoCurso, List<double> listaNotas)
        {
            Alumno alumno = new Alumno (nombre, dni, telefono, codigoCurso, listaNotas);
            _listaPersonas.Add(alumno);
            _listaAlumnos.Add(alumno);
        }
        public void AnadirAlumno(Alumno alumno)
        {
            _listaPersonas.Add(alumno);
            _listaAlumnos.Add(alumno);
        }

        public void AnyadirProfesor(Profesor profesor)
        {
            _listaProfesores.Add(profesor);
            _listaPersonas.Add(profesor);
        }

        public string MostrarProfesores()
        {
            string resultado = "Profesores:\n\n";

            foreach (Profesor profesor in _listaProfesores)//recorrer la lista
            {
                resultado += $"{profesor.Visualizar()}";
            }

            return resultado;
        }

        public void AnyadirAsignaturas(Profesor profesor)
        {
            profesor.AnyadirAsignaturas();
        }
      
    }
}
