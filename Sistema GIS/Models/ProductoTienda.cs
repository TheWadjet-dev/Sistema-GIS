using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sistema_GIS.Models
{
    [Table("Producto_Tienda")]
    public class ProductoTienda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProductoTienda { get; set; }

        [ForeignKey("IdProducto")]
        public int IdProducto { get; set; }

        public virtual Producto Producto { get; set; }

        [ForeignKey("IdTienda")]
        public int IdTienda { get; set; }

        public virtual Tienda Tienda { get; set; }

        public float PrecioUnidadCompra { get; set; } = 0;

        public float PrecioUnidadVenta { get; set; } = 0;

        public long Stock { get; set; } = 0;

        public bool Activo { get; set; } = true;

        public bool Iniciado { get; set; } = false;

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
