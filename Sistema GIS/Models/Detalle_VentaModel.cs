using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sistema_GIS.Models
{
    [Table("Detalle_Venta")]
    public class Detalle_VentaModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDetalleVenta { get; set; }

        [ForeignKey("IdVenta")]
        public int IdVenta { get; set; }

        public virtual VentaModel VentaModel { get; set; }

        [ForeignKey("IdProducto")]
        public int IdProducto { get; set; }

        public virtual ProductoModel ProductoModel { get; set; }

        public int Cantidad { get; set; }

        public float PrecioUnidad { get; set; }

        public float ImporteTotal { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
