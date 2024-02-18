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
            #region Rol
            CreateMap<Rol, VMRol>().ReverseMap();
            #endregion Rol

            #region Usuario
            CreateMap<Usuarios, VMUsuario>()
            .ForMember(destino => destino.EsActivo, opt => opt.MapFrom(origen => origen.EsActivo == true ? 1 : 0))
                .ForMember(destino =>
                destino.NombreRol,
                opt => opt.MapFrom(origen => origen.IdRolNavigation.Description));

            CreateMap<VMUsuario, Usuarios>()
                .ForMember(destino =>
                destino.EsActivo,
                opt => opt.MapFrom(origen => origen.EsActivo == 1 ? true : false))

                .ForMember(destino =>
                destino.IdRolNavigation,
                opt => opt.Ignore());
            #endregion Usuario

            #region Negocio
            CreateMap<Tienda, VMNegocio>()
                .ForMember(destino =>
                destino.PorcentajeImpuesto,
                opt => opt.MapFrom(origen => Convert.ToString(origen.PorcentajeImpuesto.Value, new CultureInfo("es-EC"))));
            CreateMap<VMNegocio, Tienda>()
               .ForMember(destino =>
               destino.PorcentajeImpuesto,
               opt => opt.MapFrom(origen => Convert.ToDecimal(origen.PorcentajeImpuesto, new CultureInfo("es-EC"))));
            #endregion Negocio

            #region Categoria
            CreateMap<Categoria, VMCategoria>()
                .ForMember(destino =>
                destino.esActivo,
                opt => opt.MapFrom(origen.EsAcivo == true ? 1 : 0));

            CreateMap<VMCategoria, Categoria>()
                .ForMember(destino =>
                destino.EsActivo,
                opt => opt.MapFrom(origen => origen.esActivo == 1 ? true : false));
            #endregion Categoria

            #region Producto
            CreateMap<Producto, VMProducto>()
                .ForMember(destino =>
                destino.EsActivo,
                opt => opt.MapFrom(origen => origen.EsActivo == true ? 1 : 0))

                .ForMember(destino =>
                destino.NombreCategoria,
               opt=>opt.MapFrom(origen.IdCategoriaNavigation.Descripcion))
                .ForMember(destino =>
                destino.Precio,
                opt => opt.MapFrom(origen => Convert.ToString(origen.Precio.Value, new CultureInfo("es-EC"))));


            CreateMap<VMProducto, Producto>()
              .ForMember(destino =>
              destino.EsActivo,
              opt => opt.MapFrom(origen => origen.EsActivo == 1 ? true : false))

              .ForMember(destino =>
              destino.IdCategoriaNavigation,
             opt => opt.Ignore())
              .ForMember(destino =>
              destino.Precio,
              opt => opt.MapFrom(origen => Convert.ToDecimal(origen.Precio, new CultureInfo("es-EC"))));
            #endregion Producto

            #region TipoDocumentoVenta
            CreateMap<TipoDocumentoVenta, VMTipoDocumentoVenta>().ReverseMap();
            #endregion TipoDocumentoVenta

            #region Venta
            CreateMap<Venta, VMVenta>()
                .ForMember(destino =>
                destino.IdDocumentoVenta,
                opt => opt.MapFrom(origen => origen.IdTipoDocumentoVentaNavigation.Descripcion))
                  .ForMember(destino =>
                destino.Usuario,
                opt => opt.MapFrom(origen => origen.IdUsuarioNavigation.Nombre))
                     .ForMember(destino =>
                destino.SubTotal,
                opt => opt.MapFrom(origen => Convert.ToString(origen.SubTotal.Value, new CultureInfo("es-EC"))))
                    .ForMember(destino =>
                destino.ImpuestoTotal,
                opt => opt.MapFrom(origen => Convert.ToString(origen.ImpuestoTotal.Value, new CultureInfo("es-EC"))))
                    .ForMember(destino =>
                destino.Total,
                opt => opt.MapFrom(origen => Convert.ToString(origen.Total.Value, new CultureInfo("es-EC"))))
                    .ForMember(destino =>
                destino.FechaRegistro,
                opt => opt.MapFrom(origen => origen.FechaRegistro.Value.ToString("dd/MM/yyyy")));


            CreateMap<VMVenta, Venta>()
                    .ForMember(destino =>
                destino.SubTotal,
                opt => opt.MapFrom(origen => Convert.ToDecimal(origen.SubTotal, new CultureInfo("es-EC"))))
                    .ForMember(destino =>
                destino.ImpuestoTotal,
                opt => opt.MapFrom(origen => Convert.ToDecimal(origen.ImpuestoTotal, new CultureInfo("es-EC"))))
                    .ForMember(destino =>
                destino.Total,
                opt => opt.MapFrom(origen => Convert.ToDecimal(origen.Total, new CultureInfo("es-EC"))));



            #endregion Venta

            #region DetalleVenta
            CreateMap<DetalleVenta, VMDetalleVenta>()
                .ForMember(destino =>
                destino.Precio,
                opt => opt.MapFrom(origen => Convert.ToString(origen.Precio.Value, new CultureInfo("es-EC"))))

                .ForMember(destino =>
                destino.Total,
                opt => opt.MapFrom(origen => Convert.ToString(origen.Total.Value, new CultureInfo("es-EC"))));

            CreateMap<VMDetalleVenta, DetalleVenta>()
           .ForMember(destino =>
           destino.Precio,
           opt => opt.MapFrom(origen => Convert.ToDecimal(origen.Precio, new CultureInfo("es-EC"))))

           .ForMember(destino =>
           destino.Total,
           opt => opt.MapFrom(origen => Convert.ToDecimal(origen.Total, new CultureInfo("es-EC"))));

            CreateMap<DetalleVenta, VMReporteVenta>()
                 .ForMember(destino =>
           destino.FechaRegistro,
           opt => opt.MapFrom(origen => origen.IdVentaNavigation.FechaRegistro.Value.ToString("dd/MM/yyyy")))

                 .ForMember(destino =>
           destino.NumeroVenta,
           opt => opt.MapFrom(origen => origen.IdVentaNavigation.NumeroVenta))

                 .ForMember(destino =>
           destino.TipoDocumento,
           opt => opt.MapFrom(origen => origen.IdVentaNavigation.idTipoDocumentoNavigation.Descripcion))

                     .ForMember(destino =>
           destino.DocuementoCliente,
           opt => opt.MapFrom(origen => origen.IdVentaNavigation.DocumentoCliente))
                       .ForMember(destino =>
           destino.NombreCliente,
           opt => opt.MapFrom(origen => origen.IdVentaNavigation.NombreCliente))

                                .ForMember(destino =>
           destino.SubtotalVenta,
           opt => opt.MapFrom(origen => Convert.ToString(origen.IdVentaNavigation.SubTotal.Value, new CultureInfo("es-EC"))))

                     .ForMember(destino =>
           destino.ImpuestoTotalVenta,
           opt => opt.MapFrom(origen => Convert.ToString(origen.IdVentaNavigation.ImpuestoTotal.Value, new CultureInfo("es-EC"))))

                        .ForMember(destino =>
           destino.TotalVenta,
           opt => opt.MapFrom(origen => Convert.ToString(origen.IdVentaNavigation.Total.Value, new CultureInfo("es-EC"))))

                         .ForMember(destino =>
           destino.Producto,
           opt => opt.MapFrom(origen => origen.DescripcionProducto))

             .ForMember(destino =>
           destino.Precio,
           opt => opt.MapFrom(origen => Convert.ToString(origen.Precio.Value, new CultureInfo("es-EC"))))

              .ForMember(destino =>
           destino.Total,
           opt => opt.MapFrom(origen => Convert.ToString(origen.Total.Value, new CultureInfo("es-EC"))));


            #endregion DetalleVenta

            #region Menu
            CreateMap<Menu, VMMenu>()
                .ForMember(destino =>
                destino.SubMenus,
                opt => opt.MapFrom(origen => origen.InverseldMenuPadreNavigation));

            #endregion Menu
        }
    }
}
