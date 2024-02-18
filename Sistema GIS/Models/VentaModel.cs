﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sistema_GIS.Models
{
    [Table("Venta")]
    public class VentaModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdVenta { get; set; }

        [StringLength(100)]
        public string Codigo { get; set; }

        public int ValorCodigo { get; set; }

        [ForeignKey("IdTienda")]
        public int IdTienda { get; set; }

        public virtual TiendaModel? TiendaModel { get; set; }

        [ForeignKey("IdUsuario")]
        public int IdUsuario { get; set; }

        public virtual UsuarioModel? UsuarioModel { get; set; }

        [ForeignKey("IdCliente")]
        public int IdCliente { get; set; }

        public virtual ClienteModel? ClienteModel { get; set; }

        [StringLength(50)]
        public string TipoDocumento { get; set; }

        public int CantidadProducto { get; set; }

        public int CantidadTotal { get; set; }

        public float TotalCosto { get; set; }

        public float ImporteRecibido { get; set; }

        public float ImporteCambio { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
