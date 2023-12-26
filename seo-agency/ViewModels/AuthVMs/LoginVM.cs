using System.ComponentModel.DataAnnotations;

namespace seo_agency.ViewModels.AuthVMs
{
    public class LoginVM
    {
       
        [Required, MaxLength(30)]
        public string UserNameOrEmail { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
