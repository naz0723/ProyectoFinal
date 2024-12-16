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
    public partial class Ausencias : System.Web.UI.Page
    {
        private readonly string connectionString = "Data Source=DESKTOP-8VM77JH\\UNIVERSIDAD;Initial Catalog=ProyectoFinal;Integrated Security=True;";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarAusencias();
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

        private void CargarAusencias()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spObtenerAusencias", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvAusencias.DataSource = dt;
                gvAusencias.DataBind();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAgregarAusencia", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@ID_Empleado", int.Parse(txtIDEmpleado.Text));
                cmd.Parameters.AddWithValue("@Fecha_Inicio", DateTime.Parse(txtFechaInicio.Text));
                cmd.Parameters.AddWithValue("@Fecha_Fin", DateTime.Parse(txtFechaFin.Text));
                cmd.Parameters.AddWithValue("@Tipo_Ausencia", txtTipoAusencia.Text);
                cmd.Parameters.AddWithValue("@Motivo", txtMotivo.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                CargarAusencias();
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spActualizarAusencia", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@ID_Ausencia", int.Parse(txtIDAusencia.Text));
                cmd.Parameters.AddWithValue("@Fecha_Fin", DateTime.Parse(txtFechaFin.Text));
                cmd.Parameters.AddWithValue("@Motivo", txtMotivo.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                CargarAusencias();
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spEliminarAusencia", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@ID_Ausencia", int.Parse(txtEliminarIDAusencia.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
                CargarAusencias();
            }
        }

        protected void btnDescargarPDFAusencias_Click(object sender, EventArgs e)
        {
            string folderPath = Server.MapPath("~/Reportes");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string filePath = Path.Combine(folderPath, "Ausencias.pdf");

            using (var writer = new PdfWriter(filePath))
            {
                using (var pdf = new PdfDocument(writer))
                {
                    var document = new Document(pdf);
                    document.Add(new Paragraph("Reporte de Ausencias"));

                    foreach (GridViewRow row in gvAusencias.Rows)
                    {
                        document.Add(new Paragraph($"ID Empleado: {row.Cells[0].Text}"));
                        document.Add(new Paragraph($"Fecha Inicio: {row.Cells[1].Text}"));
                        document.Add(new Paragraph($"Fecha Fin: {row.Cells[2].Text}"));
                        document.Add(new Paragraph($"Tipo de Ausencia: {row.Cells[3].Text}"));
                        document.Add(new Paragraph($"Motivo: {row.Cells[4].Text}"));
                        document.Add(new Paragraph("----------"));
                    }
                }
            }

            // Descarga el archivo PDF
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-Disposition", "attachment; filename=Ausencias.pdf");
            Response.TransmitFile(filePath);
            Response.End();
        }

    }
}
