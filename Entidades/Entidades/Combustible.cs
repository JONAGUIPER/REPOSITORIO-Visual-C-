using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Combustible
    {
        public int IdCombustible { get; set; }
        public string Tipo { get; set; }
        List<Coche> coches = new List<Coche>();
    }
}
