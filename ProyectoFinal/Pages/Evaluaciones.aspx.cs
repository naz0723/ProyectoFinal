using System;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoFinal.Pages
{
    public partial class Evaluaciones : System.Web.UI.Page
    {
        private readonly string connectionString = "Data Source=DESKTOP-8VM77JH\\UNIVERSIDAD;Initial Catalog=ProyectoFinal;Integrated Security=True;";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarEvaluaciones();
                CargarEmpleados();
            }
        }

        private void CargarEmpleados()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spObtenerEmpleados", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvEmpleados.DataSource = dt;
                gvEmpleados.DataBind();
            }
        }


        private void CargarEvaluaciones()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spObtenerEvaluaciones", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvEvaluaciones.DataSource = dt;
                gvEvaluaciones.DataBind();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAgregarEvaluacion", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@ID_Empleado", int.Parse(txtIDEmpleado.Text));
                cmd.Parameters.AddWithValue("@Fecha_Evaluacion", DateTime.Parse(txtFechaEvaluacion.Text));
                cmd.Parameters.AddWithValue("@Comentarios", txtComentarios.Text);
                cmd.Parameters.AddWithValue("@Puntuacion", int.Parse(txtPuntuacion.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
                CargarEvaluaciones();
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spActualizarEvaluacion", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@ID_Evaluacion", int.Parse(txtIDEvaluacion.Text));
                cmd.Parameters.AddWithValue("@Comentarios", txtComentarios.Text);
                cmd.Parameters.AddWithValue("@Puntuacion", int.Parse(txtPuntuacion.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
                CargarEvaluaciones();
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spEliminarEvaluacion", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@ID_Evaluacion", int.Parse(txtEliminarIDEvaluacion.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
                CargarEvaluaciones();
            }
        }
    }
}
