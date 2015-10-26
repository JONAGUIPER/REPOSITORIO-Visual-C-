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

            miSelectComando.Parameters.Add("@minimo", SqlDbType.Int, 4).Value = 1;
            miSelectComando.Parameters.Add("@maximo", SqlDbType.Int, 4).Value = 1000;

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
    }
}