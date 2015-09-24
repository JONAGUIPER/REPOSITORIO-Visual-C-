using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorAlumnos2
{
    class Alumno
    {
        private string nombre;
        private string apellido;
        private string telefono;
        private string email;
        private DateTime fechaNacimiento;

        public Alumno()
        {
            this.Nombre = "";
            this.Apellido = "";
            this.Telefono = "94";
            this.Email = "";
            this.FechaNacimiento = DateTime.Now;
        }
        public Alumno(string nombre,string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Telefono = "94";
            this.Email = "";
            this.FechaNacimiento = DateTime.Now.AddYears(19);
        }
        public string Nombre
        {
            get{ return nombre;}
            set{ nombre = value;}
        }
        public string Apellido
        {
            get{ return apellido;}
            set{ apellido = value;}
        }

        public string Telefono
        {
            get{return telefono;}
            set{telefono = value;}
        }

        public string Email
        {
            get{return email;}
            set{email = value;}
        }

        public DateTime FechaNacimiento
        {
            get{return fechaNacimiento;}
            set{
                if(value<=DateTime.Now.AddYears(-18)) {
                    Console.WriteLine("posee menos de 18 Años!!!");
                }
                else
                {
                    fechaNacimiento = value;
                }
                }
        }

    }
}
