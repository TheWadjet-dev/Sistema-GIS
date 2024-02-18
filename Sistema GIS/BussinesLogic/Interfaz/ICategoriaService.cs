using Sistema_GIS.Models;

namespace Sistema_GIS.BussinesLogic.Interfaz
{
    public interface ICategoriaService
    {
        Task<List<Categoria>> Lista();
        Task<Categoria> Crear(Categoria entidad);
        Task<Categoria> Editar(Categoria entidad);
        Task<bool> Eliminar(int idCategoria);
    }
}
