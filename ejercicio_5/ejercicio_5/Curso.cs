using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ejercicio_5
{
    public class Curso
    {
        //donde guardaremos la información de un curso. Los datos de un curso serán el nombre y el código

        private string _nombre;
        private string _codigo;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public Curso(string nombre, string codigo)
        {
            _nombre = nombre;
            _codigo = codigo;
        }

        public string MostrarCursos()
        {
            string texto = "\nCursos:";
            int contador = 1;

            texto += $"\nCurso {contador}";
            texto += $"\nNombre {_nombre}";
            texto += $"\nCódigo {_codigo}";

            return texto;
        }

        public override string ToString()
        {
            string texto = "";

            texto += $"\nNombre: {_nombre}"; 
            texto += $"\nCódigo Curso: {_codigo}";


            return texto;
        }

    }
}
