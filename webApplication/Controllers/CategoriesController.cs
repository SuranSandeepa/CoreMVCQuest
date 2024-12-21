using Microsoft.AspNetCore.Mvc;
using webApplication.Models;

namespace webApplication.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult Edit(int? id)
        {
            var category = new Category { CategoryId = id.HasValue ? id.Value : 0 };

            return View(category);
        }
    }
}
