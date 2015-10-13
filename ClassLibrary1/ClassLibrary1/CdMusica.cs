using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cd
{
    public class CdMusica
    {
        public string Interprete { get; set; }
        public string Titulo { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public string Genero { get; set; }
        public string Discografica { get; set; }
        public string Caratula { get; set; }
        private List<Cancion> canciones;
        private Prestamo prestamo;
        private string ubicacion;
        public int IdCd { get; set; }

        public List<Cancion> Canciones
        {
            get { return canciones; }
            set { canciones = value; }
        }

        public string Ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }

        public struct Prestamo
        {
            public bool prestado;
            public string prestatario;
            public DateTime fecha;
        }


        public CdMusica()
        {
            IdCd = 0;
            Interprete = string.Empty;
            Titulo = string.Empty;
            FechaPublicacion = new DateTime();
            Genero = string.Empty;
            Discografica = string.Empty;
            canciones = new List<Cancion>();
            prestamo = new Prestamo();
            Ubicacion = string.Empty;
            Caratula = string.Empty;
        }
        public Prestamo EnPrestamo()
        {
            return this.prestamo;
        }


    }
}
