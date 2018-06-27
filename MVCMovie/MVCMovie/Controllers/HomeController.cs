using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCMovie.Models;
using MVCMovie.Controllers;

namespace MVCMovie.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Movies");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "A List of Movies?";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contacts...Put them here if you have any!";

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
