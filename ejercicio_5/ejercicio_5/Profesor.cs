using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_5
{
    public class Profesor : Persona
    {
        //añadirá los siguientes datos: lista de asignaturas que imparte, código del curso del que es tutor y correo electrónico.
        public Curso _codigoCurso;
        private string _email;
        private List<string> _asignaturas;
        public ListaPersonas personas;
        public ListaCursos cursos;


        /*public string CodigoCurso
        {
            get { return _codigoCurso;}
            set { _codigoCurso = value;}
        }*/

        public Curso CodigoCurso
        {
            get { return _codigoCurso; }
            set { _codigoCurso = value; }
        }

        public string Email
        {
            get { return _email;}
            set { _email = value;}
        }

        public List<string> listaAsignaturas
        {
            get { return _asignaturas;}
            set { _asignaturas = value;}
        }


        public Profesor(string nombre, string dni, string telefono, Curso codigoCurso, string email, List<string> listaAsignaturas ) : base(nombre, dni, telefono)
        {
            _codigoCurso = codigoCurso;
            _email = email;
            _asignaturas = listaAsignaturas;
        }

        //método void para añadir asignaturas
        public void AnyadirAsignaturas()
        {
            string asignatura = "";
            listaAsignaturas.Add(asignatura);
        }

        public string MostrarAsignaturas()
        {
            string resultado = "";
            int contador = 1;

            if (listaAsignaturas.Count == 0)
            {
                resultado += "Aún no se han asignado asignaturas";
            } else
            {
                foreach (string asignatura in listaAsignaturas)
                {
                    resultado += $"\n\nAsignatura {contador}:";
                    resultado += $"\n{asignatura}";

                    contador++;
                }
            }

            return resultado;
        }

        public override string ToString()
        {
            string texto = base.ToString();

            texto += $"\nEmail: {_email}"; //añadimos el lado a la info de la clase padre
            texto += $"\nCódigo Curso Tutoría: {_codigoCurso}";
            texto += $"\nAsignaturas que imparte: {MostrarAsignaturas()}";

            return texto;
        }

     


        public override string Visualizar()
        {
            string resultado = base.Visualizar();

            resultado += $"\nEmail: {_email}";
            resultado += $"\nCódigo Curso Tutoría: {_codigoCurso}";
            resultado += $"\n\nAsignaturas que imparte: {MostrarAsignaturas()}";

            return resultado;
        }

    }
}
