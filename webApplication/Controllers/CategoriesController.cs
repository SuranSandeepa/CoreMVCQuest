using Microsoft.AspNetCore.Mvc;

namespace webApplication.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult Edit(int id)
        {
            return new ContentResult { Content = id.ToString() };
        }
    }
}
