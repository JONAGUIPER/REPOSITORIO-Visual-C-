using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Empleado:Persona, IPersona
    {
        protected string empleadoNumero;
        protected string empleadoNombre;

        //public Empleado()
        //{
        //    this.empleadoNumero = "E0001";
        //    this.empleadoNombre = "Gorka";

        //}
        public Empleado(string suNombre)
        {
            this.empleadoNumero = "E0001";
            this.empleadoNombre = suNombre;

        }
        protected void TrabajoDeEmpleado()
        {
            
        }
        public virtual string QuienEs()
        {
            return "(Empleado):yo soy tu padre";
        }

        void IPersona.Andar()
        {
            throw new NotImplementedException();
        }

        void IPersona.Comer()
        {
            throw new NotImplementedException();
        }

        void IPersona.dormir()
        {
            throw new NotImplementedException();
        }

        public override void SoyAbstracto()
        {
            throw new NotImplementedException();
        }
    }
}
