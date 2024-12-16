<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Empleado.aspx.cs" Inherits="ProyectoFinal.Pages.Empleados" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Gestión de Empleados</title>
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

    <form id="form1" runat="server">
        <h2>Gestión de Empleados</h2>

        <!-- Formulario para Agregar/Actualizar Empleados -->
        <fieldset>
            <legend>Datos del Empleado</legend>
            <label for="txtNombre">Nombre:</label>
            <asp:TextBox ID="txtNombre" runat="server" /><br />
            <label for="txtApellido">Apellido:</label>
            <asp:TextBox ID="txtApellido" runat="server" /><br />

            <label for="txtFechaNacimiento">Fecha de Nacimiento:</label>
<asp:TextBox ID="txtFechaNacimiento" runat="server" TextMode="Date" /><br />


            <label for="txtDireccion">Dirección:</label>
            <asp:TextBox ID="txtDireccion" runat="server" /><br />
            <label for="txtTelefono">Teléfono:</label>
            <asp:TextBox ID="txtTelefono" runat="server" /><br />
            <label for="txtEmail">Email:</label>
            <asp:TextBox ID="txtEmail" runat="server" /><br />
            <label for="ddlCargo">Cargo:</label>
<asp:DropDownList ID="ddlCargo" runat="server">
    <asp:ListItem Text="Gerente" Value="Gerente"></asp:ListItem>
    <asp:ListItem Text="Analista" Value="Analista"></asp:ListItem>
    <asp:ListItem Text="Desarrollador" Value="Desarrollador"></asp:ListItem>
    <asp:ListItem Text="Soporte Técnico" Value="Soporte Técnico"></asp:ListItem>
    <asp:ListItem Text="Marketing" Value="Marketing"></asp:ListItem>
    <asp:ListItem Text="Ventas" Value="Ventas"></asp:ListItem>
</asp:DropDownList><br />

<label for="ddlDepartamento">Departamento:</label>
<asp:DropDownList ID="ddlDepartamento" runat="server">
    <asp:ListItem Text="Recursos Humanos" Value="Recursos Humanos"></asp:ListItem>
    <asp:ListItem Text="Tecnología" Value="Tecnología"></asp:ListItem>
    <asp:ListItem Text="Finanzas" Value="Finanzas"></asp:ListItem>
    <asp:ListItem Text="Operaciones" Value="Operaciones"></asp:ListItem>
    <asp:ListItem Text="Marketing" Value="Marketing"></asp:ListItem>
    <asp:ListItem Text="Ventas" Value="Ventas"></asp:ListItem>
</asp:DropDownList><br />

            <label for="txtSalario">Salario:</label>
            <asp:TextBox ID="txtSalario" runat="server" /><br />

                    <label for="txtFechaIngreso">Fecha de Ingreso:</label>
<asp:TextBox ID="txtFechaIngreso" runat="server" TextMode="Date" /><br />
            <asp:Button ID="btnAgregar" Text="Agregar" OnClick="btnAgregar_Click" runat="server" />
            <asp:Button ID="btnActualizar" Text="Actualizar" OnClick="btnActualizar_Click" runat="server" />
        </fieldset>

        <!-- Botón para Eliminar -->
        <fieldset>
            <legend>Eliminar Empleado</legend>
            <label for="txtEliminarID">ID Empleado:</label>
            <asp:TextBox ID="txtEliminarID" runat="server" /><br />
            <asp:Button ID="btnEliminar" Text="Eliminar" OnClick="btnEliminar_Click" runat="server" />
        </fieldset>

     
        <asp:Button ID="btnDescargarPDFEmpleados" runat="server" Text="Descargar Empleados en PDF" OnClick="btnDescargarPDFEmpleados_Click" />

        <!-- Listado de Empleados -->
        <h3>Listado de Empleados</h3>
        <asp:GridView ID="gvEmpleados" AutoGenerateColumns="true" runat="server" />
    </form>
</body>
</html>


