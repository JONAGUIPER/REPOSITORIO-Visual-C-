using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Nobel.Models
{
    public class Comentario
    {
        public int comentarioID { get; set; }
        public string Texto { get; set; }
        public string Autor { get; set; }
        public int fotoID { get; set; }
        public Foto foto { get; set; }
    }
}