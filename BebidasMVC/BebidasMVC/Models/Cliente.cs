using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BebidasMVC.Models
{
    public class Cliente
    {
        [Required]
        public int idCuenta { get; set; }
        [MaxLength(20)]
        public string nombre { get; set; }
        public string apellidos { get; set; }
        [Display(Name ="Correo Electronico",Description ="ingrese su correo Electronico")]
        [EmailAddress]
        public string email { get; set; }
        [Phone]
        public string telefono { get; set; }
        [Range(18, 200, ErrorMessage = "No estas autorizado para esta compra")]
        public int edad { get; set; }

        public virtual ICollection<Bebida> Bebidas { get; set; }
    }
}