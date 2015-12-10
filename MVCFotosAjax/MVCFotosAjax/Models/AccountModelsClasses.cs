using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MVCFotosAjax.Models
{
    public class UserContext : DbContext
    {
        public UserContext() : base("FotoAppServices")
        {

        }
    }

    public class Login {
        [Required]
        [Display(Name ="Usuario")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [Display(Name ="Recuerdame?")]
        public bool RememberMe { get; set; }
    }

    public class Register
    {
        [Required]
        [Display(Name = "Usuario")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar Password")]
        [Compare("Password",ErrorMessage ="Las Contraseñas no Coinciden")]
        public string ConfirmPassword { get; set; }

    }
    public class LocalPassword
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Password Actual")]
        public string OldPassword { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password Nuevo")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar nuevo Password")]
        [Compare("NewPassword",ErrorMessage ="Los 2 password no son iguales")]
        public string ConfirmPassword { get; set; }
    }
}
