using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sistema_GIS.Models
{
    [Table("Producto")]
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProducto { get; set; }

        [StringLength(100)]
        public string Codigo { get; set; }

        public int ValorCodigo { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }

        [ForeignKey("IdCategoria")]
        public int IdCategoria { get; set; }

        public virtual Categoria Categoria { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
