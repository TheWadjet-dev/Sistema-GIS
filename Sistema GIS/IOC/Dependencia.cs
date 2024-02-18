using Sistema_GIS.BussinesLogic.Implementacion;
using Sistema_GIS.BussinesLogic.Interfaz;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sistema_GIS.DAL.DBContext;
using Sistema_GIS.DAL.Interfaces;
using Sistema_GIS.DAL.Implementacion;
using FluentAssertions.Common;

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
