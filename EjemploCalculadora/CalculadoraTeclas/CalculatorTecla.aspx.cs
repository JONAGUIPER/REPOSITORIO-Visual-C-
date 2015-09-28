using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculadoraTeclas
{
    public partial class CalculatorTecla : System.Web.UI.Page
    {
        private string Snumero=string.Empty;
        private float numero1, numero2 = 0.0F;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private string GetData()
        {
            return txtDatos.Text;
        }
        private void Concatenar(string caracter)
        {
            Snumero += caracter;
        }
        private void SetData(string data)
        {
            txtDatos.Text = data;
        }

        public void EscribirPantalla(object sender,EventArgs e)
        {
            string boton = (sender as Button).Text;
            Snumero = GetData();
            Concatenar(boton);
            SetData(Snumero);
        }
        public void Operacion(object sender,EventArgs e)
        {
            string opera = (sender as Button).Text;
            //esta variable sesion almacena valores en el servidor para que aun cuando la pagina se referesque pueda seguir manteniendo los datos que necesite
            Session["valor1"] = GetData();
            Snumero = string.Empty;
            Session["operacion"] = opera;
            SetData("");
        }
        public void Enter(object sender, EventArgs e)
        {
            Session["valor2"] = GetData();
            Calcula();
        }
        private void Calcula()
        {
            CalculadoraBasica cal = new CalculadoraBasica();
            string val1 = Session["valor1"] as string;
            string val2 = Session["valor2"] as string;
            float.TryParse(val1, out numero1);
            float.TryParse(val2, out numero2);
            float resultado=0.0F;
            string Opera = Convert.ToString(Session["operacion"]);
            switch (Opera)
            {
                case ("+"):
                    {
                        resultado = cal.Sumar(numero1, numero2);
                        break;
                    }
                case ("-"):
                    {
                        resultado = cal.Restar(numero1, numero2);
                        break;
                    }
                case ("*"):
                    {
                        resultado = cal.Multiplicar(numero1, numero2);
                        break;
                    }
                case ("/"):
                    {
                        resultado = cal.Dividir(numero1, numero2);
                        break;
                    }
            }
            SetData(Convert.ToString(resultado));
        }
    }
}