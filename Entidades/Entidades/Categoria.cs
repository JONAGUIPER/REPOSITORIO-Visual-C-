using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria
    {
        int idCategoria;
        string nombreCategoria;
        float precioCategoria;
        List<Coche> coches = new List<Coche>();
    }
}
