using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFotos.Models
{
    public class Comentario
    {
        public int IdComentario { get; set; }
        public string Autor { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Texto { get; set; }
        public int FotoId { get; set; }
    }
}