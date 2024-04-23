using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_5
{
    public abstract class Persona
    {
        //será una clase abstracta de la cual heredarán otras. Los datos que tendrá la clase Persona serán el nombre, el dni y el teléfono

        private string _nombre;
        private string _dni;
        private string _telefono;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string DNI
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public Persona(string nombre, string dni, string telefono)
        {
            _nombre = nombre;
            _dni = dni;
            _telefono = telefono;
        }

        public override string ToString()
        {
            string texto;

            texto = $"\nNombre: {_nombre} \nDNI: {_dni} \nTeléfono: {_telefono}";

            return texto;
        }

        public virtual string Visualizar()
        {
            string resultado = "";

            resultado += $"\nNombre: {_nombre}\n";
            resultado += $"\nDNI: {_dni}\n";
            resultado += $"\nTeléfono: {_telefono}\n";


            return resultado;
        }

    }
}
