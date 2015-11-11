using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DbContext
    {
        public List<Coche> coches = new List<Coche>();
        public List<Cliente> clientes = new List<Cliente>();
        public List<Alquiler> alquileres = new List<Alquiler>();
        public List<Categoria> categorias = new List<Categoria>();
        public List<Descuento> descuentos = new List<Descuento>();
        public List<Tienda> tiendas = new List<Tienda>();
        public List<Combustible> combustibles = new List<Combustible>();
        public List<Estado> estado = new List<Estado>();

    }
}
