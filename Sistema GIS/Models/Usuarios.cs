using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sistema_GIS.Models
{
    [Table("Usuario")]
    public class Usuarios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }

        [StringLength(60)]
        public string Nombre { get; set; }

        [StringLength(60)]
        public string Apellido { get; set; }

        [StringLength(60)]
        public string Correo { get; set; }

        [StringLength(60)]
        public string telefono { get; set; }
        [StringLength(60)]
        public string Usuario { get; set; }

        [StringLength(60)]
        public string Clave { get; set; }

        [ForeignKey("IdTienda")]
        public int IdTienda { get; set; }

        public virtual Tienda? TiendaModel { get; set; }

        [ForeignKey("IdRol")]
        public int IdRol { get; set; }

        public virtual Rol RolModel { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
