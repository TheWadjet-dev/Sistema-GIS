namespace Sistema_GIS.Controllers.Interfaces
{
    public interface IUtilidadesService
    {

        string GenerarClave();

        string ConvertirSha256(String texto);

    }
}
