using System;
using System.Web.UI;

namespace ChiringuitoWEB
{
    public partial class Site : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Código que se ejecuta solo la primera vez que se carga la página
            }
        }

        protected void btnRegistrarProveedor_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrarProveedor.aspx");
        }

        protected void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            Response.Redirect("ModProveedor.aspx");
        }

        protected void btnRegistrarCategoria_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrarCategoria.aspx");

        }

        protected void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegSucursal.aspx");

        }

        protected void imgShop_Click(object sender, ImageClickEventArgs e)
        {
            btnModificarCategoria.Visible = false;
            btnRegistrarCategoria.Visible = false;
            btnModificarProveedor.Visible = true;
            btnRegistrarProveedor.Visible = true;
        }

        protected void imgUsers_Click(object sender, ImageClickEventArgs e)
        {
            btnModificarProveedor.Visible = false;
            btnRegistrarProveedor.Visible=false;
            btnModificarCategoria.Visible = true;
            btnRegistrarCategoria.Visible = true;
        }

        protected void imgHome_Click(object sender, ImageClickEventArgs e)
        {
            btnModificarProveedor.Visible = false;
            btnRegistrarProveedor.Visible = false;
            btnModificarCategoria.Visible = false;
            btnRegistrarCategoria.Visible = false;
        }
    }
}
