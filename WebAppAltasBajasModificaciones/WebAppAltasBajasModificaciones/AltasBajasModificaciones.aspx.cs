using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppAltasBajasModificaciones
{
    public partial class AltasBajasModificaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            int filasAfectadas;

            if (CheckBoxConectado.Checked)
            {
                filasAfectadas = actualizarConectado();
            }
            else
            {
                filasAfectadas = actualizarDesconectado();
            }

            if (filasAfectadas > 0)
            {
                lblMensaje.Text = "La actualización se ha efectuado correctamente en " + filasAfectadas + " clientes";
            }
            else
            {
                lblMensaje.Text = "La actualización NO se ha realizado, Inténtelo de nuevo más adelante";
            }

        }

        private int actualizarConectado()
        {
            // Modo Conectado
            // 1.- Conexión
            SqlConnection miCon = new SqlConnection();
            miCon.ConnectionString = ConfigurationManager.ConnectionStrings["miAW2014"].ConnectionString;

            // 2.- Comando a ejecutar
            SqlCommand miUpdateComando = new SqlCommand();
            miUpdateComando.CommandType = CommandType.Text;
            miUpdateComando.CommandText = "update Sales.Customer"
                                        + "   set modifieddate = @fecha"
                                        + " where customerId = @customerid";
            miUpdateComando.Connection = miCon;

            // Añadimos los parámetros
            miUpdateComando.Parameters.Add("@fecha", SqlDbType.DateTime, 8).Value = DateTime.Now;
            miUpdateComando.Parameters.Add("@customerid", SqlDbType.Int, 4).Value = Convert.ToInt32(txtID.Text);

            // 3.- Abrir la conexion
            miCon.Open();

            // 4.- Ejecutar el comando
            int filasAfectadas = miUpdateComando.ExecuteNonQuery();

            // 5.- Cerrar la conexion
            miCon.Close();

            return filasAfectadas;
        }

        private int actualizarDesconectado()
        {
            // Entorno Desconectado
            int filasAfectadas = 0;

            // 1.- Conexión
            SqlConnection miCon = new SqlConnection();
            miCon.ConnectionString = ConfigurationManager.ConnectionStrings["miAW2014"].ConnectionString;

            // 2.- Crear el Objeto Adaptador de Datos
            SqlDataAdapter miDataAdapter = new SqlDataAdapter();

            // 3.- Comandos a ejecutar
            // 3.1.- Sentencia Select
            SqlCommand miSelectComando = new SqlCommand();
            miSelectComando.Connection = miCon;
            miSelectComando.CommandType = CommandType.Text;
            miSelectComando.CommandText = "select * "
                                        + "  from Sales.Customer"
                                        + " where customerid < 51";

            // 3.2.- Sentencia Update
            SqlCommand miUpdateComando = new SqlCommand();
            miUpdateComando.CommandType = CommandType.Text;
            miUpdateComando.CommandText = "update Sales.Customer"
                                        + "   set modifieddate = @fecha"
                                        + " where customerId = @customerid";
            miUpdateComando.Connection = miCon;

            // Añadimos los parámetros
            SqlParameter fechaParametro = new SqlParameter("@fecha", SqlDbType.DateTime, 8);
            SqlParameter idParametro = new SqlParameter("@customerid", SqlDbType.Int, 4);
            miUpdateComando.Parameters.Add(fechaParametro);
            miUpdateComando.Parameters.Add(idParametro);

            // 3.3.- Asociamos las sentencias a mi Data Adapter
            miDataAdapter.SelectCommand = miSelectComando;
            miDataAdapter.UpdateCommand = miUpdateComando;

            // 4.- CommandBuilder
            SqlCommandBuilder builder = new SqlCommandBuilder(miDataAdapter);

            // 5.- Crear el Almacén de Datos Local y le asignamos un nombre
            // Crear el Almacén de Datos Local y le asignamos un nombre
            DataSet miDataSet = new DataSet();

            // 6.- Abrir la conexion
            miCon.Open();

            // 7.- Rellenar el DataSet
            miDataAdapter.Fill(miDataSet, "Clientes");

            // 8.- Cerrar la conexion
            miCon.Close();

            // 9.- Actualizar Dataset
            // 9.1.- Creamos una tabla
            DataTable T_Clientes = miDataSet.Tables["Clientes"];
            // 9.2.- Recorremos la tabla
            foreach (DataRow miFila in T_Clientes.Rows)
            {
                // El dato de la celda lo da como Object => hago Unboxing a int
                int actualID = (int)miFila["customerid"];

                if (actualID == Convert.ToInt32(txtID.Text))
                {
                    miFila["modifieddate"] = DateTime.Now.AddDays(1);

                    // Añadimos los parámetros a la sentencia Update
                    fechaParametro.Value = (DateTime)miFila["modifieddate"];
                    idParametro.Value = actualID;
                    filasAfectadas++;
                }
            }
            
            // 10.- Abrir la conexion
            miCon.Open();

            // 11.- Actualizar BBDD
            miDataAdapter.Update(miDataSet, "Clientes");

            // 12.- Cerrar la conexion
            miCon.Close();

            // 13.- Rellenamos el GridView para ver los cambios
            GridViewClientes.DataSource = miDataSet.Tables["Clientes"];
            GridViewClientes.DataBind();

            return filasAfectadas;
        }
    }
}