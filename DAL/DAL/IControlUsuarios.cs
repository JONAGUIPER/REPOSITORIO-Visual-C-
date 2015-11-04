using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface IControlUsuarios
    {
        bool Registrado(string usuario, string password);
    }
}
