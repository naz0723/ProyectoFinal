using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal.Pages
{
    public partial class GestionAusencias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        // Evento para agregar una ausencia
        protected void btnAgregarAusencia_Click(object sender, EventArgs e)
        {
            // Lógica para agregar una ausencia
            string empleadoID = txtEmpleadoID.Value;
            string fechaInicio = txtFechaInicio.Value;
            string fechaFin = txtFechaFin.Value;
            string tipoAusencia = txtTipoAusencia.Value;
            string motivo = txtMotivo.Value;

            // Simulación de inserción (aquí va la lógica para insertar en la base de datos)
            // Ejemplo: InsertarAusencia(empleadoID, fechaInicio, fechaFin, tipoAusencia, motivo);

            // Mostrar mensaje de éxito o redirigir según sea necesario
            Response.Write("<script>alert('Ausencia agregada exitosamente');</script>");
        }

        // Evento para actualizar una ausencia
        protected void btnActualizarAusencia_Click(object sender, EventArgs e)
        {
            // Lógica para actualizar una ausencia
            string ausenciaID = txtAusenciaID.Value;
            string fechaInicioActualizar = txtFechaInicioActualizar.Value;
            string fechaFinActualizar = txtFechaFinActualizar.Value;
            string tipoAusenciaActualizar = txtTipoAusenciaActualizar.Value;
            string motivoActualizar = txtMotivoActualizar.Value;

            // Simulación de actualización (aquí va la lógica para actualizar en la base de datos)
            // Ejemplo: ActualizarAusencia(ausenciaID, fechaInicioActualizar, fechaFinActualizar, tipoAusenciaActualizar, motivoActualizar);

            // Mostrar mensaje de éxito o redirigir según sea necesario
            Response.Write("<script>alert('Ausencia actualizada exitosamente');</script>");
        }

        // Evento para eliminar una ausencia
        protected void btnEliminarAusencia_Click(object sender, EventArgs e)
        {
            // Lógica para eliminar una ausencia
            string ausenciaID = txtEliminarAusenciaID.Value;

            // Simulación de eliminación (aquí va la lógica para eliminar en la base de datos)
            // Ejemplo: EliminarAusencia(ausenciaID);

            // Mostrar mensaje de éxito o redirigir según sea necesario
            Response.Write("<script>alert('Ausencia eliminada exitosamente');</script>");
        }

        // Evento para redirigir a la página de reporte de puntualidad
        protected void btnPagReportePuntualidad_Click(object sender, EventArgs e)
        {
            // Redirigir a la página de reporte de puntualidad
            Response.Redirect("ReportePuntualidad.aspx");
        }
    }
}
