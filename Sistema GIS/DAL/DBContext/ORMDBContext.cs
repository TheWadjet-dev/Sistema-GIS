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
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Compra> Compra { get; set; }
        public virtual DbSet<DetalleCompra> DetalleCompra { get; set; }
        public virtual DbSet<DetalleVenta> DetalleVenta { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }

        public virtual DbSet<Permisos> Permisos { get; set; }
        public virtual DbSet<ProductoTienda> ProductoTienda { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Proveedor> Proveedores { get; set; }
        public virtual DbSet<Rol> Roles { get; set; }
        public virtual DbSet<SubMenu> SubMenu { get; set; }

        public virtual DbSet<Tienda> Tiendas { get; set; }

        public virtual DbSet<Usuarios> Usuarios { get; set; }

        public virtual DbSet<Venta> Ventas { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Data Source=DESKTOP-2PHOOVO;Initial Catalog=testUniversidadBP;Integrated Security=True;Trust Server Certificate=True");*/

    }
}
