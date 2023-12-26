using System.ComponentModel.DataAnnotations;

namespace seo_agency.Models
{
    public class Slider : BaseEntity
    {
        [MaxLength(128)]
        public string ImageUrl { get; set; }
        [MaxLength(64)]
        public string Client { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public int ServiceId { get; set; }
        public Service Service { get; set; }
    }
}
