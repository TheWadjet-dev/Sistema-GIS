using Sistema_GIS.Models;
using System;

namespace Sistema_GIS.DAL.Interfaces
{
    public interface IVentaRepository : IGenericRepository<Venta>
    {
        Task<Venta> Registrar(Venta entidad);
   
        Task<List<Venta>> Reporte(DateTime Fechalnicio, DateTime FechaFin);
    }
}
