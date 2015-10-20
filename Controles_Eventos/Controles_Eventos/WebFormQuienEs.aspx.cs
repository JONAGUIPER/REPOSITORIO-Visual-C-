using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Controles_Eventos
{
    public partial class WebFormQuienEs : System.Web.UI.Page
    {
        List<Login> misLogin = new List<Login>();
        protected void Page_Init(object sender, EventArgs e)
        {
            misLogin.Add(new Login("JON ANDER", "123"));
            misLogin.Add(new Login("MAIHUM", "456"));

            misLogin.Add(new Login("MIRANDA", "789"));

        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            string us = txtUsuario.Text.ToUpper();
            string con = txtContrasena.Text;
            lblAlertContrasena.Text = string.Empty;
            lblAlertUsuario.Text = string.Empty;

            if (string.IsNullOrWhiteSpace(us) || string.IsNullOrWhiteSpace(con))
            {
                if (string.IsNullOrWhiteSpace(us))
                {
                    lblAlertUsuario.Text = "Debe escribir un usuario";
                }
                else
                {
                    lblAlertContrasena.Text = "Debe escribir una contraseña";
                }

            }
            else
            {
                Login entrante = null;

                Trace.Warn("foreach inicio");
                foreach (Login item in misLogin)
                {
                    string usuar = item.Usuario;
                    if (usuar == us)
                    {
                        entrante = item;
                        break;
                    }
                }
                Trace.Warn("foreach fin");

                Trace.Warn("Find Inicio Lamda");
                entrante = misLogin.Find(u => u.Usuario == us);
                Trace.Warn("Find Fin Lamda");

                Trace.Warn("Find Inicio LINQ");
                entrante = (from c in misLogin where c.Usuario == us select c).FirstOrDefault();
                Trace.Warn("Find Fin LINQ");
                if (entrante != null)
                {
                    if (entrante.Contrasena == con)
                    {
                        Session["nombreUsuario"] = txtUsuario.Text;
                        Response.Redirect("Inicio.aspx");
                        lblPermiso.ForeColor = System.Drawing.Color.Green;
                        lblPermiso.Text = "BIENVENIDO!!!!";
                    }
                    else
                    {
                        lblPermiso.ForeColor = System.Drawing.Color.Red;
                        lblPermiso.Text = "Contraseña INVALIDA";
                    }
                }
                else
                {
                    lblPermiso.ForeColor = System.Drawing.Color.Blue;
                    lblPermiso.Text = "NO existe Usuario";
                }
            }
        }
    }
}