using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeDatos
{
    enum DiasLaborables
    {
        LUNES,
        MARTES,
        MIERCOLES,
        JUEVES,
        VIERNES,

    }

    public struct DatosPersonales
    {
        public string nombre;
        public string apellido;
        public string dni;
        public DateTime fechaNacimiento;
        public Direccion direccion;
    }

    public class Class1
    {
        DiasLaborables miDiaExamen = DiasLaborables.VIERNES;
        DatosPersonales misDatos;
        //maneras de convertir un tipo de datps no nullable a Nullable
        Nullable<int> miEnteroNullable = null;
        int? otroEnteroNullable = null;

        public Class1()
        {
            Alumno miAlumno = new Alumno();
            miAlumno.impuestoVenta = 0.12F;
            Alumno miAlumno2 = new Alumno();
            miAlumno.impuestoVenta = 0.12F;
            Alumno miAlumno3 = new Alumno();
            miAlumno.impuestoVenta = 0.12F;
            Alumno.impuestodeCompra = 0.20F;//Por ser una variable estatica al cambiarla una vez se cambia para todos lo obejtos que se han instanciados
            string nombreCurso = miAlumno.NombreCurso();


            miDiaExamen = DiasLaborables.VIERNES;
            misDatos.nombre = "Martin";
            misDatos.apellido = "Orbezabal";
            misDatos.dni = "123456789A";
            //misDatos.direccion = "LaCalle, 1, L, codpos, ciudad";
            misDatos.fechaNacimiento = new DateTime(1990, 1, 21);


        }

    }

}
