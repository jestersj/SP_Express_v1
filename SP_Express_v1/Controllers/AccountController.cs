using Microsoft.AspNetCore.Mvc;
using SP_Express_v1.Models;
using System.Diagnostics;

namespace SP_Express_v1.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult SignIn()
        {
            return View();
        }
        public IActionResult SignInInd()
        {
            return View();
        }
        public IActionResult SignInLegal()
        {
            return View();
        }
        public IActionResult UserLk()
        {
            return View();
        }

        public IActionResult ManagerLk()
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