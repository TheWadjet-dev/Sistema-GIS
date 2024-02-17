namespace Sistema_GIS.Interfaces
{
    public interface IUtilidadesService
    {

        string GenerarClave();

        string ConvertirSha256(string texto);

    }
}
