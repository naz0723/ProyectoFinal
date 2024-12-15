using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal.Pages
{
    public partial class GestionVacaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        // Evento para agregar una vacación, permiso o licencia
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            // Obtener los valores del formulario
            string empleadoID = txtEmpleadoID.Value;
            string fechaInicio = txtFechaInicio.Value;
            string fechaFin = txtFechaFin.Value;
            string tipo = ddlTipo.Value;
            string motivo = txtMotivo.Value;

            // Lógica para agregar en la base de datos (simulada)
            // Ejemplo: AgregarGestionVacaciones(empleadoID, fechaInicio, fechaFin, tipo, motivo);

            // Mostrar mensaje de éxito
            Response.Write("<script>alert('Vacación, Permiso o Licencia agregada exitosamente');</script>");
        }

        // Evento para actualizar una vacación, permiso o licencia
        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            // Obtener los nuevos valores del formulario
            string gestionID = txtGestionIDActualizar.Value;
            string fechaInicioActualizar = txtFechaInicioActualizar.Value;
            string fechaFinActualizar = txtFechaFinActualizar.Value;
            string tipoActualizar = ddlTipoActualizar.Value;
            string motivoActualizar = txtMotivoActualizar.Value;

            // Lógica para actualizar en la base de datos (simulada)
            // Ejemplo: ActualizarGestionVacaciones(gestionID, fechaInicioActualizar, fechaFinActualizar, tipoActualizar, motivoActualizar);

            // Mostrar mensaje de éxito
            Response.Write("<script>alert('Vacación, Permiso o Licencia actualizada exitosamente');</script>");
        }

        // Evento para eliminar una vacación, permiso o licencia
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            // Obtener el ID de la gestión a eliminar
            string gestionIDEliminar = txtGestionIDEliminar.Value;

            // Lógica para eliminar en la base de datos (simulada)
            // Ejemplo: EliminarGestionVacaciones(gestionIDEliminar);

            // Mostrar mensaje de éxito
            Response.Write("<script>alert('Vacación, Permiso o Licencia eliminada exitosamente');</script>");
        }
    }
}
