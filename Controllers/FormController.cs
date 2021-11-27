using Microsoft.AspNetCore.Mvc;

namespace TelerikAspNetCoreApp2.Controllers
{
    public class FormController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Dialog(string firstName)
        {
            ViewData["name"] = firstName;
            return View();
        }
    }
}
