using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sistema_GIS.Models
{
    [Table("SubMenu")]
    public class SubMenu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdSubMenu { get; set; }

        [ForeignKey("IdMenu")]
        public int IdMenu { get; set; }

        public virtual Menu Menu { get; set; }

        [StringLength(60)]
        public string Nombre { get; set; }

        [StringLength(60)]
        public string NombreFormulario { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
