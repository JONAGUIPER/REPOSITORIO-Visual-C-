using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginADO
{
    public partial class Aplicacion : System.Web.UI.Page
    {
        int contador = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            contador = Convert.ToInt32(Application["ususarios"]);
            Application["ususarios"] = contador + 1;
        }
    }
}