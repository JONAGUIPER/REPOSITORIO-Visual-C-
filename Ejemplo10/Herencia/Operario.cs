using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Operario : Empleado
    {
        public Operario(string nombre):base(nombre)
        {

        }
        public void TrabajoDeOperario()
        {
            
        }
        public override string QuienEs()
        {
            return "Soy el operario";
        }
    }
}
