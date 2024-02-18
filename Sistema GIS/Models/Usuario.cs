using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sistema_GIS.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }

        [StringLength(60)]
        public string Nombre { get; set; }

        [StringLength(50)]
        public string Correo { get; set; }

        [StringLength(50)]

        public string telefono { get; set; }

        [StringLength(50)]

        [ForeignKey("IdRol")]
        public int IdRol { get; set; }

        public virtual Rol? Rol { get; set; }

        public string urlFoto { get; set; }

        [StringLength(500)]

        public string nombreFoto { get; set; }

        [StringLength(100)]

        public string Clave { get; set; }

        [StringLength(100)]

        public bool Activo { get; set; } = true;

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
