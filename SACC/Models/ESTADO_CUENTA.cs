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
    
    public partial class ESTADO_CUENTA
    {
        public int ID { get; set; }
        public Nullable<double> CANTIDAD { get; set; }
        public Nullable<double> SALDO { get; set; }
        public int ID_TIPO_CARGO { get; set; }
        public Nullable<int> ID_CARGO { get; set; }
        public string EFECTUADO { get; set; }
        public System.DateTime FECHA { get; set; }
        public Nullable<System.DateTime> FECHA_VENCIMIENTO { get; set; }
        public Nullable<System.DateTime> FECHA_VENCIMIENTO_NO_VACIA { get; set; }
        public Nullable<int> ID_ABONO { get; set; }
        public Nullable<double> ABONO { get; set; }
        public Nullable<System.DateTime> FECHA_PAGO { get; set; }
        public string OBSERVACIONES { get; set; }
        public Nullable<int> ID_FACTURA { get; set; }
        public Nullable<int> ID_NOTA { get; set; }
        public Nullable<System.DateTime> FECHA_CONTRARECIBO { get; set; }
        public Nullable<System.DateTime> FECHA_COBRO { get; set; }
        public string CHEQUE { get; set; }
        public string BANCO { get; set; }
        public Nullable<int> ID_CLIENTE { get; set; }
    }
}