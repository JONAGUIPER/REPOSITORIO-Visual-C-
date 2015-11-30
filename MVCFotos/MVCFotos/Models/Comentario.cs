using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCFotos.Models
{
    public class Comentario
    {
        public int IdComentario { get; set; }
        public string Autor { get; set; }
        public DateTime FechaCreacion { get; set; }
        [Required(ErrorMessage ="Debe escribir un comentario")]
        public string Texto { get; set; }
        public int FotoId { get; set; }
    }
}