using System;

namespace ejercicio_04
{

	public class ListaEmpleados
	{
        //Miembros
        private List<Empleado> listaEmpleados;



        //Constructor
        public ListaEmpleados()
        {
            listaEmpleados = new List<Empleado>();
        }
        //Métodos
        public int AnyadirEmpleado(string id, string nombre)
        {
            Empleado empleado = new Empleado();
            int r = 0;

            empleado.IdEmpleado = id;
            empleado.NombreEmpleado = nombre;

            if (!listaEmpleados.Contains(empleado))
                listaEmpleados.Add(empleado);
            else r = -1;

            return r;
        }
        public bool YaExiste(string id)
        {
            bool result = false;

            foreach (Empleado t in listaEmpleados)
            {
                if (t.IdEmpleado == id)
                    result = true;
            }
            return result;
        }

        public int BuscarPosicion(string id)
        {
            int pos = -1;

            for (int i = 0; i < listaEmpleados.Count(); i++)
            {
                if (listaEmpleados[i].IdEmpleado == id)
                    pos = i;
            }
            return pos;
        }
        public string MostrarEmpleados()
        {
            string r = "";

            foreach (Empleado t in listaEmpleados)
                r += t.MostrarEmpleado();
            return r;
        }
        public int EliminarEmpleado(string id)
        {
            int pos = BuscarPosicion(id);

            if (pos >= 0)
                listaEmpleados.RemoveAt(pos);

            return pos;
        }

        public void OrdenarEmpleadoAlfabetico()
        {
            //Usamos el método "OrderBy" para ordenar  la lista -> empleado.NombreEmpleado para indicar la clave de ordenación
            //El método ordena la lista en función del nombre en orden ASCENDENTE
            //lo convertimos en una lista con el "ToList()"
            //le asignamos la lista ordenada de nuevo a la variable listaEmpleados para actualizarla y tener la nueva versión
            listaEmpleados = listaEmpleados.OrderBy(empleado => empleado.NombreEmpleado).ToList();

        }
        public int CantidadEmpleados()
        {
            return listaEmpleados.Count;
        }
        public string IdEmpleadoPosicion(int pos)
        {
            return listaEmpleados[pos].IdEmpleado;
        }
        public string NombreEmpleado(int pos)
        {
            return listaEmpleados[pos].NombreEmpleado;
        }

        public int AnyadirVenta(string idEmpleado, int ventaEmp)
        {
            foreach (Empleado empleado in listaEmpleados)
            {
                if (empleado.IdEmpleado == idEmpleado)
                {
                    empleado.AnyadirVenta(ventaEmp);
                    return ventaEmp;
                }
            }


            return -1; //si no se encontrara el empleado
        }

        public Empleado EmpleadoConMasVentas()
        {
            Empleado empleadoConMasVentas = null;
            int maxVentas = int.MinValue; // Propiedad estática que devuelve el valor más pequeño posible

            foreach (Empleado empleado in listaEmpleados)
            {
                int totalVentasEmpleado = empleado.VentasEmp.Sum(); // Suma total de las ventas del empleado

                if (totalVentasEmpleado > maxVentas)
                {
                    maxVentas = totalVentasEmpleado;
                    empleadoConMasVentas = empleado;
                }
            }

            return empleadoConMasVentas;
        }

        public int RegistrarVentas(string idEmpleado, int ventas)
        {
            foreach (Empleado empleado in listaEmpleados)
            {
                if (empleado.IdEmpleado == idEmpleado)
                {
                    empleado.AnyadirVenta(ventas);
                    return empleado.VentasEmp.Sum(); // Devuelve el total de las ventas de cada empleado
                }
            }
            return -1; // Devuelve -1 si el empleado no fue encontrado
        }

        /* public string MostrarVenta()
         {
             string r = "";

             foreach (Empleado empleado in listaEmpleados)
             {
                 r = empleado.() + "\n";
             }

             return r;
         }*/

        // Eliminamos ventas de empleado
        public int EliminarVentasEmpleado(string idEmpleado)
        {
            foreach (Empleado empleado in listaEmpleados)
            {
                if (empleado.IdEmpleado == idEmpleado)
                {
                    empleado.VentasEmp.Clear(); // Limpiar la lista de ventas del empleado
                    return 1;
                }
            }
            return -1; 
        }

        //así como ordenamos por orden alfabético, ahora por ventas
        public void OrdenarEmpleadosPorVentas()
        {
            listaEmpleados = listaEmpleados.OrderByDescending(empleado => empleado.VentasEmp.Count).ToList();
        }

        public string MostrarEmpleadosOrdenadosPorVentas()
        {
            // Ordenar la lista de empleados por sus ventas de forma descendente
            OrdenarEmpleadosPorVentas();

            string resultado = "";

            foreach (Empleado empleado in listaEmpleados)
            {
                resultado += empleado.MostrarEmpleado();

                // Mostrar las ventas del empleado, teniendo en cuenta si se han eliminado
                int ventas = empleado.VentasEmp.Sum();
                resultado += $"\nVentas: {ventas}\n";
            }

            
            return resultado;
        }


    }
}
