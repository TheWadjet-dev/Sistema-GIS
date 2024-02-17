using Sistema_GIS.BussinesLogic.Interfaz;

using Sistema_GIS.Datos.Interfaces;
using Sistema_GIS.Entity;
namespace Sistema_GIS.BussinesLogic.Implementacion
{
    public class CategoriaService : ICategoriaService
    {

        private readonly IGenericRepository<Categoria> _repository;

        public CategoriaService(IGenericRepository<Categoria> repository)
        {
            _repository = repository;
        }

        public async Task<Categoria> Crear(Categoria entidad)
        {
            try
            {
                CategoriaService categoria_creada = await _repository.Crear(entidad);
                if(categoria_creada.IdCategoria == 0)
                    throw new TaskCanceledException("No se pudo crear la categoria");
                return categoria_creada;
            }catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<Categoria> Editar(Categoria entidad)
        {
            try
            {
                CategoriaService categoria_encontrada = await _repository.Obtener(c => c.IdCategoria == entidad.IdCategoria);
                categoria_encontrada.Descripocion = entidad.Descripcion;
                categoria_encontrada.EsActivo = entidad.EsActivo;
                bool respuesta = await _repository.Editar(categoria_encontrada);

                if (!respuesta)
                    throw new TaskCanceledException("No se pudo modificar la categoria");
                return categoria_encontrada;
            }catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<bool> Eliminar(int idCategoria)
        {
            try
            {
                CategoriaService categoria_encontrada = await _repository.Obtener(c => c.IdCategoria == IdCategoria);
                if(categoria_encontrada == null)
                    throw new TaskCanceledException("La categoria no existe");
                bool respuesta = await _repository.Eliminar(categoria_encontrada);
                return respuesta;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<Categoria>> Lista()
        {
            IQueryable<Categoria> query = await _repository.Consultar();
        }
    }
}
