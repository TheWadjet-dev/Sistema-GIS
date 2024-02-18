using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sistema_GIS.Models
{
    [Table("Detalle_Compra")]
    public class Detalle_CompraModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDetalleCompra { get; set; }

        [ForeignKey("IdCompra")]
        public int IdCompra { get; set; }

        public virtual CompraModel CompraModel { get; set; }

        [ForeignKey("IdProducto")]
        public int IdProducto { get; set; }

        public virtual ProductoModel ProductoModel { get; set; }

        public float Cantidad { get; set; }

        public float PrecioUnitarioCompra { get; set; }

        public float PrecioUnitarioVenta { get; set; }

        public float TotalCosto { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
