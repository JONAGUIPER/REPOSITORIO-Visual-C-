using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace BaseDeDatosExpress
{
    public partial class EntradaDatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FormView1.ChangeMode(FormViewMode.Edit);
            // FormView1.CurrentMode;
            cargarFVCodigo();

        }
        private void cargarFVCodigo()
        {
            //DataSet datos=new DataSet();
            SqlDataSource origenDatos = new SqlDataSource();
            using (SqlConnection conexion = new SqlConnection())
            {
                conexion.ConnectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2014ConnectionString"].ToString();
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT CustomerID, PersonID, StoreID, TerritoryID, AccountNumber, ModifiedDate FROM Sales.Customer";
                comando.Connection = conexion;
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                
                try
                {
                    conexion.Open();
                    //adaptador.Fill(datos, "clientes");
                    origenDatos.ConnectionString=conexion.ConnectionString;
                    origenDatos.SelectCommand=comando.CommandText;
                    origenDatos.ID = "origenDatosID";
                }
                catch (Exception)
                {

                }
                finally
                {
                    //Cerramos la conexión
                    conexion.Close();
                }
            }
            

            fvCodigo.DataSourceID = origenDatos.ID;
            
            fvCodigo.DataBind();
        }

        private void ActualizarFVCodigo()
        {
            DataSet datos = new DataSet();
            using (SqlConnection conexion = new SqlConnection())
            {
                conexion.ConnectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2014ConnectionString"].ToString();
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE Sales.Customer SET ModifiedDate = @ModifiedDate WHERE (CustomerID = @CustomerID)";
                comando.Connection = conexion;

                
                comando.Parameters.Add("@ModifiedDate", SqlDbType.DateTime, 8).Value = (fvCodigo.FindControl("ModifiedDateTextBox") as System.Web.UI.WebControls.TextBox).Text;
                comando.Parameters.Add("@CustomerID", SqlDbType.Int, 4).Value = (fvCodigo.FindControl("CustomerIDLabel1") as System.Web.UI.WebControls.Label).Text;
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);


                try
                {
                    conexion.Open();
                    adaptador.Update(datos, "clientes");
                }
                catch (Exception)
                {

                }
                finally
                {
                    //Cerramos la conexión
                    conexion.Close();
                }
            }
            
            fvCodigo.DataBind();
        }
    }
    
}