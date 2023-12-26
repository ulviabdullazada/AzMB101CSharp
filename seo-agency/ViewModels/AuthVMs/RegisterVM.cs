using System.ComponentModel.DataAnnotations;

namespace seo_agency.ViewModels.AuthVMs
{
    public class RegisterVM
    {
        [Required, MaxLength(55)]
        public string Name { get; set; }
        [Required, MaxLength(75)]
        public string Surname { get; set; }

        [Required, MaxLength(30)]
        public string Email { get; set; }

        [Required, MaxLength(30)]
        public string UserName { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, DataType(DataType.Password), Compare("Password")]
        public string ConfirmPassword { get; set; }

    }
}
