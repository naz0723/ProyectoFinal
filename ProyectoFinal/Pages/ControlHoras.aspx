<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ControlHoras.aspx.cs" Inherits="ProyectoFinal.Pages.ControlHoras" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   <title>Gestión de Control de Horas</title>
<link type="text/css" rel="stylesheet" href="../Styles/Estilos.css" />
</head>
<body>
    <form id="formControlHoras" runat="server">
        <div class="container">
            <h2>Gestión de Control de Horas</h2>

            <!-- Formulario para agregar un control de horas -->
            <div class="form-section">
                <h3>Agregar Control de Horas</h3>
                <label for="txtEmpleadoID">ID del Empleado:</label>
                <input type="number" id="txtEmpleadoID" runat="server" />

                <label for="txtFecha">Fecha:</label>
                <input type="date" id="txtFecha" runat="server" />

                <label for="txtHoraEntrada">Hora de Entrada:</label>
                <input type="time" id="txtHoraEntrada" runat="server" />
            </div>

            <!-- Formulario para actualizar un control de horas -->
            <div class="form-section">
                <h3>Actualizar Control de Horas</h3>
                <label for="txtControlHorasID">ID del Control de Horas:</label>
                <input type="number" id="txtControlHorasID" runat="server" />

                <label for="txtHoraSalida">Hora de Salida:</label>
                <input type="time" id="txtHoraSalida" runat="server" />
            </div>

            <!-- Formulario para eliminar un control de horas -->
            <div class="form-section">
                <h3>Eliminar Control de Horas</h3>
                <label for="txtEliminarControlHorasID">ID del Control de Horas:</label>
                <input type="number" id="txtEliminarControlHorasID" runat="server" />
            </div>

            <!-- Botones del CRUD -->
            <div class="form-buttons">
                <asp:Button ID="btnAgregarControlHoras" runat="server" Text="Agregar Control de Horas" OnClick="btnAgregarControlHoras_Click" />
                <asp:Button ID="btnActualizarControlHoras" runat="server" Text="Actualizar Control de Horas" OnClick="btnActualizarControlHoras_Click" />
                <asp:Button ID="btnEliminarControlHoras" runat="server" Text="Eliminar Control de Horas" OnClick="btnEliminarControlHoras_Click" />
                <asp:Button ID="btnPagGestionAusencias" runat="server" Text="Gestión de Ausencias" OnClick="btnPagGestionAusencias_Click" />
            </div>
        </div>
    </form>
</body>
</html>

