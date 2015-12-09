using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFotosAjax.Models
{
    public class Foto
    {
        public int IdFoto { get; set; }
        public string Titulo { get; set; }
        public string URLFoto { get; set; }
        public virtual ICollection<Comentario> Comentarios { get; set; }
    }
}