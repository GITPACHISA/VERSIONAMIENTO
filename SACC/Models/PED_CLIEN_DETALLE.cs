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
    
    public partial class PED_CLIEN_DETALLE
    {
        public int ID { get; set; }
        public string ID_PRODUCTO { get; set; }
        public Nullable<int> NO_PEDIDO { get; set; }
        public Nullable<double> CANTIDAD_PEDIDA { get; set; }
        public Nullable<double> CANTIDAD_EXISTENCIA { get; set; }
        public Nullable<double> CANTIDAD_PENDIENTE { get; set; }
        public Nullable<double> CANT_ORIGINAL { get; set; }
        public string ACTIVO { get; set; }
        public string FINALIZADA { get; set; }
    }
}
