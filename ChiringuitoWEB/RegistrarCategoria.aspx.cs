using ChiringuitoDAO.Implementation;
using ChiringuitoDAO.Model;
using System;
using System.Web.UI;

namespace ChiringuitoWEB
{
    public partial class RegistrarCategoria : System.Web.UI.Page
    {
        CategoryImpl implcategory;
        Category t;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOtroRegistro_Click(object sender, EventArgs e)
        {
            textName.Enabled = true;
            textName.Text = string.Empty;
            textDescription.Enabled = true;
            textDescription.Text = string.Empty;
            textDescuento.Enabled = true;
            textDescuento.Text = string.Empty;
            btnRegistrar.Enabled = true;
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    t = new Category(textName.Text, textDescription.Text, textDescuento.Text);
                    implcategory = new CategoryImpl();
                    int n = implcategory.Insert(t);

                    lblMessage.CssClass = "success-message";
                    lblMessage.Text = "Registro completado exitosamente.";

                    textName.Enabled = false;
                    textDescription.Enabled = false;
                    textDescuento.Enabled = false;
                    btnRegistrar.Enabled = false;
                }
                else
                {
                    lblMessage.CssClass = "error-message";
                }
            }
            catch (Exception ex)
            {
                lblMessage.CssClass = "error-message";
                lblMessage.Text = $"Error: {ex.Message}";
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(textName.Text) ||
                string.IsNullOrWhiteSpace(textDescription.Text) ||
                string.IsNullOrWhiteSpace(textDescuento.Text))
            {
                lblMessage.Text = "Todos los campos son obligatorios.";
                return false;
            }

            if (textName.Text.StartsWith(" ") ||
                textDescription.Text.StartsWith(" ") ||
                textDescuento.Text.StartsWith(" "))
            {
                lblMessage.Text = "El primer carácter no puede ser un espacio.";
                return false;
            }

            return true;
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}
