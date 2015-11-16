using ModeloPorCapas.Manejadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ModeloPorCapas.Vistas
{
    public partial class Clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVerClientes_Click(object sender, EventArgs e)
        {
            ClientesControlers losClientes = new ClientesControlers();
            gvClientes.DataSource = losClientes.GetClientes();
            gvClientes.DataBind();
        }

        protected void gvClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["IdCliente"]=(sender as GridView).SelectedRow.Cells[1].Text;
            Page.Response.Redirect("Cliente.aspx");
        }
    }
}