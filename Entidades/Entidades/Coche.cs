using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Coche
    {
        public string IdCoche { get; set; }
        public int Categoria { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Kilometraje { get; set; }
        public int Ubicacion { get; set; }
        public int Consumo { get; set; }
        public short Combustible { get; set; }
    }
}
