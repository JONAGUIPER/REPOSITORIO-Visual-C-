using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorAlumnos2
{
    class Coche
    {
        private string nBastidor;
        private string marca;
        private string modelo;
        private Int16 nVelocidades;
        private DateTime fMatricula;

        public Coche()
        {

        }
        public string NBastidor
        {
            get{return nBastidor;}

            set{nBastidor = value;}
        }

        public string Marca
        {
            get{return marca;}

            set{marca = value;}
        }

        public string Modelo
        {
            get{return modelo;}

            set{modelo = value;}
        }

        public DateTime FMatricula
        {
            get{return fMatricula;}

            set{fMatricula = value;}
        }
    }
}
