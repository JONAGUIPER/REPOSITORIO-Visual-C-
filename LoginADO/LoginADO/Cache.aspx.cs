using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace LoginADO
{
    public partial class Cache : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVerClientes_Click(object sender, EventArgs e)
        {
            DataTable misClientes = null;
            using (SqlConnection conexion = new SqlConnection())
            {
                conexion.ConnectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2014ConnectionString"].ToString();
                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT TOP 10 * FROM Sales.Customer", conexion);

                misClientes = new DataTable("Clientes");
                try
                {
                    conexion.Open();
                    adaptador.Fill(misClientes);
                }
                catch (Exception)
                {
                    //tareas para cuando falla la conexion
                }
                finally
                {
                    conexion.Close();
                }
            }
            this.Cache["Top10Clientes"] = misClientes;
            gvClientes.DataSource = this.Cache["Top10Clientes"];
            gvClientes.DataBind();
        }
    }
}