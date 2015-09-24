using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorCoches
{
    class FactoriaCoches
    {
        private IList<Coche> coches=new List<Coche>();
        public FactoriaCoches()
        {
            Coche carro = new Coche();
            addCoche(carro);
        }
        public IList<Coche> GetCoches()
        {
            return coches;
        }
        public void addCoche(Coche carro)
        {
            coches.Add(carro);
        }
    }
}
