using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiposDeDatos
{
    public class Alumno
    {
        private DatosPersonales datosPersonales;
        private string curso;
        internal string nombre;
        internal float impuestoVenta;
        static internal float impuestodeCompra;
        List<Alumno> alumnos = new List<Alumno>();

        internal string Curso
        {
            get { return curso; }
            set { curso = value; }
        }

        public Alumno()
        {
            nombre = "Jon Ander";
            impuestoVenta = 0.2F;
        }
        public Alumno(string curso)
        {
            this.curso = curso;
        }

        public void Seleccion()
        {
            alumnos.Add(new Alumno() { Curso = "MVC" });
            alumnos.Add(new Alumno() { Curso = "NET" });
            alumnos.Add(new Alumno() { Curso = "UML" });
            alumnos.Select(a => a.Curso="MVC");
        }
        public bool Estudiando()
        {

            //throw new System.NotImplementedException();
            return true;
        }
    }
}