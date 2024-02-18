﻿using Microsoft.AspNetCore.Mvc;

using Sistema_GIS.Models.ViewModels;
using Sistema_GIS.Utilidades.Response;
using Sistema_GIS.BussinesLogic.Interfaz;
using Microsoft.AspNetCore.Authorization;

namespace Sistema_GIS.Controllers
{
    [Authorize]
    public class DashBoardController : Controller
    {

        private readonly IDashBoardService _dashboardServicio;
        public DashBoardController(IDashBoardService dashboardServicio)
        {
            _dashboardServicio = dashboardServicio;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerResumen()
        {
            GenericResponse<VMDashBoard> gResponse = new GenericResponse<VMDashBoard>();

            try
            {
                VMDashBoard vmDashBoard = new VMDashBoard();

                vmDashBoard.TotalVentas = await _dashboardServicio.TotalVentasUltimaSemana();
                vmDashBoard.TotalIngresos = await _dashboardServicio.TotalIngresosUltimaSemana();
                vmDashBoard.TotalProductos = await _dashboardServicio.TotalProductos();
                vmDashBoard.TotalCategorias = await _dashboardServicio.TotalCategorias();

                List<VMVentasSemana> listaVentasSemana = new List<VMVentasSemana>();
                List<VMProductosSemana> listaProductosSemana = new List<VMProductosSemana>();

                foreach(KeyValuePair<string,int> item in await _dashboardServicio.VentasUltimaSemana())
                {
                    listaVentasSemana.Add(new VMVentasSemana()
                    {
                        Fecha = item.Key,
                        Total = item.Value
                    });
                }

                foreach (KeyValuePair<string, int> item in await _dashboardServicio.ProductosTopUltimaSemana())
                {
                    listaProductosSemana.Add(new VMProductosSemana()
                    {
                        Producto = item.Key,
                        Cantidad = item.Value
                    });
                }

                vmDashBoard.VentasUltimaSemana = listaVentasSemana;
                vmDashBoard.ProductosTopUltimaSemana = listaProductosSemana;

                gResponse.Estado = true;
                gResponse.Objeto = vmDashBoard;

            }
            catch(Exception ex)
            {
                gResponse.Estado = false;
                gResponse.Mensaje = ex.Message;
            }
            return StatusCode(StatusCodes.Status200OK, gResponse);
        }
    }
}