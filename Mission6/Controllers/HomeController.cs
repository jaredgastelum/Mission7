using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission6.Models;

namespace Mission6.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext MovieContextFile { get; set; }

        public HomeController(MovieContext movie)
        {
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
            ViewBag.Categories = MovieContextFile.Categories.ToList();

            return View();
        }

        // THIS WILL REDIRECT THE USER TO A CONFIRMATION PAGE AFTER THEY SUBMIT A MOVIE TO THE DIRECTORY
        [HttpPost]
        public IActionResult AddMovie(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                MovieContextFile.Add(ar);
                MovieContextFile.SaveChanges();
                return View("Confirmation", ar);
            }

            else //IF INVALID
            {
                ViewBag.Categories = MovieContextFile.Categories.ToList();

                return View(ar);
            }
        }

        public IActionResult MovieList()
        {
            var applications = MovieContextFile.Responses
                .Include(x => x.Category)
                .OrderBy(x => x.Category)
                .ToList();

            return View(applications);
        }

        [HttpGet]
        public IActionResult Edit(int applicationid)
        {
            ViewBag.Categories = MovieContextFile.Categories.ToList();

            var application = MovieContextFile.Responses.Single(x => x.MovieID == applicationid);

            return View("AddMovie", application);
        }

        [HttpPost]
        public IActionResult Edit(ApplicationResponse ar)
        {
            MovieContextFile.Update(ar);
            MovieContextFile.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int applicationid)
        {
            var application = MovieContextFile.Responses.Single(x => x.MovieID == applicationid);

            return View(application);
        }

        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {
            MovieContextFile.Responses.Remove(ar);
            MovieContextFile.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
