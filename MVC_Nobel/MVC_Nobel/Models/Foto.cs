using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Nobel.Models
{
    public class Foto
    {
        public int fotoID { get; set; }
        public String fotoURL { get; set; }
        public string fotoTitulo { get; set; }

        public virtual ICollection<Comentario> comentarios { get; set; }
    }
}