using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioValidacion
{
    public partial class CustomValidate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cvObligatorio_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (string.IsNullOrEmpty(txtObligatorio.Text.ToString()))
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }

        protected void cvFormatoX_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string patron = "^[_a-z0-9-]+(\\.[_a-z0-9-]+)*@[a-z0-9-]+(\\.[a-z0-9-]+)*(\\.[a-z]{2,3})$";
            if (System.Text.RegularExpressions.Regex.IsMatch(txtFormatoX.Text, patron))
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }

        }

        protected void cvComparacion_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (txtFormatoX.Text == txtComparacion.Text)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }

        protected void cvEntreValores_ServerValidate(object source, ServerValidateEventArgs args)
        {
            try
            {
                int valor = Convert.ToInt32(txtEntreValores.Text);
                if ((valor >= 5) && (valor <= 20))
                {
                    args.IsValid = true;
                }
                else
                {
                    args.IsValid = false;
                }
            }
            catch (Exception)
            {

                args.IsValid = false;
            }

        }

        protected void cvNumerioMayor0_ServerValidate(object source, ServerValidateEventArgs args)
        {
            try
            {
                float valor = float.Parse(txtNumeroMayor0.Text);
                if (valor > 0)
                {
                    args.IsValid = true;
                }
                else
                {
                    args.IsValid = false;
                }
            }
            catch (Exception)
            {

                args.IsValid = false;
            }
        }

        protected void btnValidar_Click(object sender, EventArgs e)
        { 
 
            if (Page.IsValid)
            {
                lblRespuesta.Text = "datos válidos";
            }
            else
            {
                lblRespuesta.Text = "datos inválidos";

            }
        }
    }
}