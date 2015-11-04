using System;

namespace DAL
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public int IdPersona { get; set; }
        public int IdTienda { get; set; }
        public string NumeroCuenta { get; set; }
        public string GuidFila { get; set; }
        public DateTime FechaModificacion { get; set; }

        public Cliente(int idCliente, int idPersona, int idTienda, string numeroCuenta, string guidFila, DateTime fechaModificacion)
        {
            IdCliente = idCliente;
            IdPersona = idPersona;
            IdTienda = idTienda;
            NumeroCuenta = numeroCuenta;
            GuidFila = guidFila;
            FechaModificacion = fechaModificacion;
        }

        
        
    }
}