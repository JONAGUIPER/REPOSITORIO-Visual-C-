using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    abstract class Persona: IPersona
    {
        protected string nombre;
        protected string apellido;
        protected int edad;

        public abstract void SoyAbstracto();

        public void Andar()
        {
            throw new NotImplementedException();
        }

        public void Comer()
        {
            throw new NotImplementedException();
        }

        public void dormir()
        {
            throw new NotImplementedException();
        }
    }
}
