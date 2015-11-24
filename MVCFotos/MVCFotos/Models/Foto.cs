using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFotos.Models
{
    public class Foto
    {
        public int IDFoto { get; set; }
        public string Titulo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string FotoURL { get; set; }
        public List<Comentario> Comentarios { get; set; }
        
    }
}