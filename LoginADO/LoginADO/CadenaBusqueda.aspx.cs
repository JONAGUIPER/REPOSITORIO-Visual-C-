﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginADO
{
    public partial class CadenaBusqueda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviarXURL_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadenaBusquedaTEst.aspx?QSvalor="+txtCadena.Text);
        }
    }
}