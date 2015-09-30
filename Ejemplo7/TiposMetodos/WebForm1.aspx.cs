using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TiposMetodos
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //Declarar una variable para almacenar la edad de una persona
        //sbyte De -128 a 127  // short  De -32.768 a 32.767               //long De –9.223.372.036.854.775.808 a 9.223.372.036.854.775.807
        //byte 0-256;   // int  De -2.147.483.648 a 2.147.483.64
        byte edadPersona;
        //Declarar una variable para almacenar fecha de nacimiento
        DateTime fechaNacimiento;
        //Declarar una variable para almacenar Nombre de una persona
        string nombrePersona;
        //Declarar una varaiable para almacenar el Nombre y Apellidos de una persona
        string[] nombreCompleto = new string[3] { "Nombre", "Apellido1", "Apellido2" };
        //Declarar variable para almacenar el sueldo de una persona
        //float =  7 dígitos
        //decimal = 28-29 dígitos significativos 
        float sueldoPersona;
        //Definir una constante para almacenar un impuesto
        const float IMPUESTO = 0.03F;

        protected void Page_Load(object sender, EventArgs e)
        {
            //inicializar todas las variables
            edadPersona = 40;
            fechaNacimiento = new DateTime(1984, 11, 30);
            nombreCompleto[0] = "Jon Ander";
            nombreCompleto[1] = "Aguinaco";
            nombreCompleto[2] = "Peraza";
            nombrePersona = nombreCompleto[0];
            sueldoPersona = 2300F;

            //Llamar a un metodo que muestre los datos de la persona en el formulario
            //ShowPersonaData(nombreCompleto, edadPersona, sueldoPersona, fechaNacimiento);

            ShowPersonaData();

            txtNombreCompleto.Text = ConcatenarNombreCompleto(nombreCompleto);
            txtApellidos.Text = ConcatenarNombreCompleto(nombreCompleto[1],nombreCompleto[2]);

            txtImpuestoDefecto.Text = CalcularImpuesto(sueldoPersona).ToString();
            txtImpuestoEstablecido.Text = CalcularImpuesto(sueldoPersona,0.15F).ToString();

            int mayor = 0;
            
            txtResultadoEdad.Text = TryMayor(70, 70, out mayor).ToString()+" "+mayor;

            //Obtiene un valor que indica si la página se está mostrando por primera vez o si se está cargando como respuesta a un postback.
            if (Page.IsPostBack)
            {

            }
        }
        //crear un método que muestre en el formulario los datos de la persona
        private void ShowPersonaData(
            string[] nombreCompleto, byte edadPersona,
            float sueldoPersona, DateTime fechaNacimiento)
        {
            txtNombre.Text = nombreCompleto[0];
            txtApellido1.Text = nombreCompleto[1];
            txtApellido2.Text = nombreCompleto[2];
            txtEdad.Text = edadPersona.ToString();
            txtFechadeNacimiento.Text = fechaNacimiento.ToShortDateString();
            txtSueldo.Text = sueldoPersona.ToString();
        }
        //Crear una sobrecarga del metodo anterior...
        private void ShowPersonaData()
        {
            txtNombre.Text = nombreCompleto[0];
            txtApellido1.Text = nombreCompleto[1];
            txtApellido2.Text = nombreCompleto[2];
            txtEdad.Text = edadPersona.ToString();
            //txtFechadeNacimiento.Text = fechaNacimiento.ToShortDateString();
            txtSueldo.Text = sueldoPersona.ToString();
        }

        //usando este tipo de metodos permite trabajar con un numero indefinido de PARAMETROS, de manera que trabajara con todos los parametros que se envien al metodo
        //Importante, todos los parametros deben ser del mismo tipo
        private string ConcatenarNombreCompleto (params string[] nombres)
        {
            string nombreConcatenado = String.Empty;
            for (int i = 0; i < nombres.Length; i++)
            {
                nombreConcatenado += nombres[i] + " ";
            }
            //Trim elimina los espacios al comienzo y final de la cadena de texto
            return nombreConcatenado.Trim();
        }

        //metodo con parametro opcional: se le asigna al parametro opcional un valor por defecto, si al llamarlo se pasa al toma el valor pasado sino el valor por defecto
        private float CalcularImpuesto(float sueldo, float impuesto = IMPUESTO)
        {
            return sueldo * impuesto;
        }

        //Metodo con salidas adicionale: se establece un parametro por donde sale un valor a demas de la salida return normal
        //este metodo evia la edad mayor por: edadMayor, y retorna false, mientras que si son iguales retorna true y en edadMayor=0
        private bool TryMayor(int edad1, int edad2, out int edadMayor)
        {
            bool iguales = false;
            if (edad1>edad2)
            {
                edadMayor = edad1;
            }
            else if(edad2>edad1)
            {
                edadMayor = edad2;
            }
            else
            {
                edadMayor = 0;
                iguales= true;
            }
            return iguales;
        }
    }
}