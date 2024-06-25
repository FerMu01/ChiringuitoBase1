using System;
using System.Data;
using System.Web.UI;
using ChiringuitoDAO.Implementation;
using ChiringuitoDAO.Model;

namespace ChiringuitoWEB
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Opcional: lógica para manejar eventos de carga de la página
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            UserImpl userImpl = new UserImpl();
            try
            {
                DataTable table = userImpl.Login(txtUsername.Text, txtPassword.Text);
                if (table.Rows.Count > 0)
                {
                    SessionClass.ID = short.Parse(table.Rows[0]["id"].ToString());
                    SessionClass.SessionUserName = table.Rows[0]["userName"].ToString();
                    SessionClass.SessionRole = table.Rows[0]["role"].ToString();

                    // Redireccionar a la página de inicio o panel de control
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    // Manejo de caso en el que las credenciales son incorrectas
                    lblErrorMessage.Text = "Nombre de usuario o contraseña incorrectos.";
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                lblErrorMessage.Text = "Ocurrió un error durante el inicio de sesión. Por favor, inténtelo nuevamente.";
                // Log del error si es necesario
                // Log.Error("Error en Login", ex);
            }
        }
    }
}
