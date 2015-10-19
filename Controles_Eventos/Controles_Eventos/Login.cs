using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Controles_Eventos
{
    public class Login
    {
        private string usuario;
        private string contrasena;

        public string Usuario
        {
            get
            { return this.usuario; }
            set
            {//usuario = value;}
            }
        }

        public string Contrasena
        {
            get
            { return contrasena; }
            set
            {// contrasena = value;
            }
        }

        public Login(string usuario, string contrasena)
        {
            this.usuario = usuario;
            this.contrasena = contrasena;
        }
        public Login()
        {
            this.usuario = string.Empty;
            this.contrasena = string.Empty;
        }
    }
}