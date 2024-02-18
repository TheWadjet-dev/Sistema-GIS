using Sistema_GIS.Models.ViewModels;
using Sistema_GIS.Models;
using Sistema_GIS.Entity;
using System.Globalization;
using AutoMapper;


namespace Sistema_GIS.Utilidades.Automapper
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Rol, VMRol>().ReverseMap();



        }
    }
}
