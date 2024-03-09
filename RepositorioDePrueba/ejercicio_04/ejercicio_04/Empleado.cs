using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_04
{
    public class Empleado
    {
        
        //Miembros o campos
        private string _idEmpleado;
        private string _nombreEmpleado;
        public ListaEmpleados empleados;
        private List<int> _ventasEmp = new List<int>();



        //Propiedades
        public string IdEmpleado
        {
            get { return _idEmpleado; }
            set { _idEmpleado = value; }
        }
        public string NombreEmpleado
        {
            get { return _nombreEmpleado; }
            set { _nombreEmpleado = value; }
        }

        public List<int> VentasEmp
        {
            get { return _ventasEmp; }
            set { _ventasEmp = value; }
        }

        //Constructores
        public Empleado()
        {
            _idEmpleado = "";
            _nombreEmpleado = "";
            this.empleados = empleados;
        }
        public Empleado (string idEmpleado, string nombreEmpleado, List<int> ventasEmp)
        {
            IdEmpleado = idEmpleado;
            NombreEmpleado = nombreEmpleado;
            VentasEmp = ventasEmp;
        }

        //Métodos
        public string MostrarEmpleado()
        {
            string texto = "";

            texto += "\nID: " + IdEmpleado;
            texto += "\nNombre: " + NombreEmpleado;


            return texto;
        }

        //para mostrar ventas

       /* public string MostrarVentas()
        {
            string texto = "";

            ListaEmpleados listaEmpleados = empleados;

            Empleado empleadoConMasVentas = listaEmpleados.EmpleadoConMasVentas();

            if (empleadoConMasVentas != null)
            {
                texto += $"Empleado con más ventas:\nID Empleado: {empleadoConMasVentas.IdEmpleado}\nNombre Empleado: {empleadoConMasVentas.NombreEmpleado}\nVentas: ";
                foreach (int num in empleadoConMasVentas._ventasEmp)
                {
                    texto += num + " ";
                }
            }
            else
            {
                texto += "No hay empleados con ventas registradas.";
            }

            return texto;
        }*/

        public int OrdenarComparando (Empleado e)
        {
            return this.NombreEmpleado.CompareTo (e.NombreEmpleado);
        }

        public int OrdenarComparandoVentas(Empleado e)
        {
            // Comparar la suma total de las ventas de este empleado con la de otro empleado
            int totalVentasThis = this.VentasEmp.Sum();
            int totalVentasOtro = e.VentasEmp.Sum();

            // Comparar y devolver el resultado de la comparación
            return totalVentasThis.CompareTo(totalVentasOtro);
        }

        public void AnyadirVenta(int venta)
        {
            VentasEmp.Add(venta);
        }


    }
}
