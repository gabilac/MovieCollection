using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieCollection.Models;

namespace MovieCollection.Controllers
{
    public class HomeController : Controller
    { 
        private MovieListContext context { get; set; }

        //Construstor
        public HomeController(MovieListContext con)
        {
            context = con;
        }

        public IActionResult Index()
        {
            return View();
        }

        //link to initial movies form
        [HttpGet]
        public IActionResult EnterMovies()
        {
            return View();
        }

        //gets responses from user
        [HttpPost]
        public IActionResult EnterMovies(NewMovie m)
        {
            if (!ModelState.IsValid) //prevents movies from being added if not all fields entered
            {
                return View();
            }
            else
            {
                //database adding
                context.Movies.Add(m);
                context.SaveChanges();
                return RedirectToAction("AllMovies"); 
            }
        }

        //link to podcasts
        [HttpGet("pod")]
        public IActionResult Podcasts()
        {
            return View();
        }

        //link to view list of movies
        [HttpGet("all")]
        public IActionResult AllMovies()
        {
            return View(context.Movies);
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
