using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sistema_GIS.Models
{
    [Table("Negocio")]

    public class Negocio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdNegocio { get; set; }

        [StringLength(500)]
        public string UrlLogo { get; set; }

        [StringLength(100)]
        public string NombreLogo { get; set; }

        [StringLength(50)]
        public string NumeroDocumento { get; set; }
        [StringLength(50)]
        public string Nombre { get; set; }
        [StringLength(50)]
        public string Correo { get; set; }
        [StringLength(50)]
        public string Direccion { get; set; }
        [StringLength(50)]
        public string Telefono { get; set; }
        public decimal PorcentajeImpuesto { get; set; }
        [StringLength(5)]
        public string SimboloMoneda { get; set; }
    }
}
