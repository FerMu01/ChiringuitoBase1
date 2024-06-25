using System;
using System.Web.UI;
using ChiringuitoDAO.Implementation;
using ChiringuitoDAO.Model;

namespace ChiringuitoWEB
{
    public partial class RegistrarProveedor : System.Web.UI.Page
    {
        SupplierImpl implsupplier;
        Supplier t;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Esto asegura que el mensaje se oculte cada vez que se carga la página,
            // excepto cuando se hace un postback
            if (!IsPostBack)
            {
                lblMessage.Visible = false;
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            lblMessage.Visible = true; // Asegúrate de que el mensaje sea visible

            // Validar si los campos están vacíos
            if (string.IsNullOrWhiteSpace(textNit.Text) || string.IsNullOrWhiteSpace(textName.Text) || string.IsNullOrWhiteSpace(textNumber.Text))
            {
                lblMessage.CssClass = "error-message";
                lblMessage.Text = "Todos los campos son obligatorios";
                return;
            }

            try
            {
                t = new Supplier(textNit.Text, textName.Text, textNumber.Text);
                implsupplier = new SupplierImpl();
                int n = implsupplier.Insert(t);

                textNit.Enabled = false;
                textName.Enabled = false;
                textNumber.Enabled = false;
                btnRegistrar.Enabled = false;

                lblMessage.CssClass = "success-message";
                lblMessage.Text = "Registro exitoso";
            }
            catch (Exception ex)
            {
                // Manejo de errores
                lblMessage.CssClass = "error-message";
                lblMessage.Text = "Error al registrar: " + ex.Message;
            }
        }

        protected void btnOtroRegistro_Click(object sender, EventArgs e)
        {
            textNit.Enabled = true;
            textNit.Text = "";
            textName.Enabled = true;
            textName.Text = "";
            textNumber.Enabled = true;
            textNumber.Text = "";
            btnRegistrar.Enabled = true;
            lblMessage.Visible = false; // Oculta el mensaje cuando se inicia un nuevo registro
        }
    }
}
