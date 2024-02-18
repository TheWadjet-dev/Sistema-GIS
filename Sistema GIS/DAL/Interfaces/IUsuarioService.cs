using Sistema_GIS.Models;
using Sistema_GIS.Models.ViewModels;
using SistemaVenta.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Sistema_GIS.Datos.Interfaces
{
    public interface IUsuarioService
    {
        Task<List<VMUsuario>> Lista();
        Task<Usuario> Crear(Usuario entidad, Stream Foto = null, string NombreFoto = "", string UrlPlantillaCorreo = "");
        Task<Usuario> Editar(Usuario entidad, Stream Foto = null, string NombreFoto = "");
        Task<bool> Eliminar(int IdUsuario);
        Task<Usuario> ObtenerPorCredenciales(string correo, string clave);
        Task<Usuario> ObtenerPorId(int IdUsuario);
        Task<bool> GuardarPerfil(Usuario entidad);
        Task<bool> CambiarClave(int IdUsuario, string ClaveActual, string ClaveNueva);
        Task<bool> RestablecerClave(string Correo, string UrlPlantillaCorreo);

    }
}
