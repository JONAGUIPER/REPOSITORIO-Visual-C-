using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorAlumnos2
{
    class FactoriaAlumnos
    {
        IList<Alumno> alumnos = new List<Alumno>();

        public FactoriaAlumnos()
        {
            cargarDatos();
        }

        private void cargarDatos()
        {
            Alumno al = new Alumno();
            al.Nombre = "Jon";
            al.Apellido = "Aguinaco Peraza";
            alumnos.Add(al);
        }
        //MostrarAlumnos
        public IList<Alumno> MostrarAlumnos()
        {
            return alumnos;
        }
        //AñadirAlumnos
        public void AddAlumno(Alumno al)
        {
            //alumnos = new List<Alumno>();
            alumnos.Add(al);
        }
    }
}
