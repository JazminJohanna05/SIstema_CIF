//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaCIF_Service.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Factura
    {
        public int Id { get; set; }
        public string FacturaId { get; set; }
        public string LocalId { get; set; }
        public string TipoFactura { get; set; }
        public string Estado { get; set; }
        public string VendedorId { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public string FacturaComercialId { get; set; }
        public string ClienteId { get; set; }
    
        public virtual Factura Factura1 { get; set; }
        public virtual Factura Factura2 { get; set; }
    }
}
