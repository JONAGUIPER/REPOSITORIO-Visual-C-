using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BebidasMVC.Models
{
    public class Bebida
    {
        [Required]
        public string Marca { get; set; }
        [MaxLength(5)]
        public string Tipo { get; set; }
        [Range(20,30,ErrorMessage ="No es el costo")]
        public float Precio { get; set; }

        public virtual Cliente cliente { get; set; }
    }
}