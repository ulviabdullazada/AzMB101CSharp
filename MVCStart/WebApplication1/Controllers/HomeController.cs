using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        //public string Index(int id,string name)
        //{
        //    return id + "-" + name;
        //}
        //public int Contact(int id=2)
        //{
        //    return id*id;
        //}
        //public ActionResult Index(int id)
        //{
        //    if (id == 0)
        //    {
        //        return Content("Salam","application/json");
        //    }
        //    else if(id > 0)
        //    {
        //        return Json(new
        //        {
        //            Name = "Isa",
        //            Surname = "Aliyev"
        //        });
        //    }
        //    else
        //    {
        //        return View("View");
        //    }
        //    //ContentResult cr = new ContentResult();
        //    //cr.Content = "Salam";
        //    ////return cr;
        //    //JsonResult jr = new JsonResult(new
        //    //{
        //    //    Name = "AzMB101",
        //    //    StudentCount = 18
        //    //});
        //    ////return jr;
        //    //ViewResult vr = new ViewResult();
        //    //vr.ViewName = "View";
        //    //return vr;
        //}
        public IActionResult Index()
        {
            List<Artist> artists = new List<Artist>();
            artists.Add(new Artist
            {
                Id = 1,
                Name = "Niyammedin",
                Surname = "Musayev"
            });
            artists.Add(new Artist
            {
                Id = 2,
                Name = "<b>Eyyub</b>",
                Surname = "Yagubov"
            });
            //ViewBag.Title = "asdf";
            ViewBag.Artists = artists;
            //ViewData["Salam Dostlar"] = "lasfddjfg";
            ViewBag.Salam = "Viewbags data";
            TempData["Salam"] = "Tempdatas data";
            return RedirectToAction(nameof(About));
            //return Content("<ul>\r\n                <li>1 Niyammedin Musayev</li>\r\n                <li>2 Eyyub Yagubov</li>\r\n                <li>            <p>Alinmadi!!</p>\r\n        \r\n    </li></ul>", "text/html");
        }
        public IActionResult About()
        {
            string b = TempData["Salam"].ToString();
            return Content(b);
        }
    }
}
