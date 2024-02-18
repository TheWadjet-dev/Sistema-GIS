using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sistema_GIS.Models
{
    [Table("SubMenu")]
    public class RolMenu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRolMenu { get; set; }

        [ForeignKey("IdRol")]
        public int IdRol { get; set; }
        public virtual Rol Rol { get; set; }

        [ForeignKey("IdMenu")]
        public int IdMenu { get; set; }

        public virtual Menu Menu { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
