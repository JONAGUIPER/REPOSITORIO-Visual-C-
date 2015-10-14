using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Repaso2;

namespace PruebaEjemplos
{
    public partial class pruebas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Ejemplos pruebas = new Ejemplos();
            //Aqui pongo el evento a ser escuchado
            pruebas.miEvento += Pruebas_miEvento;
            pruebas.generadorEvento(10);
            int valor;

            if (pruebas.convertir(5, out valor))
            {
                Label2.Text = "se convierte y es: " + valor;
            }
            else
            {
                Label2.Text = "No se convierte porque entero NO es";
            }
        }

        private void Pruebas_miEvento(object sender, EventArgs e)
        {
            Label1.Text = "se disparo el evento" + sender.ToString();
        }
    }
}