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
    
    public partial class GARANTIAS
    {
        public int ID_GARANTIA { get; set; }
        public Nullable<int> ID_VENTA { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public string ID_PRODUCTO { get; set; }
        public Nullable<double> CANTIDAD { get; set; }
        public Nullable<double> PRECIO { get; set; }
        public Nullable<double> IMPORTE { get; set; }
        public string DESCRIPCION { get; set; }
        public string ESTADO { get; set; }
        public Nullable<int> IDDET { get; set; }
        public string COMENTARIO { get; set; }
        public string TIPO { get; set; }
        public string REVUNO { get; set; }
        public string REVDOS { get; set; }
        public string COMEN { get; set; }
        public string CANT_ACEP { get; set; }
    }
}
