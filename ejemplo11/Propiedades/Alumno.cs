using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    public class Alumno
    {
        private int idAlumno;
        private string nombreAlumno;
        private static int cuantos=1;

        public int IdAlumno
        {
            get { return idAlumno; }
            private set { idAlumno = value; }

        }
        public string NombreAlumno
        {
            get { return nombreAlumno; }
            set { nombreAlumno = value; }

        }
        public Alumno()
        {
            IdAlumno = ++cuantos;
            this.nombreAlumno = String.Empty;
        }
        public Alumno(string nombre)
        {
            IdAlumno = ++cuantos;
            this.nombreAlumno = nombre;
        }
    }
}
