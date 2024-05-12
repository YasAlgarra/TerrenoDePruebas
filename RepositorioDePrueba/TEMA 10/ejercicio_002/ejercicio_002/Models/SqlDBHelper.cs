using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_002.Models
{
    internal class SqlDBHelper
    {
        
        // Miembros para guardar el dataSet y el dataAdapter de profesores.
        private DataSet dataSetProfs;
        private SqlDataAdapter daProfesores;
        // Miembro para guardar el número de profesores.
        private int _numProfesores;
        // Propiedad de solo lectura.
        public int NumProfesores
        {
            get => _numProfesores;
        }
        // Constructor del objeto. 
        // En el mismo hacemos la conexión y creamos dataSet y dataAdapter
        public SqlDBHelper()
        {
            string cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Yas\\Desktop\\DAM\\1º\\PROGRAMACIÓN\\TEMA 10\\ejercicio_001\\ejercicio_001\\App_Data\\Instituto.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(cadenaConexion);
            // Abrimos la conexión.
            con.Open();
            string cadenaSQL = "SELECT * From Profesores";
            daProfesores = new SqlDataAdapter(cadenaSQL, con);
            dataSetProfs = new DataSet();
            daProfesores.Fill(dataSetProfs, "Profesores");
            // Obtenemos el número de profesores
            _numProfesores = dataSetProfs.Tables["Profesores"].Rows.Count;
            // Cerramos la conexión.
            con.Close();
        }

        // Método que a partir de una posición en la BD
        // Devuelve un objeto profesor.
        // Devuelve null si pos está fuera de los límites
        public Profesor devuelveProfesor(int pos)
        {
            Profesor profesor = null;
            if (pos >= 0 && pos < _numProfesores)
            {
                // Objeto que nos permite recoger un registro de la tabla.
                DataRow dRegistro;
                // Cogemos el registro de la posición pos en la tabla Profesores
                dRegistro = dataSetProfs.Tables["Profesores"].Rows[pos];
                // Cogemos el valor de cada una de las columnas del registro
                // y creamos el objeto profesor con esos datos.
                profesor = new Profesor(dRegistro[0].ToString(),
                dRegistro[1].ToString(), dRegistro[2].ToString(),
                dRegistro[3].ToString(), dRegistro[4].ToString()
                );
            }
            return profesor;
        }
        // Metodos CRUD
        // Método que reconecta y actualiza la BD
        private void reconectarBD()
        {
            // Reconectamos con el dataAdapter y actualizamos la BD
            SqlCommandBuilder cb = new SqlCommandBuilder(daProfesores);
            daProfesores.Update(dataSetProfs, "Profesores");
        }

        // Método que añade un profesor a nuestra BD
        public void anyadirProfesor(Profesor profesor)
        {
            // Creamos un nuevo registro.
            DataRow dRegistro = dataSetProfs.Tables["Profesores"].NewRow();
            // Metemos los datos en el nuevo registro
            dRegistro[0] = profesor.Dni;
            dRegistro[1] = profesor.Nombre;
            dRegistro[2] = profesor.Apellidos;
            dRegistro[3] = profesor.Tlf;
            dRegistro[4] = profesor.eMail;
            // Si quisieramos hacerlo por nombre de columna en vez de posición
            // dRegistro["DNI"] = profesor.Dni;
            // Añadimos el registro al Dataset
            dataSetProfs.Tables["Profesores"].Rows.Add(dRegistro);
            // Reconectamos y actualizamos la BD
            reconectarBD();
            // Actualizamos el número de profesores
            _numProfesores++;
        }

        // Actualizamos los datos del profesor 
        // situado en la posición pos
        public void actualizarProfesor(Profesor profesor, int pos)
        {
            // Cogemos el registro situado en la posición actual.
            DataRow dRegistro = dataSetProfs.Tables["Profesores"].Rows[pos];
            // Metemos los datos en el registro
            dRegistro[0] = profesor.Dni;
            dRegistro[1] = profesor.Nombre;
            dRegistro[2] = profesor.Apellidos;
            dRegistro[3] = profesor.Tlf;
            dRegistro[4] = profesor.eMail;
            // Si quisieramos hacerlo por nombre de columna en vez de posición
            // dRegistro["DNI"] = profesor.Dni;
            // Reconectamos y actualizamos la BD
            reconectarBD();
        }

        public void eliminarProfesor(int pos)
        {
            // Eliminamos el registro situado en la posición actual.
            dataSetProfs.Tables["Profesores"].Rows[pos].Delete();
            // Tenemos un profesor menos
            _numProfesores--;
            // Reconectamos y actualizamos la BD
            reconectarBD();
        }

        //devolver el listado de todos los profesores
        public string listadoProfesor(int pos)
        {
            string texto = "";
            int contador = 1;

            foreach (DataRow r in dataSetProfs.Tables["Profesores"].Rows) //recorrer tabla de Profesores
            {
                texto += $"Registro {contador}\n";
                texto += $"DNI: {r[0]}, Nombre: {r[1]}, Apellidos: {r[2]}, Teléfono: {r[3]}, Email: {r[4]}\n\n";

                contador++;
            }

            return texto;
        }

    }
    }
