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
    
    public partial class SALDO_FAVOR_PROVEEDOR
    {
        public int ID_SALDO { get; set; }
        public Nullable<int> ID_PROVEEDOR { get; set; }
        public string PROVEEDOR { get; set; }
        public Nullable<int> NUM_ORDEN { get; set; }
        public string TIPO { get; set; }
        public Nullable<int> ID_ORDEN_COMPRA { get; set; }
        public Nullable<double> TOTAL { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public string MOTIVO_CANCELACION { get; set; }
        public string APLICADA { get; set; }
    }
}