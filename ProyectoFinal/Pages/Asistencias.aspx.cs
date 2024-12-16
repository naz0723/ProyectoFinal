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
                gvEmpleados.DataSource = dt;
                gvEmpleados.DataBind();
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

        protected void btnDescargarPDFAsistencias_Click(object sender, EventArgs e)
        {
            string folderPath = Server.MapPath("~/Reportes");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string filePath = Path.Combine(folderPath, "Reporte.pdf");

            using (var writer = new PdfWriter(filePath))
            {
                using (var pdf = new PdfDocument(writer))
                {
                    var document = new Document(pdf);
                    document.Add(new Paragraph("Reporte de Asistencias"));

                    foreach (GridViewRow row in gvAsistencias.Rows)
                    {
                        document.Add(new Paragraph($"ID Empleado: {row.Cells[0].Text}"));
                        document.Add(new Paragraph($"Fecha: {row.Cells[1].Text}"));
                        document.Add(new Paragraph($"Hora Entrada: {row.Cells[2].Text}"));
                        document.Add(new Paragraph($"Hora Salida: {row.Cells[3].Text}"));
                        document.Add(new Paragraph($"Estado: {row.Cells[4].Text}"));
                        document.Add(new Paragraph($"Observaciones: {row.Cells[5].Text}"));
                        document.Add(new Paragraph("----------"));
                    }
                }
            }

            // Descarga el archivo PDF
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-Disposition", "attachment; filename=Asistencias.pdf");
            Response.TransmitFile(filePath);
            Response.End();
        }

    }
}
