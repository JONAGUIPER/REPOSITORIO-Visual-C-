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
            pruebas.miEvento += EjecutaAlDispararEvento;

            pruebas.generadorEvento(10);

            try
            {
                pruebas.crearExcepcion(50);
            }
            catch (Exception)
            {

                throw;
            }

            int valor;

            if (pruebas.convertir(5, out valor))
            {
                Label2.Text += "Si convierte y es: " + valor;
            }
            else
            {
                Label2.Text += "No se convierte porque entero NO es";
            }

            Label3.Text += pruebas.soyVirtual();
            Label4.Text += (new Ejemplos_1()).soyVirtual();
        }

        private void EjecutaAlDispararEvento(object sender, MyEventArgs e)
        {
            Label1.Text += "se disparo el evento " + sender.ToString()+"\r\n y con: "+e.Mensaje;
        }
    }
}