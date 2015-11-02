using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace LoginADO
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.ToUpper();
            string pass = txtPassword.Text;

            if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(pass) && !string.IsNullOrEmpty(txtNombre.Text))
            {
                int filasAfectadas = 0;
                using (SqlConnection conexion = new SqlConnection())
                {
                    conexion.ConnectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2014ConnectionString"].ToString();
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "INSERT INTO sales.tUsuarios (usuario,password,Nombre,nacimiento) values(@usuario,@password,@Nombre,@nacimiento)";
                    comando.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = usuario;
                    comando.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = pass;
                    comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = txtNombre.Text;
                    comando.Parameters.Add("@nacimiento", SqlDbType.Date, 3).Value = Convert.ToDateTime(txtFechaNacimiento.Text);

                    conexion.Open();
                    filasAfectadas=comando.ExecuteNonQuery();
                    
                }
                if (filasAfectadas>0)
                {
                    lblEstado.Text = "Usuario Ingresado satisfactoriamente";
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    lblEstado.Text = "Usuario no registrado";
                }

            }
            else
            {
                lblEstado.Text = "No ha escrito en los campos requeridos";
            }
        }
    }
}