using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal.Pages
{
    public partial class Empleado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
                // Código que se ejecuta al cargar la página (si es necesario)
            }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            // Lógica para agregar empleado
            string nombre = txtNombre.Value;
            string direccion = txtDireccion.Value;
            string contacto = txtContacto.Value;
            DateTime fechaIngreso = DateTime.Parse(txtFechaIngreso.Value);
            string cargo = txtCargo.Value;
            string departamento = txtDepartamento.Value;
            decimal salario = decimal.Parse(txtSalario.Value);
            string adicionadoPor = txtAdicionadoPor.Value;

            // Aquí implementas la lógica para guardar el empleado en la base de datos
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            // Lógica para actualizar empleado
            int empleadoID = int.Parse(txtEmpleadoID.Value);
            string nombre = txtNombre.Value;
            string direccion = txtDireccion.Value;
            string contacto = txtContacto.Value;
            DateTime fechaIngreso = DateTime.Parse(txtFechaIngreso.Value);
            string cargo = txtCargo.Value;
            string departamento = txtDepartamento.Value;
            decimal salario = decimal.Parse(txtSalario.Value);
            string modificadoPor = txtAdicionadoPor.Value;

            // Aquí implementas la lógica para actualizar el empleado en la base de datos
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            // Lógica para eliminar empleado
            int empleadoID = int.Parse(txtEmpleadoID.Value);

            // Aquí implementas la lógica para eliminar el empleado en la base de datos
        }

        protected void btnPagEstadoLab_Click(object sender, EventArgs e)
        {
            // Redirige a la página de gestión del estado laboral
            Response.Redirect("EstadoLab.aspx");
        }
    }
}
       