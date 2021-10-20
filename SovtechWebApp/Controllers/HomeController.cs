using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SovtechWebApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SovtechWebApp.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public ActionResult Search(string searchTerm)
        {
            //var data = DB.tblStuds.ToList();
            return PartialView();
        }
        public ActionResult GetCategories()
        {
            //var data = DB.tblStuds.ToList();
            return PartialView();
        }
        public ActionResult GetCategoryDetails()
        {
            //var data = DB.tblStuds.ToList();
            return PartialView();
        }
        public ActionResult Swapi()
        {
            //var data = DB.tblStuds.ToList();
            return PartialView();
        }
    }
}
