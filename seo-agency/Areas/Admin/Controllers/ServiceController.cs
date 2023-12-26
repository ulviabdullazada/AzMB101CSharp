using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using seo_agency.Contexts;
using seo_agency.Models;
using seo_agency.ViewModels.ServiceVMs;

namespace seo_agency.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceController : Controller
    {
        SeoDbContext _context { get; }

        public ServiceController(SeoDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Services.Select(s => new ServiceListItemVM
            {
                Id = s.Id,
                Name = s.Name,
            }).ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ServiceCreateVM vm)
        {
            if (!ModelState.IsValid) return View(vm);
            if (await _context.Services.AnyAsync(s=> s.Name == vm.Name))
            {
                ModelState.AddModelError("Name", "Name already exist");
                return View(vm);
            }
            await _context.Services.AddAsync(new Service { Name = vm.Name });
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
