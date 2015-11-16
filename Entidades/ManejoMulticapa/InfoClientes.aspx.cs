using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controladores;
using Entidades;

namespace ManejoMulticapa
{
    public partial class InfoClientes : System.Web.UI.Page
    {
        ControllersClientes cClientes = new ControllersClientes();
        protected void Page_Load(object sender, EventArgs e)
        {
            //ServiceReference1.Service1Client cClientes = new ServiceReference1.Service1Client();
            //ControllersClientes cClientes = new ControllersClientes();
            List<CLientesNombreCompleto> Nombres = cClientes.NombresClientes();
            int indice = 0;
            foreach (var item in Nombres)
            {
                dbClientes.Items.Add(item.Nombre + " " + item.Apellido);
                dbClientes.Items[indice].Value = item.ID;
                indice++;
            }
            
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            dvCliente.DataSource = cClientes.ClienteById(dbClientes.SelectedValue.ToString());
            dvCliente.DataBind();

            gvPedidos.DataSource = cClientes.PedidosByCliente(dbClientes.SelectedValue.ToString());
            gvPedidos.DataBind();
        }
    }
}