using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Juegos
{
    public partial class LosJuegos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void JugarAleatorios(object sender, EventArgs e)
        {
            GenerarAleatorios();
        }
        private void GenerarAleatorios()
        {
            Random numero1 = new Random();
            Random numero2 = new Random(Convert.ToInt32(DateTime.Now.Ticks & int.MaxValue));
            ShowAleatorios(numero1.Next(1, 7), numero2.Next(1, 7));

        }
        private void ShowAleatorios(int numero1, int numero2)
        {
            txtDado1.Text = numero1.ToString();
            txtDado2.Text = numero2.ToString();

        }

        public void JugarNumeroPrimo(object sender, EventArgs e)
        {
            if (IsNumeroPrimo(GetdataPrimo()))
            {
                lblRespuesta.Text = "Si es un número Primo";
            }
            else
            {
                lblRespuesta.Text = "No es un número Primo";
            }
        }

        private int GetdataPrimo()
        {
            return Convert.ToInt32(txtPrimo.Text);
        }

        private bool IsNumeroPrimo(int numero)
        {
            bool respuesta = true;
            int i = 2;
            do
            {
                respuesta = (numero % i!=0);
                i++;
            } while (respuesta && i<numero);
            
            return respuesta;

        }
        public void CalcularConOperacion(Object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txtNumero1.Text);
            int numero2 = Convert.ToInt32(txtNumero2.Text);

            switch (txtOperacion.Text.Trim())
            {
                case ("+"):
                    {
                        lblResultadoOperacion.Text = (numero1+numero2).ToString();
                        break;
                    }
                case "-":
                    {
                        lblResultadoOperacion.Text = (numero1 - numero2).ToString(); 
                        break;
                    }
                case "*":
                    {
                        lblResultadoOperacion.Text = (numero1 * numero2).ToString(); 
                        break;
                    }
                case "/":
                    {
                        lblResultadoOperacion.Text = (numero1 / numero2).ToString(); 
                        break;
                    }

                default:
                    {
                        lblResultadoOperacion.Text = "la operacion introducida no es valida";
                        break;
                    }
            }

        }

        protected void CalcularMedia(object sender, EventArgs e)
        {
            lblDatos.Text = String.Empty;
            //Crear Array de 7 Elementos
            int[] arrayDatos = { 23, 34, 1,54,234,90,33};

            //calcular la media de los elementos pares
            int numeroElementos = arrayDatos.Length / 2;
            int suma = 0;
            float media=0;
            for (int i = 1; i < arrayDatos.Length; i+=2)
            {
                suma += arrayDatos[i];
            }
            media = (float)suma / (float)numeroElementos;
            //Mostrar la media en el TextBox
            txtMedia.Text = media.ToString("##,###.00");
            //Mostrar los elementos en el label
            for (int i = 1; i < arrayDatos.Length; i+=2)
            {
                lblDatos.Text += arrayDatos[i].ToString() + " ";
            }

        }

        protected void CodificarTexto(object sender, EventArgs e)
        {
            lblTextoCodificado.Text = String.Empty;
            char[] cadena = txtCodificar.Text.ToCharArray();
            for (int i = 0; i < cadena.Length; i++)
            {
                if (char.IsLower(cadena[i]))
                {
                    cadena[i] = char.ToUpper(cadena[i]);
                }
                else if (char.IsUpper(cadena[i]))
                {
                    cadena[i] = char.ToLower(cadena[i]);
                }
                else if (char.IsNumber(cadena[i]))
                {
                    cadena[i] = '.';
                }
            }

            //foreach (var caracter in cadena)
            //{
            //    lblTextoCodificado.Text += caracter.ToString();
            //}
            
            string cad = new string(cadena);
            lblTextoCodificado.Text = cad;
        }
    }
}