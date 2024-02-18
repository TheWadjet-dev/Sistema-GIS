namespace Sistema_GIS.BussinesLogic.Implementacion
using Sistema_GIS.BussinesLogic.Interfaz;
using Sistema_GIS.DAL.Implementacion;
using Sistema_GIS.DAL.Interfaces;
using Sistema_GIS.Models;
using System;
using System.Net;
using System.Net.Mail;

{
using System.Threading.Tasks;

public class CorreoService : ICorreoService
{

    private readonly IGenericRepository<Configuracion> _repositorio;

    public CorreoService(IGenericRepository<Configuracion> repositorio)
    {
        _repositorio = repositorio;
    }
    public async Task<bool> EnviarCorreo(string CorreoDestino, string Asunto, string Mensaje)
    {
        try
        {
            IQueryable<Configuracion> query = await _repositorio.Consultar(c => c.Recurso.Equals("Servicio_Correo"));
            Dictionary<string, string> Config = query.ToDictionary(keySelector: c => c.Propiedad, elementSelector: c => c.Valor);

            var credenciales = new NetworkCredential(Config["correo"], Config["clave"]);
            var correo = new MailMessage()
            {
                From = new MailAddress(Config["correo"], Config["clave"]),
                Subject = Asunto,
                Body = Mensaje,
                IsBodyHtml = true
            };

            correo.To.Add(new MailAddress(CorreoDestino));
            var clienteServidor = new SmtpClient()
            {
                Host = Config["host"],
                Port = int.Parse(Config["puerto"]),
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                EnableSsl = true
            };

            clienteServidor.Send(correo);
            return true;



        } 
        catch 
        { 
            return false; 
        }


}
}
