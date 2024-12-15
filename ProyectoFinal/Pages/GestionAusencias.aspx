<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GestionAusencias.aspx.cs" Inherits="ProyectoFinal.Pages.GestionAusencias" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   <title>Gestión de Ausencias</title>
<link type="text/css" rel="stylesheet" href="../Styles/Estilos.css" />
</head>
<body>
    <form id="formGestionAusencias" runat="server">
        <div class="container">
            <h2>Gestión de Ausencias</h2>

            <!-- Formulario para agregar una ausencia -->
            <div class="form-section">
                <h3>Agregar Ausencia</h3>
                <label for="txtEmpleadoID">ID del Empleado:</label>
                <input type="number" id="txtEmpleadoID" runat="server" />

                <label for="txtFechaInicio">Fecha de Inicio:</label>
                <input type="date" id="txtFechaInicio" runat="server" />

                <label for="txtFechaFin">Fecha de Fin:</label>
                <input type="date" id="txtFechaFin" runat="server" />

                <label for="txtTipoAusencia">Tipo de Ausencia:</label>
                <input type="text" id="txtTipoAusencia" runat="server" />

                <label for="txtMotivo">Motivo:</label>
                <input type="text" id="txtMotivo" runat="server" />
            </div>

            <!-- Formulario para actualizar una ausencia -->
            <div class="form-section">
                <h3>Actualizar Ausencia</h3>
                <label for="txtAusenciaID">ID de la Ausencia:</label>
                <input type="number" id="txtAusenciaID" runat="server" />

                <label for="txtFechaInicioActualizar">Nueva Fecha de Inicio:</label>
                <input type="date" id="txtFechaInicioActualizar" runat="server" />

                <label for="txtFechaFinActualizar">Nueva Fecha de Fin:</label>
                <input type="date" id="txtFechaFinActualizar" runat="server" />

                <label for="txtTipoAusenciaActualizar">Nuevo Tipo de Ausencia:</label>
                <input type="text" id="txtTipoAusenciaActualizar" runat="server" />

                <label for="txtMotivoActualizar">Nuevo Motivo:</label>
                <input type="text" id="txtMotivoActualizar" runat="server" />
            </div>

            <!-- Formulario para eliminar una ausencia -->
            <div class="form-section">
                <h3>Eliminar Ausencia</h3>
                <label for="txtEliminarAusenciaID">ID de la Ausencia:</label>
                <input type="number" id="txtEliminarAusenciaID" runat="server" />
            </div>

            <!-- Botones del CRUD -->
            <div class="form-buttons">
                <asp:Button ID="btnAgregarAusencia" runat="server" Text="Agregar Ausencia" OnClick="btnAgregarAusencia_Click" />
                <asp:Button ID="btnActualizarAusencia" runat="server" Text="Actualizar Ausencia" OnClick="btnActualizarAusencia_Click" />
                <asp:Button ID="btnEliminarAusencia" runat="server" Text="Eliminar Ausencia" OnClick="btnEliminarAusencia_Click" />
                <asp:Button ID="btnPagReportePuntualidad" runat="server" Text="Evaluacion de Reporte de Puntualidad" OnClick="btnPagReportePuntualidad_Click" />
            </div>
        </div>
    </form>
</body>
</html>

