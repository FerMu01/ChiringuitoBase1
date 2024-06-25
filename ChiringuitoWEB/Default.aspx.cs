using System;
using System.Web.UI;

namespace ChiringuitoWEB
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Código que se ejecuta solo la primera vez que se carga la página
            }
        }

        
    }
}
