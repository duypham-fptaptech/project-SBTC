﻿using Microsoft.AspNetCore.Mvc;

namespace SBTC1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return Pages();
        }
    }
}
