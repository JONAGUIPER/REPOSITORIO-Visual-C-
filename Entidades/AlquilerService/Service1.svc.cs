using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AlquilerService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {


        public Cliente GetClienteById(string idCliente)
        {
            Cliente clienteRow = new Cliente();
            //conseguir los PEDIDOS/ALQUILERES DEL CLIENTE
            List<Alquiler> alquilerCliente = GetOrdersByIdCliente(idCliente);

            using (SqlConnection conexion = new SqlConnection(
                ConfigurationManager.ConnectionStrings["AlquilerCocheCS"].ToString()))
            {
                SqlCommand comando = new SqlCommand("select * from dbo.CLIENTES where idClientes=@idCliente", conexion);
                comando.Parameters.Add("@idCliente", SqlDbType.VarChar, 15).Value = idCliente;
                try
                {
                    conexion.Open();
                    SqlDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        clienteRow.IdCliente = lector.GetString(0);
                        clienteRow.Nombre = lector.GetString(1);
                        clienteRow.Apellidos = lector.GetString(2);
                        clienteRow.Telefono = lector.GetString(3);
                        clienteRow.Email = lector.GetString(4);
                        //probando
                        //SqlCommand comando2 = new SqlCommand("select * from ALQUILADOS where idCliente=@idCliente", conexion);
                        //comando2.Parameters.Add("@idCliente", SqlDbType.VarChar, 15).Value = idCliente;
                        //SqlDataReader lector2 = comando2.ExecuteReader();
                        //Alquiler alquilerCliente = new Alquiler();
                        clienteRow.Alquileres = alquilerCliente;
                    }
                    return clienteRow;
                }
                catch (Exception)
                {
                    //manejarexcepciones
                    return null;
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        public List<Cliente> GetClientes()
        {
            DbContext clientesDbTable = new DbContext();
            Cliente clienteRow = new Cliente();
            using (SqlConnection conexion = new SqlConnection(
                ConfigurationManager.ConnectionStrings["AlquilerCocheCS"].ToString()))
            {
                SqlCommand comando = new SqlCommand("select * from dbo.CLIENTES", conexion);
                try
                {
                    conexion.Open();
                    SqlDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        clienteRow.IdCliente = lector.GetString(0);
                        clienteRow.Nombre = lector.GetString(1);
                        clienteRow.Apellidos = lector.GetString(2);
                        clienteRow.Telefono = lector.GetString(3);
                        clienteRow.Email = lector.GetString(4);
                        //OBTENIENDO LOS PEDIDOS/ORDENES DE CADA CLIENTE
                        clienteRow.Alquileres = GetOrdersByIdCliente(clienteRow.IdCliente);
                        clientesDbTable.clientes.Add(clienteRow);
                    }
                    return clientesDbTable.clientes;
                }
                catch (Exception)
                {
                    //manejarexcepciones
                    return null;
                }
                finally
                {
                    conexion.Close();
                }
            }

        }

        public List<Alquiler> GetOrdersByIdCliente(string idCliente)
        {
            DbContext alquiladosDbTable = new DbContext();
            Alquiler alquilerRow = new Alquiler();
            using (SqlConnection conexion = new SqlConnection(
                ConfigurationManager.ConnectionStrings["AlquilerCocheCS"].ToString()))
            {
                SqlCommand comando = new SqlCommand("select * from dbo.ALQUILADOS where idCliente=@idCliente", conexion);
                comando.Parameters.Add("@idCliente", SqlDbType.VarChar, 15).Value = idCliente;
                try
                {
                    conexion.Open();
                    SqlDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        alquilerRow.IdAlquiler = lector.GetInt32(0);
                        alquilerRow.IdCoche = lector.GetString(1);
                        alquilerRow.IdCliente = lector.GetString(2);
                        alquilerRow.IdTienda = lector.GetInt32(3);
                        alquilerRow.TiendaEntrega = lector.GetInt32(5);
                        alquilerRow.FechaEntrega = lector.GetDateTime(4);
                        alquilerRow.FechaDevolucion = lector.GetDateTime(6);
                        alquilerRow.TiendaDevolucion = lector.GetInt32(7);
                        alquiladosDbTable.alquileres.Add(alquilerRow);
                    }
                    return alquiladosDbTable.alquileres;
                }
                catch (Exception)
                {
                    //manejarexcepciones
                    return null;
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        List<Coche> IService1.GetCarsByCategoryInStore(int idCategoria, int idTienda)
        {
            DbContext CocheDbTable = new DbContext();
            Coche CocheRow = new Coche();
            using (SqlConnection conexion = new SqlConnection(
                ConfigurationManager.ConnectionStrings["AlquilerCocheCS"].ToString()))
            {
                SqlCommand comando = new SqlCommand("select * from dbo.COCHES where idCategoria=@idCategoria and Ubicacion=@idTienda", conexion);
                comando.Parameters.Add("@idCategoria", SqlDbType.Int, 4).Value = idCategoria;
                comando.Parameters.Add("@idTienda", SqlDbType.Int, 4).Value = idTienda;
                try
                {
                    conexion.Open();
                    SqlDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        CocheRow.IdCoche = lector.GetString(0);
                        CocheRow.Categoria = lector.GetInt32(1);
                        CocheRow.Marca = lector.GetString(2);
                        CocheRow.Modelo = lector.GetString(3);
                        CocheRow.Kilometraje = lector.GetInt32(4);
                        CocheRow.Ubicacion = lector.GetInt32(5);
                        CocheRow.Consumo = lector.GetInt32(6);
                        CocheRow.Combustible = lector.GetByte(7);
                        CocheDbTable.coches.Add(CocheRow);
                    }
                    return CocheDbTable.coches;
                }
                catch (Exception)
                {
                    //manejarexcepciones
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
