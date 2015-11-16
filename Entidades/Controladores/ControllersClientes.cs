using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace Controladores
{
    public class ControllersClientes
    {
        
        List<Cliente> listaClientes;
        EntityServices.Service1Client servicio;
        //ServiceReference1.Service1Client servicio;
        public ControllersClientes()
        {
            servicio = new EntityServices.Service1Client();
            //servicio = new ServiceReference1.Service1Client();
            listaClientes = servicio.GetClientes();
        }

        public List<CLientesNombreCompleto> NombresClientes()
        {
            List<CLientesNombreCompleto> nombreCompletoCLientes = new List<CLientesNombreCompleto>();
            var clientesSet = (from c in listaClientes
                               select new { c.IdCliente, c.Nombre, c.Apellidos });
            foreach (var item in clientesSet)
            {
                nombreCompletoCLientes.Add(new CLientesNombreCompleto()
                {
                    Nombre = item.Nombre,
                    Apellido=item.Apellidos,
                    ID=item.IdCliente
                });
            }
            return nombreCompletoCLientes;
        }

        public Cliente ClienteById(string Id)
        {
            return listaClientes.Find(c=>c.IdCliente==Id);
        }

        public List<Alquiler> PedidosByCliente(string IdCliente)
        {
            return (listaClientes.Find(c => c.IdCliente == IdCliente)).Alquileres;
        }

    }
}
