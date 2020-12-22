using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.Models;

namespace Website.Controllers
{
    public class BobController : Controller
    {
        public IActionResult Index()
        {
            Product product = new Product()
            {
                Title = "Toilet Paper",
                Price = 1.99
            };
            return View(product);
        }
    }
}
