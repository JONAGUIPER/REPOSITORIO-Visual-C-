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
    public partial class Clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                lblWelcome.Text += " " + Session["NOMBRE"];
                lblEstado.Text = "Cargando Clientes...";
                ddIdClientes.Items.Clear();
                using (SqlConnection conexion = new SqlConnection())
                {
                    conexion.ConnectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2014ConnectionString"].ToString();
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "select c.CustomerID from sales.Customer as c, sales.SalesOrderHeader as o  where o.CustomerID=c.CustomerID";
                    conexion.Open();
                    SqlDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        ddIdClientes.Items.Add(lector.GetInt32(0).ToString());
                    }
                }
                lblEstado.Text = "";
            }

        }

        protected void ddIdClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lblEstado.Text = "Cargando Clientes...";
            //DataSet dataS = new DataSet();
            //using (SqlConnection conexion = new SqlConnection())
            //{
            //    conexion.ConnectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2014ConnectionString"].ToString();
            //    SqlCommand comando = new SqlCommand();
            //    comando.Connection = conexion;
            //    comando.CommandType = CommandType.Text;
            //    comando.CommandText = "select * from sales.SalesOrderHeader where CustomerID=@customerId";
            //    comando.Parameters.Add("@customerId", SqlDbType.VarChar, 50).Value = ddIdClientes.SelectedValue.ToString();

            //    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            //    conexion.Open();
            //    adaptador.Fill(dataS, "pedidos");
            //    gvPedidos.DataSource = dataS;
            //    gvPedidos.DataMember = dataS.Tables["pedidos"].ToString();
            //    gvPedidos.DataBind();
            //}
            //lblEstado.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lblEstado.Text = "Cargando Clientes...";
            DataSet dataS = new DataSet();
            using (SqlConnection conexion = new SqlConnection())
            {
                conexion.ConnectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2014ConnectionString"].ToString();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "select * from sales.SalesOrderHeader where CustomerID=@customerId";
                comando.Parameters.Add("@customerId", SqlDbType.VarChar, 50).Value = ddIdClientes.SelectedValue.ToString();

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
