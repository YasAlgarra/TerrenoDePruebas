using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_5
{
    public class Alumno : Persona
    {
        // añadirá los siguientes datos: código del curso al que pertenece, lista de notas(lista de valores double)
        private string _codigoCursoAlu;
        private List<double> _notas;
        //private double _nota;

        public string CodigoCursoAlu
        {
            get { return _codigoCursoAlu;}
            set { _codigoCursoAlu = value;}
        }

        public List<double> listaNotas
        {
            get { return _notas; }
            set { _notas = value; }
        }

        /*public double Nota
        {
            get { return _nota; }
            set { _nota = value; }
        }*/

        public Alumno(string nombre, string dni, string telefono, string codigoCursoAlu, List<double> listaNotas ) : base(nombre, dni, telefono)
        {
            _codigoCursoAlu = codigoCursoAlu;
            _notas = listaNotas;
            //_nota = nota;
        }

       /* //método para agregar nueva nota
        public void AgregarNota(List<double> litaNotas, double nota){


            nota = Double.Parse((Interaction.InputBox("Añadir nota")));
            _notas.Add(nota);
        }*/


    }
}
