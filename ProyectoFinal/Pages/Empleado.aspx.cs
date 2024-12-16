using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Web.UI.WebControls;

namespace ProyectoFinal.Pages
{
    public partial class Empleados : System.Web.UI.Page
    {
        private readonly string connectionString = "Data Source=DESKTOP-8VM77JH\\UNIVERSIDAD;Initial Catalog=ProyectoFinal;Integrated Security=True;";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
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

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFechaIngreso.Text))
                {
                    Response.Write("<script>alert('Por favor ingrese una fecha válida para Fecha de Ingreso.');</script>");
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spAgregarEmpleado", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                    cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                    cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Cargo", ddlCargo.SelectedValue);
                    cmd.Parameters.AddWithValue("@Departamento", ddlDepartamento.SelectedValue);
                    cmd.Parameters.AddWithValue("@Salario", decimal.Parse(txtSalario.Text));
                    cmd.Parameters.AddWithValue("@Estado", "Activo");
                    cmd.Parameters.AddWithValue("@Fecha_Nacimiento", DateTime.Parse(txtFechaNacimiento.Text));

                    // Validación y conversión de Fecha_Ingreso
                    DateTime fechaIngreso;
                    if (!DateTime.TryParse(txtFechaIngreso.Text, out fechaIngreso))
                    {
                        Response.Write("<script>alert('Por favor ingrese una fecha válida para Fecha de Ingreso.');</script>");
                        return;
                    }
                    cmd.Parameters.AddWithValue("@Fecha_Ingreso", fechaIngreso);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    CargarEmpleados();

                    Response.Write("<script>alert('Empleado agregado exitosamente.');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write($"<script>alert('Error: {ex.Message}');</script>");
            }
        }




        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spActualizarEmpleado", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@ID_Empleado", int.Parse(txtIDEmpleado.Text));
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Fecha_Ingreso", DateTime.Now);
                cmd.Parameters.AddWithValue("@Cargo", ddlCargo.SelectedValue);
                cmd.Parameters.AddWithValue("@Departamento", ddlDepartamento.SelectedValue);
                cmd.Parameters.AddWithValue("@Salario", decimal.Parse(txtSalario.Text));
                cmd.Parameters.AddWithValue("@Estado", "Activo");
                cmd.Parameters.AddWithValue("@Fecha_Nacimiento", DateTime.Parse(txtFechaNacimiento.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
                CargarEmpleados();

                Response.Write("<script>alert('Empleado actualizado exitosamente.');</script>");
            }
        }

        private void CargarDropDownLists()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Cargar Cargos
                SqlCommand cmdCargo = new SqlCommand("spObtenerCargos", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                SqlDataReader drCargo = cmdCargo.ExecuteReader();
                ddlCargo.DataSource = drCargo;
                ddlCargo.DataTextField = "Cargo"; // Nombre de la columna en la tabla
                ddlCargo.DataValueField = "Cargo";
                ddlCargo.DataBind();
                drCargo.Close();

                // Cargar Departamentos
                SqlCommand cmdDepartamento = new SqlCommand("spObtenerDepartamentos", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                SqlDataReader drDepartamento = cmdDepartamento.ExecuteReader();
                ddlDepartamento.DataSource = drDepartamento;
                ddlDepartamento.DataTextField = "Departamento"; // Nombre de la columna en la tabla
                ddlDepartamento.DataValueField = "Departamento";
                ddlDepartamento.DataBind();
                drDepartamento.Close();
            }

            // Agrega una opción predeterminada (opcional)
            ddlCargo.Items.Insert(0, new System.Web.UI.WebControls.ListItem("Seleccione un Cargo", ""));
            ddlDepartamento.Items.Insert(0, new System.Web.UI.WebControls.ListItem("Seleccione un Departamento", ""));
        }


        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spEliminarEmpleado", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@ID_Empleado", int.Parse(txtEliminarID.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
                CargarEmpleados();

                Response.Write("<script>alert('Empleado Eliminado exitosamente.');</script>");
            }
        }

        protected void btnDescargarPDFEmpleados_Click(object sender, EventArgs e)
        {
            string folderPath = Server.MapPath("~/Reportes");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string filePath = Path.Combine(folderPath, "Empleados.pdf");

            using (var writer = new PdfWriter(filePath))
            {
                using (var pdf = new PdfDocument(writer))
                {
                    var document = new Document(pdf);
                    document.Add(new Paragraph("Reporte de Empleados"));

                    foreach (GridViewRow row in gvEmpleados.Rows)
                    {
                        document.Add(new Paragraph($"Nombre: {row.Cells[0].Text}"));
                        document.Add(new Paragraph($"Apellido: {row.Cells[1].Text}"));
                        document.Add(new Paragraph($"Fecha de Nacimiento: {row.Cells[2].Text}"));
                        document.Add(new Paragraph($"Dirección: {row.Cells[3].Text}"));
                        document.Add(new Paragraph($"Teléfono: {row.Cells[4].Text}"));
                        document.Add(new Paragraph($"Email: {row.Cells[5].Text}"));
                        document.Add(new Paragraph($"Cargo: {row.Cells[6].Text}"));
                        document.Add(new Paragraph($"Departamento: {row.Cells[7].Text}"));
                        document.Add(new Paragraph($"Salario: {row.Cells[8].Text}"));
                        document.Add(new Paragraph($"Fecha de Ingreso: {row.Cells[9].Text}"));
                        document.Add(new Paragraph("----------"));
                    }
                }
            }

            // Descarga el archivo PDF
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-Disposition", "attachment; filename=Empleados.pdf");
            Response.TransmitFile(filePath);
            Response.End();
        }

    }
}
