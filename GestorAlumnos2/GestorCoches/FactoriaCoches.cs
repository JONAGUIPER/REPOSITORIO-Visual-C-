using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorAlumnos2
{
    class FactoriaCoches
    {
        IList<Coche> coches=new List<Coche>();
        public FactoriaCoches()
        {
            Coche carro = new Coche();
            addCoche(carro);
        }
        public void addCoche(Coche carro)
        {
            coches.Add(carro);
        }
    }
}
