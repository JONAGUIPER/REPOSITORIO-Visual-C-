using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Descuento
    {
        private int idDescuento;
        private int limiteTiempo;
        private float procentaje;

        public int IdDescuento
        {
            get { return idDescuento; }
            set { idDescuento = value; }
        }
        public int LimiteTiempo
        {
            get
            {
                return limiteTiempo;
            }

            set
            {
                limiteTiempo = value;
            }
        }

        public float Porcentaje
        {
            get
            {
                return procentaje;
            }

            set
            {
                procentaje = value;
            }
        }
    }
}
