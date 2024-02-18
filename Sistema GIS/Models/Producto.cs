using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NuGet.Protocol.Plugins;
using Sistema_GIS.Models.ViewModels;

namespace Sistema_GIS.Models
{
    [Table("Producto")]
    public class Producto
    {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int IdProducto { get; set; }

           public string CodigoBarra { get; set; }

            public string Marca { get; set; }

            [Required]
            [StringLength(100)]
            public string Descripcion { get; set; }

            [ForeignKey("IdCategoria")]
           public int IdCategoria { get; set; }
          public virtual Categoria Categoria { get; set; }

           public int Stock { get; set; }

            [StringLength(500)]
            public string UrlImagen { get; set; }

            [StringLength(100)]
            public string NombreImagen { get; set; }

            [Required]
            public decimal Precio { get; set; }

            public bool EsActivo { get; set; } = true;

            public DateTime FechaRegistro { get; set; } = DateTime.Now;
        }
    }

