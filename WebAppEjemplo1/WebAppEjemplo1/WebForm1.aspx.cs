using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppEjemplo1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Hola desde ASP NET";
            /*ListBox1.Items.Clear();
            ListBox1.Items.Add("1");
            ListBox1.Items.Add("2");
            ListBox1.Items.Add("3");*/

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "click en el boton";
        }
    }
}