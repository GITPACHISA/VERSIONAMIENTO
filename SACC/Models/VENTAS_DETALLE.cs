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
    
    public partial class VENTAS_DETALLE
    {
        public Nullable<int> ID_VENTA { get; set; }
        public string ID_PRODUCTO { get; set; }
        public string DESCRIPCION { get; set; }
        public Nullable<double> CANTIDAD { get; set; }
        public Nullable<double> PRECIO_VENTA { get; set; }
        public Nullable<double> PRECIO_COSTO { get; set; }
        public Nullable<double> GANANCIA { get; set; }
        public int ID_GARANTIA { get; set; }
        public int IDDET { get; set; }
        public string NO_COM_AT { get; set; }
        public double IMPORTE { get; set; }
    }
}
