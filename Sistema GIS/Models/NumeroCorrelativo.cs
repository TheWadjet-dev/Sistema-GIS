using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sistema_GIS.Models
{
    [Table("NumeroCorrelativo")]
    public class NumeroCorrelativo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdNumeroCorrelativo { get; set; }
        public int UltimoNumero { get; set; }
        public int CantidadDigitos { get; set; }
        public string Gestion { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
