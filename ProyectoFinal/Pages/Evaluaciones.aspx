<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Evaluaciones.aspx.cs" Inherits="ProyectoFinal.Pages.Evaluaciones" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gestión de Evaluaciones</title>
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
        <h2>Gestión de Evaluaciones</h2>

        <!-- Formulario para Agregar/Actualizar -->
        <fieldset>
            <legend>Datos de la Evaluación</legend>
            <label for="txtIDEvaluacion">ID Evaluación:</label>
            <asp:TextBox ID="txtIDEvaluacion" runat="server" /><br />
            <label for="txtIDEmpleado">ID Empleado:</label>
            <asp:TextBox ID="txtIDEmpleado" runat="server" /><br />
            <label for="txtFechaEvaluacion">Fecha Evaluación:</label>
            <asp:TextBox ID="txtFechaEvaluacion" runat="server" TextMode="Date" /><br />
            <label for="txtComentarios">Comentarios:</label>
            <asp:TextBox ID="txtComentarios" runat="server" TextMode="MultiLine" /><br />
            <label for="txtPuntuacion">Puntuación:</label>
            <asp:TextBox ID="txtPuntuacion" runat="server" TextMode="Number" /><br />
            <asp:Button ID="btnAgregar" Text="Agregar" OnClick="btnAgregar_Click" runat="server" />
            <asp:Button ID="btnActualizar" Text="Actualizar" OnClick="btnActualizar_Click" runat="server" />
        </fieldset>

        <!-- Botón para Eliminar -->
        <fieldset>
            <legend>Eliminar Evaluación</legend>
            <label for="txtEliminarIDEvaluacion">ID Evaluación:</label>
            <asp:TextBox ID="txtEliminarIDEvaluacion" runat="server" /><br />
            <asp:Button ID="btnEliminar" Text="Eliminar" OnClick="btnEliminar_Click" runat="server" />
        </fieldset>

        <h3>Listado de Empleados</h3>
<asp:GridView ID="gvEmpleados" AutoGenerateColumns="true" runat="server" />

        <asp:Button ID="btnDescargarPDFEvaluaciones" runat="server" Text="Descargar Evaluaciones en PDF" OnClick="btnDescargarPDFEvaluaciones_Click" />


        <!-- Listado de Evaluaciones -->
        <h3>Listado de Evaluaciones</h3>
        <asp:GridView ID="gvEvaluaciones" AutoGenerateColumns="true" runat="server" />
    </form>
</body>
</html>
