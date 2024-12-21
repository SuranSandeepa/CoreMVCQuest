using Microsoft.AspNetCore.Mvc;

namespace webApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
