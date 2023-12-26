using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace seo_agency.Models
{
    public class Service : BaseEntity
    {
        [MaxLength(64)]
        public string Name { get; set; }
        public IEnumerable<Slider> Sliders { get; set; }
    }
}
