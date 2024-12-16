<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="ProyectoFinal.Pages.Usuarios" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gestión de Usuarios</title>
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
        <h2>Gestión de Usuarios</h2>

        <!-- Formulario para Agregar/Actualizar -->
        <fieldset>
            <legend>Datos del Usuario</legend>
            <label for="txtIDUsuario">ID Usuario:</label>
            <asp:TextBox ID="txtIDUsuario" runat="server" /><br />
            <label for="txtUsuario">Usuario:</label>
            <asp:TextBox ID="txtUsuario" runat="server" /><br />
            <label for="txtContraseña">Contraseña:</label>
            <asp:TextBox ID="txtContraseña" runat="server" TextMode="Password" /><br />
            <label for="ddlRol">Rol:</label>
            <asp:DropDownList ID="ddlRol" runat="server">
                <asp:ListItem Text="Admin" Value="Admin"></asp:ListItem>
                <asp:ListItem Text="Empleado" Value="Empleado"></asp:ListItem>
            </asp:DropDownList><br />
            <asp:Button ID="btnAgregar" Text="Agregar" OnClick="btnAgregar_Click" runat="server" />
            <asp:Button ID="btnActualizar" Text="Actualizar" OnClick="btnActualizar_Click" runat="server" />
        </fieldset>

        <!-- Botón para Eliminar -->
        <fieldset>
            <legend>Eliminar Usuario</legend>
            <label for="txtEliminarIDUsuario">ID Usuario:</label>
            <asp:TextBox ID="txtEliminarIDUsuario" runat="server" /><br />
            <asp:Button ID="btnEliminar" Text="Eliminar" OnClick="btnEliminar_Click" runat="server" />
        </fieldset>

        <!-- Listado de Usuarios -->
        <h3>Listado de Usuarios</h3>
        <asp:GridView ID="gvUsuarios" AutoGenerateColumns="true" runat="server" />
    </form>
</body>
</html>
