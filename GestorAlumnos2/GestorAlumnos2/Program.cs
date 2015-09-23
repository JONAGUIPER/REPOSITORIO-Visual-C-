using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorAlumnos2
{
    class Program
    {
        static void Main(string[] args)
        {
            EjecutarOpciones(MostrarMenu());
            Console.ReadKey();
        }
        //Funciones para trabajar
        private static int MostrarMenu()
        {
            Console.WriteLine("1 - Mostrar Alumnos");
            Console.WriteLine("2 - Añadir Alumnos");
            Console.WriteLine("3 - Salir!!");
            Console.WriteLine("Escoja Opcion: ");
            return Int16.Parse(Console.ReadLine());
        }

        private static void EjecutarOpciones(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    {
                        Console.WriteLine("Mostrar Alumnos");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Añadir Alumnos");
                        break;
                    }
                case 3:
                    {
                        Environment.Exit(0);
                        break;                                              
                    }
                default:
                    {
                        Console.WriteLine("Opción Inválida");
                        break;
                    }
            }
        }
    }
}
