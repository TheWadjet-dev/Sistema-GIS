using Microsoft.EntityFrameworkCore;
using Sistema_GIS.BussinesLogic.Interfaz;
using Sistema_GIS.Datos.Interfaces;
using Sistema_GIS.Entity;

namespace Sistema_GIS.BussinesLogic.Implementacion
{
    public class ProductoService
    {
        private readonly IGenericRepository<Producto> _repository;
        private readonly IFireBaseService fireBaseService;
        private readonly IUtilidadesService utilidadesService;

        public ProductoService(IGenericRepository<Producto> repository, IFireBaseService fireBaseService, IUtilidadesService utilidadesService)
        {
            _repository = repository;
            this.fireBaseService = fireBaseService;
            this.utilidadesService = utilidadesService;
        }
    }
}
