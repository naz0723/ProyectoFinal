using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace ProyectoFinal.App_code
{
    public class clEvaluacionDesempeno
    {
        public static DatabaseHelper dh = new DatabaseHelper();

        /// <summary>
        /// Este método agrega una nueva evaluación de desempeño utilizando el procedimiento almacenado sp_CrearEvaluacionDesempeno.
        /// </summary>
        public static bool AgregarEvaluacionDesempeno(int empleadoID, DateTime fechaEvaluacion, string comentarios, int puntuacion)
        {
            try
            {
                string query = "sp_CrearEvaluacionDesempeno";

                SqlParameter[] sqlParameters = new SqlParameter[]
                {
            new SqlParameter("@EmpleadoID", SqlDbType.Int) { Value = empleadoID },
            new SqlParameter("@FechaEvaluacion", SqlDbType.Date) { Value = fechaEvaluacion },
            new SqlParameter("@Comentarios", SqlDbType.NVarChar, 1000) { Value = comentarios },
            new SqlParameter("@Puntuacion", SqlDbType.Int) { Value = puntuacion }
                };

                int rowsAffected = dh.ExecuteNonQuery(query, sqlParameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                dh.LogError(ex);
                return false;
            }
        }

        /// <summary>
        /// Este método actualiza una evaluación de desempeño existente.
        /// </summary>
        public static bool ActualizarEvaluacionDesempeno(int evaluacionID, DateTime fechaEvaluacion, string comentarios, int puntuacion)
        {
            try
            {
                string query = "sp_ActualizarEvaluacionDesempeno";

                SqlParameter[] sqlParameters = new SqlParameter[]
                {
            new SqlParameter("@EvaluacionID", SqlDbType.Int) { Value = evaluacionID },
            new SqlParameter("@FechaEvaluacion", SqlDbType.Date) { Value = fechaEvaluacion },
            new SqlParameter("@Comentarios", SqlDbType.NVarChar, 1000) { Value = comentarios },
            new SqlParameter("@Puntuacion", SqlDbType.Int) { Value = puntuacion }
                };

                int rowsAffected = dh.ExecuteNonQuery(query, sqlParameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                dh.LogError(ex);
                return false;
            }
        }


        /// <summary>
        /// Este método elimina una evaluación de desempeño.
        /// </summary>
        public static bool EliminarEvaluacionDesempeno(int evaluacionID)
        {
            try
            {
                string query = "sp_EliminarEvaluacionDesempeno";

                SqlParameter[] sqlParameters = new SqlParameter[]
                {
            new SqlParameter("@EvaluacionID", SqlDbType.Int) { Value = evaluacionID }
                };

                int rowsAffected = dh.ExecuteNonQuery(query, sqlParameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                dh.LogError(ex);
                return false;
            }
        }

    }
}
    