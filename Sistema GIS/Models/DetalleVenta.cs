using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sistema_GIS.Models
{
    [Table("DetalleVenta")]
    public class DetalleVenta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDetalleVenta { get; set; }

        [ForeignKey("IdVenta")]
        public int IdVenta { get; set; }

        public virtual Ventum Venta { get; set; }

        [ForeignKey("IdProducto")]
        public int IdProducto { get; set; }

        public virtual Producto Producto { get; set; }

        [StringLength(100)]
        public string MarcaProducto { get; set; }

        [StringLength(100)]
        public string DescripcionProducto { get; set; }

        [StringLength(100)]
        public string CategoriaProducto { get; set; }
        public int Cantidad { get; set; }

        public float Precio { get; set; }

        public float Total { get; set; }
    }
}
