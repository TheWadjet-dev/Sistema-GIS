﻿using Sistema_GIS.Models;

namespace Sistema_GIS.BussinesLogic.Interfaz
{
    public interface IProductoService
    {
        Task<List<Producto>> Lista();
        Task<Producto> Crear(Producto entidad, Stream imagen = null, string NombreImagen = "");
        Task<Producto> Editar(Producto entidad, Stream imagen = null, string NombreImagen = "");
        Task<bool> Eliminar(int idProducto);
    }
}
