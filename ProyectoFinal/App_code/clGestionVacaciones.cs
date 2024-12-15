using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace ProyectoFinal.App_code
{
    public class clGestionVacaciones
    {
        public static DatabaseHelper dh = new DatabaseHelper();

        /// <summary>
        /// Este método agrega una nueva vacación, permiso o licencia utilizando el procedimiento almacenado sp_CrearGestionVacaciones.
        /// </summary>
        public static bool AgregarVacacionPermisoLicencia(int empleadoID, DateTime fechaInicio, DateTime fechaFin, string tipo, string motivo)
        {
            try
            {
                string query = "sp_CrearGestionVacacionesPermisosLicencias";

                SqlParameter[] sqlParameters = new SqlParameter[]
                {
            new SqlParameter("@EmpleadoID", SqlDbType.Int) { Value = empleadoID },
            new SqlParameter("@FechaInicio", SqlDbType.Date) { Value = fechaInicio },
            new SqlParameter("@FechaFin", SqlDbType.Date) { Value = fechaFin },
            new SqlParameter("@Tipo", SqlDbType.NVarChar, 50) { Value = tipo },  // Tipo puede ser 'Vacación', 'Permiso' o 'Licencia'
            new SqlParameter("@Motivo", SqlDbType.NVarChar, 255) { Value = motivo }
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
        /// Este método actualiza la vacación, permiso o licencia en la base de datos.
        /// </summary>
        public static bool ActualizarVacacionPermisoLicencia(int gestionID, DateTime fechaInicio, DateTime fechaFin, string tipo, string motivo)
        {
            try
            {
                string query = "sp_ActualizarGestionVacacionesPermisosLicencias";

                SqlParameter[] sqlParameters = new SqlParameter[]
                {
            new SqlParameter("@GestionID", SqlDbType.Int) { Value = gestionID },
            new SqlParameter("@FechaInicio", SqlDbType.Date) { Value = fechaInicio },
            new SqlParameter("@FechaFin", SqlDbType.Date) { Value = fechaFin },
            new SqlParameter("@Tipo", SqlDbType.NVarChar, 50) { Value = tipo },
            new SqlParameter("@Motivo", SqlDbType.NVarChar, 255) { Value = motivo }
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
        /// Este método elimina una vacación, permiso o licencia.
        /// </summary>
        public static bool EliminarVacacionPermisoLicencia(int gestionID)
        {
            try
            {
                string query = "sp_EliminarGestionVacacionesPermisosLicencias";

                SqlParameter[] sqlParameters = new SqlParameter[]
                {
            new SqlParameter("@GestionID", SqlDbType.Int) { Value = gestionID }
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
    