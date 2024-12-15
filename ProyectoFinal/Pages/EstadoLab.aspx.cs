using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal.Pages
{
    public partial class EstadoLab : System.Web.UI.Page
    {
        // Cadena de conexión a la base de datos
        private string connectionString = "Data Source=TU_SERVIDOR;Initial Catalog=TU_BASE_DE_DATOS;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            // Código que se ejecuta al cargar la página (si es necesario)
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            // Lógica para agregar un estado laboral
            int empleadoID = int.Parse(txtEmpleadoID.Value);
            string estado = txtEstado.Value;
            DateTime fechaInicio = DateTime.Parse(txtFechaInicio.Value);
            DateTime fechaFin = DateTime.Parse(txtFechaFin.Value);
            string adicionadoPor = txtAdicionadoPor.Value;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO EstadosLaborales (EmpleadoID, Estado, FechaInicio, FechaFin, AdicionadoPor) " +
                                   "VALUES (@EmpleadoID, @Estado, @FechaInicio, @FechaFin, @AdicionadoPor)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmpleadoID", empleadoID);
                        command.Parameters.AddWithValue("@Estado", estado);
                        command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                        command.Parameters.AddWithValue("@FechaFin", fechaFin);
                        command.Parameters.AddWithValue("@AdicionadoPor", adicionadoPor);

                        connection.Open();
                        command.ExecuteNonQuery();
                        Response.Write("<script>alert('Estado laboral agregado exitosamente.');</script>");
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error al agregar el estado laboral: " + ex.Message + "');</script>");
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            // Lógica para actualizar un estado laboral
            int estadoLaboralID = int.Parse(txtEstadoLaboralID.Value);
            int empleadoID = int.Parse(txtEmpleadoID.Value);
            string estado = txtEstado.Value;
            DateTime fechaInicio = DateTime.Parse(txtFechaInicio.Value);
            DateTime fechaFin = DateTime.Parse(txtFechaFin.Value);
            string modificadoPor = txtModificadoPor.Value;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE EstadosLaborales SET EmpleadoID = @EmpleadoID, Estado = @Estado, " +
                                   "FechaInicio = @FechaInicio, FechaFin = @FechaFin, ModificadoPor = @ModificadoPor " +
                                   "WHERE EstadoLaboralID = @EstadoLaboralID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EstadoLaboralID", estadoLaboralID);
                        command.Parameters.AddWithValue("@EmpleadoID", empleadoID);
                        command.Parameters.AddWithValue("@Estado", estado);
                        command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                        command.Parameters.AddWithValue("@FechaFin", fechaFin);
                        command.Parameters.AddWithValue("@ModificadoPor", modificadoPor);

                        connection.Open();
                        command.ExecuteNonQuery();
                        Response.Write("<script>alert('Estado laboral actualizado exitosamente.');</script>");
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error al actualizar el estado laboral: " + ex.Message + "');</script>");
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            // Lógica para eliminar un estado laboral
            int estadoLaboralID = int.Parse(txtEstadoLaboralID.Value);

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM EstadosLaborales WHERE EstadoLaboralID = @EstadoLaboralID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EstadoLaboralID", estadoLaboralID);

                        connection.Open();
                        command.ExecuteNonQuery();
                        Response.Write("<script>alert('Estado laboral eliminado exitosamente.');</script>");
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error al eliminar el estado laboral: " + ex.Message + "');</script>");
            }
        }

        protected void btnPagControlHoras_Click(object sender, EventArgs e)
        {
            // Redirige a la página de Control de Horario
            Response.Redirect("ControlHoras.aspx");
        }
    }
}