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
    public partial class Tiendas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["USER"]==null)//si no hay session redirecciona a login
            {
                Response.Redirect("Login.aspx");
            }
            else if(seguridad(Session["USER"].ToString()))
            //if (true)
            {
                if (!Page.IsPostBack)
                {

                    lblWelcome.Text += " " + Session["NOMBRE"];
                    lblEstado.Text = "Cargando Tiendas...";
                    ddIdTiendas.Items.Clear();
                    using (SqlConnection conexion = new SqlConnection())
                    {
                        conexion.ConnectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2014ConnectionString"].ToString();
                        SqlCommand comando = new SqlCommand();
                        comando.Connection = conexion;
                        comando.CommandType = CommandType.Text;
                        comando.CommandText = "select Name from sales.Store";
                        conexion.Open();
                        SqlDataReader lector = comando.ExecuteReader();
                        while (lector.Read())
                        {
                            ddIdTiendas.Items.Add(lector.GetString(0).ToString());
                        }
                    }
                    lblEstado.Text = "";
                }
            }


        }

        private bool seguridad(string user)//en el usuario se encuentra el valor del usuario que esta en la sesion actual
        {
            bool respuesta = false;
            string cookieValor = "";
            DateTime cookieExpira;

            if (Request.Cookies["seguridad"] != null)//sino existe: expiro, y me redirecciona a la pagina de login
            {
                cookieValor = Request.Cookies["seguridad"]["user"];
                //actualizo el tiempo de vuida de la cookie
                Response.Cookies["seguridad"].Expires = DateTime.Now.AddMinutes(5d);
            }
            else
            {
                Response.Redirect("Login.aspx");
            }

            using (SqlConnection conexion = new SqlConnection())//aqui busco en la base de datos si elvalor de la coockie  coinside con el valor de la sesion actual
            {
                conexion.ConnectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2014ConnectionString"].ToString();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "select galleta,validez from sales.tUsuarios where usuario=@usuario";
                comando.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = user;
                conexion.Open();
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    respuesta = (lector.GetString(0) == cookieValor)
                        && (lector.GetDateTime(1) >= DateTime.Now);
                }
            }
            return respuesta;
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            lblEstado.Text = "Cargando Tiendas...";
            DataSet dataS = new DataSet();
            using (SqlConnection conexion = new SqlConnection())
            {
                conexion.ConnectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2014ConnectionString"].ToString();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "select * from sales.Customer as c,sales.Store as s where s.Name=@tiendaName and c.StoreID=s.BusinessEntityID";
                comando.Parameters.Add("@tiendaName", SqlDbType.VarChar, 50).Value = ddIdTiendas.SelectedValue.ToString();

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                conexion.Open();
                adaptador.Fill(dataS, "Tiendas");
                gvTiendas.DataSource = dataS;
                gvTiendas.DataMember = dataS.Tables["Tiendas"].ToString();
                gvTiendas.DataBind();
            }
            lblEstado.Text = "";
        }

        protected void gvTiendas_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow filaSeleccionada = (sender as GridView).SelectedRow;
            txtNombre.Text = filaSeleccionada.Cells[2].Text;
            txtPersonID.Text = filaSeleccionada.Cells[3].Text;
            txtDemografia.Text = filaSeleccionada.Cells[4].Text;
            txtModificacion.Text = filaSeleccionada.Cells[6].Text;
        }
    }
}