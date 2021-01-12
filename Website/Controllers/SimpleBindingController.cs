using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.Models;

namespace Website.Controllers
{
    public class SimpleBindingController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new WebUser() { FirstName = "John", LastName = "Doe" });
        }

        [HttpPost]
        public IActionResult Index(WebUser webUser)
        {
            return Content($"User {webUser.FirstName} updated!");
        }
    }
}
