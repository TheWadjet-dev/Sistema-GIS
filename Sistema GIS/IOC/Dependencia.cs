using Sistema_GIS.BussinesLogic.Implementacion;
using Sistema_GIS.BussinesLogic.Interfaz;
using Sistema_GIS.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sistema_GIS.DAL.DBContext;
using Microsoft.EntityFrameworkCore;
using Sistema_GIS.DAL.Implementacion;
using Sistema_GIS.Datos.Implementacion;
using Sistema_GIS.Datos.Interfaces;

namespace Sistema_GIS.IOC
{
    public static class Dependencia
    {
        public static void InyectarDependencia(this IServiceCollection services, IConfiguration Configuration) { 
        
            services.AddDbContext<ORMDBContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("CadenaSQL"));
            });
            services.AddTransient(typeof(IGenericRepository<>), typeof(IGenericRepository<>));
            services.AddScoped<IVentaRepository, IVentaRepository>();
        
            services.AddScoped<ICategoriaService, CategoriaService>();
            services.AddScoped<IProductoService, ProductoService>();
            services.AddScoped<ICorreoService, CorreoService>();
            services.AddScoped<IFireBaseService, FireBaseService>();

            services.AddScoped<IUtilidadesService, UtilidadesService>();
            services.AddScoped<IRolService, RolService>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<INegocioService, NegocioService>();

        }   
    }
}
