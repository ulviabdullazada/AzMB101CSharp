using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using seo_agency.Models;
using seo_agency.ViewModels.AuthVMs;

namespace seo_agency.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public AuthController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;

        }
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid)
            {
                return View(registerVM);
            }
            AppUser appUser = new AppUser()
            {
                Name = registerVM.Name,
                Email = registerVM.Email,
                Surname = registerVM.Surname,
                UserName = registerVM.UserName
            };
            await _userManager.CreateAsync(user: appUser, password: registerVM.Password);
            return RedirectToAction(nameof(Index), "Home");

        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid)
            {
                return View(loginVM);
            }
            AppUser user;
            if (loginVM.UserNameOrEmail.Contains("@"))
            {
                user = await _userManager.FindByEmailAsync(loginVM.UserNameOrEmail);
            }
            else
            {
                user = await _userManager.FindByNameAsync(loginVM.UserNameOrEmail);
            }
            if (user == null) 
            {
                ModelState.AddModelError("", "Some user credentials are wrong!");
                return View(loginVM);
            }
            var result = await _signInManager.CheckPasswordSignInAsync(user, loginVM.Password, true);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Some user credentials are wrong!");
                return View(loginVM);
            }
            return RedirectToAction(nameof(Index), "Home");
        }



        
    }
}
