<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EvaluacionDesempeno.aspx.cs" Inherits="ProyectoFinal.Pages.EvaluacionDesempeno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Gestión de Evaluaciones de Desempeño</title>
<link type="text/css" rel="stylesheet" href="../Styles/Estilos.css" />
</head>
<body>
    <form id="formGestionEvaluaciones" runat="server">
        <div class="container">
            <h2>Gestión de Evaluaciones de Desempeño</h2>

            <!-- Formulario para agregar una evaluación -->
            <div class="form-section">
                <h3>Agregar Evaluación de Desempeño</h3>
                <label for="txtEmpleadoID">ID del Empleado:</label>
                <input type="number" id="txtEmpleadoID" runat="server" />

                <label for="txtFechaEvaluacion">Fecha de Evaluación:</label>
                <input type="date" id="txtFechaEvaluacion" runat="server" />

                <label for="txtComentarios">Comentarios:</label>
                <textarea id="txtComentarios" runat="server"></textarea>

                <label for="txtPuntuacion">Puntuación (1-10):</label>
                <input type="number" id="txtPuntuacion" runat="server" min="1" max="10" />

                <asp:Button ID="btnAgregarEvaluacion" runat="server" Text="Agregar Evaluación" OnClick="btnAgregarEvaluacion_Click" />
            </div>

            <!-- Formulario para actualizar una evaluación -->
            <div class="form-section">
                <h3>Actualizar Evaluación de Desempeño</h3>
                <label for="txtEvaluacionID">ID de la Evaluación:</label>
                <input type="number" id="txtEvaluacionID" runat="server" />

                <label for="txtFechaEvaluacionActualizar">Nueva Fecha de Evaluación:</label>
                <input type="date" id="txtFechaEvaluacionActualizar" runat="server" />

                <label for="txtComentariosActualizar">Nuevos Comentarios:</label>
                <textarea id="txtComentariosActualizar" runat="server"></textarea>

                <label for="txtPuntuacionActualizar">Nueva Puntuación:</label>
                <input type="number" id="txtPuntuacionActualizar" runat="server" min="1" max="10" />

                <asp:Button ID="btnActualizarEvaluacion" runat="server" Text="Actualizar Evaluación" OnClick="btnActualizarEvaluacion_Click" />
            </div>

            <!-- Formulario para eliminar una evaluación -->
            <div class="form-section">
                <h3>Eliminar Evaluación de Desempeño</h3>
                <label for="txtEvaluacionIDEliminar">ID de la Evaluación:</label>
                <input type="number" id="txtEvaluacionIDEliminar" runat="server" />
                <asp:Button ID="btnEliminarEvaluacion" runat="server" Text="Eliminar Evaluación" OnClick="btnEliminarEvaluacion_Click" />
            </div>

            <!-- Botones del CRUD -->
            <div class="form-buttons">
                <asp:Button ID="btnPagGestionVacaciones" runat="server" Text="Gestionar Vacaciones" OnClick="btnPagGestionVacaciones_Click" />
            </div>
        </div>
    </form>
</body>
</html>

