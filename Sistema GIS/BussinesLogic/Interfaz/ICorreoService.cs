namespace Sistema_GIS.BussinesLogic.Interfaz
{
    public interface ICorreoService
    {
        Task<bool> EnviarCorreo(string CorreoDestino, string Asunto, string Mensaje);
    }
}
