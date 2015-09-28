using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MiCalculator
{
    public partial class Calculadora : System.Web.UI.Page
    {
        private float numero1 = 0.0F;
        private float numero2 = 0.0F;

        private void GetDatos()
        {
            //Convierte la representación en forma de cadena de un número en flotante. Un valor devuelto indica si la operación tuvo éxito.
            float.TryParse(txtNumero1.Text, out numero1);
            float.TryParse(txtNumero2.Text, out numero2);
        }

        private void SetResultado(float dato)
        {
            txtResultado.Text = dato.ToString();
        }
        public void Opera(object sender, EventArgs e)
        {
            string boton = (sender as Button).ID;
            float resultado = 0.0F;
            GetDatos();
            CalculadoraBasica cal = new CalculadoraBasica();
            switch (boton)
            {
                case ("btnSuma"):
                    {
                        resultado=cal.Sumar(numero1, numero2);                 
                        break;
                    }
                case ("btnResta"):
                    {
                        resultado=cal.Restar(numero1, numero2);
                        break;
                    }
                case ("btnMultiplicacion"):
                    {
                        resultado=cal.Multiplicar(numero1, numero2);
                        break;
                    }
                case ("btnDivision"):
                    {
                        resultado=cal.Dividir(numero1, numero2);
                        break;
                    }
            }
            SetResultado(resultado);
        
        }

    }
}