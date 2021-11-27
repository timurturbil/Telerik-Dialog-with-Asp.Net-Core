using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelerikAspNetCoreApp2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Dialog(string firstName)
        {
            ViewData["name"] = firstName;
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
