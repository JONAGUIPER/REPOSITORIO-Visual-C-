using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorCoches
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche co = new Coche();
            Coche co2 = new Coche();
            Console.WriteLine("Coches creado= "+Coche.Numero);//el resultado es 2
            //esto es para observar que al declarar un atributo static el valor cambia en todos los objetos creados
            Console.WriteLine("Ingrese numero 1");
            int numero1 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero 2");
            int numero2 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Resultado de Multiplicacion: "+Calculadora.Multiplicar(numero1,numero2));
            Console.WriteLine("Resultado de Division: "+Calculadora.Dividir(numero1,numero2));
            Console.WriteLine("Resultado de Multiplicacion: "+Calculadora.Multiplicar(numero1,numero2));
            Console.WriteLine("Resultado de Potencia (numero1^numero2): "+Calculadora.Potencia(numero1,numero2));

            Console.ReadKey();


        }
    }
}
