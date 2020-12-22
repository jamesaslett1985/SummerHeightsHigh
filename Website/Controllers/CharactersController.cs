using Microsoft.AspNetCore.Mvc;
using System;
using Website.Models;

namespace Website.Controllers
{
    public class CharactersController : Controller
    {
        public IActionResult Index()
        {
            Characters characters = new Characters()
            {
                Name = "Name from HomeController",
                Age = 18,
                MainCharacteristic = "MainCharacteristic from HomeController",
                Quote = "Quote from HomeController"
               
            };
            return View(characters);
        }
    }
}
