using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace BaseDeDatosExpress
{
    public partial class EntradaDatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FormView1.ChangeMode(FormViewMode.Edit);
            // FormView1.CurrentMode;

        }
        private void cargarFVCodigo()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString=connec
        }
    }
}