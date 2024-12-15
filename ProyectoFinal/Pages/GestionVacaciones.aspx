<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GestionVacaciones.aspx.cs" Inherits="ProyectoFinal.Pages.GestionVacaciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Gestión de Vacaciones, Permisos y Licencias</title>
<link type="text/css" rel="stylesheet" href="../Styles/Estilos.css" />
</head>
<body>
    <form id="formGestionVacaciones" runat="server">
        <div class="container">
            <h2>Gestión de Vacaciones, Permisos y Licencias</h2>

            <!-- Formulario para agregar una vacación, permiso o licencia -->
            <div class="form-section">
                <h3>Agregar Vacación, Permiso o Licencia</h3>
                <label for="txtEmpleadoID">ID del Empleado:</label>
                <input type="number" id="txtEmpleadoID" runat="server" />

                <label for="txtFechaInicio">Fecha de Inicio:</label>
                <input type="date" id="txtFechaInicio" runat="server" />

                <label for="txtFechaFin">Fecha de Fin:</label>
                <input type="date" id="txtFechaFin" runat="server" />

                <label for="ddlTipo">Tipo:</label>
                <select id="ddlTipo" runat="server">
                    <option value="Vacación">Vacación</option>
                    <option value="Permiso">Permiso</option>
                    <option value="Licencia">Licencia</option>
                </select>

                <label for="txtMotivo">Motivo:</label>
                <textarea id="txtMotivo" runat="server"></textarea>

                <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
            </div>

            <!-- Formulario para actualizar una vacación, permiso o licencia -->
            <div class="form-section">
                <h3>Actualizar Vacación, Permiso o Licencia</h3>
                <label for="txtGestionIDActualizar">ID de Gestión:</label>
                <input type="number" id="txtGestionIDActualizar" runat="server" />

                <label for="txtFechaInicioActualizar">Nueva Fecha de Inicio:</label>
                <input type="date" id="txtFechaInicioActualizar" runat="server" />

                <label for="txtFechaFinActualizar">Nueva Fecha de Fin:</label>
                <input type="date" id="txtFechaFinActualizar" runat="server" />

                <label for="ddlTipoActualizar">Nuevo Tipo:</label>
                <select id="ddlTipoActualizar" runat="server">
                    <option value="Vacación">Vacación</option>
                    <option value="Permiso">Permiso</option>
                    <option value="Licencia">Licencia</option>
                </select>

                <label for="txtMotivoActualizar">Nuevo Motivo:</label>
                <textarea id="txtMotivoActualizar" runat="server"></textarea>

                <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
            </div>

            <!-- Formulario para eliminar una vacación, permiso o licencia -->
            <div class="form-section">
                <h3>Eliminar Vacación, Permiso o Licencia</h3>
                <label for="txtGestionIDEliminar">ID de Gestión:</label>
                <input type="number" id="txtGestionIDEliminar" runat="server" />

                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
        </div>
    </form>
</body>
</html>

