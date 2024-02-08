using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema_GIS.Models
{
    [Table("Inventario")]
    internal class Inventario
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idInventario { get; set; }

        [StringLength(50)]
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public double? Precio { get; set; }
        public int? Cantidad { get; set; }
    }
}
