<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Empleado.aspx.cs" Inherits="ProyectoFinal.Pages.Empleado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Gestión de Empleados</title>
    <link type="text/css" rel="stylesheet" href="../Styles/Estilos.css" />
</head>
<body>
    <form id="formEmpleados" runat="server">
        <div class="container">
            <h2>Gestión de Empleados</h2>

            <!-- Formulario para gestionar empleados -->
            <div class="form-section">
                <label for="txtNombre">Nombre:</label>
                <input type="text" id="txtNombre" runat="server" />

                <label for="txtDireccion">Dirección:</label>
                <input type="text" id="txtDireccion" runat="server" />

                <label for="txtContacto">Contacto:</label>
                <input type="text" id="txtContacto" runat="server" />

                <label for="txtFechaIngreso">Fecha de Ingreso:</label>
                <input type="date" id="txtFechaIngreso" runat="server" />

                <label for="txtCargo">Cargo:</label>
                <input type="text" id="txtCargo" runat="server" />

                <label for="txtDepartamento">Departamento:</label>
                <input type="text" id="txtDepartamento" runat="server" />

                <label for="txtSalario">Salario:</label>
                <input type="number" id="txtSalario" runat="server" />

                <label for="txtAdicionadoPor">Añadido/Modificado por:</label>
                <input type="text" id="txtAdicionadoPor" runat="server" />

                <label for="txtEmpleadoID">ID del Empleado (para actualizar/eliminar):</label>
                <input type="text" id="txtEmpleadoID" runat="server" />
            </div>

            <!-- Botones CRUD al final -->
            <div class="form-section">
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar Empleado" OnClick="btnAgregar_Click" />
                <asp:Button ID="btnActualizar" runat="server" Text="Actualizar Empleado" OnClick="btnActualizar_Click" />
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar Empleado" OnClick="btnEliminar_Click" />
                <asp:Button ID="btnPagEstadoLab" runat="server" Text="Gestionar Estado Laboral" OnClick="btnPagEstadoLab_Click" />
            </div>
        </div>
    </form>
</body>
</html>

