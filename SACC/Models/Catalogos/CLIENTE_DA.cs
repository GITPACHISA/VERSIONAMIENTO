﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SACC.Models
{
    public class CLIENTE_DA
    {
        public int ID_CLIENTE { get; set; }
        [Required]
        [StringLength(150)]
        public string NOMBRE { get; set; }
        [Required]
        [StringLength(150)]
        [DisplayName("NOMBRE COMERCIAL")]
        public string NOMBRE_COMERCIAL { get; set; }
        public string RFC { get; set; }
        public string TELEFONO_CASA { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [DisplayName("TELEFONO")]
        public string TELEFONO_TRABAJO { get; set; }
        [Required]
        [StringLength(20)]
        public string PAIS { get; set; }
        [Required]
        [StringLength(15)]
        [DisplayName("DIAS CRÉDITO")]
        public string DIAS_CREDITO { get; set; }
        public string FAX { get; set; }
        public string CONTACTO { get; set; }
        [Required]
        [StringLength(100)]
        public string DIRECCION { get; set; }
        [Required]
        [StringLength(250)]
        [DataType(DataType.MultilineText)]
        public string COMENTARIOS { get; set; }
        [Required]
        [StringLength(100)]
        public string CIUDAD { get; set; }
        [Required]
        [StringLength(40)]
        public string COLONIA { get; set; }
        [Required]
        public Nullable<double> DESCUENTO { get; set; }
        [Required]
        [StringLength(30)]
        [DisplayName("ID DESCUENTO")]
        public string ID_DESCUENTO { get; set; }
        [Required]
        [StringLength(10)]
        [DisplayName("ID AGENTE")]
        public string ID_AGENTE { get; set; }
        [Required]
        [DisplayName("NUMERO EXTERIOR")]
        public string NUMERO_EXTERIOR { get; set; }
        [DisplayName("NUMERO INTERIOR")]
        public string NUMERO_INTERIOR { get; set; }
        public string CURP { get; set; }
        [Required]
        [DataType(DataType.PostalCode)]
        public string CP { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string EMAIL { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [DisplayName("WEB PASS")]
        public string WEB_PASSWORD { get; set; }
        [Required]
        [StringLength(20)]
        public string ESTADO { get; set; }
        [Required]
        //[DataType(DataType.Date)]
        [DisplayName("FECHA REG.")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [RegularExpression("(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\\d\\d", ErrorMessage = "FORMATO INVALIDO (dd-MM-yyyy)")]
        public string FECHA_ALTA { get; set; }
        [Required]
        [DisplayName("LIMITE CREDITO")]
        public Nullable<double> LIMITE_CREDITO { get; set; }
        [Required]
        [StringLength(100)]
        [DisplayName("DIRECCION ENVIO")]
        public string DIRECCION_ENVIO { get; set; }
        public string VALORACION { get; set; }
        public string LEYENDAS { get; set; }
        public string AGENTE { get; set; }
        public string ASIG { get; set; }
        public string RECIBO { get; set; }
        public int Adenda_ID_facturaglobal { get; set; }
        public string Adenda_proveedor { get; set; }
        public string Adenda_contrato { get; set; }
        public string Adenda_unidad_negocio { get; set; }
        public string Adenda_pedido { get; set; }
        public string Adenda_fianza { get; set; }
        public string Adenda_afianzadora { get; set; }
        public string Adenda_alta { get; set; }
        public bool Flag_extranjero { get; set; }
        [Required]
        [DataType(DataType.CreditCard)]
        [DisplayName("NUMERO DE CUENTA")]
        public string Num_cuenta_pago_cliente { get; set; }
        [Required]
        [StringLength(150)]
        [DisplayName("CFDI")]
        public string Clave_CFDI { get; set; }
    }
}