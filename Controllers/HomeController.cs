﻿using CodeFirstApproach.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using NToastNotify;
using CodeFirstApproach.Data;

namespace CodeFirstApproach.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IToastNotification _toastNotification;
        private readonly CodeFirstApproachContext _context;
    

        public HomeController(ILogger<HomeController> logger, IToastNotification toastNotification,CodeFirstApproachContext context)
        {
            _logger = logger;
            _toastNotification = toastNotification;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel 
            { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}