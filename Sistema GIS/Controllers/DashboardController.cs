﻿using Microsoft.AspNetCore.Mvc;

namespace Sistema_GIS.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}