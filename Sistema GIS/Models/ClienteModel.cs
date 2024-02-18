using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sistema_GIS.Models
{
    [Table("Cliente ")]
    public class ClienteModel
    {
        /*pancito goloso*/

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCliente { get; set; }

        [StringLength(50)]
        public string TipoDocumento { get; set; }

        [StringLength(50)]
        public string NumeroDocumento { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        [StringLength(50)]
        public string Direccion { get; set; }

        [StringLength(40)]
        public string Telefono { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
