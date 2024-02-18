namespace Sistema_GIS.Datos.Interfaces
{
    public interface IUtilidadesService
    {

        string GenerarClave();

        string ConvertirSha256(string texto);

    }
}
