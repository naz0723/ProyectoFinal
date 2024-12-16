using System;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoFinal.Pages
{
    public partial class EstadosLaborales : System.Web.UI.Page
    {
        private readonly string connectionString = "Data Source=DESKTOP-8VM77JH\\UNIVERSIDAD;Initial Catalog=ProyectoFinal;Integrated Security=True;";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarEstadosLaborales();
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

        private void CargarEstadosLaborales()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spObtenerEstadosLaborales", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvEstadosLaborales.DataSource = dt;
                gvEstadosLaborales.DataBind();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAgregarEstadoLaboral", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@ID_Empleado", int.Parse(txtIDEmpleado.Text));
                cmd.Parameters.AddWithValue("@Estado", txtEstado.Text);
                cmd.Parameters.AddWithValue("@Fecha_Inicio", DateTime.Parse(txtFechaInicio.Text));

                if (string.IsNullOrWhiteSpace(txtFechaFin.Text))
                {
                    cmd.Parameters.AddWithValue("@Fecha_Fin", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Fecha_Fin", DateTime.Parse(txtFechaFin.Text));
                }

                cmd.Parameters.AddWithValue("@AdicionadoPor", txtAdicionadoPor.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                CargarEstadosLaborales();
            }
        }


        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spActualizarEstadoLaboral", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@ID_EstadoLaboral", int.Parse(txtIDEstado.Text));
                cmd.Parameters.AddWithValue("@Estado", txtEstado.Text);

                // Manejo condicional del parámetro @Fecha_Fin
                if (string.IsNullOrWhiteSpace(txtFechaFin.Text))
                {
                    cmd.Parameters.AddWithValue("@Fecha_Fin", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Fecha_Fin", DateTime.Parse(txtFechaFin.Text));
                }

                cmd.Parameters.AddWithValue("@ModificadoPor", txtAdicionadoPor.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                CargarEstadosLaborales();
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spEliminarEstadoLaboral", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@ID_EstadoLaboral", int.Parse(txtEliminarIDEstado.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
                CargarEstadosLaborales();
            }
        }
    }
}
