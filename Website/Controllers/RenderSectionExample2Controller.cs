﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Website.Controllers
{
    public class RenderSectionExample2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
