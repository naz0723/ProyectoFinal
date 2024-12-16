<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Gestiones.aspx.cs" Inherits="ProyectoFinal.Pages.Gestiones" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gestión de Vacaciones, Permisos y Licencias</title>
  <link rel="stylesheet" type="text/css" href="../Styles/styles.css" />
</head>

    <body>

       <div class="submenu">
    <a href="Empleado.aspx">Gestión de Empleados</a>
    <a href="Asistencias.aspx">Gestión de Asistencias</a>
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
<body>
    <form id="form1" runat="server">
        <h2>Gestión de Vacaciones, Permisos y Licencias</h2>

        <!-- Formulario para Agregar/Actualizar -->
        <fieldset>
            <legend>Datos de Gestión</legend>
            <label for="txtIDGestion">ID Gestión:  (Solo funciona para actualizar)</label>
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

