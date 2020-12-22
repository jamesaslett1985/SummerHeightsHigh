using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.Models;

namespace Website.Controllers
{
    public class ValidationController : Controller
    {
        [HttpGet]
        public IActionResult SimpleValidation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SimpleValidation(ModelBindingExample webUser)
        {
            if (ModelState.IsValid)
                return Content("Thank you!");
            else
                return Content("Model could not be validated!");
        }

    }
}