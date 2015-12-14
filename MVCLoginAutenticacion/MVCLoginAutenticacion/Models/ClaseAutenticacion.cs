using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCLoginAutenticacion.Models
{
    public class ContextoUsuarios:DbContext
    {
        public ContextoUsuarios() : base("DatosUsuarios")
        {

        }

        public System.Data.Entity.DbSet<MVCLoginAutenticacion.Models.Logueo> Logueos { get; set; }

        public System.Data.Entity.DbSet<MVCLoginAutenticacion.Models.Register> Registers { get; set; }
    }

    public class Logueo
    {
        //public int id { get; set; }
       
        [Required]
        [Display(Name = "Nombre de Usuario")]
        public string NombreUsuario { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Te Recuerdo?")]
        public bool RecordarMe { get; set; }
    }

    public class Register
    {
        //public int id { get; set; }
        [Required]
        [Display(Name = "Nombre de Usuario")]
        public string NombreUsuario { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar password")]
        [Compare("Password", ErrorMessage =
            "El password y la confirmacion del password no son iguales.")]
        public string ConfirmPassword { get; set; }
    }

    public class LocalPassword
    {
        //public int id { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "password Actual")]
        public string OldPassword { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Nuevo password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar Nuevo password")]
        [Compare("NewPassword",
            ErrorMessage =
            "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }


}