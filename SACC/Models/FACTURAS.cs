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
    
    public partial class FACTURAS
    {
        public int ID_FACTURA { get; set; }
        public int ID_CLIENTE { get; set; }
        public System.DateTime FECHA { get; set; }
        public Nullable<double> TOTAL { get; set; }
        public string ID_USUARIO { get; set; }
        public string TOTAL_LETRAS { get; set; }
        public string ORDENCOMPRA { get; set; }
        public string SOLICITO { get; set; }
        public Nullable<int> ID_COMANDA { get; set; }
        public Nullable<int> ID_NOTA { get; set; }
        public string FORMA_PAGO { get; set; }
        public string CANCELADA { get; set; }
    }
}