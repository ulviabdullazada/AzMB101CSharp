using Microsoft.AspNetCore.Identity;

namespace seo_agency.Models
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }

    }
}
