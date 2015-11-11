using System.Collections.Generic;

namespace Entidades
{
    public class Estado
    {
        public int IdEstado { get; set; }
        public string Ubicacion { get; set; }
        List<Coche> coches = new List<Coche>();
    }
}