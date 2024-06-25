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
    public partial class ModProveedor : System.Web.UI.Page
    {
        SupplierImpl implsupplier;
        Supplier t;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Select();
                textName.Enabled = false;
                textNit.Enabled = false;
                textNumber.Enabled = false;

            }
        }
        void Select()
        {
            try
            {
                implsupplier = new SupplierImpl();
                gridData.DataSource = implsupplier.Select();
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


        private bool EsNumero(char c)
        {
            // Verificar si el carácter es un dígito
            return char.IsDigit(c);
        }


        protected void textNit_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text;

            // Verificar si el último carácter ingresado es numérico
            if (!EsNumero(text[text.Length - 1]))
            {
                // Si no es numérico, eliminar el último carácter y mantener el foco en el TextBox
                textBox.Text = text.Substring(0, text.Length - 1);
                textBox.Focus();
            }
        }

        protected void textNumber_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text;

            // Verificar si el último carácter ingresado es numérico
            if (!EsNumero(text[text.Length - 1]))
            {
                // Si no es numérico, eliminar el último carácter y mantener el foco en el TextBox
                textBox.Text = text.Substring(0, text.Length - 1);
                textBox.Focus();
            }
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
                textName.Text = t.Business;
                textNit.Text = t.Nit;
                textNumber.Text = t.PhoneNumber;
            }
        }
        void Get(byte id)
        {
            try
            {
                t = null;
                implsupplier = new SupplierImpl();
                t = implsupplier.Get(id);
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
            textNit.Enabled = true;
            textNumber.Enabled = true;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Get(byte.Parse(textID.Text));
                if (t!=null)
                {
                    t.Nit = textNit.Text;
                    t.Business = textName.Text;
                    t.PhoneNumber = textNumber.Text;

                    implsupplier = new SupplierImpl();
                    int n=implsupplier.Update(t);
                    if (n > 0)
                    {
                        Select();
                    }
                }

            } catch (Exception ex)
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
                    implsupplier = new SupplierImpl();
                    int n=implsupplier.Delete(t);
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