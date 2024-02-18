using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sistema_GIS.Models
{
    [Table("Compra")]
    public class Compra
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCompra { get; set; }

        [ForeignKey("IdUsuario")]
        public int IdUsuario { get; set; }

        public virtual Usuarios Usuario { get; set; }

        [ForeignKey("IdProveedor")]
        public int IdProveedor { get; set; }

        public virtual Proveedor Proveedor { get; set; }

        [ForeignKey("IdTienda")]
        public int IdTienda { get; set; }

        public virtual Tienda Tienda { get; set; }

        public float TotalCosto { get; set; } = 0;

        [StringLength(50)]
        public string TipoComprobante { get; set; } = "Boleta";

        public bool Activo { get; set; } = true;

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
