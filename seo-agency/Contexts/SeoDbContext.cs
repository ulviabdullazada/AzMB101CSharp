using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using seo_agency.Models;

namespace seo_agency.Contexts
{
    public class SeoDbContext : DbContext
    {
        public SeoDbContext(DbContextOptions opt) : base(opt) { }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}
