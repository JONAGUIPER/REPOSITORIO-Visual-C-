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
        public List<Cliente> GetCarsByCategoryInStore(int idCategoria, int idTienda)
        {
            
            throw new NotImplementedException();
        }

        public Cliente GetClienteById(string idCliente)
        {
            
            throw new NotImplementedException();
        }

        public List<Cliente> GetClientes()
        {
            using (SqlConnection conexion = new SqlConnection(
                ConfigurationManager.ConnectionStrings["AlquilerCocheCS"].ToString()))
            {
                SqlCommand comando = new SqlCommand("select * from dbo.CLIENTES");
                
            }
            DbContext clientesDbTable = new DbContext();
            Cliente clienteRow = new Cliente();


            while (reader.read)
            {
                clienteRow.IdCliente = reader.GetInt32(0);
                ...
                clientesDbTable.clientes.Add(clienteRow);
            }
            throw new NotImplementedException();
        }

        public string GetData(int value)
        {
            throw new NotImplementedException();
        }

        public List<Alquiler> GetOrdersByIdCliente(string idCliente)
        {
            throw new NotImplementedException();
        }
    }
}
