<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Asistencias.aspx.cs" Inherits="ProyectoFinal.Pages.Asistencias" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gestión de Asistencias</title>
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
        <h2>Gestión de Asistencias</h2>

         <!-- Formulario para Agregar/Actualizar -->
        <fieldset>
            <legend>Datos de Asistencia</legend>
            <label for="txtIDAsistencia">ID:</label>
            <asp:TextBox ID="txtIDAsistencia" runat="server" /><br />
            <label for="txtIDEmpleado">ID Empleado:</label>
            <asp:TextBox ID="txtIDEmpleado" runat="server" /><br />
            <label for="txtFecha">Fecha:</label>
            <asp:TextBox ID="txtFecha" runat="server" TextMode="Date" /><br />
            <label for="txtHoraEntrada">Hora Entrada:</label>
            <asp:TextBox ID="txtHoraEntrada" runat="server" TextMode="Time" /><br />
            <label for="txtHoraSalida">Hora Salida:</label>
            <asp:TextBox ID="txtHoraSalida" runat="server" TextMode="Time" /><br />
            <label for="txtEstado">Estado:</label>
            <asp:TextBox ID="txtEstado" runat="server" /><br />
            <label for="txtObservaciones">Observaciones:</label>
            <asp:TextBox ID="txtObservaciones" runat="server" /><br />
            <asp:Button ID="btnAgregar" Text="Agregar" OnClick="btnAgregar_Click" runat="server" />
            <asp:Button ID="btnActualizar" Text="Actualizar" OnClick="btnActualizar_Click" runat="server" />
        </fieldset>

        <!-- Botón para Eliminar -->
        <fieldset>
            <legend>Eliminar Asistencia</legend>
            <label for="txtEliminarIDAsistencia">ID Asistencia:</label>
            <asp:TextBox ID="txtEliminarIDAsistencia" runat="server" /><br />
            <asp:Button ID="btnEliminar" Text="Eliminar" OnClick="btnEliminar_Click" runat="server" />
        </fieldset>

        <!-- Listado de Asistencias -->
        <h3>Listado de Asistencias</h3>
        <asp:GridView ID="gvAsistencias" AutoGenerateColumns="true" runat="server" />
    </form>
</body>
</html>

