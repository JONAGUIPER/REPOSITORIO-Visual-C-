using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cd
{
    public struct Cancion
    {
        public DateTime Duracion { get; set; }
        public string Titulo { get; set; }
        public string Interprete { get; set; }
        public Int16 Track { get; set; }
    }
}
