using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorCoches
{
    class Calculadora
    {
        public static int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
        public static int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }
        public static double Dividir(int numero1, int numero2)
        {
            return (double)numero1 / (double)numero2;
        }
        public static int Factorial(int numero1)
        {
            int resultado = 1;
            while (numero1 > 0)
            {
                resultado *= numero1;
                numero1--;
            }
            return resultado;
        }
    }
}
