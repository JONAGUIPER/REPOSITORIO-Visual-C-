using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JugarConsola
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Beep();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine("Toma ya!!!!!!!!!!!!");
            int[] matrizEnteros = new int[4];
            Console.WriteLine("Tamaño de matriz: " + matrizEnteros.Length);
            Console.WriteLine("Dimensiones de la matriz: " + matrizEnteros.Rank);
            Console.Write("Matriz: ");
            for (int i = 0; i < matrizEnteros.Length; i++)
            {
                matrizEnteros[i] = i;
                Console.Write(" " + matrizEnteros[i]);
            }
            Console.WriteLine("");
            Array.Resize(ref matrizEnteros, (matrizEnteros.Length + 1));
            Console.WriteLine("Tamaño despues de Redimensionar " + matrizEnteros.Length);

            List<int> listaEnteros = new List<int>();
            listaEnteros.Add(1);
            int primeroElemento = (from i in listaEnteros select i).First();//LinQ

            Console.ReadKey();
        }
    }
}
