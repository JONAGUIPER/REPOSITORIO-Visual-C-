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
    
    public partial class COCH
    {
        public COCH()
        {
            this.EntregasDevoluciones = new HashSet<EntregasDevolucione>();
        }
    
        public string idCoche { get; set; }
        public int idCategoria { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Kilometraje { get; set; }
        public Nullable<int> Ubicacion { get; set; }
        public Nullable<int> Consumo { get; set; }
        public Nullable<byte> idCombustible { get; set; }
    
        public virtual CATEGORIA CATEGORIA { get; set; }
        public virtual COMBUSTIBLE COMBUSTIBLE { get; set; }
        public virtual TIENDA TIENDA { get; set; }
        public virtual ICollection<EntregasDevolucione> EntregasDevoluciones { get; set; }
    }
}
