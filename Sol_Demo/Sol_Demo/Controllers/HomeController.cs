using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CookieManager;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sol_Demo.Models;
using Sol_Demo.Persistence;

namespace Sol_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICookieManager cookieManager = null;

        public HomeController(ILogger<HomeController> logger, ICookieManager cookieManager)
        {
            _logger = logger;
            this.cookieManager = cookieManager;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.CookieModelObj = await Data.DataPersitanceAsync(cookieManager);

            return View();
        }

        public IActionResult Privacy()
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