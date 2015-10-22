using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Validacion
{
    public partial class Validaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!this.IsPostBack)
            //{
            //    this.Validate();
            //}
        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblRespuesta.Text = "Datos validos";
            }
            else
                lblRespuesta.Text = "Datos invalidos";

        }


        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {

            string dato = args.Value;
            //string val1 = dato.Split(' ')[0].ToString();
            //string val2 = dato.Split('0')[0].ToString();
            if ((dato == dato.Split(' ')[0].ToString()) 
                && (dato == dato.Split('0')[0].ToString())
                && (!string.IsNullOrEmpty(dato)))
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }
    }
}