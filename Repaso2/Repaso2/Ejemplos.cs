using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso2
{
    //Crear enumeracion
    enum Verano
    {
        junio, julio, agosto, septiembre
    };
    //crear estructura
    struct estructura
    {
        int uno;
        string texto;

        public estructura(int uno, string texto)
        {
            this.uno = uno;
            this.texto = texto;
        }
        public string metodoEstructura()
        {
            return this.texto + this.uno;
        }
    }
    public class Ejemplos
    {


        //Crear una Constante
        int CONSTANTE = 30;
        //Crear un Campo Privado
        private int campoPrivado = 20;
        //Crear un campo encapsulado...
        private int campoEmcapsulado;

        public int CampoEncapsulado
        {
            get { return campoEmcapsulado; }
            set { campoEmcapsulado = value; }
        }

        //Crear una propiedad automatica
        public int PropiedadAutomatica { get; set; }

        //Crear un constructor por defecto
        public Ejemplos()
        {
            this.campoPrivado = 0;
            CampoEncapsulado = 0;
            PropiedadAutomatica = 0;
        }

        //Crear un constructor con 2 parametros
        //Que inicialicen el campo privado uy el encapsulado
        public Ejemplos(int encapsulado, int privado)
        {
            this.campoPrivado = privado;
            CampoEncapsulado = encapsulado;
        }

        //crear un procdimiento que acepte un paramtro de tipo int y 
        //lo compare con la costante y diga si es mayor o menor que ella
        public string mayorMenor(int valor)
        {
            if (valor > this.CONSTANTE)
            {
                return "mayor";
            }
            else if (valor < this.CONSTANTE)
            {
                return "menor";
            }
            else
            {
                return "igual";
            }
        }
        //Crear un procedimiento que nos diga si un parametro de entrada se puede convertir
        //al tipo de la variable encapsulada y ademas nos de de alguna manera el valor convertido
        public bool convertir(object tipo, out int valor)
        {
            if (tipo is Int32)
            {
                valor = (int)tipo;
                return true;
            }
            else
            {
                valor = 0;
                return false;
            }
        }


        //crear un metodo que nos sume un numero de elementos variable
        public int Sumar(params int[] sumandos)
        {
            int acumulador = 0;
            for (int i = 0; i < sumandos.Length; i++)
            {
                acumulador += sumandos[i];
            }
            return acumulador;
        }

        //crear un metodo que nos salude cuando le introducimos nuestro nombre, 
        //el saludo sera variable y siempre como parametro de entrada aunque casi siempre es HOLA
        public string Saludar(string nombre, string hola = "HOLA")
        {
            return (hola + " " + nombre);
        }

        //crear un metodo que nos devuelve el numero que le pasamos
        //mas un numero aleatorio si el numero resultante es 13 lanzara una excepcion

        public int crearExcepcion(int valor)
        {
            Random aleatorio = new Random();
            int resultado = aleatorio.Next() + valor;
            if (resultado == 13)
            {
                throw new System.ArgumentException("La suma con el numero aleatorio da como resultado 13");
            }
            return resultado;

        }

        /************************************************/
        //crear un evento
        //public delegate void delegado(Object sender,EventArgs arg);
        public event EventHandler miEvento = null;

        //Crear un metodo que cuando se complete una tarea determinada lo lance; p.e: llegar a un numero en bucle...
        public void generadorEvento(int valor)
        {
            Random aleatorio = new Random();
            int val;
            do
            {
                val = aleatorio.Next(1, 8000);
                if (val == valor)
                {
                    if (miEvento != null)
                    {
                        miEvento(this, new EventArgs());
                    }
                }

            } while (valor != val);
        }

        //crear un metodo que se llame soyVirtual que se pueda sobreescribir en una clase derivada
        public virtual string soyVirtual()
        {
            return "soy virtual del padre";
        }


        static float estatica = 50.6F;
        //crear un metodo estatico que nos devuelva el valor de un variable estatica que pueda contener porcentajes
        static public float variableEstatica()
        {
            return estatica;
        }

    }

    //Crear una clase que se llame Ejemplos_1 y Su clase base sea Ejemplos
    public class Ejemplos_1 : Ejemplos
    {

    }
}
