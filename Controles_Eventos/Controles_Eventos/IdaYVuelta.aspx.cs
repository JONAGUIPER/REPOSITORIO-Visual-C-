using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Controles_Eventos
{
    public partial class IdaYVuelta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)//esto es para saber si es l aprimera ves que se carga la pagina y de esa manera no recargar ndatos que se cargaron la primera vez
            {
                lblIdaVuelta.Text = "Primera carga de la pagina";
            }
            else
            {
                lblIdaVuelta.Text = "Postback de la pagina";

            }
        }
    }
}