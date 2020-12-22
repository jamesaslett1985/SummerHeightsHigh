using Microsoft.AspNetCore.Mvc;
using System;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Models.Movie movie = new Models.Movie()
            {
                Title = "The Godfather",
                ReleaseDate = new DateTime(1972, 3, 24)
            };
            return View(movie);
        }
    }
}
