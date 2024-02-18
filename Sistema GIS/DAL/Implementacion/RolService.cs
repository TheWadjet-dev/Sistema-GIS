using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_GIS.BLL.Interfaces;
using Sistema_GIS.DAL.Interfaces;
using Sistema_GIS.Datos.Interfaces;
using Sistema_GIS.Models;
using sistemaVentas.Entity;

namespace Sistema_GIS.Datos.Implementacion
{
    public class RolService : IRolService
    {
        private readonly IGenericRepository<Rol> _repositorio;

        public RolService(IGenericRepository<Rol> repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<List<Rol>> Lista()
        {
            IQueryable<Rol> query = await_repositorio.Consultar();
            return query.ToList();
        }
    }
}
