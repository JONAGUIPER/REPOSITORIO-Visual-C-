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
    public partial class Pedidos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = " " + Session["NOMBRE"];
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            lblEstado.Text = "Cargando Clientes...";
            DataSet dataS = new DataSet();
            using (SqlConnection conexion = new SqlConnection())
            {
                conexion.ConnectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2014ConnectionString"].ToString();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "select * from sales.SalesOrderHeader where OrderDate>=@desde AND OrderDate<=@hasta";
                comando.Parameters.Add("@desde", SqlDbType.DateTime, 8).Value = Convert.ToDateTime(txtDesde.Text);
                comando.Parameters.Add("@hasta", SqlDbType.DateTime, 8).Value = Convert.ToDateTime(txtHasta.Text);


                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                conexion.Open();
                adaptador.Fill(dataS, "pedidos");
                gvPedidos.DataSource = dataS;
                gvPedidos.DataMember = dataS.Tables["pedidos"].ToString();
                gvPedidos.DataBind();
            }
            lblEstado.Text = "";
        }

       
    }
}