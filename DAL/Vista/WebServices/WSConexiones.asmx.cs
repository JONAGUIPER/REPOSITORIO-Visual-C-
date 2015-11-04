using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Services;
using DAL;

namespace Vista.WebServices
{
    /// <summary>
    /// Descripción breve de WSConexiones
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WSConexiones : System.Web.Services.WebService
    {

        [WebMethod]
        public string CadenaConexion()
        {
            return ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }
        [WebMethod]
        public int Suma(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
        [WebMethod]
        public bool Autorizacion(string usuario,string password)
        {
            ControlUsuarios cliente = new ControlUsuarios();
            return cliente.Registrado(usuario, password); ;
        }
    }
}
