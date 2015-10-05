using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeDatos
{
    public static class Extensora
    {
        public static string NombreCurso(this Alumno mialumno)//Metodo para extende la clase alumno
        {
            return mialumno.nombre + " " + mialumno.Curso;
        }
    }
}
