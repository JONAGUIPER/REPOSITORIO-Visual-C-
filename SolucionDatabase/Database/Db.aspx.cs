using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Database
{
    public partial class Db : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClientes_Click(object sender, EventArgs e)
        {
            DataSet miDs;
            //Objeto conexión a Sql
            using (SqlConnection miConexion = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=AdventureWorks2014;Integrated Security=True"))
            {//usando el using hace que el objeto utilizado se destruye en el momento en que se cierra la llave correspondiente
                //cerar el objeto adaptador de datos,
                //Abre la conexion ejecuta el comando
                //y cierra la conexion

                SqlDataAdapter miAdaptador = new SqlDataAdapter("select * from Sales.Customer", miConexion);

                //Almacen de datos local, el nombre dado es para local.
                miDs = new DataSet("dsClientes");
                try
                {
                    //nos aseguramos de abrir la conexion a la BBDD
                    miConexion.Open();

                    //Recuper y almacenar los datos mediante el metodo fill
                    //del adaptador
                    miAdaptador.Fill(miDs, "Clientes");
                }
                catch (SqlException ex)
                {

                }
                finally
                {
                    //Cerramos la conexión
                    miConexion.Close();
                }
            }//aqui se cierra el objeto miConexion y cierra la conexion a su vez
            verTabla.DataSource = miDs;
            verTabla.DataMember = miDs.Tables["Clientes"].ToString();
            verTabla.DataBind();

        }
    }
}