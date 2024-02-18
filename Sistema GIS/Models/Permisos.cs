using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sistema_GIS.Models
{
    [Table("Permisos")]
    public class Permisos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPermisos { get; set; }

        [ForeignKey("IdRol")]
        public int IdRol { get; set; }

        public virtual Rol RolModel { get; set; }

        [ForeignKey("IdSubMenu")]
        public int IdSubMenu { get; set; }

        public virtual SubMenu SubMenu { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
