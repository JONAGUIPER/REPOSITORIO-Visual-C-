//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModeloPorCapas.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class ALQUILADO
    {
        public int idAlquiler { get; set; }
        public string idCoche { get; set; }
        public string idCliente { get; set; }
        public int idTienda { get; set; }
        public System.DateTime FechaEntrega { get; set; }
        public int idTiendaEntrega { get; set; }
        public System.DateTime FechaDevolucion { get; set; }
        public int idTiendaDevolucion { get; set; }
    
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual TIENDA TIENDA { get; set; }
    }
}
