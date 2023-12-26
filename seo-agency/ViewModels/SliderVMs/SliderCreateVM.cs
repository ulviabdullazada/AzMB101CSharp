using System.ComponentModel.DataAnnotations;

namespace seo_agency.ViewModels.SliderVMs
{
    public class SliderCreateVM
    {
        [Required]
        public IFormFile ImageFile { get; set; }
        [Required]
        public string Client { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int ServiceId { get; set; }
    }
}
