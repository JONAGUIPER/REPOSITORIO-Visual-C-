using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Coordinador : Empleado
    {
        public Coordinador(string elnombre):base(elnombre)
        {

        }
        public override string QuienEs()
        {
            return "(Coordinador):yo soy el coordinador";
        }
        public void TrabajoDeCoordinador()
        {

        }
    }
}
