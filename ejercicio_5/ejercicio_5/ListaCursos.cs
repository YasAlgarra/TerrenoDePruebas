using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_5
{
    public class ListaCursos
    {
        private List<Curso> _listaCursos;
        
        public ListaCursos()
        {
            _listaCursos = new List<Curso>();
        }

        public void AnadirCurso(string nombre, string codCurso)
        {
            Curso curso = new Curso(nombre, codCurso);
            _listaCursos.Add(curso);

        }


        //para ver si existe el curso añadido en profesor o alumno
        public bool Existe(string codCurso)
        {
            foreach (Curso curso in _listaCursos)//recorrer la lista
            {
                if (curso.Codigo == codCurso)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
