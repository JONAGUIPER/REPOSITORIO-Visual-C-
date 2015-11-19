using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BebidasMVC.Models
{
    public class DBContex
    {

        static public List<Cliente> clientes;
        static public List<Bebida> bebidas;

        static  DBContex()
        {
            clientes = new List<Cliente>()
            {
                new Cliente()
                {
                    idCuenta=1,
                    nombre="Gorka",
                    apellidos="Gallego Pavón",
                    email="gorka.gallego@gmail.com",
                    telefono="616257996",
                    edad=35,
                },
                new Cliente()
                {
                    idCuenta=2,
                    nombre="Pepe",
                    apellidos="Perez Palomino",
                    email="pepe.perez@gmail.com",
                    telefono="657859632",
                    edad=16,
                },
                new Cliente()
                {
                    idCuenta=3,
                    nombre="Leire",
                    apellidos="Prieto Remesal",
                    email="leire.prieto@gmail.com",
                    telefono="687489523",
                    edad=62,
                }
            };
            bebidas = new List<Bebida>()
            {
                new Bebida()
                {
                    Tipo="Vino",
                    Marca="Pierola",
                    Precio=15.98F,
                },
                new Bebida()
                {
                    Tipo="Licor",
                    Marca="43",
                    Precio=18.55F,
                },
                new Bebida()
                {
                    Tipo="Ron",
                    Marca="Brugal",
                    Precio=25.98F,
                },
            };
        }
    }
}