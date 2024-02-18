using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Sistema_GIS.DAL.DBContext;
using Sistema_GIS.DAL.Interfaces;
using Sistema_GIS.Models;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sistema_GIS.DAL.Implementacion
{
    public class VentaRepository : GenericRepository<Venta>, IVentaRepository
    {
        private readonly ORMDBContext _dbContext;
        public VentaRepository(ORMDBContext ORMDBContext):base(ORMDBContext) 
        {
            _dbContext = new ORMDBContext();

        }
        
        public async Task<Venta> Registrar(Venta entidad)
        {
            Venta ventaGenerada = new Venta();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try 
                {
                    foreach (DetalleVenta dv in entidad.DocumentoCliente) {

                        Producto producto_encontrado = _dbContext.Productos.Where(p => p.IdProducto == dv.IdProducto).First();
                        producto_encontrado.Stock = producto_encontrado.Stock -dv.Cantidad;
                        _dbContext.Productos.Update(producto_encontrado);
                        
                    }
                    await _dbContext.SaveChangesAsync();

                    NumeroCorrelativo correlativo = _dbContext.NumeroCorrelativos.Where(n => n.Gestion == "venta").First();
                    correlativo.UltimoNumero = correlativo.UltimoNumero + 1;
                    correlativo.FechaActualizacion = DateTime.Now;

                    _dbContext.NumeroCorrelativos.Update(correlativo);
                    await _dbContext.SaveChangesAsync();
                    string ceros = string.Concat(Enumerable.Repeat("0",correlativo.CantidadDigitos.Value));
                    string numeroVenta = ceros + correlativo.UltimoNumero.ToString();

                    numeroVenta = numeroVenta.Substring(numeroVenta.Length - correlativo.CantidadDigitos.Value, correlativo.CantidadDigitos.Value);

                    entidad.NumeroVenta = numeroVenta;
                    await _dbContext.Ventas.AddAsync(entidad);
                    await _dbContext.SaveChangesAsync();
                    ventaGenerada = entidad;
                    transaction.Commit();

                }
                catch (Exception ex) 
                { 
                    transaction.Rollback();
                    throw ex;
                }
            }
            return ventaGenerada;
        }
        
        public async Task<List<Venta>> Reporte(DateTime Fechalnicio, DateTime FechaFin)
        {
            List<DetalleVenta> listaResumen = await _dbContext.DetalleVenta
            .Include(v => v.IdVenta)
            .ThenInclude(u => u.IdUsuario.Navigation)
            .Include()(v => v.IdVentaNavigation)
            .ThenInclude(tdv => tdv.IdTipoDocumentoVentaNavigation)
             .Where(dv => dv.IdVentaNavigation.FechaRegistro.Value.Date >= FechaInicio.Date &&
            dv.IdVentaNavigation.FechaRegistro.Value.Date <= FechaFin.Date).ToListAsync();

            return listaResumen;
        }
    }
}
