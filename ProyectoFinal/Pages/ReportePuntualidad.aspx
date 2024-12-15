<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportePuntualidad.aspx.cs" Inherits="ProyectoFinal.Pages.ReportePuntualidad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   <title>Gestión de Reportes de Puntualidad</title>
<link type="text/css" rel="stylesheet" href="../Styles/Estilos.css" />
</head>
<body>
    <form id="formGestionReportes" runat="server">
        <div class="container">
            <h2>Gestión de Reportes de Puntualidad</h2>

            <!-- Formulario para agregar un reporte -->
            <div class="form-section">
                <h3>Agregar Reporte de Puntualidad</h3>
                <label for="txtEmpleadoID">ID del Empleado:</label>
                <input type="number" id="txtEmpleadoID" runat="server" />

                <label for="txtMes">Mes:</label>
                <input type="number" id="txtMes" runat="server" />

                <label for="txtAño">Año:</label>
                <input type="number" id="txtAño" runat="server" />

                <label for="txtDiasTarde">Días Tarde:</label>
                <input type="number" id="txtDiasTarde" runat="server" />

                <label for="txtDiasCumplidos">Días Cumplidos:</label>
                <input type="number" id="txtDiasCumplidos" runat="server" />

                <label for="txtHorasExtras">Horas Extras:</label>
                <input type="number" step="0.1" id="txtHorasExtras" runat="server" />

                <!-- Botón de agregar -->
                <asp:Button ID="btnAgregarReporte" runat="server" Text="Agregar Reporte" OnClick="btnAgregarReporte_Click" />
            </div>

            <!-- Formulario para actualizar un reporte -->
            <div class="form-section">
                <h3>Actualizar Reporte de Puntualidad</h3>
                <label for="txtReporteID">ID del Reporte:</label>
                <input type="number" id="txtReporteID" runat="server" />

                <label for="txtDiasTardeActualizar">Nuevo Días Tarde:</label>
                <input type="number" id="txtDiasTardeActualizar" runat="server" />

                <label for="txtDiasCumplidosActualizar">Nuevo Días Cumplidos:</label>
                <input type="number" id="txtDiasCumplidosActualizar" runat="server" />

                <label for="txtHorasExtrasActualizar">Nuevas Horas Extras:</label>
                <input type="number" step="0.1" id="txtHorasExtrasActualizar" runat="server" />

                <!-- Botón de actualizar -->
                <asp:Button ID="btnActualizarReporte" runat="server" Text="Actualizar Reporte" OnClick="btnActualizarReporte_Click" />
            </div>

            <!-- Formulario para eliminar un reporte -->
            <div class="form-section">
                <h3>Eliminar Reporte de Puntualidad</h3>
                <label for="txtEliminarReporteID">ID del Reporte:</label>
                <input type="number" id="txtEliminarReporteID" runat="server" />

                <!-- Botón de eliminar -->
                <asp:Button ID="btnEliminarReporte" runat="server" Text="Eliminar Reporte" OnClick="btnEliminarReporte_Click" />
            </div>

            <!-- Botón adicional para gestionar evaluaciones -->
            <div class="form-section">
                <asp:Button ID="btnPagEvaluacionDesempeno" runat="server" Text="Gestionar Evaluaciones de Desempeño" OnClick="btnPagEvaluacionDesempeno_Click" />
            </div>
        </div>
    </form>
</body>
</html>

