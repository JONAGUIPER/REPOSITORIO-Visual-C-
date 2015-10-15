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
        //crear una variable de solo lectura
        private readonly DateTime hoy = DateTime.Today;
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

        public bool convertir2(object incognito, out int valor, out string tipo)
        {
            Type tip = incognito.GetType();
            tipo = tip.ToString();
            if (tipo == "System.Int32")
            {
                valor = (int)incognito;
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
                throw new Exception("La suma con el numero aleatorio da como resultado 13");
            }
            return resultado;

        }

        /************************************************/
        //crear un evento
        public delegate void delegado(Object sender, MyEventArgs arg);
        public event delegado miEvento = null;
        //Por defecto podriamos crear el evento de esta manera usando como delegado el EventHandler
        //public event EventHandler miEvento = null;

        //Crear un metodo que cuando se complete una tarea determinada lo lance; p.e: llegar a un numero en bucle...
        public void generadorEvento(int valor)
        {
            Random aleatorio = new Random();
            int val, contador = 0;
            do
            {
                val = aleatorio.Next(1, 8000);
                contador++;
                if (val == valor)//he acabado la tarea
                {
                    if (miEvento != null)
                    {
                        //Disparo el evento
                        miEvento(this, new MyEventArgs("mensaje enviado a traves del EventArgs en la iteracion:" + contador));
                    }
                }

            } while (valor != val);
        }

        //Crear un evento que recoja 3 valores de tipo int y avise cuando alguno sea menor del 50 % de la media
        public int? mediaInteligente(params int[] valores)
        {
            int acumulador = 0;
            foreach (int i in valores)
            {
                acumulador += i;
            }
            float media = acumulador / valores.Length;
            int j = -1;
            do
            {
                j++;
            } while ((valores[j] >= media * 0.5) && (j < valores.Length));
            if (j == valores.Length)
            {
                return null;
            }
            else
            {
                return valores[j];
            }

        }

        //crear un metodo que se llame soyVirtual que se pueda sobreescribir en una clase derivada
        public virtual string soyVirtual()
        {
            return "soy TU PADRE";
        }


        static float estatica = 50.6F;
        //crear un metodo estatico que nos devuelva el valor de un variable estatica que pueda contener porcentajes
        static public float variableEstatica()
        {
            return estatica;
        }

    }
    //creando una clase derivada de eventargs para enviar invormacion desde donde se origina el aevento al recptor del mismo: El FORM principal
    public class MyEventArgs : EventArgs
    {
        //se crean las variables que se quieran
        public string Mensaje { get; set; }
        //y los constructores necesarios
        public MyEventArgs(string message)
        {
            Mensaje = message;
        }
    }

    //Crear una clase que se llame Ejemplos_1 y Su clase base sea Ejemplos
    public class Ejemplos_1 : Ejemplos
    {

        //CREAR UN CONSTRUCTOR SIN PARAMETROS
        public Ejemplos_1() : base()//esto llama al constructor SIN PARAMETROS sde la clase base y lo inicializa
        {

        }
        public Ejemplos_1(int bNumero1, int bNumero2) : base(bNumero1, bNumero2)//esto llama al constructor CON PARAMETROS sde la clase base y lo inicializa
        {

        }
        //sobreescribir el Objeto de la clase Base
        public override string soyVirtual()
        {
            //return base.soyVirtual(); //retorna el valor de la clase base
            return "No!! no puedo ser tu hijo!!";

        }
        //crear un metodo que haga hiding o ocultamiento de algun metodo de la clase base
        public new bool convertir(object tipo, out int valor)
        {
            //hacer everything
            valor = 0;
            return true;

        }
        //crear una colleccion que funcione como una cola es decir FIFO
        Queue<int> colaNumeros = new Queue<int>();
        //Lo mismo para la pila
        Stack<int> pilaNumeros = new Stack<int>();
        //declarar variable para que pueda aceptar variable null
        int? miNullable = null;
        Nullable<int> tambienNullable = null;

        //metodo con la sentencis ?:
        public void elIfLineal()
        {
            int a = 3;
            bool resultado = (a < 4) ? true : false;
        }

        //crear un indexer
        public object this[int indice]
        {
            get { return new object(); }
            set
            { //algo para ingresar datos
            }
        }
        public object this[string indice]
        {
            get { return new object(); }
            set
            { //algo para ingresar datos
            }
        }
        //uso de yield para mostrar resultados parciales
        public static System.Collections.Generic.IEnumerable<int> Power(int bas, int exp)
        {
            int acum = 1;
            for (int i = 0; i < exp; i++)
            {
                acum *= bas;
                yield return acum;
            }
        }
    }
}
