using Microsoft.AspNetCore.Mvc;

namespace LugxGaming.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
