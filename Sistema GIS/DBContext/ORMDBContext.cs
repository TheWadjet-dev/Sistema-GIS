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
        public virtual DbSet<CategoriaModel> Categoria { get; set; }
        public virtual DbSet<ClienteModel> Clientes { get; set; }
        public virtual DbSet<CompraModel> Compra { get; set; }
        public  virtual DbSet<Detalle_CompraModel> DetalleCompra { get; set; }
        public virtual DbSet<Detalle_VentaModel> DetalleVenta { get; set; }
        public virtual DbSet<MenuModel> Menu { get; set; }

        public virtual DbSet<PermisosModel> Permisos { get; set; }
        public virtual DbSet<Producto_TiendaModel> ProductoTienda { get; set; }
        public virtual DbSet<ProductoModel> Productos { get; set; }
        public virtual DbSet<ProveedorModel> Proveedores { get; set; }
        public virtual DbSet<RolModel> Roles { get; set; }
        public virtual DbSet<SubMenuModel> SubMenu { get; set; }

        public virtual DbSet<TiendaModel> Tiendas { get; set; }

        public virtual DbSet<UsuarioModel> Usuarios { get; set; }

        public virtual DbSet<VentaModel> Ventas { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Data Source=DESKTOP-2PHOOVO;Initial Catalog=testUniversidadBP;Integrated Security=True;Trust Server Certificate=True");*/

    }
}
