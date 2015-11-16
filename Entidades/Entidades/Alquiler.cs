using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alquiler
    {
        public int IdAlquiler { get; set; }
        public string IdCoche { get; set; }
        public string IdCliente { get; set; }
        public int IdTienda { get; set; }
        public DateTime FechaEntrega { get; set; }
        public int TiendaEntrega { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public int TiendaDevolucion { get; set; }
    }
}
