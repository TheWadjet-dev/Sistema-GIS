using Sistema_GIS.BussinesLogic.Implementacion;
using Sistema_GIS.BussinesLogic.Interfaz;

namespace Sistema_GIS.IOC
{
    public static class Dependencia
    {
        public static void InyectarDependencia(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ICategoriaService, CategoriaService>();
            services.AddScoped<IProductoService, ProductoService>();
            services.AddScoped<ICorreoService, CorreoService>();
            services.AddScoped<IFireBaseService, FireBaseService>();
        }   
    }
}
