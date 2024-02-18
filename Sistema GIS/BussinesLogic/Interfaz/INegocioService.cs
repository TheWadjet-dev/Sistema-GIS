using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistema_GIS.Entity;
using Sistema_GIS.Models;

namespace Sistema_GIS.BussinesLogic.Interfaz
{
    public interface INegocioService
    {
        Task<Negocio> Obtener();
        Task<Negocio> GuardarCambio(Negocio entidad, Stream Logo = null, string NombreLogo = "");

    }
}
