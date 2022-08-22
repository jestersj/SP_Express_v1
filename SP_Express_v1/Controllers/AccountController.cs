using Microsoft.AspNetCore.Mvc;
using SP_Express_v1.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using SP_Express_v1.ModelViews;
using SP_Express_v1.Models;

namespace SP_Express_v1.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        // private readonly IDbInsert _repo;
        // private readonly IEmailDbService _EmailService;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                
            }
            return View(model);
        }

        public IActionResult Register()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult SignInInd()
        {
            return View();
        }
        
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> SignInInd(RegisterViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            
            var resultUser = await _userManager.FindByEmailAsync(model.Email).ConfigureAwait(false);

            if (resultUser != null)
            {
                ModelState.AddModelError(string.Empty, "Пользователь уже существует");
                return View(model);
            }
            
            IdentityUser user = new()
            {
                UserName = model.Email,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View(model);
            }
            
            await _userManager.AddToRoleAsync(user, "usr");

            return RedirectToAction("Login", "Account");
        }
        
        public IActionResult SignInLegal()
        {
            return View();
        }
        public IActionResult UserLk()
        {
            return View();
        }

        public IActionResult SignManagerLk()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}