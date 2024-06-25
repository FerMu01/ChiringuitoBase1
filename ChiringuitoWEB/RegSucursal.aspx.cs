using ChiringuitoDAO.Implementation;
using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChiringuitoWEB
{
    public partial class RegSucursal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadType();
            }
        }

        void LoadType()
        {
            try
            {
                Tipoimpl tipoImpl = new Tipoimpl();
                DataTable table = tipoImpl.Select();
                CityImpl cityImpl = new CityImpl();
                DataTable city = cityImpl.Select();
                cbxTipo.DataSource = table;
                cbxTipo.DataTextField = "name"; // Asegúrate que el DataTextField coincide con el nombre de columna en tu DataTable
                cbxTipo.DataValueField = "id"; // Asegúrate que el DataValueField coincide con el nombre de columna en tu DataTable
                cbxTipo.DataBind();
                cbxCity.DataSource = city;
                cbxCity.DataTextField = "name"; // Asegúrate que el DataTextField coincide con el nombre de columna en tu DataTable
                cbxCity.DataValueField = "id"; // Asegúrate que el DataValueField coincide con el nombre de columna en tu DataTable
                cbxCity.DataBind();

                cbxTipo.Items.Insert(0, new ListItem("Seleccione Tipo", ""));
                cbxCity.Items.Insert(0, new ListItem("Seleccione Ciudad", ""));

            }
            catch (Exception ex)
            {
                // Usa lblMessage para mostrar el error
                lblMessage.Text = ex.Message;
                lblMessage.CssClass = "error-message";
            }
        }
    }
}
