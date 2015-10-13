using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContex
{
    public class TablaClientes
    {
        public List<Cliente> clientes = new List<Cliente>();

        public void Insert(Cliente nuevo)
        {
            clientes.Add(nuevo);
        }

        public event EventHandler insertOK = null;
        public void Insert(int id, string nombreC, string tlfContacto, string personaContacto)
        {
            if (true)
            {
                if (insertOK != null)
                {
                    insertOK(this, new EventArgs());
                    clientes.Add(new Cliente
                    {
                        Id = id,
                        NombreCompania = nombreC,
                        TlfContacto = tlfContacto,
                        PersonaContacto = personaContacto,
                        ListaPedidos = new List<Pedido>()
                    });
                }
            }

        }
    }
}
