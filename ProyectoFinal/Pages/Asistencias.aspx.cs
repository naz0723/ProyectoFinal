using System;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoFinal.Pages
{
    public partial class Asistencias : System.Web.UI.Page
    {
        private readonly string connectionString = "Data Source=DESKTOP-8VM77JH\\UNIVERSIDAD;Initial Catalog=ProyectoFinal;Integrated Security=True;";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarAsistencias();
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
            }
        }


        private void CargarAsistencias()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spObtenerAsistencias", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvAsistencias.DataSource = dt;
                gvAsistencias.DataBind();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAgregarAsistencia", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@ID_Empleado", int.Parse(txtIDEmpleado.Text));
                cmd.Parameters.AddWithValue("@Fecha", DateTime.Parse(txtFecha.Text));
                cmd.Parameters.AddWithValue("@Hora_Entrada", TimeSpan.Parse(txtHoraEntrada.Text));
                cmd.Parameters.AddWithValue("@Hora_Salida", TimeSpan.Parse(txtHoraSalida.Text));
                cmd.Parameters.AddWithValue("@Estado", txtEstado.Text);
                cmd.Parameters.AddWithValue("@Observaciones", txtObservaciones.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                CargarAsistencias();
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spActualizarAsistencia", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@ID_Asistencia", int.Parse(txtIDAsistencia.Text));
                cmd.Parameters.AddWithValue("@Hora_Salida", TimeSpan.Parse(txtHoraSalida.Text));
                cmd.Parameters.AddWithValue("@Estado", txtEstado.Text);
                cmd.Parameters.AddWithValue("@Observaciones", txtObservaciones.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                CargarAsistencias();
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spEliminarAsistencia", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@ID_Asistencia", int.Parse(txtEliminarIDAsistencia.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
                CargarAsistencias();
            }
        }
    }
}
