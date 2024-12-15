using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal.Pages
{
    public partial class ReportePuntualidad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        // Evento para agregar un nuevo reporte de puntualidad
        protected void btnAgregarReporte_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados por el usuario
            int empleadoID = int.Parse(txtEmpleadoID.Value);
            int mes = int.Parse(txtMes.Value);
            int año = int.Parse(txtAño.Value);
            int diasTarde = int.Parse(txtDiasTarde.Value);
            int diasCumplidos = int.Parse(txtDiasCumplidos.Value);
            double horasExtras = double.Parse(txtHorasExtras.Value);

            // Lógica para agregar el reporte de puntualidad en la base de datos
            // Aquí debes llamar a tu servicio o lógica para guardar los datos
            // Ejemplo de implementación:
            // ReportesService.AgregarReporte(empleadoID, mes, año, diasTarde, diasCumplidos, horasExtras);

            // Mostrar mensaje de éxito
            Response.Write("<script>alert('Reporte de Puntualidad agregado exitosamente.');</script>");
        }

        // Evento para actualizar un reporte de puntualidad existente
        protected void btnActualizarReporte_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados por el usuario
            int reporteID = int.Parse(txtReporteID.Value);
            int diasTarde = int.Parse(txtDiasTardeActualizar.Value);
            int diasCumplidos = int.Parse(txtDiasCumplidosActualizar.Value);
            double horasExtras = double.Parse(txtHorasExtrasActualizar.Value);

            // Lógica para actualizar el reporte de puntualidad en la base de datos
            // Aquí debes llamar a tu servicio o lógica para actualizar los datos
            // Ejemplo de implementación:
            // ReportesService.ActualizarReporte(reporteID, diasTarde, diasCumplidos, horasExtras);

            // Mostrar mensaje de éxito
            Response.Write("<script>alert('Reporte de Puntualidad actualizado exitosamente.');</script>");
        }

        // Evento para eliminar un reporte de puntualidad existente
        protected void btnEliminarReporte_Click(object sender, EventArgs e)
        {
            // Obtener el ID del reporte a eliminar
            int reporteID = int.Parse(txtEliminarReporteID.Value);

            // Lógica para eliminar el reporte de puntualidad de la base de datos
            // Aquí debes llamar a tu servicio o lógica para eliminar los datos
            // Ejemplo de implementación:
            // ReportesService.EliminarReporte(reporteID);

            // Mostrar mensaje de éxito
            Response.Write("<script>alert('Reporte de Puntualidad eliminado exitosamente.');</script>");
        }

        // Evento para gestionar evaluaciones de desempeño
        protected void btnPagEvaluacionDesempeno_Click(object sender, EventArgs e)
        {
            // Redirigir al formulario de gestión de evaluaciones de desempeño
            // Aquí puedes agregar la lógica para redirigir a otra página si es necesario
            Response.Redirect("EvaluacionDesempeno.aspx");
        }

    }
}
