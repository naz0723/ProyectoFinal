using System;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoFinal.Pages
{
    public partial class Usuarios : System.Web.UI.Page
    {
        private readonly string connectionString = "Data Source=DESKTOP-8VM77JH\\UNIVERSIDAD;Initial Catalog=ProyectoFinal;Integrated Security=True;";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarUsuarios();
            }
        }

        private void CargarUsuarios()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spObtenerUsuarios", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvUsuarios.DataSource = dt;
                gvUsuarios.DataBind();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAgregarUsuario", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@Contraseña", txtContraseña.Text); // Encriptación opcional
                cmd.Parameters.AddWithValue("@Rol", ddlRol.SelectedValue);

                conn.Open();
                cmd.ExecuteNonQuery();
                CargarUsuarios();
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spActualizarUsuario", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@ID_Usuario", int.Parse(txtIDUsuario.Text));
                cmd.Parameters.AddWithValue("@Contraseña", txtContraseña.Text); // Encriptación opcional
                cmd.Parameters.AddWithValue("@Rol", ddlRol.SelectedValue);

                conn.Open();
                cmd.ExecuteNonQuery();
                CargarUsuarios();
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spEliminarUsuario", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@ID_Usuario", int.Parse(txtEliminarIDUsuario.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
                CargarUsuarios();
            }
        }
    }
}
