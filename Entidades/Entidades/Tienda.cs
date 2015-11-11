using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tienda
    {
        int idTienda;
        string nombreTienda;
        string direccion;
        string telefono;
        string email;
        List<Alquiler> alquileres = new List<Alquiler>();
        List<Coche> coches = new List<Coche>(); 

        public int IdTienda
        {
            get { return idTienda; }
            set { idTienda = value; }
        }

        public string NombreTienda
        {
            get { return nombreTienda; }
            set { nombreTienda = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

    }
}
