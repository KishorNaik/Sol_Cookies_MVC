using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookieManager;
using Microsoft.AspNetCore.Mvc;
using Sol_Demo.Models;
using Sol_Demo.Persistence;

namespace Sol_Demo.Controllers
{
    // https://github.com/nemi-chand/CookieManager

    public class CookiesDemoController : Controller
    {
        #region Declaration

        private readonly ICookieManager cookieManager = null;

        #endregion Declaration

        #region Constructor

        public CookiesDemoController(ICookieManager cookieManager)
        {
            this.cookieManager = cookieManager;
        }

        #endregion Constructor

        #region Public Property

        [BindProperty]
        public CookiesModel Cookies { get; set; }

        #endregion Public Property

        public async Task<IActionResult> Index()
        {
            Cookies = await Data.DataPersitanceAsync(cookieManager);

            return View(Cookies);
        }

        public async Task<IActionResult> Index1()
        {
            Cookies = await Data.DataPersitanceAsync(cookieManager);

            return View(Cookies);
        }

        public IActionResult HomeIndex()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}