﻿using Microsoft.AspNetCore.Mvc;

namespace Sistema_GIS.Controllers
{
    public class NegocioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
