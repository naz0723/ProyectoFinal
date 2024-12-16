<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Gestiones.aspx.cs" Inherits="ProyectoFinal.Pages.Gestiones" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gestión de Vacaciones, Permisos y Licencias</title>
    <link rel="stylesheet" type="text/css" href="Styles/styles.css" />

</head>

    <body>

        <div class="submenu">
        <a href="Empleado.aspx">Gestión de Empleados</a>
        <a href="Asistencias.aspx">Gestión de Asistencias</a>
        <a href="EstadosLaborales.aspx">Gestión de Estados Laborales</a>
        <a href="Evaluaciones.aspx">Gestión de Evaluaciones</a>
        <a href="Ausencias.aspx">Gestión de Ausencias</a>
        <a href="Gestiones.aspx">Gestión de Vacaciones</a>
        <a href="Usuarios.aspx">Gestión de Usuarios</a>
    </div>

    <style>
        .submenu {
            background-color: #f4f4f4;
            padding: 10px;
            text-align: center;
            border-bottom: 1px solid #ddd;
        }
        .submenu a {
            text-decoration: none;
            color: #333;
            margin: 0 15px;
            font-size: 16px;
        }
        .submenu a:hover {
            color: #007bff;
            text-decoration: underline;
        }
    </style>
<body>
    <form id="form1" runat="server">
        <h2>Gestión de Vacaciones, Permisos y Licencias</h2>

        <!-- Formulario para Agregar/Actualizar -->
        <fieldset>
            <legend>Datos de Gestión</legend>
            <label for="txtIDGestion">ID Gestión:</label>
            <asp:TextBox ID="txtIDGestion" runat="server" /><br />
            <label for="txtIDEmpleado">ID Empleado:</label>
            <asp:TextBox ID="txtIDEmpleado" runat="server" /><br />
            <label for="txtFechaInicio">Fecha Inicio:</label>
            <asp:TextBox ID="txtFechaInicio" runat="server" TextMode="Date" /><br />
            <label for="txtFechaFin">Fecha Fin:</label>
            <asp:TextBox ID="txtFechaFin" runat="server" TextMode="Date" /><br />
            <label for="txtTipo">Tipo:</label>
            <asp:DropDownList ID="ddlTipo" runat="server">
                <asp:ListItem Text="Vacación" Value="Vacación"></asp:ListItem>
                <asp:ListItem Text="Permiso" Value="Permiso"></asp:ListItem>
                <asp:ListItem Text="Licencia" Value="Licencia"></asp:ListItem>
            </asp:DropDownList><br />
            <label for="txtMotivo">Motivo:</label>
            <asp:TextBox ID="txtMotivo" runat="server" TextMode="MultiLine" /><br />
            <asp:Button ID="btnAgregar" Text="Agregar" OnClick="btnAgregar_Click" runat="server" />
            <asp:Button ID="btnActualizar" Text="Actualizar" OnClick="btnActualizar_Click" runat="server" />
        </fieldset>

        <!-- Botón para Eliminar -->
        <fieldset>
            <legend>Eliminar Gestión</legend>
            <label for="txtEliminarIDGestion">ID Gestión:</label>
            <asp:TextBox ID="txtEliminarIDGestion" runat="server" /><br />
            <asp:Button ID="btnEliminar" Text="Eliminar" OnClick="btnEliminar_Click" runat="server" />
        </fieldset>

                <h3>Listado de Empleados</h3>
<asp:GridView ID="gvEmpleados" AutoGenerateColumns="true" runat="server" />

        <asp:Button ID="btnDescargarPDFGestiones" runat="server" Text="Descargar Gestiones en PDF" OnClick="btnDescargarPDFGestiones_Click" />


        <!-- Listado de Gestiones -->
        <h3>Listado de Gestiones</h3>
        <asp:GridView ID="gvGestiones" AutoGenerateColumns="true" runat="server" />
    </form>
</body>
</html>

