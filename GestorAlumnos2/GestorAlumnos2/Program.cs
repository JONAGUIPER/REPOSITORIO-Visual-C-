using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorAlumnos2
{
    class Program
    {
        static FactoriaAlumnos listaAlumnos = null;
        static void Main(string[] args)
        {
            listaAlumnos = new FactoriaAlumnos();
            int opcion = 0;
            opcion = MostrarMenu();
            while (opcion < 4 && opcion > 0)
            {
                EjecutarOpciones(opcion);
                opcion=MostrarMenu();
            }
            
            Console.ReadKey();
        }
        //Funciones para trabajar
        private static int MostrarMenu()
        {
            Console.WriteLine("*******************");
            Console.WriteLine("*      MENU       *");
            Console.WriteLine("*******************");
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
                        MostrarAlumnos(listaAlumnos.MostrarAlumnos());
                        //Console.WriteLine("Mostrar Alumnos");
                        break;
                    }
                case 2:
                    {
                        AdicionarAlumno();
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
        private static void MostrarAlumnos(IList <Alumno> alumnos)
        {
            Alumno al = null;
            Console.WriteLine("*******************");
            Console.WriteLine("*  Lista Alumnos  *");
            Console.WriteLine("*******************");
            for (int i = 0; i < alumnos.Count; i++)
            {
                al=alumnos.ElementAt(i);
                Console.WriteLine(i+" "+al.Nombre+" "+al.Apellido);
            }
        }

        private static void AdicionarAlumno()
        {
            Console.Clear();
            Console.WriteLine("******************");
            Console.WriteLine("* Añadir Alumnos *");
            Console.WriteLine("******************");
            Alumno al = new Alumno();
            Console.WriteLine("Introduzca Nombre");
            al.Nombre = Console.ReadLine();
            Console.WriteLine("Introduzca Apellidos");
            al.Apellido = Console.ReadLine();
            listaAlumnos.AddAlumno(al);
        }
       
    }
}
