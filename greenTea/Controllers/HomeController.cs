﻿using greenTea.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace greenTea.Controllers
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
            return View();
        }

        public IActionResult Sobre()
        {
            return View();
        }

        public IActionResult Wnoise()
        {
            return View();
        }

        public IActionResult Faq()
        {
            return View();
        }
        
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult BlogPicto()
        {
            return View();
        }
        public IActionResult BlogWnoise()
        {
            return View();
        }
        public IActionResult BlogDieta()
        {
            return View();
        }

        public IActionResult Contatos()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
