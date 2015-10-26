using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
//using System.da

namespace Database
{
    public partial class WebFormConectado : System.Web.UI.Page
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
            dropdownClientes.Items.Clear();
            while (milector.Read())
            {
                dropdownClientes.Items.Add(milector.GetInt32(0).ToString());
            }
            //cerrar el lector
            milector.Close();
            //cerrar conexion
            micon.Close();


        }

        protected void btnVer_Click(object sender, EventArgs e)
        {
           /* int id = Convert.ToInt32(dropdownClientes.SelectedValue);
            using (SqlConnection miConexion = new SqlConnection())
            {
                miConexion.ConnectionString = ConfigurationManager.ConnectionStrings["BaseDeDatosEnWebConfig"].ToString();
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT CustomerID,StoreID,TerritoryID,AccountNumber,ModifiedDate FROM Sales.Customer WHERE CustomerID=@fulanito";
                comando.Parameters.Add("@fulanito", SqlDbType.Int, 4).Value = id;
                comando.Connection = miConexion;

                miConexion.Open();
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    txtId.Text = lector[0].ToString();
                    txtStore.Text = lector[1].ToString();
                    txtTerritorio.Text = lector[2].ToString();
                    txtCuenta.Text = lector[3].ToString();
                    txtFecha.Text = lector[4].ToString();
                }
                lector.Close();
                miConexion.Close();
            }*/
            /*********ALMACENADO LOS VALORES Y DESPUES USANDOLOS*******/

            int id2 = Convert.ToInt32(dropdownClientes.SelectedValue);
            DataTable miTabla = new DataTable();
            using (SqlConnection miConexion2 = new SqlConnection())
            {
                miConexion2.ConnectionString = ConfigurationManager.ConnectionStrings["BaseDeDatosEnWebConfig"].ToString();
                SqlCommand comando2 = new SqlCommand();
                comando2.CommandType = CommandType.Text;
                comando2.CommandText = "SELECT CustomerID,StoreID,TerritoryID,AccountNumber,ModifiedDate FROM Sales.Customer WHERE CustomerID=@fulanito";
                comando2.Parameters.Add("@fulanito", SqlDbType.Int, 4).Value = id2;
                comando2.Connection = miConexion2;

                SqlDataAdapter miDa = new SqlDataAdapter(comando2);
                miConexion2.Open();
                miDa.Fill(miTabla);
                miConexion2.Close();
            }
            //OPERAR
            DataRow miFila = miTabla.Rows[0];
            txtId.Text = miFila["CustomerID"].ToString();
            txtStore.Text = miFila["StoreID"].ToString();
            txtTerritorio.Text = miFila["TerritoryID"].ToString();
            txtCuenta.Text = miFila["AccountNumber"].ToString();
            txtFecha.Text = miFila["ModifiedDate"].ToString();



        }
    }
}