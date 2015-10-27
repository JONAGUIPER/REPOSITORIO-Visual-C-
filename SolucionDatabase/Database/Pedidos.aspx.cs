using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Database
{
    public partial class Pedidos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConectar_Click(object sender, EventArgs e)
        {
            //Crear el Objeto Conexion
            SqlConnection micon = new SqlConnection();
            //tomar la cadena de conexion desde WebConfig
            micon.ConnectionString = ConfigurationManager.ConnectionStrings["BaseDeDatosEnWebConfig"].ToString();

            //crear objeto comando
            SqlCommand miSelectComando = new SqlCommand();
            miSelectComando.CommandType = CommandType.Text;
            miSelectComando.CommandText = "SELECT CustomerID FROM Sales.Customer WHERE CustomerID BETWEEN @minimo AND @maximo";
            //miSelectComando.CommandText = "SELECT CustomerID FROM Sales.Customer";
            miSelectComando.Parameters.Add("@minimo", SqlDbType.Int, 4).Value = 10000;
            miSelectComando.Parameters.Add("@maximo", SqlDbType.Int, 4).Value = 15000;

            miSelectComando.Connection = micon;

            //abrir conexion
            micon.Open();
            //recuperar los datos mediante el objeto DataReader
            SqlDataReader milector = miSelectComando.ExecuteReader();
            DropDownIds.Items.Clear();
            while (milector.Read())
            {
                DropDownIds.Items.Add(milector.GetInt32(0).ToString());
            }
            //cerrar el lector
            milector.Close();
            //cerrar conexion
            micon.Close();
        }

        protected void btnVer_Click(object sender, EventArgs e)
        {
            int cliente= Convert.ToInt32(DropDownIds.SelectedItem.Text);
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = ConfigurationManager.ConnectionStrings["BaseDeDatosEnWebConfig"].ToString();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText= "SELECT * FROM Sales.SalesOrderHeader WHERE CustomerID=@cliente";
            comando.Parameters.Add("@cliente", SqlDbType.Int, 4).Value = cliente;
            comando.Connection = conexion;
            
            SqlDataAdapter miDa = new SqlDataAdapter(comando);
            conexion.Open();
            DataSet miTabla = new DataSet("dsPedidos");
            miDa.Fill(miTabla, "Clientes");
            conexion.Close();
            gridPedidos.DataSource = miTabla;
            gridPedidos.DataMember = miTabla.Tables["Clientes"].ToString();
            gridPedidos.DataBind();
        }
        
    }
}