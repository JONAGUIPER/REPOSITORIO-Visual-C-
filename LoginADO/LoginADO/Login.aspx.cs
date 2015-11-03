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
    public partial class Login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected bool guardarCookie(string usuario)
        {
            Random aleatorio = new Random();
            //crear la COOKIE para combprobar la seguridad en las siguientes paginas (soloo para tiendas)
            HttpCookie galleta = new HttpCookie("seguridad");
            galleta["user"] = aleatorio.Next().ToString();
            Response.Cookies.Add(galleta);
            galleta.Expires = DateTime.Now.AddMinutes(5d);
            int filas = 0;
            try
            {
                using (SqlConnection conexion = new SqlConnection())
                {
                    conexion.ConnectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2014ConnectionString"].ToString();
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE sales.tUsuarios set galleta=@galleta where usuario=@usuario";
                    //comando.CommandText = "UPDATE sales.tUsuarios set galleta=@galleta,validez=@validez where usuario=@usuario";
                    comando.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = usuario;
                    comando.Parameters.Add("@galleta", SqlDbType.VarChar, 10).Value = Request.Cookies["seguridad"]["user"].ToString();
                    //comando.Parameters.Add("@validez", SqlDbType.DateTime, 8).Value = Convert.ToDateTime(Request.Cookies["user"].Expires);
                    conexion.Open();
                    filas = comando.ExecuteNonQuery();
                }
                return (filas > 0) ? true : false;


            }
            catch (Exception)
            {

                return false;
            }

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.ToUpper();
            string pass = txtPassword.Text;

            if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(pass))
            {
                bool acceso = false;
                string nombre = "";
                using (SqlConnection conexion = new SqlConnection())
                {
                    conexion.ConnectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2014ConnectionString"].ToString();
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT usuario,password,Nombre from sales.tUsuarios where usuario=@usuario";
                    comando.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = usuario;
                    conexion.Open();
                    SqlDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        nombre = lector.GetString(2);
                        acceso = (lector.GetString(0) == usuario) && (lector.GetString(1) == pass);
                    }
                }
                if ((acceso) && guardarCookie(usuario))
                {

                    lblEstado.Text = "entro!!!!";
                    Session["NOMBRE"] = nombre;
                    Session["USER"] = usuario;
                    Response.Redirect("Default.aspx");

                }
                else
                {
                    lblEstado.Text = "usuario y//o password incorrectos";
                }

            }
            else
            {
                lblEstado.Text = "No ha escrito en los campos requeridos";
            }

        }
    }
}