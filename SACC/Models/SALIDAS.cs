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
    
    public partial class SALIDAS
    {
        public int ID_SALIDA { get; set; }
        public string ID_PRODUCTO { get; set; }
        public Nullable<double> PRECIO { get; set; }
        public Nullable<double> CANTIDAD { get; set; }
        public string JUSTIFICACION { get; set; }
        public string ID_USUARIO { get; set; }
        public string SUCURSAL { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
    }
}
