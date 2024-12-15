using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal.Pages
{
    public partial class ControlHoras : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        // Evento para agregar un control de horas
        protected void btnAgregarControlHoras_Click(object sender, EventArgs e)
        {
            // Lógica para agregar un control de horas
            string empleadoID = txtEmpleadoID.Value;
            string fecha = txtFecha.Value;
            string horaEntrada = txtHoraEntrada.Value;

            // Simulación de inserción (aquí va la lógica para insertar en la base de datos)
            // Ejemplo: InsertarControlHoras(empleadoID, fecha, horaEntrada);

            // Mostrar mensaje de éxito o redirigir según sea necesario
            Response.Write("<script>alert('Control de horas agregado exitosamente');</script>");
        }

        // Evento para actualizar un control de horas
        protected void btnActualizarControlHoras_Click(object sender, EventArgs e)
        {
            // Lógica para actualizar un control de horas
            string controlHorasID = txtControlHorasID.Value;
            string horaSalida = txtHoraSalida.Value;

            // Simulación de actualización (aquí va la lógica para actualizar en la base de datos)
            // Ejemplo: ActualizarControlHoras(controlHorasID, horaSalida);

            // Mostrar mensaje de éxito o redirigir según sea necesario
            Response.Write("<script>alert('Control de horas actualizado exitosamente');</script>");
        }

        // Evento para eliminar un control de horas
        protected void btnEliminarControlHoras_Click(object sender, EventArgs e)
        {
            // Lógica para eliminar un control de horas
            string controlHorasID = txtEliminarControlHorasID.Value;

            // Simulación de eliminación (aquí va la lógica para eliminar en la base de datos)
            // Ejemplo: EliminarControlHoras(controlHorasID);

            // Mostrar mensaje de éxito o redirigir según sea necesario
            Response.Write("<script>alert('Control de horas eliminado exitosamente');</script>");
        }

        // Evento para redirigir a la gestión de ausencias
        protected void btnPagGestionAusencias_Click(object sender, EventArgs e)
        {
            // Redirigir a la página de gestión de ausencias
            Response.Redirect("GestionAusencias.aspx");
        }
    }
}
