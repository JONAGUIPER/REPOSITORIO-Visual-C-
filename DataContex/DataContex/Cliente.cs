using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContex
{
    public class Cliente
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string NombreCompania { get; set; }
        public string TlfContacto { get; set; }
        public string PersonaContacto { get; set; }
        public List<Pedido> ListaPedidos { get; set; }



    }
}
