using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    class Indexador
    {
        private int count = 0;
        public int Count
        {
            get
            {
                return count;
            }
        }

        //LISTA DE ALUMNOS
        private List<Alumno> lstAlumnos = new List<Alumno>();

        public Indexador()
        {

            lstAlumnos.Add(new Alumno() { NombreAlumno = "qwerty" });
            lstAlumnos.Add(new Alumno() { NombreAlumno = "Idola" });
            lstAlumnos.Add(new Alumno() { NombreAlumno = "Ana" });
            lstAlumnos.Add(new Alumno() { NombreAlumno = "Patxi" });
            lstAlumnos.Add(new Alumno() { NombreAlumno = "periko" });
            count = lstAlumnos.Count;
        }

        public Alumno this[string nombre]
        {
            get
            {
                return lstAlumnos.Find(a => a.NombreAlumno == nombre);
                //tambien funciona:
                //Alumno elElegido = (from a in lstAlumnos
                //                    where a.NombreAlumno == nombre
                //                    select a).First<Alumno>();
                //return elElegido;
            }
            set
            {
                var id = (from a in lstAlumnos
                          where a.NombreAlumno == nombre
                          select new { a.IdAlumno }).First();
                int indice = (Convert.ToInt32(id)) - 1;
                lstAlumnos[indice].NombreAlumno = value.NombreAlumno;
            }
        }

        //INDEXADOR PARA ACCEDER MEDIANTE INDICE
        //es this porque se crea se forma en la clase en donde se crea (ver implementacion o instancia)
        public Alumno this[int index]
        {
            get
            {

                return lstAlumnos[index];
                //tambien funciona de esta manera:
                //Alumno elElegido = (from a in lstAlumnos
                //                    where a.NombreAlumno == nombre
                //                    select a).First<Alumno>();
                //return elElegido;
            }
            set
            {
                lstAlumnos[index].NombreAlumno = value.NombreAlumno;
                //una prueba infrucctuosa
                //Alumno elElegido = (from a in lstAlumnos
                //                    where a.NombreAlumno == nombre
                //                    select a).First<Alumno>();
                //lstAlumnos[elElegido.IdAlumno - 1].NombreAlumno = value.NombreAlumno;
                //elElegido = value;
                //Alumnos.Add(value);
            }
        }
    }
}
