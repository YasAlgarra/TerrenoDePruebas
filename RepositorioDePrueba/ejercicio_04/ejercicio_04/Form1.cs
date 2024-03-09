using Microsoft.VisualBasic;

namespace ejercicio_04
{
    public partial class Form1 : Form
    {
        //a�adir instancia para ListaEmpleados 
        public ListaEmpleados empleados;

        public Form1()
        {
            InitializeComponent();
            empleados = new ListaEmpleados(); //inicializar la instancia de la lista


        }

        private void btnIntroducirEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                string idEmp, nombre;

                idEmp = Interaction.InputBox("C�digo ID del empleado/a: ", "ID EMPLEADO/A");
                while (empleados.YaExiste(idEmp))
                {
                    MessageBox.Show("C�digo ocupado, elige otro");
                    idEmp = Interaction.InputBox("C�digo ID del empleado/a: ", "ID EMPLEADO/A");
                }

                nombre = Interaction.InputBox("Nombre del empleado/a: ", "ID EMPLEADO/A");

                empleados.AnyadirEmpleado(idEmp, nombre);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al a�adir el empleado/a: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                string id = Interaction.InputBox("Insertar el ID de empleado/a a eliminar", "ELIMINAR EMPLEADO");

                if (empleados.EliminarEmpleado(id) >= 0)
                {
                    MessageBox.Show("Empleado/a eliminado con �xito");
                }
                else
                {
                    MessageBox.Show("No se ha encontrado el empleado/a");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al eliminar el empleado/a: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrarListaEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                string r = empleados.MostrarEmpleados();
                MessageBox.Show(r);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al mostrar los empleados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOrdenarEmpleadosAlfabetico_Click(object sender, EventArgs e)
        {
            try
            {
                empleados.OrdenarEmpleadoAlfabetico();
                MessageBox.Show("Empleados ordenados con �xito");
            } catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al ordenar los empleados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                string r = empleados.MostrarEmpleados();
                MessageBox.Show(r);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al mostrar los empleados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnyadirVentas_Click(object sender, EventArgs e)
        {

            try
            {
                string idEmp;
                int ventEmp = 0;

                idEmp = Interaction.InputBox("C�digo ID del empleado/a: ", "ID EMPLEADO/A");
                while (empleados.YaExiste(idEmp))
                {
                    string input = Interaction.InputBox("A�adir las ventas del empleado/a", "A�ADIR VENTAS EMPLEADO");
                    // Intentar convertir el input a un n�mero entero
                    if (int.TryParse(input, out int ventas))
                    {
                        ventEmp = ventas; // Asignar las ventas a la variable ventEmp
                                          // Registrar las ventas tanto en la lista de empleados como en la lista de ventas
                        empleados.AnyadirVenta(idEmp, ventEmp);
                        empleados.RegistrarVentas(idEmp, ventEmp);
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese un n�mero v�lido para las ventas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al a�adir el empleado/a: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnMotrarEmpleadoMayoresVentas_Click(object sender, EventArgs e)
        {

            try
            {
                Empleado empleadoConMasVentas = empleados.EmpleadoConMasVentas();

                if (empleadoConMasVentas != null)
                {
                    string mensaje = $"Empleado con m�s ventas:\nID Empleado: {empleadoConMasVentas.IdEmpleado}\nNombre Empleado: {empleadoConMasVentas.NombreEmpleado}";
                    MessageBox.Show(mensaje);
                }
                else
                {
                    MessageBox.Show("No hay empleados con ventas registradas.", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al mostrar los empleados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminarVentasEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                string id = Interaction.InputBox("Ingrese el ID del empleado/a para elminar ventas", "ELIMINAR VENTAS EMPLEADO");

                int resultado = empleados.EliminarVentasEmpleado(id);

                if (resultado >= 0)
                {
                    MessageBox.Show("Ventas del empleado/a eliminadas con �xito");
                }
                else
                {
                    MessageBox.Show("No se encontr� el empleado/a con el ID proporcionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al eliminar las ventas del empleado/a: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOrdenarEmpleadosVentas_Click(object sender, EventArgs e)
        {
            try
            {
                empleados.OrdenarEmpleadosPorVentas();
                MessageBox.Show("Empleados ordenados por ventas");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al ordenar los empleados por ventas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // A�ad� este bot�n para asegurarme de que ordenaba correctamente por ventas a los empleado
        // Pero no he podido sacarlo sin que salga un 1 delante
        private void btnMostrarDatosEmpVentas_Click(object sender, EventArgs e)
        {
            try
            {
                // Mostramos la lista actualizada de empleados por pantalla
                string r = empleados.MostrarEmpleadosOrdenadosPorVentas();
                MessageBox.Show(r);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al reflejar los cambios y ordenar por ventas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}