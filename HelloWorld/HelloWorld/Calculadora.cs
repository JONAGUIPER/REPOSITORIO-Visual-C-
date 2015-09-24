using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Calculadora
    {
        private int numero1;
        private int numero2;

        public int Numero1
        {
            get { return numero1; }
            set { numero1 = value; }
        }

        public int Numero2
        {
            get { return numero2; }
            set { numero2 = value; }
        }

        public Calculadora()
        {
            /*this.numero1 = 0;
            this.numero2 = 0;*/
            Numero1 = 0;
            Numero2 = 0;
        }
        public Calculadora(int numero1, int numero2)
        {
            Numero1 = numero1;
            Numero2 = numero2;
        }
        public double Sumar()
        {
            return (double)(this.numero1 + this.numero2);
        }
        public double Multiplicar()
        {
            return (double)(Numero1 * Numero2);
        }
        public double Dividir()
        {
            return (double)(Numero1 / Numero2);
        }
    }
}
