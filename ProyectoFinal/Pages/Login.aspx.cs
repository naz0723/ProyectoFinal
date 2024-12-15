using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 
            // Puedes inicializar mensajes u ocultar etiquetas aquí
            lblMessage.Visible = false;
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            // Captura los datos de usuario y contraseña
            string usuario = "admin";// username.Value;
            string contraseña = "admin123";// password.Value;

            // Realiza la validación de las credenciales
            bool autenticado = AutenticarUsuario(usuario, contraseña);

            if (autenticado)
            {
                // Redirecciona a la página principal si las credenciales son correctas
                Response.Redirect("Empleado.aspx");
            }
            else
            {
                // Muestra mensaje de error si las credenciales no son válidas
                lblMessage.InnerHtml = "Usuario o contraseña incorrectos.";
                lblMessage.Visible = true;
            }
        }

        private bool AutenticarUsuario(string usuario, string contraseña)
        {
            // Aquí va la lógica de autenticación, por ejemplo:
            // return UsuarioService.ValidarCredenciales(usuario, contraseña);

            // Para fines de prueba, se simula una autenticación simple
            if (usuario == "admin" && contraseña == "admin123")
            {
                return true;
            }

            return false;
        }
    }
}