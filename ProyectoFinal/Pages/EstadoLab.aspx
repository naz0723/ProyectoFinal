<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EstadoLab.aspx.cs" Inherits="ProyectoFinal.Pages.EstadoLab" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   <title>Gestión de Estados Laborales</title>
    <link rel="stylesheet" type="text/css" href="../Styles/Estilos.css" />
</head>
<body>
    <form id="formEstadoLab" runat="server">
        <div class="container">
            <h2>Gestión de Estados Laborales</h2>

            <!-- Campos del formulario -->
            <div class="form-section">
                <label for="txtEstadoLaboralID">ID del Estado Laboral:</label>
                <input type="text" id="txtEstadoLaboralID" runat="server" />

                <label for="txtEmpleadoID">ID del Empleado:</label>
                <input type="text" id="txtEmpleadoID" runat="server" />

                <label for="txtEstado">Estado:</label>
                <input type="text" id="txtEstado" runat="server" />

                <label for="txtFechaInicio">Fecha de Inicio:</label>
                <input type="date" id="txtFechaInicio" runat="server" />

                <label for="txtFechaFin">Fecha de Fin:</label>
                <input type="date" id="txtFechaFin" runat="server" />

                <label for="txtAdicionadoPor">Añadido por:</label>
                <input type="text" id="txtAdicionadoPor" runat="server" />

                <label for="txtModificadoPor">Modificado por:</label>
                <input type="text" id="txtModificadoPor" runat="server" />
            </div>

            <!-- Botones del CRUD -->
            <div class="form-buttons">
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar Estado" OnClick="btnAgregar_Click" />
                <asp:Button ID="btnActualizar" runat="server" Text="Actualizar Estado" OnClick="btnActualizar_Click" />
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar Estado" OnClick="btnEliminar_Click" />
                <asp:Button ID="btnPagControlHoras" runat="server" Text="Control de Horario" OnClick="btnPagControlHoras_Click" />
            </div>
        </div>
    </form>
</body>
</html>
