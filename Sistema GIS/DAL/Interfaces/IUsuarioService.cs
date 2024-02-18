using Sistema_GIS.Models;
using Sistema_GIS.Models.ViewModels;
namespace Sistema_GIS.Datos.Interfaces
{
    public interface IUsuarioService
    {
        Task<List<VMUsuario>> Lista();
        Task<Usuarios> Crear(Usuarios entidad, Stream Foto = null, string NombreFoto = "", string UrlPlantillaCorreo = "");
        Task<Usuarios> Editar(Usuarios entidad, Stream Foto = null, string NombreFoto = "");
        Task<bool> Eliminar(int IdUsuario);
        Task<Usuarios> ObtenerPorCredenciales(string correo, string clave);
        Task<Usuarios> ObtenerPorId(int IdUsuario);
        Task<bool> GuardarPerfil(Usuarios entidad);
        Task<bool> CambiarClave(int IdUsuario, string ClaveActual, string ClaveNueva);
        Task<bool> RestablecerClave(string Correo, string UrlPlantillaCorreo);

    }
}
