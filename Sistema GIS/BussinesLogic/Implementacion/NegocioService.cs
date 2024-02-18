﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Sistema_GIS.BussinesLogic.Interfaz;
using Sistema_GIS.DAL.Interfaces;
using Sistema_GIS.Entity;
using Sistema_GIS.Models;

namespace Sistema_GIS.BussinesLogic.Implementacion
{
    public class NegocioService : INegocioService
    {
        private readonly IGenericRepository<Negocio> _repositorio;
        private readonly IFireBaseService _firebaseService;
        public NegocioService(IGenericRepository<Negocio> repositorio, IFireBaseService firebaseService)
        {
            _repositorio = repositorio;
            _firebaseService = firebaseService;
        }
        public async Task<Negocio> Obtener()
        {
            try
            {
                Negocio negocio_encontrado = await _repositorio.Obtener(n => n.IdNegocio == 1);
                return negocio_encontrado;
            }
            catch
            {
                throw; 
            }
        }
        public async Task<Negocio> GuardarCambio(Negocio entidad, Stream Logo = null, string NombreLogo = "")
        {
            try
            {
                Negocio negocio_encontrado = await _repositorio.Obtener(n => n.IdNegocio == 1);

                negocio_encontrado.NumeroDocumento = entidad.NumeroDocumento;
                negocio_encontrado.Nombre = entidad.Nombre;
                negocio_encontrado.Correo = entidad.Correo;
                negocio_encontrado.Direccion = entidad.Direccion;
                negocio_encontrado.Telefono = entidad.Telefono;
                negocio_encontrado.PorcentajeImpuesto = entidad.PorcentajeImpuesto;
                negocio_encontrado.SimboloMoneda = entidad.SimboloMoneda;

                negocio_encontrado.NombreLogo = negocio_encontrado.NombreLogo ==""?NombreLogo : negocio_encontrado.NombreLogo;

                if(Logo != null)
                {
                    string urlLogo = await _firebaseService.SubirStorage(Logo, "carpeta_logo", negocio_encontrado.NombreLogo);
                    negocio_encontrado.urlLogo = urlLogo;


                }
                await _repositorio.Editar(negocio_encontrado);
                return negocio_encontrado;

            }
            catch
            {
                throw;
            }
        }

       
    }
}
