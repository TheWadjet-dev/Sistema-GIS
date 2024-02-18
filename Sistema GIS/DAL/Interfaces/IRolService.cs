using Sistema_GIS.Models;


namespace Sistema_GIS.Datos.Interfaces
{
    public interface IRolService
    {
        Task<List<Rol>> Lista();
    }
}
