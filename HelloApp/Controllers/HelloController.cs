using Microsoft.AspNetCore.Mvc;

namespace HelloApp.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Welcome(string name) { 
            return View("Welcome", name); 
        }
    }
}
