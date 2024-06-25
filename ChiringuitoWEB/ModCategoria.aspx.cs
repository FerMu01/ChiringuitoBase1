using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ChiringuitoDAO.Implementation;
using ChiringuitoDAO.Model;

namespace ChiringuitoWEB
{
  
    public partial class ModCategoria : System.Web.UI.Page
    {
        Category t;
        CategoryImpl implcategory;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Select();
                textName.Enabled = false;
                textDescripcion.Enabled = false;
                textDescuento.Enabled = false;

            }

        }
        void Select()
        {
            try
            {
                implcategory = new CategoryImpl();
                gridData.DataSource = implcategory.Select();
                gridData.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btnVer_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            Label lbl = (Label)row.FindControl("IDlbl");
            textName.Text = lbl.Text;
            Get(byte.Parse(lbl.Text));
            if (t != null)
            {
                textName.Text = t.Name;
                textDescripcion.Text = t.Description;
                textDescuento.Text = t.Discount;
            }
        }
        void Get(byte id)
        {
            try
            {
                t = null;
                implcategory = new CategoryImpl();
                t = implcategory.Get(id);
                if (t != null)
                {
                    textID.Text = t.Id.ToString();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            textName.Enabled = true;
            textDescuento.Enabled = true;
            textDescripcion.Enabled = true;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Get(byte.Parse(textID.Text));
                if (t != null)
                {
                    t.Name = textName.Text;
                    t.Description = textDescripcion.Text;
                    t.Discount = textDescuento.Text;

                    implcategory = new CategoryImpl();
                    int n = implcategory.Update(t);
                    if (n > 0)
                    {
                        Select();
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Get(byte.Parse(textID.Text));
                if (t != null)
                {
                    implcategory = new CategoryImpl();
                    int n = implcategory.Delete(t);
                    if (n > 0)
                    {
                        Select();
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}