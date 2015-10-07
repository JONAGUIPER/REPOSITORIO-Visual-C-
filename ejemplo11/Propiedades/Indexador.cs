using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    class Indexador
    {
        public List<Alumno> alumnos2 = new List<Alumno>()
            {
                new Alumno() { NombreAlumno = "Martin" },
                new Alumno() { NombreAlumno = "Idola" },
                new Alumno() { NombreAlumno = "Ana" },
                new Alumno() { NombreAlumno = "Patxi" },
                new Alumno() { NombreAlumno = "periko" }
    };

    public Alumno this[string nombre]//es this porque se crea se forma en la clase en donde se crea (ver implementacion o instancia)
        {
            get
            {
                Alumno elElegido = (from a in alumnos2
                                    where a.NombreAlumno == nombre
                                    select a).First<Alumno>();
                return elElegido;
            }
            set
            {
                Alumno elElegido = (from a in alumnos2
                                    where a.NombreAlumno == nombre
                                    select a).First<Alumno>();
                alumnos2[elElegido.IdAlumno - 1].NombreAlumno = value.NombreAlumno;
                //elElegido = value;
                //Alumnos.Add(value);
            }
        }
    }
}
