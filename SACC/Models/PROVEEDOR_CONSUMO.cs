//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SACC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PROVEEDOR_CONSUMO
    {
        public int ID_PROVEEDOR { get; set; }
        public string NOMBRE { get; set; }
        public string DIRECCION { get; set; }
        public string COLONIA { get; set; }
        public string CIUDAD { get; set; }
        public Nullable<int> CP { get; set; }
        public string RFC { get; set; }
        public string TELEFONO1 { get; set; }
        public string TELEFONO2 { get; set; }
        public string NOTAS { get; set; }
        public string ESTADO { get; set; }
        public string PAIS { get; set; }
        public string ELIMINADO { get; set; }
    }
}