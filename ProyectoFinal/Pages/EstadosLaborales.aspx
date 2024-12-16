<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EstadosLaborales.aspx.cs" Inherits="ProyectoFinal.Pages.EstadosLaborales" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Gestión de Estados Laborales</title>


  <link rel="stylesheet" type="text/css" href="../Styles/styles.css" />
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
    background-color: #e63946; /* Rojo vibrante */
    padding: 15px 0;
    text-align: center;
    box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1); /* Sombra ligera */
    border-bottom: 3px solid #c5303b; /* Rojo más oscuro */
    margin-bottom: 20px;
}

.submenu a {
    text-decoration: none;
    color: #ffffff; /* Blanco */
    margin: 0 15px;
    font-size: 18px;
    font-weight: bold;
    text-transform: uppercase;
    transition: color 0.3s, transform 0.2s;
}

.submenu a:hover {
    color: #ffcccb; /* Rojo claro */
    text-decoration: underline;
    transform: scale(1.1); /* Aumenta ligeramente el tamaño */
}

/* Separadores entre enlaces (opcional) */
.submenu a:not(:last-child):after {
    content: "|";
    color: #ffffff;
    margin-left: 15px;
}
    </style>

    <form id="form1" runat="server">
        <h2>Gestión de Estados Laborales</h2>

        <!-- Formulario para Agregar/Actualizar -->
        <fieldset>
            <legend>Datos del Estado Laboral</legend>
            <label for="txtIDEstado">ID Estado Laboral:</label>
            <asp:TextBox ID="txtIDEstado" runat="server" /><br />
            <label for="txtIDEmpleado">ID Empleado:</label>
            <asp:TextBox ID="txtIDEmpleado" runat="server" /><br />
            <label for="txtEstado">Estado:</label>
            <asp:TextBox ID="txtEstado" runat="server" /><br />
            <label for="txtFechaInicio">Fecha Inicio:</label>
            <asp:TextBox ID="txtFechaInicio" runat="server" TextMode="Date" /><br />
            <label for="txtFechaFin">Fecha Fin:</label>
            <asp:TextBox ID="txtFechaFin" runat="server" TextMode="Date" /><br />
            <label for="txtAdicionadoPor">Adicionado Por:</label>
            <asp:TextBox ID="txtAdicionadoPor" runat="server" /><br />
            <asp:Button ID="btnAgregar" Text="Agregar" OnClick="btnAgregar_Click" runat="server" />
            <asp:Button ID="btnActualizar" Text="Actualizar" OnClick="btnActualizar_Click" runat="server" />
        </fieldset>

        <!-- Botón para Eliminar -->
        <fieldset>
            <legend>Eliminar Estado Laboral</legend>
            <label for="txtEliminarIDEstado">ID Estado Laboral:</label>
            <asp:TextBox ID="txtEliminarIDEstado" runat="server" /><br />
            <asp:Button ID="btnEliminar" Text="Eliminar" OnClick="btnEliminar_Click" runat="server" />
        </fieldset>

         <h3>Listado de Empleados</h3>
 <asp:GridView ID="gvEmpleados" AutoGenerateColumns="true" runat="server" />

        <asp:Button ID="btnDescargarPDFEstadosLaborales" runat="server" Text="Descargar Estados Laborales en PDF" OnClick="btnDescargarPDFEstadosLaborales_Click" />


        <!-- Listado de Estados Laborales -->
        <h3>Listado de Estados Laborales</h3>
        <asp:GridView ID="gvEstadosLaborales" AutoGenerateColumns="true" runat="server" />
    </form>
</body>
</html>

