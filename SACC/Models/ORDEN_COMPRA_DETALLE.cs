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
    
    public partial class ORDEN_COMPRA_DETALLE
    {
        public int ID { get; set; }
        public Nullable<int> ID_ORDEN_COMPRA { get; set; }
        public string ID_PRODUCTO { get; set; }
        public string DESCRIPCION { get; set; }
        public Nullable<double> CANTIDAD { get; set; }
        public Nullable<double> PRECIO { get; set; }
        public Nullable<int> DIAS_ENTREGA { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public double SURTIDO { get; set; }
        public string FACT_PROVE { get; set; }
        public string NO_ENVIO { get; set; }
        public Nullable<int> NO_PEDIDO { get; set; }
    }
}
