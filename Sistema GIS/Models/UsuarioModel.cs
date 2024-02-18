using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sistema_GIS.Models
{
    [Table("Usuario")]
    public class UsuarioModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }

        [StringLength(60)]
        public string Nombres { get; set; }

        [StringLength(60)]
        public string Apellidos { get; set; }

        [StringLength(60)]
        public string Correo { get; set; }

        [StringLength(60)]
        public string Usuario { get; set; }

        [StringLength(60)]
        public string Clave { get; set; }

        [ForeignKey("IdTienda")]
        public int IdTienda { get; set; }

        public virtual TiendaModel? TiendaModel { get; set; }

        [ForeignKey("IdRol")]
        public int IdRol { get; set; }

        public virtual RolModel RolModel { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
