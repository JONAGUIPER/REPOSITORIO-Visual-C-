using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginADO
{
    public partial class CacheTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gvCacheTest.DataSource = Cache["Top10Clientes"];
            gvCacheTest.DataBind();
        }
    }
}