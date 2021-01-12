using Website.Models;
using Microsoft.AspNetCore.Mvc;

namespace Website.Controllers
{
    public class UsersController : Controller
    {
        //two Create methods; one for Get which returns the view and one for Post which is called when the form is submitted to create the new user. It will check if the Model is valid (which is done
        //automatically thanks to DataAnnotations) and then return the view

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(WebUser webUser)
        {
            if (ModelState.IsValid)
            {
                // Here the WebUser should be saved. Afterwards we would normally return another View, to 
                // indicate that the User has been successfully created, or redirect to another page 
            }
            return View();
        }
    }
}