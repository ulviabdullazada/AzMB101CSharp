using LugxGaming.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace LugxGaming.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var dt = await SqlHelper.GetDatas("SELECT * FROM GamesWithGenre");
            return View(dt);
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
