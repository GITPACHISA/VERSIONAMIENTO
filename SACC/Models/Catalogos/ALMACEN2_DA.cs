﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SACC.Models.Catalogos
{
    public class ALMACEN2_DA
    {
        public int ID { get; set; }
        [Required]
        [DisplayName("ID PRODUCTO")]
        [StringLength(25)]
        public string ID_PRODUCTO { get; set; }
        [Required]
        [StringLength(100)]
        public string DESCRIPCION { get; set; }
        [DisplayName("ID DESCUENTO")]
        [StringLength(30)]
        public string ID_DESCUENTO { get; set; }
        [Required]
        [DisplayName("CANTIDAD MINIMA")]
        public double C_MINIMA { get; set; }
        [Required]
        [DisplayName("CANTIDAD MAXIMA")]
        public double C_MAXIMA { get; set; }
        [Required]
        [StringLength(20)]
        public string TIPO { get; set; }
        [Required]
        [DisplayName("VENTA WEB")]
        public string VENTA_WEB { get; set; }
        [Required]
        [StringLength(50)]
        public string MARCA { get; set; }
        [Required]
        [StringLength(20)]
        public string MATERIAL { get; set; }
        [Required]
        [StringLength(10)]
        public string COLOR { get; set; }
        [DisplayName("FOTO FRENTE")]
        public byte[] FOTO_FRENTE { get; set; }
        [DisplayName("FOTO LADO")]
        public byte[] FOTO_LADO { get; set; }
        public double GANANCIA { get; set; }
        [DisplayName("PRECIO COSTO")]
        public double PRECIO_COSTO { get; set; }
        [DisplayName("PRECIO VENTA")]
        public double PRECIO_VENTA { get; set; }
        [Required]
        public string LOCALIZACION { get; set; }
        [Required]
        [DisplayName("TIPO DE CAMBIO")]
        [StringLength(10)]
        public string PRECIO_EN { get; set; }
        [Required]
        [DisplayName("USR ALTA")]
        public int USR_ALTA { get; set; }
        [DisplayName("FECHA REG.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FECHA_ALTA { get; set; }
        public int USR_MOD { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime FECHA_MOD { get; set; }
        [Required]
        [DisplayName("PRECIO COSTO 2")]
        public double PRECIO_COSTO2 { get; set; }
        [Required]
        [StringLength(25)]
        public string ESPECIE { get; set; }
    }
}