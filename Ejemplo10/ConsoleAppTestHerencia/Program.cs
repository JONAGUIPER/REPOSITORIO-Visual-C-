using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Herencia;

namespace ConsoleAppTestHerencia
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string elNombreClaseBase = "Ane";
            Empleado miEmpleado = new Empleado("Perico");
            Operario miOperario = new Operario(elNombreClaseBase);
            Coordinador miCoordinador = new Coordinador("Pilar");

            IPersona ipersona = miEmpleado;
            

            miEmpleado = miCoordinador;
            miEmpleado.QuienEs();
            miOperario.QuienEs();
            miEmpleado = miOperario;
            miEmpleado.QuienEs();
            
               

            
          
            

        }
    }
}
