using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DAL
{
    class DataContext : IDataContext
    {
        public DataTable GetCustomers()
        {
            DataTable datos = null;
            using (SqlConnection conexion = new SqlConnection())
            {
                try
                {
                    conexion.ConnectionString = @"Data Source=.\sqlexpress;Initial Catalog=AdventureWorks2014;Integrated Security=True";
                    conexion.Open();
                    SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM Sales.Customer", conexion);
                    DataSet datosSet = new DataSet();
                    adaptador.Fill(datosSet, "Clientes");
                    datos = datosSet.Tables["Clientes"];
                    return datos;
                }
                catch (Exception)
                {
                    //no hubo conexion: manejar eventos
                    return null;
                }
                finally
                {
                    conexion.Close();
                }
            }

        }

        public Cliente GetCustomersByID(int ClienteID)
        {
            Cliente clientito = null;
            using (SqlConnection conexion = new SqlConnection())
            {
                try
                {
                    conexion.ConnectionString = @"Data Source=.\sqlexpress;Initial Catalog=AdventureWorks2014;Integrated Security=True";
                    SqlCommand comando = new SqlCommand("SELECT * FROM Sales.Customer WHERE CustomerID=@customerID");
                    comando.Parameters.Add("@customerID", SqlDbType.Int, 10).Value = ClienteID;
                    comando.Connection = conexion;
                    conexion.Open();
                    SqlDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        clientito = new Cliente(lector.GetInt32(0), lector.GetInt32(1), lector.GetInt32(2), lector.GetString(4), lector.GetString(5),lector.GetDateTime(6));
                    }

                    
                    return clientito;
                }
                catch (Exception)
                {
                    //no hubo conexion: manejar eventos
                    return null;
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        public DataTable GetPedidos(int ClienteID)
        {
            throw new NotImplementedException();
        }

        public DataTable GetSalesOrdersHeaders()
        {
            DataTable datos = null;
            using (SqlConnection conexion = new SqlConnection())
            {
                try
                {
                    conexion.ConnectionString = @"Data Source=.\sqlexpress;Initial Catalog=AdventureWorks2014;Integrated Security=True";
                    conexion.Open();
                    SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM Sales.SalesOrderHeader", conexion);
                    DataSet datosSet = new DataSet();
                    adaptador.Fill(datosSet, "Ordenes");
                    datos = datosSet.Tables["Ordenes"];
                    return datos;
                }
                catch (Exception)
                {
                    //no hubo conexion: manejar eventos
                    return null;
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        public DataTable GetStores()
        {
            DataTable datos = null;
            using (SqlConnection conexion = new SqlConnection())
            {
                try
                {
                    conexion.ConnectionString = @"Data Source=.\sqlexpress;Initial Catalog=AdventureWorks2014;Integrated Security=True";
                    conexion.Open();
                    SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM Sales.Store", conexion);
                    DataSet datosSet = new DataSet();
                    adaptador.Fill(datosSet, "Tiendas");
                    datos = datosSet.Tables["Tiendas"];
                    return datos;
                }
                catch (Exception)
                {
                    //no hubo conexion: manejar eventos
                    return null;
                }
                finally
                {
                    conexion.Close();
                }
            }
        }
    }
}
