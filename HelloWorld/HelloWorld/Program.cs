using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            double resultado = 0;
            Calculadora cal = new Calculadora();

            opcion = mostrarMenu();
            while (opcion != 5)
            {
                resultado = iniciarCalculadora(opcion);
                if (opcion > 0 && opcion >= 4)
                {
                    mostrarTexto("El resultado es: " + resultado);
                }
                Console.ReadKey();
                opcion = mostrarMenu();
            }
            Environment.Exit(0);

        }

        //string: se usa para guardar texto que no se va a manipular demasiado. por ejemplo mostrar en pantalla
        //String: es una wraper o superclase que contiene a string que ocupa mas memoria y se utiliza cuando las operaciones con el texto es mas avanzada
        static double iniciarCalculadora(int opcion)
        {

            int[] numeros = new int[2];
            double resultado = 0;
            Calculadora cal = null;
            switch (opcion)
            {
                case 1:
                    {
                        mostrarTexto("SUMA DE 2 NÚMEROS");
                        numeros = pedirDatos();
                        cal = new Calculadora(numeros[0], numeros[1]);
                        resultado = cal.Sumar();
                        break;
                    }
                case 2:
                    {
                        mostrarTexto("RESTA DE 2 NÚMEROS");
                        numeros = pedirDatos();
                        cal = new Calculadora(numeros[0], -numeros[1]);
                        resultado = cal.Sumar();
                        break;
                    }
                case 3:
                    {
                        mostrarTexto("MULTIPLICACIÓN DE 2 NÚMEROS");
                        numeros = pedirDatos();
                        cal = new Calculadora();
                        cal.Numero1 = numeros[0];
                        cal.Numero2 = numeros[1];
                        resultado = cal.Multiplicar();
                        break;
                    }
                case 4:
                    {
                        mostrarTexto("DIVISION DE 2 NÚMEROS");
                        numeros = pedirDatos();
                        cal = new Calculadora(numeros[0], numeros[1]);
                        resultado = cal.Dividir();
                        break;
                    }
                default:
                    mostrarTexto("Opción Inválida");
                    break;
            }
            return resultado;
        }
        static void mostrarTexto(string texto)
        {
            Console.WriteLine(texto);
        }
        static int mostrarMenu()
        {
            Console.Clear();
            mostrarTexto("1 - Suma\n2 - Resta\n3 - Multiplicación\n4 - División\n5 - Salir!!\n\n Elija una Opción");
            int opcion = 0;
            opcion = Int16.Parse(Console.ReadLine());
            return opcion;
        }
        static int[] pedirDatos()
        {
            int[] res = new int[2];
            mostrarTexto("Ingrese el primer número:");
            res[0] = (Int16.Parse(Console.ReadLine()));
            mostrarTexto("Ingrese el segundo número:");
            res[1] = (Int16.Parse(Console.ReadLine()));
            return res;
        }
        static int sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
        static int multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }
        static double dividir(int numero1, int numero2)
        {
            return (double)numero1 / (double)numero2;
        }

    }


}
