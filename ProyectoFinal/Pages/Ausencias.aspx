<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ausencias.aspx.cs" Inherits="ProyectoFinal.Pages.Ausencias" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gestión de Ausencias</title>
    <link rel="stylesheet" type="text/css" href="Styles/styles.css" />

</head>
<body>

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
    <form id="form1" runat="server">
        <h2>Gestión de Ausencias</h2>

        <!-- Formulario para Agregar/Actualizar -->
        <fieldset>
            <legend>Datos de la Ausencia</legend>
            <label for="txtIDAusencia">ID Ausencia:</label>
            <asp:TextBox ID="txtIDAusencia" runat="server" /><br />
            <label for="txtIDEmpleado">ID Empleado:</label>
            <asp:TextBox ID="txtIDEmpleado" runat="server" /><br />
            <label for="txtFechaInicio">Fecha Inicio:</label>
            <asp:TextBox ID="txtFechaInicio" runat="server" TextMode="Date" /><br />
            <label for="txtFechaFin">Fecha Fin:</label>
            <asp:TextBox ID="txtFechaFin" runat="server" TextMode="Date" /><br />
            <label for="txtTipoAusencia">Tipo de Ausencia:</label>
            <asp:TextBox ID="txtTipoAusencia" runat="server" /><br />
            <label for="txtMotivo">Motivo:</label>
            <asp:TextBox ID="txtMotivo" runat="server" TextMode="MultiLine" /><br />
            <asp:Button ID="btnAgregar" Text="Agregar" OnClick="btnAgregar_Click" runat="server" />
            <asp:Button ID="btnActualizar" Text="Actualizar" OnClick="btnActualizar_Click" runat="server" />
        </fieldset>

        <!-- Botón para Eliminar -->
        <fieldset>
            <legend>Eliminar Ausencia</legend>
            <label for="txtEliminarIDAusencia">ID Ausencia:</label>
            <asp:TextBox ID="txtEliminarIDAusencia" runat="server" /><br />
            <asp:Button ID="btnEliminar" Text="Eliminar" OnClick="btnEliminar_Click" runat="server" />
        </fieldset>

        <h3>Listado de Empleados</h3>
        <asp:GridView ID="gvEmpleados" AutoGenerateColumns="true" runat="server" />

<asp:Button ID="btnDescargarPDFAusencias" runat="server" Text="Descargar Ausencias en PDF" OnClick="btnDescargarPDFAusencias_Click" />

        <!-- Listado de Ausencias -->
        <h3>Listado de Ausencias</h3>
        <asp:GridView ID="gvAusencias" AutoGenerateColumns="true" runat="server" />
    </form>
</body>
</html>
