using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCFotosAjax.Models
{
    public class Comentario
    {
        private readonly DateTime fechaComentario = DateTime.Now;
        public int IdComentario { get; set; }
        public string Autor { get; set; }
        [Display(Name = "Comentario")]
        public string Contenido { get; set; }
        [Display(Name ="Comentado")]
        [DisplayFormat(DataFormatString ="{0:D}")]
        public DateTime FechaComentario {
            get {
                return fechaComentario;
            }
        }
        public int IdFoto { get; set; }
        public Foto FotoComentario { get; set; }
    }
}