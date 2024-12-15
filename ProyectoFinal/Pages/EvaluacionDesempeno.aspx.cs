using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal.Pages
{
    public partial class EvaluacionDesempeno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        // Evento para agregar una evaluación de desempeño
        protected void btnAgregarEvaluacion_Click(object sender, EventArgs e)
        {
            // Lógica para agregar una evaluación
            string empleadoID = txtEmpleadoID.Value;
            string fechaEvaluacion = txtFechaEvaluacion.Value;
            string comentarios = txtComentarios.Value;
            string puntuacion = txtPuntuacion.Value;

            // Simulación de inserción (aquí va la lógica para insertar en la base de datos)
            // Ejemplo: InsertarEvaluacion(empleadoID, fechaEvaluacion, comentarios, puntuacion);

            // Mostrar mensaje de éxito o redirigir según sea necesario
            Response.Write("<script>alert('Evaluación agregada exitosamente');</script>");
        }

        // Evento para actualizar una evaluación de desempeño
        protected void btnActualizarEvaluacion_Click(object sender, EventArgs e)
        {
            // Lógica para actualizar una evaluación
            string evaluacionID = txtEvaluacionID.Value;
            string fechaEvaluacionActualizar = txtFechaEvaluacionActualizar.Value;
            string comentariosActualizar = txtComentariosActualizar.Value;
            string puntuacionActualizar = txtPuntuacionActualizar.Value;

            // Simulación de actualización (aquí va la lógica para actualizar en la base de datos)
            // Ejemplo: ActualizarEvaluacion(evaluacionID, fechaEvaluacionActualizar, comentariosActualizar, puntuacionActualizar);

            // Mostrar mensaje de éxito o redirigir según sea necesario
            Response.Write("<script>alert('Evaluación actualizada exitosamente');</script>");
        }

        // Evento para eliminar una evaluación de desempeño
        protected void btnEliminarEvaluacion_Click(object sender, EventArgs e)
        {
            // Lógica para eliminar una evaluación
            string evaluacionIDEliminar = txtEvaluacionIDEliminar.Value;

            // Simulación de eliminación (aquí va la lógica para eliminar en la base de datos)
            // Ejemplo: EliminarEvaluacion(evaluacionIDEliminar);

            // Mostrar mensaje de éxito o redirigir según sea necesario
            Response.Write("<script>alert('Evaluación eliminada exitosamente');</script>");
        }

        // Evento para redirigir a la página de gestión de vacaciones
        protected void btnPagGestionVacaciones_Click(object sender, EventArgs e)
        {
            // Redirigir a la página de gestión de vacaciones
            Response.Redirect("GestionVacaciones.aspx");
        }
    }
}
