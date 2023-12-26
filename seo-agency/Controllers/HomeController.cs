using Microsoft.AspNetCore.Mvc;

namespace seo_agency.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
