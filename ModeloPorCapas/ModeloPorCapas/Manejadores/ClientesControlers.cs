using ModeloPorCapas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModeloPorCapas.Manejadores
{
    public class ClientesControlers
    {
        //Crear un objeto del tipo AlquilerCochesEntities
        AlquilerCochesEntities ContextoBD = new AlquilerCochesEntities();

        //crear un metodo que devuelva la tabla de clientes

        public List<CLIENTE> GetClientes()
        {
            var misClientes = from c in ContextoBD.CLIENTES
                              select c;
            
            List<CLIENTE> clientes = new List<CLIENTE>();
            //foreach (var item in misClientes)
            //{
            //    clientes.Add(item);
            //}
            foreach (var item in ContextoBD.CLIENTES)
            {
                clientes.Add(item);
            }
            return clientes;
        }


        public CLIENTE GetClienteByID(string idCliente)
        {
            //var cliente = (from c in ContextoBD.CLIENTES
            //               where c.idClientes == idCliente
            //               select c).First<CLIENTE>();

            var cliente = ContextoBD.CLIENTES.Find(idCliente);
            return cliente;
        }
    }
}