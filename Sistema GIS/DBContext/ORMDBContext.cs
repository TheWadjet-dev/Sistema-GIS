using Microsoft.EntityFrameworkCore;
using Sistema_GIS.Models;

namespace Sistema_GIS.DBContext
{
    public class ORMDBContext:DbContext
    {
        public ORMDBContext()
        {
        }
        public ORMDBContext(DbContextOptions<ORMDBContext> options)
    : base(options)
        {
        }
        public virtual DbSet<Categorium> Categoria { get; set; }
        public virtual DbSet<DetalleVentum> DetalleVenta { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Configuracion> Configuracions { get; set; }
        public virtual DbSet<Negocio> Negocios { get; set; }
        public virtual DbSet<NumeroCorrelativo> NumeroCorrelativos { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<RolMenu> RolMenus { get; set; }

        public virtual DbSet<TipoDocumentoVentum> TipoDocumentoVenta { get; set; }

        public virtual DbSet<Usuario> Usuarios { get; set; }

        public virtual DbSet<Ventum> Ventas { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Data Source=DESKTOP-2PHOOVO;Initial Catalog=testUniversidadBP;Integrated Security=True;Trust Server Certificate=True");*/

    }
}
