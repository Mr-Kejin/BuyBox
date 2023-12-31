using Microsoft.AspNetCore.Mvc;

namespace BuyBox.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
