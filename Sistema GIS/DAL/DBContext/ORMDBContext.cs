using Microsoft.EntityFrameworkCore;
using Sistema_GIS.Models;

namespace Sistema_GIS.DAL.DBContext
{
    public class ORMDBContext : DbContext
    {
        public ORMDBContext()
        {
        }
        public ORMDBContext(DbContextOptions<ORMDBContext> options)
    : base(options)
        {
        }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Configuracion> Configuracions { get; set; }
        public virtual DbSet<DetalleVenta> DetalleVenta { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }

        public virtual DbSet<Negocio> Negocios { get; set; }
        public virtual DbSet<NumeroCorrelativo> NumeroCorrelativos { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Rol> Roles { get; set; }
        public virtual DbSet<RolMenu> RolMenus { get; set; }

        public virtual DbSet<TipoDocumentoVenta> TipoDocumentoVentas { get; set; }

        public virtual DbSet<Usuario> Usuarios { get; set; }

        public virtual DbSet<Venta> Ventas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Data Source=DESKTOP-2PHOOVO;Initial Catalog=superUCE;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

    }
}
