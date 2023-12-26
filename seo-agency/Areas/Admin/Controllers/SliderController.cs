using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using seo_agency.Contexts;
using seo_agency.Models;
using seo_agency.ViewModels.SliderVMs;

namespace seo_agency.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        SeoDbContext _context { get; }
        IWebHostEnvironment _environment;

        public SliderController(SeoDbContext context, 
            IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            ViewBag.Services = new SelectList(_context.Services, nameof(Service.Id), nameof(Service.Name));
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(SliderCreateVM vm)
        {
            if (vm.ImageFile != null)
            {
                if (vm.ImageFile.Length > 1024 * 1024 * 6)
                {
                    ModelState.AddModelError("ImageFile", "File size is too large");
                }
                if (!vm.ImageFile.ContentType.Contains("image"))
                {
                    ModelState.AddModelError("ImageFile", "File format isnt correct");
                }
            }
            if (!ModelState.IsValid)
            {
                ViewBag.Services = new SelectList(_context.Services, nameof(Service.Id), nameof(Service.Name));
                return View(vm);
            }
            string filename = Guid.NewGuid() + Path.GetExtension(vm.ImageFile.FileName);
            using (Stream fs = new FileStream(Path.Combine(_environment.WebRootPath,"imgs","slider", filename), FileMode.Create))
            {
                await vm.ImageFile.CopyToAsync(fs);
            }
            await _context.Sliders.AddAsync(new Slider
            {
                Client = vm.Client,
                Date = vm.Date,
                ImageUrl = filename,
                ServiceId = vm.ServiceId,
            });
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public async Task<IActionResult> Update(int id, SliderCreateVM vm)
        {
            ViewBag.Services = new SelectList(_context.Services, nameof(Service.Id), nameof(Service.Name));
            var data = await _context.Sliders.FindAsync(id);
            if (System.IO.File.Exists(Path.Combine(_environment.WebRootPath, "imgs", "slider", data.ImageUrl))) 
            {
                System.IO.File.Delete(Path.Combine(_environment.WebRootPath, "imgs", "slider", data.ImageUrl));
            }
            string filename = Guid.NewGuid() + Path.GetExtension(vm.ImageFile.FileName);
            using (Stream fs = new FileStream(Path.Combine(_environment.WebRootPath, "imgs", "slider", filename), FileMode.Create))
            {
                await vm.ImageFile.CopyToAsync(fs);
            }
            data.ImageUrl = filename;
            return View();
        }
    }
}
