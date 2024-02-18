using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sistema_GIS.Models
{
    [Table("Producto_Tienda")]
    public class Producto_TiendaModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProductoTienda { get; set; }

        [ForeignKey("IdProducto")]
        public int IdProducto { get; set; }

        public virtual ProductoModel ProductoModel { get; set; }

        [ForeignKey("IdTienda")]
        public int IdTienda { get; set; }

        public virtual TiendaModel TiendaModel { get; set; }

        public float PrecioUnidadCompra { get; set; } = 0;

        public float PrecioUnidadVenta { get; set; } = 0;

        public long Stock { get; set; } = 0;

        public bool Activo { get; set; } = true;

        public bool Iniciado { get; set; } = false;

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
