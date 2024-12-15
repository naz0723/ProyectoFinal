﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace ProyectoFinal.App_code
{
    public class clReportePuntualidad
    {
        public static DatabaseHelper dh = new DatabaseHelper();

        /// <summary>
        /// Este método agrega un nuevo dueño utilizando el procedimiento almacenado sp_CrearDueño.
        /// </summary>

        public static bool AgregarReporte(int empleadoID, int mes, int año, int diasTarde, int diasCumplidos, float horasExtras)
        {
            try
            {
                string query = "sp_CrearReportePuntualidad";

                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                new SqlParameter("@EmpleadoID", SqlDbType.Int) { Value = empleadoID },
                new SqlParameter("@Mes", SqlDbType.Int) { Value = mes },
                new SqlParameter("@Año", SqlDbType.Int) { Value = año },
                new SqlParameter("@DiasTarde", SqlDbType.Int) { Value = diasTarde },
                new SqlParameter("@DiasCumplidos", SqlDbType.Int) { Value = diasCumplidos },
                new SqlParameter("@HorasExtras", SqlDbType.Float) { Value = horasExtras }
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

        public static bool ActualizarReporte(int reporteID, int diasTarde, int diasCumplidos, float horasExtras)
        {
            try
            {
                string query = "sp_ActualizarReportePuntualidad";

                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                new SqlParameter("@ReporteID", SqlDbType.Int) { Value = reporteID },
                new SqlParameter("@DiasTarde", SqlDbType.Int) { Value = diasTarde },
                new SqlParameter("@DiasCumplidos", SqlDbType.Int) { Value = diasCumplidos },
                new SqlParameter("@HorasExtras", SqlDbType.Float) { Value = horasExtras }
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

        public static bool EliminarReporte(int reporteID)
        {
            try
            {
                string query = "sp_EliminarReportePuntualidad";

                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                new SqlParameter("@ReporteID", SqlDbType.Int) { Value = reporteID }
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
