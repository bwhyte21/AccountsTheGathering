﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AccountsTheGathering_Models.ViewModels;

namespace AccountsTheGathering.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// CTORs are generated by default, but it's okay to have here just in case.
        /// </summary>
        public HomeController()
        {
            
        }

        /// <summary>
        /// The main goods of this page.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Error page that comes with default MVC project.
        /// </summary>
        /// <returns></returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}