﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistema_GIS.BussinesLogic.Interfaz;
using Sistema_GIS.DAL.Interfaces;
using Sistema_GIS.Interfaces;
using Sistema_GIS.Entity;

namespace Sistema_GIS.Implementacion
{
    public class RolService : IRolService
    {
        private readonly IGenericRepository<Rol>_repositorio;

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
