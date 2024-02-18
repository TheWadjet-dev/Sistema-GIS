using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sistema_GIS.Models
{
    [Table("TipoDocumentoVentum")]

    public class TipoDocumentoVentum
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTipoDocumentoVenta { get; set; }

        public string Descripcion { get; set; }

        public bool EsActivo { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
