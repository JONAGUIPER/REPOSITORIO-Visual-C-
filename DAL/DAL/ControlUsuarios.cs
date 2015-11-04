using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ControlUsuarios : IControlUsuarios
    {
        public bool Registrado(string usuario, string password)
        {
            bool registrado = false;
            string usu = null;
            //Autenticar Usuario
            //Buscar si el usuario y contraseña existen en algun registro de la BD de tUsuarios
            //conexion a da bd tUsuarios
            using (SqlConnection conexion = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=AdventureWorks2014;Integrated Security=True"))
            {
                //Comando de busqueda de Usuarios
                SqlCommand comando = new SqlCommand("SELECT * FROM tUsuarios WHERE usuario=@usuario AND password=@password");
                //Parametros del comando(usuario y Contraseña que nos proporcionan desde los argumentos
                comando.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = usuario;
                comando.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = password;
                //determinar si existe segun lo que nos devuelve la BBDD
                //ExecutteReader, ExecuteNonQuery(para Update, delete, y devuelve la cantidad de filas afectadas) o ExecuteScalar(devuelve la primera columna de la primera fila si encuentra el elemento)?
                try
                {
                    conexion.Open();
                    usu= (string)comando.ExecuteScalar();
                }
                catch (InvalidCastException ie)
                {
                }
                catch (SqlException se)
                {
                }
                catch(Exception e)
                {
                }
                finally
                {
                    conexion.Close();
                }
            }
            registrado=!string.IsNullOrEmpty(usu);
            return registrado;
        }
    }
}
