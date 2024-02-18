using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sistema_GIS.Models
{
    [Table("Venta")]
    public class Ventum
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdVenta { get; set; }

        [StringLength(6)]
        public string NumeroVenta { get; set; }

        [ForeignKey("IdTipoDocumentoVenta")]
        public int IdTipoDocumentoVenta { get; set; }

        public virtual TipoDocumentoVentum TipoDocumentoVentum { get; set; }

        [ForeignKey("IdUsuario")]
        public int IdUsuario { get; set; }

        public virtual Usuario? Usuario { get; set; }


        [StringLength(10)]
        public string DocumentoCliente { get; set; }

        [StringLength(20)]
        public string NombreCliente { get; set; }


        public double Subtotal { get; set; }

        public double ImpuestoTotal { get; set; }

        public double Total { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
