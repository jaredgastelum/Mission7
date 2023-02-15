using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission6.Models;

namespace Mission6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieContext MovieContextFile { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieContext movie)
        {
            _logger = logger;
            MovieContextFile = movie;
        }

        public IActionResult Index()
        {
            return View();
        }

        // PODCASTS PAGE
        public IActionResult Podcasts()
        {
            return View();
        }

        // ADD MOVIE FORM
        [HttpGet]
        public IActionResult AddMovie ()
        {
            return View();
        }

        // THIS WILL REDIRECT THE USER TO A CONFIRMATION PAGE AFTER THEY SUBMIT A MOVIE TO THE DIRECTORY
        [HttpPost]
        public IActionResult AddMovie(ApplicationResponse ar)
        {
            MovieContextFile.Add(ar);
            MovieContextFile.SaveChanges();
            return View("Confirmation", ar);
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
