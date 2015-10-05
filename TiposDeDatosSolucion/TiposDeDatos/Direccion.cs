using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiposDeDatos
{
    public struct Direccion
    {
        /// <summary>
        /// nombre de calle o avenida
        /// </summary>
        public string calleAvenida;
        /// <summary>
        /// numero del portal
        /// </summary>
        public int portal;
        public int CP;
        public int piso;
        public string puerta;
        public string ciudad;
        public string provincia;
        public string pais;
    }
}