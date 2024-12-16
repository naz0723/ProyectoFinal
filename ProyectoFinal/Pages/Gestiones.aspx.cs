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
    public partial class Gestiones : System.Web.UI.Page
    {
        private readonly string connectionString = "Data Source=DESKTOP-8VM77JH\\UNIVERSIDAD;Initial Catalog=ProyectoFinal;Integrated Security=True;";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGestiones();
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

        private void CargarGestiones()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spObtenerGestiones", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvGestiones.DataSource = dt;
                gvGestiones.DataBind();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAgregarGestion", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@ID_Empleado", int.Parse(txtIDEmpleado.Text));
                cmd.Parameters.AddWithValue("@Fecha_Inicio", DateTime.Parse(txtFechaInicio.Text));
                cmd.Parameters.AddWithValue("@Fecha_Fin", DateTime.Parse(txtFechaFin.Text));
                cmd.Parameters.AddWithValue("@Tipo", ddlTipo.SelectedValue);
                cmd.Parameters.AddWithValue("@Motivo", txtMotivo.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                CargarGestiones();
                Response.Write("<script>alert('Gestion agregada exitosamente.');</script>");
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spActualizarGestion", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@ID_Gestion", int.Parse(txtIDGestion.Text));
                cmd.Parameters.AddWithValue("@Fecha_Fin", DateTime.Parse(txtFechaFin.Text));
                cmd.Parameters.AddWithValue("@Motivo", txtMotivo.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                CargarGestiones();
                Response.Write("<script>alert('Gestion actualizada exitosamente.');</script>");
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spEliminarGestion", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@ID_Gestion", int.Parse(txtEliminarIDGestion.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
                CargarGestiones();
                Response.Write("<script>alert('Gestion eliminada exitosamente.');</script>");
            }
     
        }

        protected void btnDescargarPDFGestiones_Click(object sender, EventArgs e)
        {
            string folderPath = Server.MapPath("~/Reportes");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string filePath = Path.Combine(folderPath, "Gestiones.pdf");

            using (var writer = new PdfWriter(filePath))
            {
                using (var pdf = new PdfDocument(writer))
                {
                    var document = new Document(pdf);
                    document.Add(new Paragraph("Reporte de Gestiones"));

                    foreach (GridViewRow row in gvGestiones.Rows)
                    {
                        document.Add(new Paragraph($"ID Gestión: {row.Cells[0].Text}"));
                        document.Add(new Paragraph($"ID Empleado: {row.Cells[1].Text}"));
                        document.Add(new Paragraph($"Fecha Inicio: {row.Cells[2].Text}"));
                        document.Add(new Paragraph($"Fecha Fin: {row.Cells[3].Text}"));
                        document.Add(new Paragraph($"Tipo: {row.Cells[4].Text}"));
                        document.Add(new Paragraph($"Motivo: {row.Cells[5].Text}"));
                        document.Add(new Paragraph("----------"));
                    }
                }
            }

            // Descarga el archivo PDF
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-Disposition", "attachment; filename=Gestiones.pdf");
            Response.TransmitFile(filePath);
            Response.End();
        }

    }
}
