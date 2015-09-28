using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiCalculator
{
    public class CalculadoraBasica
    {
        public float Sumar(float sumando1, float sumando2)
        {
            return sumando1 + sumando2;
        }
        public float Restar(float minuendo, float sustraendo)
        {
            return (minuendo - sustraendo);
        }
        public float Multiplicar(float multiplicando1, float multiplicando2)
        {
            return multiplicando1 * multiplicando2;
        }
        public float Dividir(float dividendo, float divisor)
        {
            return dividendo / divisor;
        }
    }
}