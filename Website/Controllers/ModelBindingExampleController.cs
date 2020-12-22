using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.Models;

namespace Website.Controllers
{
    public class ModelBindingExampleController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new ModelBindingExample() { FirstName = "John", LastName = "Doe" });
        }

        [HttpPost]
        public IActionResult Index(ModelBindingExample webUser)
        {
            return Content($"User {webUser.FirstName} updated!");
        }
    }
}
